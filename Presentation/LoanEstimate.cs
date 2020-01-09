using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;

namespace Presentation
{
    public partial class LoanEstimate : Form
    {
        LoanEstimateModel Estimate = new LoanEstimateModel();

        public LoanEstimate()
        {
            InitializeComponent();
        }

        private void LoanEstimate_Load(object sender, EventArgs e)
        {
            ListarSolicitudes();
            SetFormat();
        }

        private void ListarSolicitudes()
        {
            LoanEstimateModel RequestList = new LoanEstimateModel();
            DataGridRequest.DataSource = RequestList.ShowEstimate();
        }

        private void ListarCuotas()
        {
            DataGridDues.DataSource = Estimate.ShowDues(txtDocument.Text);
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (DataGridRequest.SelectedRows.Count > 0)
            {
                txtDocument.Text = DataGridRequest.CurrentRow.Cells["Document"].Value.ToString();
                txtName.Text = DataGridRequest.CurrentRow.Cells["Name"].Value.ToString();
                txtLastName.Text = DataGridRequest.CurrentRow.Cells["LastName"].Value.ToString();
                txtRequestAmount.Text = DataGridRequest.CurrentRow.Cells["RequestedAmount"].Value.ToString();
                txtInterestRate.Text = DataGridRequest.CurrentRow.Cells["InterestRate"].Value.ToString();
                txtApplicationDate.Text = DataGridRequest.CurrentRow.Cells["ApplicationDate"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor");
            }
        }

        private void SetFormat()
        {
            //LoanId,Document,le.Name,le.LastName,RequestedAmount,InterestRate,ApplicationDate
            DataGridRequest.Columns["LoanId"].HeaderText = "Solicitud";
            DataGridRequest.Columns["Document"].HeaderText = "Documento";
            DataGridRequest.Columns["Name"].HeaderText = "Nombre";
            DataGridRequest.Columns["LastName"].HeaderText = "Apellidos";
            DataGridRequest.Columns["RequestedAmount"].HeaderText = "Cantidad Solicitada";
            DataGridRequest.Columns["InterestRate"].HeaderText = "Tasa interes";
            DataGridRequest.Columns["ApplicationDate"].HeaderText = "Fecha Solicitud";
            this.DataGridRequest.Columns["RequestedAmount"].DefaultCellStyle.Format = "c0";
            this.DataGridRequest.Columns["RequestedAmount"].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("es-CO");

            for (int i = 0; i < DataGridRequest.Columns.Count - 1; i++)
            {
                DataGridRequest.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            DataGridRequest.Columns[DataGridRequest.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            for (int i = 0; i < DataGridRequest.Columns.Count; i++)
            {
                int colw = DataGridRequest.Columns[i].Width;
                DataGridRequest.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                DataGridRequest.Columns[i].Width = colw;
            }
        }

        private void btnGenerateDues_Click(object sender, EventArgs e)
        {
            try
            {
                Estimate.InsertDues(txtDocument.Text,txtRequestAmount.Text,txtInterestRate.Text,txtApplicationDate.Text);
                MessageBox.Show("Se inserto correctamente.");
                ListarCuotas();
                btnGenerateDues.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pueden insertar los datos por: " + ex);
            }
            try
            {
                DataGridDues.Columns["DueDate"].HeaderText = "Fecha Cuota";
                DataGridDues.Columns["LoanAmount"].HeaderText = "Saldo";
                DataGridDues.Columns["InterestRate"].HeaderText = "Tasa Interes";
                DataGridDues.Columns["DueNumber"].HeaderText = "Numero Cuota";
                DataGridDues.Columns["DueValue"].HeaderText = "Valor Cuota";

                this.DataGridDues.Columns["LoanAmount"].DefaultCellStyle.Format = "c0";
                this.DataGridDues.Columns["LoanAmount"].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("es-CO");
                this.DataGridDues.Columns["DueValue"].DefaultCellStyle.Format = "c0";
                this.DataGridDues.Columns["DueValue"].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("es-CO");

                for (int i = 0; i < DataGridDues.Columns.Count - 1; i++)
                {
                    DataGridDues.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
                DataGridDues.Columns[DataGridDues.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                for (int i = 0; i < DataGridDues.Columns.Count; i++)
                {
                    int colw = DataGridDues.Columns[i].Width;
                    DataGridDues.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                    DataGridDues.Columns[i].Width = colw;
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnGenerateDues.Enabled = true;
            try
            {
                Estimate.InsertEstimate(txtDocument.Text, txtNumDues.Text, txtApplicationDate.Text, txtInterestRate.Text, txtRequestAmount.Text);
                MessageBox.Show("Se inserto correctamente.");
                ListarSolicitudes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pueden insertar los datos por: " + ex);
            }
        }

        private void ClearForm()
        {
            txtDocument.Clear();
            txtName.Clear();
            txtLastName.Clear();
            txtRequestAmount.Clear();
            txtInterestRate.Clear();
            txtNumDues.Clear();
            txtApplicationDate.Clear();
            DataGridRequest.DataSource = null;
            DataGridDues.DataSource = null;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
    }
}
