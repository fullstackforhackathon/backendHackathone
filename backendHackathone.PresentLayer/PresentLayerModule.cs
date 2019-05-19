using backendHackathone.PresentLayer.Services.SubmissionScopeService;
using Microsoft.Extensions.DependencyInjection;

namespace backendHackathone.PresentLayer
{
    public static class PresentLayerModule
    {
        public static IServiceCollection AddPresentLayerService(this IServiceCollection services)
        {
            services.AddScoped<ISubmissionScopeService, SubmissionScopeService>();

            return services;
        }
    }
}
