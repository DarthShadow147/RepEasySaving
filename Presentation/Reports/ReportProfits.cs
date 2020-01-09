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
    public partial class ReportProfits : Form
    {
        public ReportProfits()
        {
            InitializeComponent();
        }

        private void PBExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ReportProfits_Load(object sender, EventArgs e)
        {
        }

        public void GetReport(string InitialDate, string FinalDate)
        {
            ReportProfitsModel report = new ReportProfitsModel();
            report.ShowReport(InitialDate, FinalDate);

            profitsBindingSource.DataSource = report;
            profitsBindingSource.DataSource = report.ReportProfitsData;
            this.ReportViewerProfits.RefreshReport();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                var InitialDate = DatePickerInitial.Value.ToString();
                var FinalDate = DatePickerFinal.Value.ToString();
                GetReport(InitialDate, FinalDate);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pueden insertar los datos por: " + ex);
            }
        }
    }
}
