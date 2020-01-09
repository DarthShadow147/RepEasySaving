using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Reports
{
    public class ReportContributionsDao:SQLServer.ConnectionToSql
    {
        public DataTable ShowReport(DateTime InitialDate, DateTime FinalDate)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SP_REPORT_CONTRIBUTIONS";
                    command.Parameters.AddWithValue("@INITIAL_DATE", InitialDate);
                    command.Parameters.AddWithValue("@FINAL_DATE", FinalDate);
                    command.CommandType = CommandType.StoredProcedure;
                    var reader = command.ExecuteReader();
                    var table = new DataTable();
                    table.Load(reader);
                    reader.Dispose();
                    return table;
                }
            }
        }

        public DataTable ShowTotals(DateTime InitialDate, DateTime FinalDate)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SP_REPORT_CONTRIBUTIONS_TOTAL";
                    command.Parameters.AddWithValue("@INITIAL_DATE", InitialDate);
                    command.Parameters.AddWithValue("@FINAL_DATE", FinalDate);
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
