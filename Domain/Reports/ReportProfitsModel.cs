using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Reports;

namespace Domain.Reports
{
    public class ReportProfitsModel
    {
        //Atributos Reporte
        public List<ReportProfitsData> ReportProfitsData { get; private set; }

        //Metodos Reporte
        public void ShowReport(string InitialDate, string FinalDate)
        {
            var report = new ReportProfitsDao();
            var result = report.ShowReport(Convert.ToDateTime(InitialDate), Convert.ToDateTime(FinalDate));

            ReportProfitsData = new List<ReportProfitsData>();

            foreach (System.Data.DataRow rows in result.Rows)
            {
                var ReportProfits = new ReportProfitsData()
                {
                    //ProfitId,LoanId,EventId,Description,EventDate,Amount
                    ProfitId = Convert.ToInt32(rows[0]),
                    LoanId = Convert.ToInt32(rows[1]),
                    EventId = Convert.ToInt32(rows[2]),
                    Description = Convert.ToString(rows[3]),
                    EventDate = Convert.ToDateTime(rows[4]),
                    Amount = Convert.ToDecimal(rows[5])
                };
                ReportProfitsData.Add(ReportProfits);
            }
        }
    }
}
