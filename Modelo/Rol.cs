using System.Collections.Generic;

namespace FrbaCommerce.Modelo
{
    public class Rol
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public bool Habilitado { get; set; }
        public List<int> Funcionalidades;

        public Rol(string nombre)
        {
            Nombre = nombre;
        }
        
        public Rol(int cod, string nombre, bool habilitado)
        {
            Codigo = cod;
            Nombre = nombre;
            Habilitado = habilitado;
        }
        
        public Rol(string nombre, List<int> funcionalidades )
        {
            Nombre = nombre;
            Funcionalidades = funcionalidades;
            Habilitado = true;
        }

    }
}