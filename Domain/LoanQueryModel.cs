using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.SQLServer;

namespace Domain
{
    //Atributos
    public class LoanQueryModel
    {
        public List<ReportLoansQueryModel> ReportLoansQueryModel { get; private set; }

        //Metodos
        public void ReportLoan(string Document, string ApplicationDate)
        {
            var query = new LoanQueryDao();
            var result = query.ShowSummary(Document, Convert.ToDateTime(ApplicationDate));

            ReportLoansQueryModel = new List<ReportLoansQueryModel>();

            foreach (System.Data.DataRow rows in result.Rows)
            {
                var LoanQueryModel = new ReportLoansQueryModel()
                {
                    //Name,LastName,RequestedAmount,InterestRate,NumDues,FinalAmount,InitialPayDate,FinalPayDate,CurrentDeb,AmountPaid
                    Name = Convert.ToString(rows[0]),
                    LastName = Convert.ToString(rows[1]),
                    RequestedAmount = Convert.ToDecimal(rows[2]),
                    InterestRate = Convert.ToInt32(rows[3]),
                    NumDues = Convert.ToInt32(rows[4]),
                    FinalAmount = Convert.ToDecimal(rows[5]),
                    InitialPayDate = Convert.ToDateTime(rows[6]),
                    FinalPayDate = Convert.ToDateTime(rows[7]),
                    CurrentDeb = Convert.ToDecimal(rows[8]),
                    AmountPaid = Convert.ToDecimal(rows[9])
                };
                ReportLoansQueryModel.Add(LoanQueryModel);
            }
        }
    }
}
