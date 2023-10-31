using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasoEstudio_Form.Domain.EntityModels.Usuarios
{
    public class Usuario : Entity
    {
        public Usuario(string nombreUsuario, string passwordUsuario)
        {
            this.nombreUsuario = nombreUsuario;
            this.passwordUsuario = passwordUsuario;
        }

        public void setInfo(string nombre, string password)
        {
            nombreUsuario = nombre;
            passwordUsuario = password;
        }

        [Key]
        public int idUsuario { get; private set; }

        public string nombreUsuario { get; private set; }

        public string passwordUsuario { get; private set; }

        public void Update(string nombre1, string password1)
        {
            nombreUsuario = nombre1;
            passwordUsuario = password1;
        }
    }
}
