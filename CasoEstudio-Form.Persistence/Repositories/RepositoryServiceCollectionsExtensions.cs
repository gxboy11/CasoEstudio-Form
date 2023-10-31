using CasoEstudio_Form.Application.Contracts.Repositories;
using CasoEstudio_Form.Domain.EntityModels;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasoEstudio_Form.Persistence.Repositories
{
    public static class RepositoryServiceCollectionsExtensions
    {
        public static IServiceCollection AddRepository<TEntity, TContact, TRepository>
            (this IServiceCollection services)
            where TEntity : Entity
            where TContact : class, IRepository<TEntity>
            where TRepository : class, TContact
        {
            services.AddScoped<TContact, TRepository>();
            return services;
        }
    }
}
