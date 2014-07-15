﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

using FrbaCommerce.CapaADO;
using FrbaCommerce.Modelo;

namespace FrbaCommerce.DAO
{
    class ADOCalificacion : SqlConnector
    {
        public static void setCalificacion(int idPublicacion, int cEstrellas, string detalle)
        {

            DateTime fechaActual = DateTime.Now;
            SqlConnector.executeProcedure("SetCalificacion", idPublicacion, cEstrellas,
                detalle, fechaActual, Globals.userID);
            SqlConnector.executeProcedure("UpdateCompraCalificacion", idPublicacion, Globals.userID);

        }
    }
 

}
