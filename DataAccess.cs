using System;
using System.Diagnostics;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Data.Common;

using MySqlConnector;
using AppTypes;
using dataOperations;

namespace Datakit
{
    public class DataAccess 
    {
         public static IConfiguration configuration;
        checkData checkData = new checkData();

        public DataAccess()
        {
            PoolConnection.configuration = configuration;
        }

        public bool checkCredentials(User usuario)
        {
            
            return checkData.checkCredentials(usuario);
        }

        
    }
}
