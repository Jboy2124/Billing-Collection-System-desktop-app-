using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using MySql.Data.MySqlClient;

namespace billing_collection.Config
{
    public static class Connection
    {
        private readonly static string connectionString;
        static Connection() {
            string server = "localhost";
            int port = 3306;
            string database = "wd_billing_collection";
            string user = "root";
            string password = "root";

            connectionString = $"server={server};port={port};user={user};password={password};database={database};";
        }

        public static IDbConnection MySQLConnect() {
            try
            {
                MySqlConnection conn = new MySqlConnection(connectionString);
                conn.Open();
                return conn;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
