using CasoEstudio_Form.Application.Contracts.Repositories;
using CasoEstudio_Form.Application.Diagnostics;
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
    public class UsuarioRepository : Repository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(ApplicationDbContext dbContext, IOptions<Guard> guard)
            : base(dbContext, guard)
        {
        }
    }
}
