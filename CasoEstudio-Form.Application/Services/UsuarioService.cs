﻿using CasoEstudio_Form.Application.Contracts;
using CasoEstudio_Form.Application.Contracts.Repositories;
using CasoEstudio_Form.Domain.DTOs.Usuarios;
using Entities = CasoEstudio_Form.Domain.EntityModels.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CasoEstudio_Form.Domain.InputModels;

namespace CasoEstudio_Form.Application.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _repository;

        public UsuarioService(IUsuarioRepository _repository)
        {
            this._repository = _repository;
        }

        public Usuario Get(int id)
        {
            var user = _repository.Get(s => s.idUsuario == id);
            return new Usuario(user.idUsuario, user.nombreUsuario, user.passwordUsuario);
        }

        public List<Usuario> List()
        {
            return _repository.GetAll().ToList()
                .ConvertAll(user => new Usuario(user.idUsuario, user.nombreUsuario, user.passwordUsuario));
        }

        public bool Insert(NuevoUsuario newUsuario)
        {
            Entities.Usuario user = new Entities.Usuario(newUsuario.nombreUsuario, newUsuario.passwordUsuario);
            _repository.Insert(user);
            _repository.Save();
            return true;
        }

        public bool Update(UsuarioExistente existingUsuario)
        {
            Entities.Usuario user = _repository.Get(s => s.idUsuario == existingUsuario.idUsuario);
            user.Update(existingUsuario.nombreUsuario, existingUsuario.passwordUsuario);
            _repository.Update(user);
            _repository.Save();
            return true;
        }

        public bool Delete(int id)
        {
            Entities.Usuario user = _repository.Get(s => s.idUsuario == id);
            _repository.Delete(user);
            _repository.Save();
            return true;
        }

        public bool IsCredentialValid(string nombreUsuario, string password)
        {
            var usuarioRegistrado = _repository.Get(s => s.nombreUsuario == nombreUsuario);

            if (usuarioRegistrado != null)
            {
                if (usuarioRegistrado.passwordUsuario == password)
                {
                    return true;
                }
            }

            return false;
        }



    }
}
