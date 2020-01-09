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
    public partial class Payments : Form
    {
        PaymentsModel payments = new PaymentsModel();

        public Payments()
        {
            InitializeComponent();
        }

        private void Payments_Load(object sender, EventArgs e)
        {
            ListarInforCoutas();
        }

        private void PBExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListarInforCoutas()
        {
            PaymentsModel pay = new PaymentsModel();
            DataGridDuesInfo.DataSource = pay.ShowDuesInfo(txtDocument.Text);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                ListarInforCoutas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pueden mostrar los datos por: " + ex);
            }

            try
            {
                //DueId,d.LoanId,DueDate,DueNumber,DueValue,Status
                DataGridDuesInfo.Columns["DueId"].HeaderText = "Id Cuota";
                DataGridDuesInfo.Columns["LoanId"].HeaderText = "Id Prestamo";
                DataGridDuesInfo.Columns["DueDate"].HeaderText = "Fecha Cuota";
                DataGridDuesInfo.Columns["DueNumber"].HeaderText = "Numero Cuota";
                DataGridDuesInfo.Columns["DueValue"].HeaderText = "Valor Cuota";
                DataGridDuesInfo.Columns["Status"].HeaderText = "Estado";

                this.DataGridDuesInfo.Columns["DueValue"].DefaultCellStyle.Format = "c0";
                this.DataGridDuesInfo.Columns["DueValue"].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("es-CO");

                for (int i = 0; i < DataGridDuesInfo.Columns.Count - 1; i++)
                {
                    DataGridDuesInfo.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
                DataGridDuesInfo.Columns[DataGridDuesInfo.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                for (int i = 0; i < DataGridDuesInfo.Columns.Count; i++)
                {
                    int colw = DataGridDuesInfo.Columns[i].Width;
                    DataGridDuesInfo.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                    DataGridDuesInfo.Columns[i].Width = colw;
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (DataGridDuesInfo.SelectedRows.Count > 0)
            {
                txtIdCuota.Text = DataGridDuesInfo.CurrentRow.Cells["DueId"].Value.ToString();
                txtIdPrestamo.Text = DataGridDuesInfo.CurrentRow.Cells["LoanId"].Value.ToString();
                txtFechaCuota.Text = DataGridDuesInfo.CurrentRow.Cells["DueDate"].Value.ToString();
                txtNumCuota.Text = DataGridDuesInfo.CurrentRow.Cells["DueNumber"].Value.ToString();
                txtValorCuota.Text = DataGridDuesInfo.CurrentRow.Cells["DueValue"].Value.ToString();
                txtEstado.Text = DataGridDuesInfo.CurrentRow.Cells["Status"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor");
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            try
            {
                payments.InsertPayment(txtDocument.Text,txtIdCuota.Text,txtIdPrestamo.Text,txtValorCuota.Text);
                MessageBox.Show("Se inserto correctamente.");
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pueden insertar los datos por: " + ex);
            }
        }

        public void Clear()
        {
            txtDocument.Clear();
            txtIdCuota.Clear();
            txtIdPrestamo.Clear();
            txtFechaCuota.Clear();
            txtNumCuota.Clear();
            txtValorCuota.Clear();
            txtEstado.Clear();
            DataGridDuesInfo.DataSource = null;
        }
    }
}
