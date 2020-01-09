using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.SQLServer
{
    public class EventsDao:ConnectionToSql
    {
        DataTable tableEvents = new DataTable();
        public DataTable ShowEvents()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM Events";
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    tableEvents.Load(reader);
                    return tableEvents;
                }
            }
        }

        DataTable tableBinnacle = new DataTable();
        public DataTable ShowSummary(string EventId)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT EventId,Description,DateBinnacle,CASE WHEN Spending = 1 THEN 'GASTO' WHEN Spending = 0 THEN 'INGRESO' END AS Spending,AmountEvent FROM Binnacle WHERE EventId = @EVENT_ID";
                    command.Parameters.AddWithValue("@EVENT_ID" , EventId);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    tableBinnacle.Load(reader);
                    return tableBinnacle;
                }
            }
        }

        public void InsertEvent(string eventName, decimal Inversion, int Participants)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SP_INSERT_EVENT";
                    command.Parameters.AddWithValue("@EVENT_NAME", eventName);
                    command.Parameters.AddWithValue("@INVERSION", Inversion);
                    command.Parameters.AddWithValue("@PARTICIPANTS", Participants);
                    command.CommandType = CommandType.StoredProcedure;
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
            }
        }

        public void InsertBinnacle(int EventId,string Description,bool Spending,decimal Amount)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SP_INSERT_BINNACLE";
                    command.Parameters.AddWithValue("@EVENT_ID", EventId);
                    command.Parameters.AddWithValue("@DESCRIPTION", Description);
                    command.Parameters.AddWithValue("@SPENDING", Spending);
                    command.Parameters.AddWithValue("@AMOUNT", Amount);
                    command.CommandType = CommandType.StoredProcedure;
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
            }
        }

        public void SettlementEvent(int EventId)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SP_SETTLEMENT_EVENT";
                    command.Parameters.AddWithValue("@EVENTID", EventId);
                    command.CommandType = CommandType.StoredProcedure;
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
            }
        }

        public DataTable ShowReport(int EventId)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM SettlementEvents WHERE EventId = @EVENTID";
                    command.Parameters.AddWithValue("@EVENTID", EventId);
                    command.CommandType = CommandType.Text;
                    var reader = command.ExecuteReader();
                    var table = new DataTable();
                    table.Load(reader);
                    reader.Dispose();
                    return table;
                }
            }
        }

        public DataTable ShowBinnacle(int EventId)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT Id,EventId,Description,DateBinnacle,CASE WHEN Spending = 1 THEN 'Gasto' WHEN Spending = 0 THEN 'Ingreso' END AS Spending,AmountEvent FROM Binnacle WHERE EventId = @EVENTID";
                    command.Parameters.AddWithValue("@EVENTID", EventId);
                    command.CommandType = CommandType.Text;
                    var reader = command.ExecuteReader();
                    var table = new DataTable();
                    table.Load(reader);
                    reader.Dispose();
                    return table;
                }
            }
        }

        public DataTable ShowTotal(int EventId)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SP_TOTAL_BINNACLE";
                    command.Parameters.AddWithValue("@EVENTID", EventId);
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
