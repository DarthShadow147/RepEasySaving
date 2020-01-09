using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;

namespace Presentation.Reports
{
    public partial class LoanSaving : Form
    {
        public LoanSaving()
        {
            InitializeComponent();
        }

        private void LoanSaving_Load(object sender, EventArgs e)
        {
            //this.reportViewer1.RefreshReport();
        }

        private void PBExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var Document = txtDocumento.Text;
            GetReportSaving(Document);
        }

        private void GetReportSaving(string Document)
        {
            LoanSavingModel reportSaving = new LoanSavingModel();
            reportSaving.ReportSaving(Document);

            eSLoanSavingBindingSource.DataSource = reportSaving;
            eSLoanSavingBindingSource.DataSource = reportSaving.ReportSavingModel;
            this.ReportSaving.RefreshReport();
        }
    }
}
