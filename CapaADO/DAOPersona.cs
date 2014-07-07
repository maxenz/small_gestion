using System;
using System.Data;
using FrbaCommerce.Modelo;

namespace FrbaCommerce.CapaADO
{
    class DAOPersona : SqlConnector
    {
        public static Persona getPersona(int idPersona)
        {
            var table = retrieveDataTable("getPersona", idPersona);
            return dataRowToPersona(table.Rows[0]);
        }

        private static Persona dataRowToPersona(DataRow dr)
        {
            var persona = new Persona
            {
                Mail = dr["Mail"].ToString(),
                Domicilio_Calle = dr["Domicilio_Calle"].ToString(),
                Nro_Calle = Convert.ToInt32(dr["Nro_Calle"]),
                Ciudad = dr["Ciudad"].ToString(),
                Cod_Postal = dr["Cod_Postal"].ToString(),
                Departamento = dr["Departamento"].ToString(),
                Localidad = dr["Localidad"].ToString(),
                Piso = dr["Piso"].ToString(),
                Telefono = dr["Telefono"].ToString()
            };
            return persona;
        }

        public static int AgregarPersona(Persona persona)
        {
            return executeProcedureWithReturnValue("agregarPersona", persona.Mail, persona.Telefono, persona.Domicilio_Calle,
                persona.Nro_Calle, persona.Piso, persona.Departamento, persona.Localidad,
                persona.Cod_Postal, persona.Ciudad, 1);
        }

        public static void UpdatePersona(Persona persona, int id)
        {
            executeProcedure("updatePersona", id, persona.Mail, persona.Telefono, persona.Domicilio_Calle,
                persona.Nro_Calle, persona.Piso, persona.Departamento, persona.Localidad,
                persona.Cod_Postal, persona.Ciudad);
        }

        public static void BajaPersona(int id, int act)
        {
            executeProcedure("activarPersona", id, act);
        }
    }
}