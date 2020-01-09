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
    public partial class LoanRequest : Form
    {
        LoanRequestModel Request = new LoanRequestModel();
        private bool Select = false;
        private string LoanId = null;


        public LoanRequest()
        {
            InitializeComponent();
        }

        private void LoanRequest_Load(object sender, EventArgs e)
        {
            ListarMiembros();
            ListarFondos();
            ListarSolicitud();
            SetFormat();
        }

        private void ListarMiembros()
        {
            LoanRequestModel MemberRequest = new LoanRequestModel();
            DataGridMember.DataSource = MemberRequest.ShowMembers();
        }

        public void ListarSolicitud()
        {
            LoanRequestModel Request = new LoanRequestModel();
            DataGridLoans.DataSource = Request.ShowRequest();
        }

        public void ListarFondos()
        {
            LoanRequestModel vault = new LoanRequestModel();
            DataGridVault.DataSource = vault.ShowVault();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetFormat()
        {
            //IdMember,Document,Name,LastName
            DataGridMember.Columns["IdMember"].HeaderText = "Id";
            DataGridMember.Columns["Document"].HeaderText = "Documento";
            DataGridMember.Columns["Name"].HeaderText = "Nombre";
            DataGridMember.Columns["LastName"].HeaderText = "Apellidos";
            DataGridMember.Columns["LimLoan"].HeaderText = "Lim Prestamo";
            DataGridMember.Columns["CurrentDeb"].HeaderText = "Deuda Actual";

            this.DataGridMember.Columns["LimLoan"].DefaultCellStyle.Format = "c0";
            this.DataGridMember.Columns["LimLoan"].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("es-CO");
            this.DataGridMember.Columns["CurrentDeb"].DefaultCellStyle.Format = "c0";
            this.DataGridMember.Columns["CurrentDeb"].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("es-CO");

            //LoanId,MemberId,Name,LastName,RequestedAmount,InterestRate,ApplicationDate,Observations
            DataGridLoans.Columns["LoanId"].HeaderText = "Solicitud";
            DataGridLoans.Columns["MemberId"].HeaderText = "Miembro";
            DataGridLoans.Columns["Name"].HeaderText = "Nombre";
            DataGridLoans.Columns["LastName"].HeaderText = "Apellidos";
            DataGridLoans.Columns["RequestedAmount"].HeaderText = "Cantidad Sol";
            DataGridLoans.Columns["InterestRate"].HeaderText = "Tasa Inter";
            DataGridLoans.Columns["ApplicationDate"].HeaderText = "Fecha Sol";
            DataGridLoans.Columns["Observations"].HeaderText = "Observaciones";

            this.DataGridLoans.Columns["RequestedAmount"].DefaultCellStyle.Format = "c0";
            this.DataGridLoans.Columns["RequestedAmount"].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("es-CO");

            for (int i = 0; i < DataGridLoans.Columns.Count - 1; i++)
            {
                DataGridLoans.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            DataGridLoans.Columns[DataGridLoans.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            for (int i = 0; i < DataGridLoans.Columns.Count; i++)
            {
                int colw = DataGridLoans.Columns[i].Width;
                DataGridLoans.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                DataGridLoans.Columns[i].Width = colw;
            }


            //Amount
            DataGridVault.Columns["AvailableAmount"].HeaderText = "Fondos";
            this.DataGridVault.Columns["AvailableAmount"].DefaultCellStyle.Format = "c0";
            this.DataGridVault.Columns["AvailableAmount"].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("es-CO");

            for (int i = 0; i < DataGridVault.Columns.Count - 1; i++)
            {
                DataGridVault.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            DataGridVault.Columns[DataGridVault.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            for (int i = 0; i < DataGridVault.Columns.Count; i++)
            {
                int colw = DataGridVault.Columns[i].Width;
                DataGridVault.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                DataGridVault.Columns[i].Width = colw;
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (DataGridMember.SelectedRows.Count > 0)
            {
                txtDocument.Text = DataGridMember.CurrentRow.Cells["Document"].Value.ToString();
                txtName.Text = DataGridMember.CurrentRow.Cells["Name"].Value.ToString();
                txtLastName.Text = DataGridMember.CurrentRow.Cells["LastName"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor");
            }
        }

        private void DataGridMember_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ClearForm()
        {
            txtDocument.Clear();
            txtName.Clear();
            txtLastName.Clear();
            txtRequestAmount.Clear();
            txtInterestRate.Clear();
            txtObservations.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Select == false)
            {
                try
                {
                    Request.InsertRequest(txtDocument.Text, txtName.Text, txtLastName.Text, txtRequestAmount.Text, txtInterestRate.Text, txtObservations.Text);
                    MessageBox.Show("Se inserto correctamente.");
                    ListarSolicitud();
                    ClearForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pueden insertar los datos por: " + ex);
                }
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnDeleteRequest_Click(object sender, EventArgs e)
        {
            if (DataGridLoans.SelectedRows.Count > 0)
            {
                LoanId = DataGridLoans.CurrentRow.Cells["LoanId"].Value.ToString();
                Request.DeleteRequets(LoanId);
                MessageBox.Show("Registro eliminado correctamente.");
                ListarSolicitud();
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor");
            }
        }
    }
}