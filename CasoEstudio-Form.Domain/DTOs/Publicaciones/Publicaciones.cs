using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasoEstudio_Form.Domain.DTOs.Publicaciones
{
    public class Publicaciones
    {

        public Publicaciones(int idComentario, string TextComentario, DateTime FechaComentario, int idUsuario, int? IdParent)
        {
            this.IdComentario = idComentario;
            this.TextComentario = TextComentario;
            this.FechaComentario = FechaComentario;
            this.IdUsuario = idUsuario;
            this.IdParent = IdParent;
        }

        public int IdComentario { get; set; }

        public string TextComentario { get; set; }

        public DateTime FechaComentario { get; set; }

        public int IdUsuario { get; set; }

        public int? IdParent { get; set; }

        public bool HasChanged { get; set; }

        public void Update(string textComentario, DateTime fechaComentario)
        {
            HasChanged = !textComentario.Equals(TextComentario);
            TextComentario = textComentario;
            FechaComentario = fechaComentario;
        }
    }
}
