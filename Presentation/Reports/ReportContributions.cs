using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain.Reports;

namespace Presentation.Reports
{
    public partial class ReportContributions : Form
    {
        public ReportContributions()
        {
            InitializeComponent();
        }

        private void PBExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ReportContributions_Load(object sender, EventArgs e)
        {
            //this.reportViewer1.RefreshReport();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                var InitialDate = DateTimeInitial.Value.ToString();
                var FinalDate = DatetimeFinal.Value.ToString();
                GetReport(InitialDate, FinalDate);
                GetReportTotal(InitialDate, FinalDate);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pueden mostrar los datos por: " + ex);
            }
        }

        private void GetReport(string InitialDate, string FinalDate)
        {
            ReportContributionsModel report = new ReportContributionsModel();
            report.ShowReport(InitialDate, FinalDate);

            rEPORTCONTRIBUTIONSBindingSource.DataSource = report;
            rEPORTCONTRIBUTIONSBindingSource.DataSource = report.ReportDataContributions;
            this.ReportContributionsView.RefreshReport();
        }

        private void GetReportTotal(string InitialDate, string FinalDate)
        {
            ReportContributionsModel report2 = new ReportContributionsModel();
            report2.ShowTotals(InitialDate, FinalDate);

            sPREPORTCONTRIBUTIONSTOTALBindingSource.DataSource = report2;
            sPREPORTCONTRIBUTIONSTOTALBindingSource.DataSource = report2.ReportDataContributionsTotal;
            this.ReportContributionsView.RefreshReport();
        }
    }
}
