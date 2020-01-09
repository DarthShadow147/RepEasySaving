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
    public partial class BuyStationery : Form
    {
        BuyStationeryModel Buy = new BuyStationeryModel();

        public BuyStationery()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ListarSaldo()
        {
            BuyStationeryModel Amount = new BuyStationeryModel();
            DataGridStationeryVault.DataSource = Amount.ShowAmount();
        }

        public void ListarMovimiento()
        {
            BuyStationeryModel Vault = new BuyStationeryModel();
            DataGridVault.DataSource = Vault.ShowVault(DatePickerInitial.Value.ToString(), DatePickerFinal.Value.ToString());
        }

        private void BuyStationery_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ReportBuyStationery.SP_REPORT_STATIONERY' Puede moverla o quitarla según sea necesario.
            ListarSaldo();
            SetFormat();
            this.ReportViewerStationery.RefreshReport();
        }

        private void SetFormat()
        {
            DataGridStationeryVault.Columns["Disponible"].HeaderText = "Disponible";


            this.DataGridStationeryVault.Columns["Disponible"].DefaultCellStyle.Format = "c0";
            this.DataGridStationeryVault.Columns["Disponible"].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("es-CO");


            for (int i = 0; i < DataGridStationeryVault.Columns.Count - 1; i++)
            {
                DataGridStationeryVault.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            DataGridStationeryVault.Columns[DataGridStationeryVault.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            for (int i = 0; i < DataGridStationeryVault.Columns.Count; i++)
            {
                int colw = DataGridStationeryVault.Columns[i].Width;
                DataGridStationeryVault.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                DataGridStationeryVault.Columns[i].Width = colw;
            }
        }

        private void btnRegBinnacle_Click(object sender, EventArgs e)
        {
            try
            {
                Buy.InsertBuy(txtDescription.Text, txtAmount.Text);
                ListarSaldo();
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pueden insertar los datos por: " + ex);
            }
        }

        private void Clear()
        {
            txtDescription.Clear();
            txtAmount.Clear();
        }

        public void GetReport(string InitialDate, string FinalDate)
        {
            BuyStationeryModel report = new BuyStationeryModel();
            report.ShowReport(InitialDate, FinalDate);

            reportBuyStationeryBindingSource.DataSource = report;
            reportBuyStationeryBindingSource.DataSource = report.ReportBuyStationery;
            this.ReportViewerStationery.RefreshReport();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                ListarMovimiento();

                //OperationId,Description,DateTransaction,Amount
                DataGridVault.Columns["OperationId"].HeaderText = "Operación";
                DataGridVault.Columns["Description"].HeaderText = "Descripción";
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

                var InitialDate = DatePickerInitial.Value.ToString();
                var FinalDate = DatePickerFinal.Value.ToString();
                GetReport(InitialDate, FinalDate);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pueden mostrar los datos por: " + ex);
            }
            
        }
    }
}
