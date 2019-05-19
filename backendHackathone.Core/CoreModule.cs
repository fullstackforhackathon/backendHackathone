using backendHackathone.Core.Services;
using backendHackathone.Core.Services.BusinessEntityTypeService;
using backendHackathone.Core.Services.FieldsService;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace backendHackathone.Core
{
    public static class CoreModule
    {
        public static IServiceCollection AddCoreServices(this IServiceCollection services)
        {
            services.AddScoped<IFieldsService, FieldsService>();
            services.AddScoped<IBusinessEntityTypeService, BusinessEntityTypeService>();

            return services;
        }
    }
}