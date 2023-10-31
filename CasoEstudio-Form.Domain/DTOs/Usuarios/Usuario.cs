using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasoEstudio_Form.Domain.DTOs.Usuarios
{
    public class Usuario
    {
        public Usuario(int id, string nombre, string password)
        {
            idUsuario = id;
            nombreUsuario = nombre;
            passwordUsuario = password;
        }

        public int idUsuario { get; private set; }

        public string nombreUsuario { get; private set; }

        public string passwordUsuario { get; private set; }

        public bool HasChanged { get; private set; }

        public void Update(string nombre, string password)
        {
            HasChanged =
                !nombre.Equals(nombreUsuario, StringComparison.OrdinalIgnoreCase) &&
                !password.Equals(passwordUsuario, StringComparison.OrdinalIgnoreCase);

            nombreUsuario = nombre;
            passwordUsuario = password;
        }
    }
}
