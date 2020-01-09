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
    public partial class CreateAccount : Form
    {
        CreateAccountModel Account = new CreateAccountModel();

        public CreateAccount()
        {
            InitializeComponent();
        }

        private void CreateAccount_Load(object sender, EventArgs e)
        {
            ListarMiembros();
            SetFormat();
        }

        private void PBExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListarMiembros()
        {
            CreateAccountModel Members = new CreateAccountModel();
            DataGridMembers.DataSource = Members.ShowMembers();
        }

        private void SetFormat()
        {
            //Document,Name,LastName,LimSaving
            DataGridMembers.Columns["Document"].HeaderText = "Documento";
            DataGridMembers.Columns["Name"].HeaderText = "Nombres";
            DataGridMembers.Columns["LastName"].HeaderText = "Apellidos";
            DataGridMembers.Columns["LimSaving"].HeaderText = "Ahorro / Mes";
            DataGridMembers.Columns["AccountNumber"].HeaderText = "Numero Cuenta";

            this.DataGridMembers.Columns["LimSaving"].DefaultCellStyle.Format = "c0";
            this.DataGridMembers.Columns["LimSaving"].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("es-CO");

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

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                Account.InsertAccount(txtDocumento.Text);
                MessageBox.Show("Se creo correctamente.");
                Clear();
                ListarMiembros();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pueden insertar los datos por: " + ex);
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (DataGridMembers.SelectedRows.Count > 0)
            {
                txtDocumento.Text = DataGridMembers.CurrentRow.Cells["Document"].Value.ToString();
                txtNombres.Text = DataGridMembers.CurrentRow.Cells["Name"].Value.ToString();
                txtApellidos.Text = DataGridMembers.CurrentRow.Cells["LastName"].Value.ToString();
                txtAhorro.Text = DataGridMembers.CurrentRow.Cells["LimSaving"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor");
            }
        }

        private void Clear()
        {
            txtDocumento.Clear();
            txtNombres.Clear();
            txtApellidos.Clear();
            txtAhorro.Clear();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }
    }
}
