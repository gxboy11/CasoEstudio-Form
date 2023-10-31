using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CasoEstudio_Form.Application.Contracts.Contexts;
using CasoEstudio_Form.Domain.EntityModels.Usuarios;
using Microsoft.EntityFrameworkCore;

namespace CasoEstudio_Form.Persistence.Contexts
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<Usuario> Usuarios { get; set; }

        public void Save()
        {
            this.SaveChanges();
        }
    }
}
