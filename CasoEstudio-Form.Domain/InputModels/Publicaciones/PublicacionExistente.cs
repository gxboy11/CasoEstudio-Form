using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasoEstudio_Form.Domain.InputModels.Publicaciones
{
    public class PublicacionExistente
    {
        public int idComentario { get; set; }

        public int idUsuario { get; set; }

        public string TextComentario { get; set; }

        public DateTime FechaComentario { get; set; }

        public int? idParent { get; set; }

        public static implicit operator PublicacionExistente(DTOs.Publicaciones.Publicaciones publicacion)
        {
            return new PublicacionExistente()
            {
                idComentario = publicacion.IdComentario,
                idUsuario = publicacion.IdUsuario,
                TextComentario = publicacion.TextComentario,
                FechaComentario = publicacion.FechaComentario,
                idParent = publicacion.IdParent
            };
        }
    }
}
