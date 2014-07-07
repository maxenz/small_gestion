using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce.Modelo
{
    public class Usuario
    {
        public string NombreUsuario;
        public int Id;
        public int RolActivo { get; set; }
        private List<int> _roles;

        public Usuario(int id, string nombre, List<int> rol)
        {
            Id = id;
            NombreUsuario = nombre;
            _roles = rol;
        }

        public List<int> Roles()
        {
            return _roles;
        }
    }
}
