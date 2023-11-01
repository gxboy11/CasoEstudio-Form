using CasoEstudio_Form.Application.Contracts.Repositories;
using CasoEstudio_Form.Application.Diagnostics;
using CasoEstudio_Form.Domain.EntityModels.Publicaciones;
using CasoEstudio_Form.Domain.EntityModels.Usuarios;
using CasoEstudio_Form.Persistence.Contexts;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasoEstudio_Form.Persistence.Repositories
{
    public class PublicacionRepository : Repository<Publicaciones>, IPublicacionRepository
    {
        public PublicacionRepository(ApplicationDbContext dbContext, IOptions<Guard> guard)
            : base(dbContext, guard)
        {
        }
    }
}
