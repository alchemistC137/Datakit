using System;
using Datakit;
using Microsoft.Extensions.Configuration;

namespace dataOperations
{
    public class getData
    {
       
        public string getIdUser(string user)
        {
            try
            {
                string query = $"SELECT IdUsuario FROM usuarios Where userName = '{user}'";


                return DapperDataAccess.getSimpleData<string>(query); 
            }
            catch (Exception ex )
            {

                throw ex;
            }


        }


    }
}