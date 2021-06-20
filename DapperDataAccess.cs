using System;
using System.Diagnostics;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;

using System.Threading.Tasks;
using System.Data.Common;
using Dapper;
using MySqlConnector;
using System.Collections.Generic;

namespace Datakit
{
    internal abstract class DapperDataAccess
    {
        public static T getSimpleData<T>(string query)
        {

            using (PoolConnection conex = new PoolConnection())
            {
                T result = conex.getConnection(PoolConnection.ConnectionNames.app).QueryFirstOrDefault<T>(query);
                System.Console.WriteLine($"query Lanzada: {query}");
                return result;
            }
        }

    }
}
