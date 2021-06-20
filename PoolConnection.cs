using System;
using System.Diagnostics;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;

using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Data.Common;

using MySqlConnector;
using System.ComponentModel;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace Datakit
{
    internal class PoolConnection : IDisposable
    {

        public static IConfiguration configuration {get;set;}


        public PoolConnection()
        {



        }
        public PoolConnection(IConfiguration config)
        {



        }

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

            MySqlConnection conex = new MySqlConnection(configuration.GetValue<string>($"ConnectionStrings:{conexName}"));
            System.Console.WriteLine($"Conexion realizada");
            return conex;




        }

        public void temporal()
        {





            #region SQL connection


            // try 
            //             { 
            //                 SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

            //                 builder.DataSource = ""; 
            //                 builder.UserID = "";            
            //                 builder.Password = "";     
            //                 builder.InitialCatalog = "";

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

        #region Disposable functions
        // Flag: Has Dispose already been called?
        bool disposed = false;
        // Instantiate a SafeHandle instance.
        SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);

        // Public implementation of Dispose pattern callable by consumers.

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        // Protected implementation of Dispose pattern.
        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                handle.Dispose();
                // Free any other managed objects here.
                //
            }

            disposed = true;
        }
        #endregion




    }
}
