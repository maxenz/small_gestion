using System;
using System.Collections.Generic;
using System.Data;
using FrbaCommerce.Modelo;

namespace FrbaCommerce.CapaADO
{
    public class DAOCliente:SqlConnector
    {
        public static DataTable getClienteTable()
        {
            return retrieveDataTable("getClientes");
        }

        public static Cliente getCliente(int id)
        {
            var table = retrieveDataTable("getCliente", id);
            return dataRowToCliente(table.Rows[0]);
        }

        public static void UpdateCliente(Cliente cliente, int id)
        {
            DAOPersona.UpdatePersona(cliente.Persona, id);
            executeProcedure("updateCliente", id, cliente.Nombre, cliente.Apellido, cliente.TipoDoc, cliente.Documento,
                cliente.Cuil, cliente.FechaDeNacimiento);
        }

        public static int AgregarCliente(Cliente cliente)
        {
            var id = DAOPersona.AgregarPersona(cliente.Persona);
            executeProcedure("agregarCliente", id, cliente.Nombre, cliente.Apellido, cliente.TipoDoc, cliente.Documento,
                cliente.Cuil, cliente.FechaDeNacimiento);
            return id;
        }

        public static bool existeDni(string dni, int tipo)
        {
            var dt = retrieveDataTable("getClienteDni", dni,tipo);
            return dt.Rows.Count > 0;
        }

        public static bool existeTelefono(string tel)
        {
            var dt = retrieveDataTable("getClienteTel", tel);
            return dt.Rows.Count > 0;
        }

        private static Cliente dataRowToCliente(DataRow dr)
        {
            var persona = DAOPersona.getPersona(Convert.ToInt32(dr["ID_Persona"]));
            var cliente = new Cliente(persona, dr["Nombre"].ToString(), dr["Apellido"].ToString(),
                dr["Num_Doc"].ToString(), dr["Cuil"].ToString(), Convert.ToByte(dr["Tipo_Doc"]),
                dr["Fecha_Nac"].ToString(), dr["Telefono"].ToString());
            return cliente;
        }

        public static void BajaCliente(int id)
        {
            DAOPersona.BajaPersona(id,0);
        }

        public static List<TipoDocumento> TiposDocumento()
        {
            DataTable dt =  retrieveDataTable("getTiposDocumento");
            List<TipoDocumento> lstTipoDoc = new List<TipoDocumento>();
            foreach (DataRow r in dt.Rows)
            {
                TipoDocumento td  = dataRowToTipoDocumento(r);
                lstTipoDoc.Add(td);
            }

            return lstTipoDoc;
        }

        private static TipoDocumento dataRowToTipoDocumento(DataRow r)
        {
            TipoDocumento td = new TipoDocumento(Convert.ToInt32(r["ID"]), r["Descripcion"].ToString());
            return td;
        }
    }
}
