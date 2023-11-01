using CasoEstudio_Form.Domain.EntityModels.Usuarios;
using CasoEstudio_Form.Domain.EntityModels.Publicaciones;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasoEstudio_Form.Application.Contracts.Contexts
{
    public interface IApplicationDbContext
    {

        DbSet<Usuario> Usuarios { get; set; }
        DbSet<Publicaciones> Publicaciones { get; set; }

        void Save();

    }
}
