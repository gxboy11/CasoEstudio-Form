using CasoEstudio_Form.Application.Contracts;
using CasoEstudio_Form.Application.Contracts.Repositories;
using CasoEstudio_Form.Domain.DTOs.Publicaciones;
using Entities = CasoEstudio_Form.Domain.EntityModels.Publicaciones;
using CasoEstudio_Form.Domain.InputModels.Publicaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasoEstudio_Form.Application.Services
{
    public class PublicacionService : IPublicacionService
    {

        private readonly IPublicacionRepository _repository;

        public PublicacionService(IPublicacionRepository _repository)
        {
            this._repository = _repository;
        }
        public bool Delete(int id)
        {
            Entities.Publicaciones comment = _repository.Get(s => s.idUsuario == id);
            _repository.Delete(comment);
            _repository.Save();
            return true;
        }

        public Publicaciones Get(int id)
        {
            var comment = _repository.Get(s => s.idComentario == id);
            return new Publicaciones(comment.idComentario, comment.textComentario, comment.fechaComentario, comment.idUsuario, comment.idParent);
        }

        public IEnumerator<Publicaciones> GetAll()
        {
            var publicaciones = _repository.GetAll();
            var publicacionesDTOs = publicaciones.Select(comment => new Publicaciones(comment.idComentario, comment.textComentario, comment.fechaComentario, comment.idUsuario, comment.idParent));
            return (IEnumerator<Publicaciones>)publicacionesDTOs;
        }

        public bool Post(NuevaPublicacion post)
        {
            Entities.Publicaciones comment = new Entities.Publicaciones(post.TextoComentario, post.FechaComentario, post.idUsuario, post.idParent);
            _repository.Insert(comment);
            _repository.Save();
            return true;
        }

        public bool Update(PublicacionExistente post)
        {
            {
                Entities.Publicaciones comment = _repository.Get(s => s.idComentario == post.idComentario);
                comment.Update(post.TextComentario, post.FechaComentario);
                _repository.Update(comment);
                _repository.Save();
                return true;
            }
        }
    }
}
