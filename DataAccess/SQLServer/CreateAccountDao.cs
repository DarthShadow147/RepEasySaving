using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.SQLServer
{
    public class CreateAccountDao:ConnectionToSql
    {
        DataTable tablemembers = new DataTable();
        public DataTable ShowMembers()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT Document,Name,LastName,LimSaving,AccountNumber FROM Members WHERE Member = 1";
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    tablemembers.Load(reader);
                    return tablemembers;
                }
            }
        }

        public void InsertAccount(string Document)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SP_CREATE_ACCOUNT";
                    command.Parameters.AddWithValue("@DOCUMENT", Document);
                    command.CommandType = CommandType.StoredProcedure;
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
            }
        }
    }
}
