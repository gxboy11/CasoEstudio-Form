using CasoEstudio_Form.Domain.EntityModels.Usuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasoEstudio_Form.Domain.EntityModels.Publicaciones
{
    public class Publicaciones : Entity
    {

        public Publicaciones(string textComentario, DateTime fechaComentario, int idUsuario, int? idParent)
        {
            this.textComentario = textComentario;
            this.fechaComentario = fechaComentario;
            this.idUsuario = idUsuario;
            this.idParent = idParent;
        }

        [Key]
        public int idComentario { get; private set; }

        public int idUsuario { get; private set; }

        public string textComentario { get; private set; }

        public DateTime fechaComentario { get; private set; }

        public int? idParent { get; private set; }


        [ForeignKey("idUsuario")]
        public Usuario Usuario { get; set; }

        [ForeignKey("idParent")]
        public Publicaciones Publicacion { get; set; }


        public void Update(string textComentario, DateTime fechaComentario)
        {
            this.textComentario = textComentario;
            this.fechaComentario = fechaComentario;
        }
    }
}
