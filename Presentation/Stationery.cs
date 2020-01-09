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
    public partial class Stationery : Form
    {
        StationeryModel transfer = new StationeryModel();

        public Stationery()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Stationery_Load(object sender, EventArgs e)
        {
            ListarMiembros();
            SetFormat();
        }

        public void ListarMiembros()
        {
            StationeryModel members = new StationeryModel();
            DataGridMembers.DataSource = members.ShowMembers();
        }

        public void ListarVault()
        {
            StationeryModel vault = new StationeryModel();
            DataGridVault.DataSource = vault.ShowVault(DatePickerInitial.Value.ToString(), DataPickerFinal.Value.ToString());
        }

        public void Clear()
        {
            txtId.Clear();
            txtDocument.Clear();
            txtName.Clear();
            txtLastName.Clear();
        }

        public void SetFormat()
        {
            //IdMember,Document,Name,LastName,Member

            DataGridMembers.Columns["IdMember"].HeaderText = "Id";
            DataGridMembers.Columns["Document"].HeaderText = "Documento";
            DataGridMembers.Columns["Name"].HeaderText = "Nombres";
            DataGridMembers.Columns["LastName"].HeaderText = "Apellidos";
            DataGridMembers.Columns["Member"].HeaderText = "Estado";
            DataGridMembers.Columns["AccountId"].HeaderText = "Id Cuenta";

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

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (DataGridMembers.SelectedRows.Count > 0)
            {
                txtId.Text = DataGridMembers.CurrentRow.Cells["IdMember"].Value.ToString();
                txtDocument.Text = DataGridMembers.CurrentRow.Cells["Document"].Value.ToString();
                txtName.Text = DataGridMembers.CurrentRow.Cells["Name"].Value.ToString();
                txtLastName.Text = DataGridMembers.CurrentRow.Cells["LastName"].Value.ToString();
                txtAccountId.Text = DataGridMembers.CurrentRow.Cells["AccountId"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor");
            }
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            try
            {
                transfer.TransferVault(txtId.Text, txtDocument.Text, txtAccountId.Text);
                MessageBox.Show("Se inserto correctamente.");
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pueden insertar los datos por: " + ex);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                ListarVault();

                //Document,Name,LastName,OperationId,Description,DateTransaction,Amount

                DataGridVault.Columns["Document"].HeaderText = "Documento";
                DataGridVault.Columns["Name"].HeaderText = "Nombres";
                DataGridVault.Columns["LastName"].HeaderText = "Apellidos";
                DataGridVault.Columns["OperationId"].HeaderText = "Operacion";
                DataGridVault.Columns["Description"].HeaderText = "Descripcion";
                DataGridVault.Columns["DateTransaction"].HeaderText = "Fecha";
                DataGridVault.Columns["Amount"].HeaderText = "Valor";

                this.DataGridVault.Columns["Amount"].DefaultCellStyle.Format = "c0";
                this.DataGridVault.Columns["Amount"].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("es-CO");

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
            catch (Exception ex)
            {
                MessageBox.Show("No se pueden insertar los datos por: " + ex);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            DataGridVault.DataSource = null;
        }
    }
}
