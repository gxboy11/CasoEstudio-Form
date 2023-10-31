using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CasoEstudio_Form.Domain.InputModels
{
    public class NuevoUsuario
    {
        [Required]
        [DisplayName("Nombre Usuario")]
        public string nombreUsuario { get; set; }

        [Required]
        [DisplayName("Contraseña")]
        public string passwordUsuario { get; set; }


    }
}
