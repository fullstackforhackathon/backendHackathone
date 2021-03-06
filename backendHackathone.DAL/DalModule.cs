﻿using backendHackathone.DAL.Repositories.AgeRangeRepository;
using backendHackathone.DAL.Repositories.BusinessEntityTypeRepository;
using backendHackathone.DAL.Repositories.ConfigurationRepository;
using backendHackathone.DAL.Repositories.Fields;
using backendHackathone.DAL.Repositories.FieldsMappingRuleRepository;
using backendHackathone.DAL.Repositories.FieldValues;
using backendHackathone.DAL.Repositories.PowerLineRepository;
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
            services.AddScoped<IAgeRangeRepository, AgeRangeRepository>();
            services.AddScoped<IConfigurationRepository, ConfigurationRepository>();
            services.AddScoped<IFieldsMappingRulesRepository, FieldsMappingRulesRepository>();
            services.AddScoped<IPowerLineRepository, PowerLineRepository>();
            services.AddScoped<IFieldValueRepository, FieldValueRepository>();
            
            return services;
        }
    }
}
