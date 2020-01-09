using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Reports;

namespace Domain.Reports
{
    public class ReportContributionsModel
    {
        public List<ReportDataContributions> ReportDataContributions { get; private set; }
        public List<ReportDataContributionsTotal> ReportDataContributionsTotal { get; private set; }

        //Metodos
        public void ShowReport(string InitialDate, string FinalDate)
        {
            var report = new ReportContributionsDao();
            var result = report.ShowReport(Convert.ToDateTime(InitialDate), Convert.ToDateTime(FinalDate));

            ReportDataContributions = new List<ReportDataContributions>();

            foreach (System.Data.DataRow rows in result.Rows)
            {
                var ReportContributionsModel = new ReportDataContributions()
                {
                    //Document,Member,AccountNumber,ahorroTotal,AmountTransaction,TransactionDate
                    Document = Convert.ToString(rows[0]),
                    Member = Convert.ToString(rows[1]),
                    AccountNumber = Convert.ToInt32(rows[2]),
                    ahorroTotal = Convert.ToDecimal(rows[3]),
                    AmountTransaction = Convert.ToDecimal(rows[4]),
                    TransactionDate = Convert.ToDateTime(rows[5])
                };
                ReportDataContributions.Add(ReportContributionsModel);
            }
        }

        public void ShowTotals(string InitialDate, string FinalDate)
        {
            var report = new ReportContributionsDao();
            var result = report.ShowTotals(Convert.ToDateTime(InitialDate), Convert.ToDateTime(FinalDate));

            ReportDataContributionsTotal = new List<ReportDataContributionsTotal>();

            foreach (System.Data.DataRow rows in result.Rows)
            {
                var ReportContributionsModel = new ReportDataContributionsTotal()
                {
                    //TotalSavings,TotalMonth
                    TotalSavings = Convert.ToDecimal(rows[0]),
                    TotalMonth = Convert.ToDecimal(rows[1])
                };
                ReportDataContributionsTotal.Add(ReportContributionsModel);
            }
        }
    }
}
