using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce.Modelo
{
    public class TipoDocumento
    {
        public int ID { get; set; }
        public string Descripcion { get; set; }

        public TipoDocumento(int id, string descripcion)
        {
            ID = id;
            Descripcion = descripcion;
        }
    }
}
