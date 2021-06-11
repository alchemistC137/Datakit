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
    public class DataAccess : IDataAccess
    {
        checkData checkData = new checkData();

        private readonly IConfiguration config;

        public DataAccess()
        {
        }

        public bool checkCredentials(User usuario)
        {
            
            return checkData.checkCredentials(usuario);
        }

        public void IDisposable()
        {
            throw new NotImplementedException();
        }
    }
}
