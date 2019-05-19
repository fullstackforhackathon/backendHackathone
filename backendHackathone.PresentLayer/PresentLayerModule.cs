using backendHackathone.PresentLayer.Services.AgeRangeService;
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

            return services;
        }
    }
}
