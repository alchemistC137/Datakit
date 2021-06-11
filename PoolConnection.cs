using System;
using System.Diagnostics;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Data.Common;

using MySqlConnector;

namespace Datakit
{
    public class PoolConnection
    {
        private readonly IConfiguration config;

        public enum ConnectionNames
        {
            app,
            log
        }
        public MySqlConnection getConnection(ConnectionNames ConnectionName)
        {

            string conexName = String.Empty;
            switch (ConnectionName)
            {
                case ConnectionNames.app:
                    conexName = "Default";
                    break;

                default:
                    break;
            }
            // config = configuration;

            MySqlConnection conex = new MySqlConnection(config.GetValue<string>($"ConnectionStrings:{conexName}"));

            return conex;




        }

        public void temporal()
        {


            using (MySqlConnection connection = new MySqlConnection(config.GetValue<string>("ConnectionStrings:Default")))
            {

                connection.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "SELECT * FROM tablaPrueba";

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = int.Parse(reader["id"].ToString());
                        string nombre = reader["nombre"].ToString();
                    }
                }
            }


            #region SQL connection


            // try 
            //             { 
            //                 SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

            //                 builder.DataSource = "82.223.121.235"; 
            //                 builder.UserID = "root";            
            //                 builder.Password = "";     
            //                 builder.InitialCatalog = "pruebaBaseDatosMarco";

            //                 using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            //                 {
            //                     Console.WriteLine("\nQuery data example:");
            //                     Console.WriteLine("=========================================\n");

            //                     connection.Open();       

            //                     String sql = "SELECT id, collation_name FROM sys.databases";

            //                     using (SqlCommand command = new SqlCommand(sql, connection))
            //                     {
            //                         using (SqlDataReader reader = command.ExecuteReader())
            //                         {
            //                             while (reader.Read())
            //                             {
            //                                 Console.WriteLine("{0} {1}", reader.GetString(0), reader.GetString(1));
            //                             }
            //                         }
            //                     }                    
            //                 }
            //             }
            //             catch (SqlException e)
            //             {
            //                 Console.WriteLine(e.ToString());
            //             }
            //             Console.WriteLine("\nDone. Press enter.");
            //             Console.ReadLine(); 

            #endregion

        }

    }
}
