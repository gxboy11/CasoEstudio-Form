using CasoEstudio_Form.Domain.InputModels;
using CasoEstudio_Form.Domain.DTOs.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasoEstudio_Form.Application.Contracts
{
    public interface IUsuarioService
    {
        Usuario Get(int id);

        bool IsCredentialValid(string nombre, string password);

        bool Insert(NuevoUsuario user);

        bool Update(UsuarioExistente user);

        bool Delete(int id);
    }
}
