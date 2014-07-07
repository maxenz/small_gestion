using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce.Exceptions
{
    class UsuarioInhabilitado : UserException
    {
        public UsuarioInhabilitado(string nombreUsuario) : base(nombreUsuario) { }
    }
}
