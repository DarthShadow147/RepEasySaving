using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.SQLServer
{
    public class ShowDuesDao:ConnectionToSql
    {
        DataTable tableMembers = new DataTable();
        public DataTable MostrarMiembros()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT Document,m.Name,m.LastName,Phone,CurrentSaving,CurrentDeb FROM Members m WHERE CurrentDeb > 0";
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    tableMembers.Load(reader);
                    return tableMembers;
                }
            }
        }

        DataTable tableDues = new DataTable();
        public DataTable ShowDues(string Document)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SP_SHOW_DUES";
                    command.Parameters.AddWithValue("@DOCUMENT",Document);
                    command.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = command.ExecuteReader();
                    tableDues.Load(reader);
                    return tableDues;
                }
            }
        }

        public DataTable PrintDues(string Document)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SP_SHOW_DUES";
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

        public DataTable DuesMember(string Document)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SP_SHOW_MEMBER_DUES";
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
