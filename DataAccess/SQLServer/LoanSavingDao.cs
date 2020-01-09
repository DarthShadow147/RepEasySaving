using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.SQLServer
{
    public class LoanSavingDao:ConnectionToSql
    {
        public DataTable ShowSaving(string Document)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    //command.CommandText = "SELECT m.Name,m.LastName,m.LimSaving,CurrentSaving,m.AccountNumber,RegistrationDate FROM Members m INNER JOIN Account a ON a.MemberId = m.IdMember WHERE m.Document = @DOCUMENT";
                    command.CommandText = "SP_LOAN_SAVING";
                    command.Parameters.AddWithValue("@DOCUMENT", Document);
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
