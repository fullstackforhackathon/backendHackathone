using backendHackathone.PresentLayer.Services.AgeRangeService;
using backendHackathone.PresentLayer.Services.ConfigurationService;
using backendHackathone.PresentLayer.Services.FieldsMappingRuleService;
using backendHackathone.PresentLayer.Services.SubmissionScopeService;
using Microsoft.Extensions.DependencyInjection;

namespace backendHackathone.PresentLayer
{
    public static class PresentLayerModule
    {
        public static IServiceCollection AddPresentLayerService(this IServiceCollection services)
        {
            services.AddScoped<ISubmissionScopeService, SubmissionScopeService>();
            services.AddScoped<IAgeRangeService, AgeRangeService>();
            services.AddScoped<IConfigurationService, ConfigurationService>();
            services.AddScoped<IFieldsMappingRuleService, FieldsMappingRuleService>();

            return services;
        }
    }
}
