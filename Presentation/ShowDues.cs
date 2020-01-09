using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;

namespace Presentation
{
    public partial class ShowDues : Form
    {
        ShowDuesModel Dues = new ShowDuesModel();

        public ShowDues()
        {
            InitializeComponent();
        }

        private void PBExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListarMiembros()
        {
            DataGridMembers.DataSource = Dues.ShowMembers();
        }

        private void ListarCoutas()
        {
            ShowDuesModel ListDues = new ShowDuesModel();
            DataGridShowDues.DataSource = ListDues.ShowDues(txtDocument.Text);
        }

        private void SetFormat()
        {
            //Document,Name,LastName,Phone,CurrentSaving,CurrentDeb
            DataGridMembers.Columns["Document"].HeaderText = "Documento";
            DataGridMembers.Columns["Name"].HeaderText = "Nombres";
            DataGridMembers.Columns["LastName"].HeaderText = "Apellidos";
            DataGridMembers.Columns["Phone"].HeaderText = "Telefono";
            DataGridMembers.Columns["CurrentSaving"].HeaderText = "Ahorro Actual";
            DataGridMembers.Columns["CurrentDeb"].HeaderText = "Deuda Actual";
            this.DataGridMembers.Columns["CurrentSaving"].DefaultCellStyle.Format = "c0";
            this.DataGridMembers.Columns["CurrentSaving"].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("es-CO");
            this.DataGridMembers.Columns["CurrentDeb"].DefaultCellStyle.Format = "c0";
            this.DataGridMembers.Columns["CurrentDeb"].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("es-CO");

            for (int i = 0; i < DataGridMembers.Columns.Count - 1; i++)
            {
                DataGridMembers.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            DataGridMembers.Columns[DataGridMembers.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            for (int i = 0; i < DataGridMembers.Columns.Count; i++)
            {
                int colw = DataGridMembers.Columns[i].Width;
                DataGridMembers.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                DataGridMembers.Columns[i].Width = colw;
            }
        }

        private void ShowDues_Load(object sender, EventArgs e)
        {
            ListarMiembros();
            SetFormat();
            this.PrintDues.RefreshReport();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (DataGridMembers.SelectedRows.Count > 0)
            {
                txtDocument.Text = DataGridMembers.CurrentRow.Cells["Document"].Value.ToString();
                txtDocumentReport.Text = DataGridMembers.CurrentRow.Cells["Document"].Value.ToString();
                txtName.Text = DataGridMembers.CurrentRow.Cells["Name"].Value.ToString();
                txtLastName.Text = DataGridMembers.CurrentRow.Cells["LastName"].Value.ToString();
                txtPhone.Text = DataGridMembers.CurrentRow.Cells["Phone"].Value.ToString();
                txtCurrentSaving.Text = DataGridMembers.CurrentRow.Cells["CurrentSaving"].Value.ToString();
                txtCurrentLoan.Text = DataGridMembers.CurrentRow.Cells["CurrentDeb"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor");
            }

            try
            {
                ListarCoutas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pueden mostrar los datos por: " + ex);
            }
            try
            {
                DataGridShowDues.Columns["DueDate"].HeaderText = "Fecha Cuota";
                DataGridShowDues.Columns["LoanAmount"].HeaderText = "Saldo";
                DataGridShowDues.Columns["InterestRate"].HeaderText = "Tasa Interes";
                DataGridShowDues.Columns["DueNumber"].HeaderText = "Numero Cuota";
                DataGridShowDues.Columns["DueValue"].HeaderText = "Valor Cuota";
                DataGridShowDues.Columns["Pay"].HeaderText = "Pago";
                DataGridShowDues.Columns["Status"].HeaderText = "Estado";

                this.DataGridShowDues.Columns["LoanAmount"].DefaultCellStyle.Format = "c0";
                this.DataGridShowDues.Columns["LoanAmount"].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("es-CO");
                this.DataGridShowDues.Columns["DueValue"].DefaultCellStyle.Format = "c0";
                this.DataGridShowDues.Columns["DueValue"].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("es-CO");

                for (int i = 0; i < DataGridShowDues.Columns.Count - 1; i++)
                {
                    DataGridShowDues.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
                DataGridShowDues.Columns[DataGridShowDues.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                for (int i = 0; i < DataGridShowDues.Columns.Count; i++)
                {
                    int colw = DataGridShowDues.Columns[i].Width;
                    DataGridShowDues.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                    DataGridShowDues.Columns[i].Width = colw;
                }

            }
            catch (Exception ex)
            {

            }
            
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            var Document = txtDocumentReport.Text;
            GetReport(Document);
            GetName(Document);
        }

        private void ClearForm()
        {
            txtDocument.Clear();
            txtName.Clear();
            txtLastName.Clear();
            txtPhone.Clear();
            txtCurrentSaving.Clear();
            txtCurrentLoan.Clear();

            DataGridShowDues.Refresh();

        }

        public void GetReport(string Document)
        {
            ShowDuesModel report = new ShowDuesModel();
            report.PrintDues(Document);
            sHOWDUESBindingSource.DataSource = report;
            sHOWDUESBindingSource.DataSource = report.ReportShowDues;
            this.PrintDues.RefreshReport();
        }

        public void GetName(string Document)
        {
            ShowDuesModel report = new ShowDuesModel();
            report.PrintMember(Document);
            memberDuesBindingSource.DataSource = report;
            memberDuesBindingSource.DataSource = report.ReportShowMember;
            this.PrintDues.RefreshReport();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
        }
    }
}
