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
    public partial class Members : Form
    {
        MemberModel members = new MemberModel();
        private string memberId = null;
        private bool Editar = false;

        public Members()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Members_Load(object sender, EventArgs e)
        {
            ShowMembers();
            SetFormat();
        }

        private void ShowMembers()
        {
            MemberModel member = new MemberModel();
            DataGridMembers.DataSource = member.ShowMembers();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Editar == false)
            {
                try
                {
                    members.InsertMember(txtDocument.Text, txtName.Text, txtApellido.Text, txtPhone.Text, txtLimSaving.Text, txtLimLoan.Text, CheckBoxYes.Checked.ToString());
                    MessageBox.Show("Se inserto correctamente.");
                    ShowMembers();
                    ClearForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pueden insertar los datos por: " + ex);
                }
            }
            if (Editar == true)
            {
                try
                {
                    members.EditMember(txtDocument.Text, txtName.Text, txtApellido.Text, txtPhone.Text, txtLimSaving.Text, txtLimLoan.Text, CheckBoxYes.Checked.ToString());
                    MessageBox.Show("Se editaron los datos correctamente.");
                    ShowMembers();
                    ClearForm();
                    Editar = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se puede editar los datos por: " + ex);
                }
            }

        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (DataGridMembers.SelectedRows.Count > 0)
            {
                Editar = true;
                txtDocument.Text = DataGridMembers.CurrentRow.Cells["Document"].Value.ToString();
                txtName.Text = DataGridMembers.CurrentRow.Cells["Name"].Value.ToString();
                txtApellido.Text = DataGridMembers.CurrentRow.Cells["LastName"].Value.ToString();
                txtPhone.Text = DataGridMembers.CurrentRow.Cells["Phone"].Value.ToString();
                txtLimSaving.Text = DataGridMembers.CurrentRow.Cells["LimSaving"].Value.ToString();
                txtLimLoan.Text = DataGridMembers.CurrentRow.Cells["LimLoan"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor");
            }
        }

        private void SetFormat()
        {
            DataGridMembers.Columns["IdMember"].HeaderText = "Id";
            DataGridMembers.Columns["Document"].HeaderText = "Documento";
            DataGridMembers.Columns["Name"].HeaderText = "Nombre";
            DataGridMembers.Columns["LastName"].HeaderText = "Apellidos";
            DataGridMembers.Columns["Phone"].HeaderText = "Telefono";
            DataGridMembers.Columns["LimSaving"].HeaderText = "Ahorro/Mes";
            DataGridMembers.Columns["LimLoan"].HeaderText = "Lim Prestamos";
            DataGridMembers.Columns["CurrentDeb"].HeaderText = "Deuda Act";
            DataGridMembers.Columns["Member"].HeaderText = "Estado";

            this.DataGridMembers.Columns["LimLoan"].DefaultCellStyle.Format = "c0";
            this.DataGridMembers.Columns["LimLoan"].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("es-CO");
            this.DataGridMembers.Columns["LimSaving"].DefaultCellStyle.Format = "c0";
            this.DataGridMembers.Columns["LimSaving"].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("es-CO");
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

        private void ClearForm()
        {
            txtDocument.Clear();
            txtName.Clear();
            txtApellido.Clear();
            txtPhone.Clear();
            txtLimSaving.Clear();
            txtLimLoan.Clear();
            CheckBoxYes.Checked = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (DataGridMembers.SelectedRows.Count > 0)
            {
                memberId = DataGridMembers.CurrentRow.Cells["idMember"].Value.ToString();
                members.DeleteMember(memberId);
                MessageBox.Show("Registro eliminado correctamente.");
                ShowMembers();
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            //En Progreso :v
        }
    }
}
