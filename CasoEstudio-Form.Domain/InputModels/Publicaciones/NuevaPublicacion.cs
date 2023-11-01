using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasoEstudio_Form.Domain.InputModels.Publicaciones
{
    public class NuevaPublicacion
    {
        [Required]
        [DisplayName("Texto Publicacion")]
        public string TextoComentario { get; set; }

        [Required]
        [DisplayName("Fecha Publicacion")]
        public DateTime FechaComentario { get; set; }

        [Required]
        [DisplayName("Nombre Usuario")]
        public int idUsuario { get; set; }

        [DisplayName("Comentario Padre")]
        public int idParent { get; set; }
    }
}
