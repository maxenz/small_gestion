﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using FrbaCommerce.Exceptions;
using FrbaCommerce.Modelo;

namespace FrbaCommerce.CapaADO
{
    class DAORol:SqlConnector
    {
        public static DataTable getRolesUsuario(int id)
        {
            var table =  retrieveDataTable("getRolesUsuario", id);
            if (table == null) throw new UsuarioSinRolesAsignadosException("");
            return table;
        }

        public static void AgregarRol(Rol rol)
        {
            rol.Codigo = executeProcedureWithReturnValue("agregarRol", rol.Nombre, rol.Habilitado);
            foreach (int func in rol.Funcionalidades)
            {
                executeProcedure("agregarRolFuncionalidad",rol.Codigo,func);
            }
        }

        public static DataTable getRoles()
        {
            return retrieveDataTable("getRoles");
        }

        public static bool existeRol(string nombre)
        {
            var dt = retrieveDataTable("getRolNom", nombre);
            return dt.Rows.Count > 0;
        }

        public static void BajaRol(int id, int act)
        {
            executeProcedure("activarRol", id, act);
        }

        public static void eliminarRolDeUsuarios(int idRol)
        {
            executeProcedure("eliminarRolDeUsuarios", idRol);
        }

        public static Rol getRol(int id)
        {
            var table = retrieveDataTable("getRolId", id);
            var rol = dataRowToRol(table.Rows[0]);

            table = retrieveDataTable("getRolFunc", id);

            var lista = (from DataRow fila in table.Rows select (Convert.ToInt32(fila["ID"]))).ToList();
            rol.Funcionalidades = lista;
            return rol;
        }

        public static Rol dataRowToRol(DataRow dr)
        {
            return new Rol(Convert.ToInt32(dr["ID"]),dr["Nombre"].ToString(),dr["Activo"].ToString()=="1");
        }

        public static void UpdateRol(Rol rol)
        {
            executeProcedure("UpdateRol", rol.Codigo, rol.Nombre);
            foreach (int func in rol.Funcionalidades)
            {
                executeProcedure("agregarRolFuncionalidad", rol.Codigo, func);
            }
        }
    }
}
