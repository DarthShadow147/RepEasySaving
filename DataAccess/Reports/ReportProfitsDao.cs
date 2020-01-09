using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Reports
{
    public class ReportProfitsDao:SQLServer.ConnectionToSql
    {
        public DataTable ShowReport(DateTime InitialDate, DateTime FinalDate)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM Profits WHERE EventDate BETWEEN @INITIALDATE AND @FINALDATE";
                    command.Parameters.AddWithValue("@INITIALDATE", InitialDate);
                    command.Parameters.AddWithValue("@FINALDATE", FinalDate);
                    command.CommandType = CommandType.Text;
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
