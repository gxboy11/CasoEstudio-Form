using CasoEstudio_Form.Application.Contracts.Contexts;
using CasoEstudio_Form.Application.Contracts.Repositories;
using CasoEstudio_Form.Domain.EntityModels.Publicaciones;
using CasoEstudio_Form.Domain.EntityModels.Usuarios;
using CasoEstudio_Form.Persistence.Contexts;
using CasoEstudio_Form.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CasoEstudio_Form.Persistence
{
    public static class Injection
    {
        public static IServiceCollection AddPersistence
            (this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>
                (options => options.UseSqlServer(configuration.GetConnectionString("Default")));

            services.AddScoped<IApplicationDbContext>
                (options => options.GetService<ApplicationDbContext>());

            services.AddRepository<Usuario, IUsuarioRepository, UsuarioRepository>();
            services.AddRepository<Publicaciones, IPublicacionRepository, PublicacionRepository>();

            return services;
        }
    }
}