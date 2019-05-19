﻿using backendHackathone.DAL.Repositories.BusinessEntityTypeRepository;
using backendHackathone.DAL.Repositories.Fields;
using backendHackathone.DAL.Repositories.SubmissionScopeRepository;
using Microsoft.Extensions.DependencyInjection;

namespace backendHackathone.DAL
{
    public static class DalModule
    {
        public static IServiceCollection AddDalRepositories(this IServiceCollection services)
        {
            services.AddScoped<IFieldRepository, FieldRepository>();
            services.AddScoped<IBusinessEntityTypeRepository, BusinessEntityTypeRepository>();
            services.AddScoped<ISubmissionScopeRepository, SubmissionScopeRepository>();

            return services;
        }
    }
}
