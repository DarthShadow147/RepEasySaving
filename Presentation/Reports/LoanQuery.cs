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
using Common.Cache;

namespace Presentation
{
    public partial class LoanQuery : Form
    {

        public LoanQuery()
        {
            InitializeComponent();
        }

        private void LoanQuery_Load(object sender, EventArgs e)
        {
            //this.ReportLoan.RefreshReport();
        }

        private void PBExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var Document = txtDocumento.Text;
            var ApplicationDate = DatePickerAppDate.Value.ToString();
            GetReport(Document, ApplicationDate);
        }

        private void GetReport(string Document, string ApplicationDate)
        {
            LoanQueryModel report = new LoanQueryModel();
            report.ReportLoan(Document, ApplicationDate);

            loanReportBindingSource.DataSource = report;
            loanReportBindingSource.DataSource = report.ReportLoansQueryModel;
            this.ReportLoan.RefreshReport();
        }
    }
}