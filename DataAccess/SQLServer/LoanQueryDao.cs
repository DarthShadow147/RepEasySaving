using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Cache;

namespace DataAccess.SQLServer
{
    public class LoanQueryDao:ConnectionToSql
    {
        public DataTable ShowSummary(string Document, DateTime ApplicationDate)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SP_LOAN_QUERY";
                    //command.CommandText = "SELECT lr.Name,lr.LastName,RequestedAmount,InterestRate,NumDues,FinalAmount,InitialPayDate,FinalPayDate,m.CurrentDeb,SUM(p.AmountPaid) AS AmountPaid FROM LoanRequest lr INNER JOIN Members m ON m.IdMember = lr.MemberId INNER JOIN LoanEstimate le ON le.RequestId = lr.LoanId INNER JOIN Payments p ON p.LoanIdRequest = lr.LoanId WHERE m.Document = @DOCUMENT GROUP BY lr.Name,lr.LastName,RequestedAmount,InterestRate,NumDues,FinalAmount,InitialPayDate,FinalPayDate,m.CurrentDeb";
                    command.Parameters.AddWithValue("@DOCUMENT", Document);
                    command.Parameters.AddWithValue("@APP_DATE", ApplicationDate);
                    command.CommandType = CommandType.StoredProcedure;
                    var reader = command.ExecuteReader();
                    var table = new DataTable();
                    table.Load(reader);
                    reader.Dispose();
                    return table;
                }
            }
        }
    }
}
