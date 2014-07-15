using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce.Modelo
{
    public class Usuario
    {
        public string NombreUsuario { get; set; }
        public int Id { get; set; }
        public int RolActivo { get; set; }
        private List<int> _roles;
        public string Primera_vez { get; set; }

        public Usuario(int id, string nombre, List<int> rol)
        {
            Id = id;
            NombreUsuario = nombre;
            _roles = rol;
        }

        public Usuario(int id, string nombre)
        {
            Id = id;
            NombreUsuario = nombre;
        }

        public Usuario(int id, string nombre, string primera_vez )
        {
            Id = id;
            NombreUsuario = nombre;
            Primera_vez = primera_vez;
        }

        public List<int> Roles()
        {
            return _roles;
        }
    }
}
