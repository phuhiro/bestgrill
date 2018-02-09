using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestGrill.DB
{
    class DataProvider
    {
        private static DataProvider instance;
        private DataProvider()
        {

        }

        public static DataProvider Instance
        {
            get { if(instance == null) instance = new DataProvider(); return DataProvider.instance; }
            private set { DataProvider.instance = value; }
        }

        private string connString = ConfigurationManager.AppSettings.Get("connectionString");

        public DataTable ExecuteQuery(string query)
        {
            DataTable data = new DataTable();
            using (MySqlConnection conn = new MySqlConnection(connString)) 
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(data);
                conn.Close();
            }

            return data;
        }


        public int ExecuteNonQuery(string query)
        {
            int result = 0;
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand(query, conn);
                command.ExecuteNonQuery();
                result = (int)command.LastInsertedId;
                conn.Close();
            }

            return result;
        }

        public object ExecuteScalar(string query)
        {
            object result ;
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand(query, conn);
                result = command.ExecuteScalar();
                conn.Close();
            }

            return result;
        }
    }
}
