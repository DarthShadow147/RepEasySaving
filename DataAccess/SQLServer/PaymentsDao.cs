using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.SQLServer
{
    public class PaymentsDao:ConnectionToSql
    {
        DataTable tableDuesInfo = new DataTable();
        public DataTable ShowDuesInfo(string Document)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT DueId, d.LoanId,DueDate,DueNumber,DueValue,CASE WHEN d.Status = 1 THEN 'Pendiente' WHEN d.Status = 0 THEN 'Cancelada' END AS Status FROM Dues d INNER JOIN LoanRequest lr ON lr.LoanId = d.LoanId INNER JOIN Members m ON m.IdMember = lr.MemberId WHERE m.Document = @DOCUMENTO AND d.Status <> 0";
                    command.Parameters.AddWithValue("@DOCUMENTO", Document);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    tableDuesInfo.Load(reader);
                    return tableDuesInfo;
                }
            }
        }

        public void InsertPayment(string Document, int DueId, int LoanId, decimal DueValue)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SP_LOAD_PAYMENT";
                    command.Parameters.AddWithValue("@DOCUMENTO", Document);
                    command.Parameters.AddWithValue("@DUEID", DueId);
                    command.Parameters.AddWithValue("@LOANID", LoanId);
                    command.Parameters.AddWithValue("@DUEVALUE", DueValue);
                    command.CommandType = CommandType.StoredProcedure;
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
            }
        }
    }
}
