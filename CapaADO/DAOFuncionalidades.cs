using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using FrbaCommerce.Modelo;

namespace FrbaCommerce.CapaADO
{
    public class DAOFuncionalidades: SqlConnector
    {
        public static List<Funcionalidad> getFuncionalidades()
        {
            DataTable dt =  retrieveDataTable("getFuncionalidades");
            List<Funcionalidad> lst = new List<Funcionalidad>();
            foreach (DataRow r in dt.Rows)
            {
                lst.Add(dataRowToFuncionalidad(r));
            }

            return lst;
        }

        public static List<Funcionalidad> getRolFunc(int idRol)
        {
            DataTable dt = retrieveDataTable("getRolFunc", idRol);
            List<Funcionalidad> lst = new List<Funcionalidad>();
            foreach (DataRow r in dt.Rows)
            {
                lst.Add(dataRowToFuncionalidad(r));
            }

            return lst;
        }

        private static Funcionalidad dataRowToFuncionalidad(DataRow r)
        {
            Funcionalidad f = new Funcionalidad(Convert.ToInt32(r["ID"]),
                r["Descripcion"].ToString());

            return f;
        }

    }
}
