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
    public partial class Settlement : Form
    {
        SettlementModel settlement = new SettlementModel();

        public Settlement()
        {
            InitializeComponent();
        }

        private void Settlement_Load(object sender, EventArgs e)
        {
            ListarMiembros();
            ListarLiquidacion();
            SetFormat();
            //this.reportViewer1.RefreshReport();
            this.ReportViewerSettlement.RefreshReport();
        }

        private void ListarMiembros()
        {
            SettlementModel members = new SettlementModel();
            DataGridMembers.DataSource = members.ShowMembers();
        }

        private void ListarLiquidacion()
        {
            SettlementModel liquidation = new SettlementModel();
            DataGridSettlement.DataSource = liquidation.ShowSettlement();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetFormat()
        {
            // Document,Name,LastName,LimSaving,CurrentDeb,CurrentSaving,AccountNumber,Status
            DataGridMembers.Columns["Document"].HeaderText = "Documento";
            DataGridMembers.Columns["Name"].HeaderText = "Nombre";
            DataGridMembers.Columns["LastName"].HeaderText = "Apellidos";
            DataGridMembers.Columns["LimSaving"].HeaderText = "Ahorro/Mes";
            DataGridMembers.Columns["CurrentDeb"].HeaderText = "Deuda Actual";
            DataGridMembers.Columns["CurrentSaving"].HeaderText = "Ahorro Actual";
            DataGridMembers.Columns["AccountNumber"].HeaderText = "Numero Cuenta";
            DataGridMembers.Columns["Status"].HeaderText = "Estado";

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


            // Document,Name,LastName,AccountId,LimSaving,Amount
            DataGridSettlement.Columns["Document"].HeaderText = "Documento";
            DataGridSettlement.Columns["Name"].HeaderText = "Nombres";
            DataGridSettlement.Columns["LastName"].HeaderText = "Apellidos";
            DataGridSettlement.Columns["AccountId"].HeaderText = "ID Cuenta";
            DataGridSettlement.Columns["LimSaving"].HeaderText = "Ahorro / Mes";
            DataGridSettlement.Columns["Amount"].HeaderText = "Ganancias";
            DataGridSettlement.Columns["CurrentSaving"].HeaderText = "Liquidación";

            this.DataGridSettlement.Columns["LimSaving"].DefaultCellStyle.Format = "c0";
            this.DataGridSettlement.Columns["LimSaving"].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("es-CO");
            this.DataGridSettlement.Columns["Amount"].DefaultCellStyle.Format = "c0";
            this.DataGridSettlement.Columns["Amount"].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("es-CO");
            this.DataGridSettlement.Columns["CurrentSaving"].DefaultCellStyle.Format = "c0";
            this.DataGridSettlement.Columns["CurrentSaving"].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("es-CO");


            for (int i = 0; i < DataGridSettlement.Columns.Count - 1; i++)
            {
                DataGridSettlement.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            DataGridSettlement.Columns[DataGridSettlement.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            for (int i = 0; i < DataGridSettlement.Columns.Count; i++)
            {
                int colw = DataGridSettlement.Columns[i].Width;
                DataGridSettlement.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                DataGridSettlement.Columns[i].Width = colw;
            }
        }

        private void btnSettlement_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea realizar la liquidación del fondo?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                settlement.InsertSettlement();
                ListarLiquidacion();
                GetReport();
                GetTotalVault();
                GetTotalProfits();
            }
        }

        private void GetReport()
        {
            SettlementModel report = new SettlementModel();
            report.ShowReport();

            settlementSummaryBindingSource.DataSource = report;
            settlementSummaryBindingSource.DataSource = report.reportSetlementVault;
            this.ReportViewerSettlement.RefreshReport();
        }

        private void GetTotalVault()
        {
            SettlementModel report = new SettlementModel();
            report.ShowTotalVault();

            vaultTotalBindingSource.DataSource = report;
            vaultTotalBindingSource.DataSource = report.reportSetlementVTotal;
            this.ReportViewerSettlement.RefreshReport();
        }

        private void GetTotalProfits()
        {
            SettlementModel report = new SettlementModel();
            report.ShowTotalProfits();

            profitsTotalBindingSource.DataSource = report;
            profitsTotalBindingSource.DataSource = report.reportSetlementPTotal;
            this.ReportViewerSettlement.RefreshReport();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            GetReport();
            GetTotalVault();
            GetTotalProfits();
        }
    }
}
