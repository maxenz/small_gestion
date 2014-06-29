﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Text.RegularExpressions;

namespace FrbaCommerce.CapaADO
{
    public class SqlConnector
    {
        /// <summary>
        /// Realiza la conexion a la base de datos.
        /// </summary>
        /// <param name="cn"></param>
        /// <param name="cm"></param>
        public static void conexionSql(SqlConnection cn,SqlCommand cm)
        {           
            try
            {
                string sconcompleto = Globals.getConnectionString();
                cn.ConnectionString = sconcompleto; // esta linea no se si es obligatoria pero por las dudas jaja, haria lo mismo, estableceria la cabecera de conexion                
                cm.Connection = cn; // establezco que el comando sql que cree antes use la conexion sql que estableci recien
                cn.Open(); // aca abro la conexion  
            }
            catch (Exception ex)
            {
                throw ex; // tiro el error para arriba para que lo tome el metodo de acceso
            }
        }
        /// <summary>
        /// Ejecuta un stored procedure y devuelve un datatable con el resultado del mismo.
        /// </summary>
        /// <param name="procedure">Nombre del stored procedure almacenado en la BDD sin el nombre del esquema delante.</param>
        /// <param name="values">Argumentos que recibe el stored procedure.</param>
        /// <returns></returns>
        public static DataTable retrieveDataTable(string procedure, params object[] values)
        {
            List<string> argumentos = _generateArguments(procedure);
            return _retrieveDataTable(procedure, argumentos, values);
        }

        /// <summary>
        /// Ejecuta un stored procedure y devuelve un datatable con el resultado del mismo.
        /// </summary>
        /// <param name="procedure">Nombre del stored procedure almacenado en la BDD sin el nombre del esquema delante.</param>
        /// <returns></returns>
        public static DataTable retrieveDataTable(string procedure)
        {
            return _retrieveDataTable(procedure, null, null);
        }

        /// <summary>
        /// Ejecuta un stored procedure.
        /// </summary>
        /// <param name="procedure">Nombre del stored procedure almacenado en la BDD sin el nombre del esquema delante.</param>
        /// <param name="values">Argumentos que recibe el stored procedure.</param>
        public static void executeProcedure(string procedure, params object[] values)
        {
            List<string> argumentos = _generateArguments(procedure);
            _executeProcedure(procedure, argumentos, values);
        }

        /// <summary>
        /// Ejecuta un stored procedure.
        /// </summary>
        /// <param name="procedure">Nombre del stored procedure almacenado en la BDD sin el nombre del esquema delante.</param>
        public static void executeProcedure(string procedure)
        {
            _executeProcedure(procedure, null, null);
        }

        /// <summary>
        /// Ejecuta una consulta (a partir de un stored procedure) y devuelve si encontró datos o no.
        /// </summary>
        /// <param name="procedure">Nombre del stored procedure almacenado en la BDD sin el nombre del esquema delante.</param>
        /// <param name="values">Argumentos que recibe el stored procedure.</param>
        /// <returns> True: la consulta devolvió alguna fila. False: no devolvió filas.</returns>
        public static bool checkIfExists(string procedure, params object[] values)
        {
            List<string> argumentos = _generateArguments(procedure);
            return _checkIfExists(procedure, argumentos, values);
        }
        /// <summary>
        /// Ejecuta una consulta (a partir de un stored procedure) y devuelve si encontró datos o no.
        /// </summary>
        /// <param name="procedure">Nombre del stored procedure almacenado en la BDD sin el nombre del esquema delante.</param>
        /// <returns> True: la consulta devolvió alguna fila. False: no devolvió filas.</returns>
        public static bool checkIfExists(string procedure)
        {
            return _checkIfExists(procedure, null, null);
        }
        /// <summary>
        /// Ejecuta un stored procedure que devuelve un valor númerico y retorna dicho valor.
        /// </summary>
        /// <param name="procedure">Nombre del stored procedure almacenado en la BDD sin el nombre del esquema delante.</param>
        /// <param name="values">Argumentos que recibe el stored procedure.</param>
        /// <returns> Valor de retorno del stored procedure.</returns>
        public static int executeProcedureWithReturnValue(string procedure, params object[] values)
        {
            List<string> argumentos = _generateArguments(procedure);
            return _executeProcedureWithReturnValue(procedure, argumentos, values);
        }

