using System;
using AppTypes;
using Microsoft.Extensions.Configuration;

namespace dataOperations
{
    public class checkData
    {
        private getData getData = new getData();
        public bool checkCredentials(User usuario)
        {

            Guid? idUser = getData.getIdUser(usuario.userName);
            usuario.IdUsuario = idUser;
            Guid? idPass = getData.getIdPass(usuario);

            System.Console.WriteLine($"Resultado query usuario: {idUser}");
            System.Console.WriteLine($"Resultado query pass: {idPass}");

            if (idUser != null && idPass != null)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}