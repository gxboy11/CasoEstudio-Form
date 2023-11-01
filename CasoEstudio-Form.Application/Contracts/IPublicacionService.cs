using CasoEstudio_Form.Domain.DTOs.Publicaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CasoEstudio_Form.Domain.InputModels.Publicaciones;

namespace CasoEstudio_Form.Application.Contracts
{
    public interface IPublicacionService
    {
        IEnumerator<Publicaciones> GetAll();

        Publicaciones Get(int id);

        bool Post(NuevaPublicacion post);

        bool Update(PublicacionExistente post);

        bool Delete(int id);
    }
}
