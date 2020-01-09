using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.SQLServer
{
    public class BuyStationeryDao:ConnectionToSql
    {
        DataTable table = new DataTable();
        public DataTable ShowAmount()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT SUM(Amount) AS Disponible FROM Vault WHERE OperationId = 3";
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    table.Load(reader);
                    return table;
                }
            }
        }

        public void InsertBuy(string Description, decimal Amount)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SP_BUY_STATONERY";
                    command.Parameters.AddWithValue("@DESCRIPTION", Description);
                    command.Parameters.AddWithValue("@AMOUNT", Amount);
                    command.CommandType = CommandType.StoredProcedure;
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
            }
        }

        public DataTable ShowVault(DateTime InitialDate, DateTime FinalDate)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT CASE WHEN OperationId = 3 THEN 'Papeleria' END AS OperationId,Description,DateTransaction,Amount FROM Vault WHERE OperationId = 3 AND DateTransaction BETWEEN @INITIALDATE AND @FINALDATE AND Amount < 0";
                    command.Parameters.AddWithValue("@INITIALDATE", InitialDate);
                    command.Parameters.AddWithValue("@FINALDATE", FinalDate);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    table.Load(reader);
                    return table;
                }
            }
        }

        public DataTable ShowReport(DateTime InitialDate, DateTime FinalDate)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SP_REPORT_STATIONERY";
                    command.Parameters.AddWithValue("@INITIALDATE", InitialDate);
                    command.Parameters.AddWithValue("@FINALDATE", FinalDate);
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
