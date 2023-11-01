using FluentValidation;
using CasoEstudio_Form.Application.Contracts;
using CasoEstudio_Form.Application.Diagnostics;
using CasoEstudio_Form.Application.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CasoEstudio_Form.Application
{
    public static class Injection
    {
        public static IServiceCollection AddAplication
    (this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<Guard>(options => { });

            var assembly = typeof(Injection).Assembly;

            services.AddMediatR(options => options.RegisterServicesFromAssemblies(assembly));
            services.AddValidatorsFromAssembly(assembly);

            services.AddScoped<IUsuarioService, UsuarioService>();
            services.AddScoped<IPublicacionService, PublicacionService>();

            return services;
        }
    }
}