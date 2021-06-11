using System;
using System.Diagnostics;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Data.Common;

using MySqlConnector;
using AppTypes;

namespace Datakit
{
    public interface IDataAccess
    {
       

       public  bool checkCredentials(User usuario);
       public void IDisposable();
    }


    
}
