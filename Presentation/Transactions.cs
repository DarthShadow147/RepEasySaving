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
    public partial class Transactions : Form
    {
        TransactionsModel transactions = new TransactionsModel();

        public Transactions()
        {
            InitializeComponent();
        }

        private void PBExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Transactions_Load(object sender, EventArgs e)
        {
            ListarPersona();
            SetFormat();
            this.ReportViewerTransactions.RefreshReport();
        }

        private void ListarPersona()
        {
            TransactionsModel persona = new TransactionsModel();
            DataGridPerson.DataSource = persona.ShowPerson(txtDocumento.Text);
        }

        private void ListarResumen()
        {
            TransactionsModel summary = new TransactionsModel();
            DataGridTransaction.DataSource = summary.ShowSummary(txtDocumento.Text);
        }

        private void txtDocumento_KeyUp(object sender, KeyEventArgs e)
        {
            ListarPersona();
        }

        private void Clear()
        {
            txtDocumento.Clear();
            txtAhorro.Clear();
            ComboBoxOperation.SelectedItem = null;
            DataGridTransaction.DataSource = null;
        }

        private void SetFormat()
        {
            //Document,m.AccountNumber,Name,LastName,CurrentSaving
            DataGridPerson.Columns["Document"].HeaderText = "Documento";
            DataGridPerson.Columns["AccountNumber"].HeaderText = "Nro Cuenta";
            DataGridPerson.Columns["Name"].HeaderText = "Nombres";
            DataGridPerson.Columns["LastName"].HeaderText = "Apellidos";
            DataGridPerson.Columns["LimSaving"].HeaderText = "Ahorro / Mes";
            DataGridPerson.Columns["CurrentSaving"].HeaderText = "Saldo";

            this.DataGridPerson.Columns["LimSaving"].DefaultCellStyle.Format = "c0";
            this.DataGridPerson.Columns["LimSaving"].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("es-CO");
            this.DataGridPerson.Columns["CurrentSaving"].DefaultCellStyle.Format = "c0";
            this.DataGridPerson.Columns["CurrentSaving"].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("es-CO");

            for (int i = 0; i < DataGridPerson.Columns.Count - 1; i++)
            {
                DataGridPerson.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            DataGridPerson.Columns[DataGridPerson.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            for (int i = 0; i < DataGridPerson.Columns.Count; i++)
            {
                int colw = DataGridPerson.Columns[i].Width;
                DataGridPerson.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                DataGridPerson.Columns[i].Width = colw;
            }
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            try
            {
                transactions.InsertTransaction(txtDocumento.Text,ComboBoxOperation.SelectedItem.ToString(),txtAhorro.Text);
                MessageBox.Show("Se transfirio correctamente.");
                ListarPersona();
                ListarResumen();

                //Document,AccountNumber,Name,LastName,Amount,AmountTransaction,TransactionDate
                DataGridTransaction.Columns["Document"].HeaderText = "Documento";
                DataGridTransaction.Columns["AccountNumber"].HeaderText = "Nro Cuenta";
                DataGridTransaction.Columns["Name"].HeaderText = "Nombres";
                DataGridTransaction.Columns["LastName"].HeaderText = "Apellidos";
                DataGridTransaction.Columns["Amount"].HeaderText = "Saldo";
                DataGridTransaction.Columns["AmountTransaction"].HeaderText = "Monto Transaccion";
                DataGridTransaction.Columns["TransactionDate"].HeaderText = "Fecha Transaccion";

                this.DataGridTransaction.Columns["Amount"].DefaultCellStyle.Format = "c0";
                this.DataGridTransaction.Columns["Amount"].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("es-CO");
                this.DataGridTransaction.Columns["AmountTransaction"].DefaultCellStyle.Format = "c0";
                this.DataGridTransaction.Columns["AmountTransaction"].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("es-CO");

                for (int i = 0; i < DataGridTransaction.Columns.Count - 1; i++)
                {
                    DataGridTransaction.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
                DataGridTransaction.Columns[DataGridTransaction.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                for (int i = 0; i < DataGridTransaction.Columns.Count; i++)
                {
                    int colw = DataGridTransaction.Columns[i].Width;
                    DataGridTransaction.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                    DataGridTransaction.Columns[i].Width = colw;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pueden transferir por: " + ex);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void ComboBoxOperation_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ComboBoxOperation.SelectedIndex)
            {
                case 0:
                    if (ComboBoxOperation.SelectedIndex == 0)
                    {
                        lblOperation.Text = "";
                    }
                    break;
                case 1:
                    if (ComboBoxOperation.SelectedIndex == 1)
                    {
                        lblOperation.Text = "Ahorro";
                    }
                    break;
                case 2:
                    if (ComboBoxOperation.SelectedIndex == 2)
                    {
                        lblOperation.Text = "Cuota Extra";
                    }
                    break;
            }
        }

        private void GetReport(string Document)
        {
            TransactionsModel report = new TransactionsModel();
            report.ShowReportTransactions(Document);

            reportTransactionsHeaderBindingSource.DataSource = report;
            reportTransactionsHeaderBindingSource.DataSource = report.ReportTransactions;
            this.ReportViewerTransactions.RefreshReport();
        }

        private void GetReportDetail(string Document)
        {
            TransactionsModel report = new TransactionsModel();
            report.ShowReportDetail(Document);

            reportTransactionsDetailBindingSource.DataSource = report;
            reportTransactionsDetailBindingSource.DataSource = report.ReportTransactionsDetail;
            this.ReportViewerTransactions.RefreshReport();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            var Document = txtDocumento.Text;
            GetReport(Document);
            GetReportDetail(Document);
        }
    }
}
