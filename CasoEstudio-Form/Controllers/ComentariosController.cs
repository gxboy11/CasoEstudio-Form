using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CasoEstudio_Form.Controllers
{
    public class ComentarioModel
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string Author { get; set; }
        public DateTime DatePosted { get; set; }

        public ComentarioModel()
        {
            Id = 0; // O el valor que desees
            Text = string.Empty; // O el valor que desees
            Author = string.Empty; // O el valor que desees
            DatePosted = DateTime.Now;
        }
    }

    [Route("api/comentarios")]
	public class ComentariosController : Controller
	{

        private List<ComentarioModel> comentarios = new List<ComentarioModel>();


    public ComentariosController()
		{
			// Datos
			comentarios.Add(new ComentarioModel { Id = 1, Text = "Primer comentario", Author = "Usuario1", DatePosted = DateTime.Now });
			comentarios.Add(new ComentarioModel { Id = 2, Text = "Segundo comentario", Author = "Usuario2", DatePosted = DateTime.Now });
		}



		public IActionResult Get()
		{
			return Ok(comentarios);
		}

		[HttpGet("{id}")]
		public IActionResult Get(int id)
		{
			var comentario = comentarios.FirstOrDefault(c => c.Id == id);
			if (comentario == null)
			{
				return NotFound();
			}

			return Ok(comentario);
		}

		[HttpPost]
		public IActionResult Post([FromBody] ComentarioModel comentario)
		{
			comentario.Id = comentarios.Count + 1;
			comentario.DatePosted = DateTime.Now;
			comentarios.Add(comentario);
			return CreatedAtAction("Get", new { id = comentario.Id }, comentario);
		}

		[HttpPut("{id}")]
		public IActionResult Put(int id, [FromBody] ComentarioModel updatedComentario)
		{
			var comentario = comentarios.FirstOrDefault(c => c.Id == id);
			if (comentario == null)
			{
				return NotFound();
			}

			comentario.Text = updatedComentario.Text;
			comentario.Author = updatedComentario.Author;
			return NoContent();
		}

		[HttpDelete("{id}")]
		public IActionResult Delete(int id)
		{
			var comentario = comentarios.FirstOrDefault(c => c.Id == id);
			if (comentario == null)
			{
				return NotFound();
			}

			comentarios.Remove(comentario);
			return NoContent();
		}
	}
}
