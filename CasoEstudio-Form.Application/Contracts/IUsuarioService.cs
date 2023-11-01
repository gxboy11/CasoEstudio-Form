using CasoEstudio_Form.Domain.DTOs.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CasoEstudio_Form.Domain.InputModels.Usuarios;

namespace CasoEstudio_Form.Application.Contracts
{
    public interface IUsuarioService
    {
        Usuario Get(int id);

        int GetUserByCredentials(string username, string password);

        bool IsCredentialValid(string nombre, string password);

        bool Insert(NuevoUsuario user);

        bool Update(UsuarioExistente user);

        bool Delete(int id);
    }
}
