using backendHackathone.DAL.Repositories.BusinessEntityTypeRepository;
using backendHackathone.DAL.Repositories.Fields;
using Microsoft.Extensions.DependencyInjection;

namespace backendHackathone.DAL
{
    public static class DalModule
    {
        public static IServiceCollection AddDalRepositories(this IServiceCollection services)
        {
            services.AddScoped<IFieldRepository, FieldRepository>();
            services.AddScoped<IBusinessEntityTypeRepository, BusinessEntityTypeRepository>();

            return services;
        }
    }
}
