using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace DataAccessLayer
{
    public class Database
    {

        protected static string connectionString;

        public Database()
        {
            if (string.IsNullOrEmpty(connectionString))
                connectionString = "Server=mssqlstud.fhict.local;Database=dbi523343_mediabz;User Id=dbi523343_mediabz;Password=sem2group;";
        }
        protected SqlConnection OpenConnection()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            return connection;
        }
        
        protected void CloseConnection(SqlConnection connection)
        {
            if(connection != null && connection.State == ConnectionState.Open)
                connection.Close();
        }
        
    }
}