        private static void _executeProcedure(string procedure, List<string> args, params object[] values)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cm = new SqlCommand();
            

            try
            {
                conexionSql(cn, cm);
                cm.CommandType = CommandType.StoredProcedure;
                cm.CommandText = "SMALL."+procedure;
                if (_validateArgumentsAndParameters(args, values))
                {
                    _loadSqlCommand(args, values, cm);
                }
                cm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                if (cn != null)
                {
                    cn.Close();
                }
            }
        }
        private static bool _checkIfExists(string procedure, List<string> args, params object[] values)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cm = new SqlCommand();
            SqlDataReader dr;
            DataTable dt = new DataTable();

            try
            {
                conexionSql(cn, cm);
                cm.CommandType = CommandType.StoredProcedure;
                cm.CommandText = "SMALL." + procedure;
                if (_validateArgumentsAndParameters(args, values))
                {
                    _loadSqlCommand(args, values, cm);
                }
                dr = cm.ExecuteReader();
                return dr.HasRows;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                if (cn != null)
                {
                    cn.Close();
                }
            }
        }
        private static int _executeProcedureWithReturnValue(string procedure, List<string> args, params object[] values)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cm = new SqlCommand();
            

            try
            {
                conexionSql(cn, cm);
                cm.CommandType = CommandType.StoredProcedure;
                cm.CommandText = "SMALL." + procedure;
                if (_validateArgumentsAndParameters(args, values))
                {
                    _loadSqlCommand(args, values, cm);
                }
                cm.Parameters.Add("@RETURN_VALUE", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
                cm.ExecuteNonQuery();
                return (int)cm.Parameters["@RETURN_VALUE"].Value;
            }
            catch (Exception ex)
            {
                return -1;
            }

            finally
            {
                if (cn != null)
                {
                    cn.Close();
                }
            }
        }
        private static DataTable _retrieveDataTable(string procedure, List<string> args, params object[] values)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cm = new SqlCommand();
            SqlDataReader dr;
            DataTable dt = new DataTable();

            try
            {
                conexionSql(cn, cm);
                cm.CommandType = CommandType.StoredProcedure;
                cm.CommandText = "SMALL." + procedure;
                if (_validateArgumentsAndParameters(args, values))
                {
                    _loadSqlCommand(args, values, cm);
                }
                dr = cm.ExecuteReader();
                dt.Load(dr);
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }

            finally
            {
                if (cn != null)
                {
                    cn.Close();
                }
            }
        }
        private static List<string> _generateArguments(string procedure)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cm = new SqlCommand();
            SqlDataReader dr;
            DataTable dt = new DataTable();
            List<string> args = new List<string>();
            try
            {
                conexionSql(cn, cm);
                cm.CommandType = CommandType.Text;
                cm.CommandText = "SELECT PARAMETER_NAME FROM information_schema.parameters WHERE SPECIFIC_SCHEMA='SMALL' AND SPECIFIC_NAME='" + procedure + "'";
                dr = cm.ExecuteReader();
                dt.Load(dr);
                foreach (DataRow d in dt.Rows)
                {
                    args.Add(d[0].ToString());
                }
                return args;
            }
            catch (Exception ex)
            {
                return null;
            }

            finally
            {
                if (cn != null)
                {
                    cn.Close();
                }
            }
        }
        private static bool _validateArgumentsAndParameters(List<string> args, params object[] values)
        {
            if (args != null && values != null)
            {
                if (args.Count != values.Length)
                {
                    throw new ApplicationException();
                }
                return true;
            }
            return false;
        }
        private static void _loadSqlCommand(List<string> args, object[] values, SqlCommand cm)
        {
            for (int i = 0; i < args.Count; i++)
            {
                cm.Parameters.AddWithValue(args[i], values[i]);
            }
        }
    }
}
