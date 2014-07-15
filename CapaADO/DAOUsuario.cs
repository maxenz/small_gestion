using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce.Exceptions;
using FrbaCommerce.Modelo;
using FrbaCommerce.Helpers;
using FrbaCommerce.ManejoDeUsuarios;

namespace FrbaCommerce.CapaADO
{
    public class DAOUsuario : SqlConnector
    {

        public static string GetUserPassword(string nombreUsuario, string pass)
        {
            DataTable dt = retrieveDataTable("getUserPassword", nombreUsuario, pass);
            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0]["PassSHA256"].ToString();
            }
            else
            {
                return "";
            }

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
            Seguridad seg = new Seguridad();
            string passIngresada = seg.hash(password);
            string passFromDB = GetUserPassword(nombreUsuario, password);

            if (passFromDB == "") throw new UsuarioNoEncontradoException("");

            int userID = getUsuarioID(nombreUsuario);

            if (userID == 0) throw new UsuarioNoEncontradoException(nombreUsuario);

            //Valido que el usuario no haya pasado el limite de logins invalidos
            if (GetInvalidLogins(nombreUsuario) >= 3)
            {
                DAOPersona.BajaPersona(userID, 0);
                throw new UsuarioAlcanzoLimiteLoginsException(nombreUsuario);
            } 

            

            //Chequeo que los hash coincidan
            if (passIngresada == passFromDB)
            {

                ResetInvalidLogins(nombreUsuario); //reseteo la cantidad de intentos de logins fallidos
                var id = getUsuarioID(nombreUsuario);
                var rolesUsuario = GetRolesUsuario(id);

                List<Persona> per = DAO.ADOPersona.getPersonas();
                per = per.Where(x => x.ID == id).ToList<Persona>();
                if (per.FirstOrDefault().Activo == 0) throw new UsuarioInhabilitado(nombreUsuario);

                if (rolesUsuario.Count == 0) throw new UsuarioSinRolesAsignadosException(nombreUsuario);

                return new Usuario(id,nombreUsuario);
            }
            
            //Password invalido, incremento la cantidad de logins fallidos
            RaiseInvalidLogin(nombreUsuario);
            bool primerIngreso = esPrimerIngreso(userID);
            if (primerIngreso)
            {
                DAOUsuario.DeletePrimeraVez(userID) ;
                for (int i = 0; i < 2; i++) RaiseInvalidLogin(nombreUsuario);
            }
            throw new PasswordIncorrectoException();
            
        }


        private static bool esPrimerIngreso(int id)
        {
            List<Usuario> usrs = new List<Usuario>();
            usrs = getUsuarios();
            usrs = usrs.Where(x => x.Id == id).ToList<Usuario>();
            Usuario usr = usrs.FirstOrDefault();

            return usr.Primera_vez != "" ? true : false;

        }

        public static void DeletePrimeraVez(int userID)
        {
            executeProcedure("DeletePrimeraVez", userID);
        }

        public static List<Usuario> getUsuarios()
        {
            DataTable dt = retrieveDataTable("getUsuarios");
            List<Usuario> lst = new List<Usuario>();

            // --> ver q hago con primera _vez

            foreach (DataRow r in dt.Rows) {
                
                Usuario u = new Usuario(Convert.ToInt32(r["ID"]),r["Usuario"].ToString(),
                   Convert.ToString(r["Primera_Vez"]));
                lst.Add(u);
            }
            return lst; 
        }

        public static int getPersonaIDFromUser(int idUser)
        {
            int idPersona = executeProcedureWithReturnValue("GetPersonaIDFromUser", idUser);
            return idPersona;
        }

        public static void changePassword(int userID, string hashedPassword)
        {
            executeProcedure("changePassword", userID, hashedPassword);
        }

        public static int getUsuarioID(string nombreUsuario)
        {
            var dt = retrieveDataTable("getUserID", nombreUsuario);
            return Convert.ToInt32(dt.Rows[0]["ID"]);
        }

        public static List<int> GetRolesUsuario(int id)
        {
            var dt = retrieveDataTable("GetRolesUsuario", id);
            return (from DataRow fila in dt.Rows select Convert.ToInt32(fila["ID"])).ToList();
        }

        public static List<int> GetFuncionalidadesUsuario(int rolActivo)
        {
            return DAORol.getRol(rolActivo).Funcionalidades;
        }

        public static bool UsuarioExistente(string usuario)
        {
            var dt = retrieveDataTable("GetUserID", usuario);
            return dt.Rows.Count > 0;
        }

        public static void AgregarUsuario(int id, string user, string pass, int rol)
        {
            var idUser = executeProcedureWithReturnValue("AgregarUsuario",id,user,pass);

            executeProcedure("AgregarUsuarioRol",idUser,rol);
        }

        public static void AgregarUsuarioAuto(int personaId, string user, string s, int i)
        {
            AgregarUsuario(personaId, user, s, i);
            executeProcedure("setPrimerInicio", personaId,DateTime.Now);
        }



    }
}
