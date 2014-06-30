using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce.Exceptions;
using FrbaCommerce.Model;

namespace FrbaCommerce.CapaADO
{
    public class DAOUsuario : SqlConnector
    {
        public static string GetUserPassword(string nombreUsuario)
        {
            DataTable dt = retrieveDataTable("getUserPassword", nombreUsuario);

            if (dt.Rows.Count == 0) return null;

            DataRow dr = dt.Rows[0];
            return dr["PassSHA256"].ToString();
        }

        public static int GetInvalidLogins(string nombreUsuario)
        {
            DataTable dt = retrieveDataTable("getInvalidLogins", nombreUsuario);
            var invalidLogins = dt.Rows[0]["InvalidLogins"];

            if (invalidLogins != null) return Convert.ToInt32(invalidLogins);

            ResetInvalidLogins(nombreUsuario);
            return 0;
        }

        public static void RaiseInvalidLogin(string nombreUsuario)
        {
            executeProcedure("raiseInvalidLogin", nombreUsuario);
        }

        public static void ResetInvalidLogins(string nombreUsuario)
        {
            executeProcedure("resetInvalidLogins", nombreUsuario);
        }

        public static Usuario GetUsuario(string nombreUsuario, string password)
        {
            var passObtenido = GetUserPassword(nombreUsuario); //Traigo el hash del password del usuario en la tabla
            var passIngresado = Hasher.Hash(password); //Hasheo el password ingresado

            if (passObtenido == null) throw new UsuarioNoEncontradoException(nombreUsuario);

            //Valido que el usuario no haya pasado el limite de logins invalidos
            if (GetInvalidLogins(nombreUsuario) >= 3) throw new UsuarioAlcanzoLimiteLoginsException(nombreUsuario);

            //Chequeo que los hash coincidan
            if (passObtenido.Equals(passIngresado))
            {
                ResetInvalidLogins(nombreUsuario); //reseteo la cantidad de intentos de logins fallidos
                var id = getUsuarioID(nombreUsuario);
                var rolesUsuario = GetRolesUsuario(id);

                if (rolesUsuario.Count == 0) throw new UsuarioSinRolesAsignadosException(nombreUsuario);

                Globals.setAdminLoggeado(true);
                return new Usuario(id,nombreUsuario, rolesUsuario);
            }
            
            //Password invalido, incremento la cantidad de logins fallidos
            RaiseInvalidLogin(nombreUsuario);
            throw new PasswordIncorrectoException();
            
        }

        public static int getUsuarioID(string nombreUsuario)
        {
            var dt = retrieveDataTable("getUsuarioID", nombreUsuario);
            return Convert.ToInt32(dt.Rows[0]["ID_Persona"]);
        }

        public static List<int> GetRolesUsuario(int id)
        {
            var dt = retrieveDataTable("getRolesUsuario", id);
            return (from DataRow fila in dt.Rows select Convert.ToInt32(fila["ID"])).ToList();
        }

        public static List<int> GetFuncionalidadesUsuario(int rolActivo)
        {
            return DAORol.getRol(rolActivo).Funcionalidades;
        }

        public static bool UsuarioExistente(string usuario)
        {
            var dt = retrieveDataTable("getUsuarioID", usuario);
            return dt.Rows.Count > 0;
        }

        public static void AgregarUsuario(int id, string user, string pass, int rol)
        {
            var idUser = executeProcedureWithReturnValue("agregarUsuario",id,user,Hasher.Hash(pass));

            executeProcedure("agregarUsuarioRol",idUser,rol);
        }

        public static void AgregarUsuarioAuto(int personaId, string user, string s, int i)
        {
            AgregarUsuario(personaId, user, s, i);
            executeProcedure("setPrimerInicio", personaId);
        }
    }
}
