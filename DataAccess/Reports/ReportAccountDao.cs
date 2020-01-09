using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.SQLServer
{
    public class ReportAccountDao:ConnectionToSql
    {
        DataTable ReportAccount = new DataTable();
        public DataTable TableAccount(string Document)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SP_REPORT_SINGLE_ACCOUNT";
                    command.Parameters.Add("@DOCUMENT", SqlDbType.VarChar).Value = Document;
                    command.CommandType = CommandType.StoredProcedure;
                    var reader = command.ExecuteReader();
                    var table = new DataTable();
                    reader.Dispose();
                    return table;
                }
            }
        }
    }
}
