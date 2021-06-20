using System;
using AppTypes;
using Datakit;
using Microsoft.Extensions.Configuration;

namespace dataOperations
{
    public class getData
    {

        public Guid? getIdUser(string userName)
        {
            try
            {
                string query = $"SELECT IdUsuario FROM usuarios Where userName = '{userName}'";

                Guid result;
                Guid? IdUser = null;
                IdUser =  Guid.TryParse(DapperDataAccess.getSimpleData<string>(query), out result) ? (Guid) result: null;
                return IdUser;
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        internal Guid? getIdPass(User us)
        {
            try
            {
                string query = $"SELECT IdPass FROM passwords Where IdUsuario = '{us.IdUsuario}' and pass = '{us.password}' ";
                Guid result;
                us.IdPass = null; 
                us.IdPass = Guid.TryParse(DapperDataAccess.getSimpleData<string>(query),out result) ? (Guid) result : null;

                return us.IdPass;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}