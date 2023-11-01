﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace CasoEstudio_Form.Domain.InputModels.Usuarios
{
    public class UsuarioExistente
    {

        public int idUsuario { get; set; }

        public string nombreUsuario { get; set; }

        public string passwordUsuario { get; set; }

        public static implicit operator UsuarioExistente(DTOs.Usuarios.Usuario existente)
        {
            return new UsuarioExistente
            {
                idUsuario = existente.idUsuario,
                nombreUsuario = existente.nombreUsuario,
                passwordUsuario = existente.passwordUsuario
            };
        }
    }
}
