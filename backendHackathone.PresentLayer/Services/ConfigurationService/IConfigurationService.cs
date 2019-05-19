using backendHackathone.PresentLayer.Models;

namespace backendHackathone.PresentLayer.Services.ConfigurationService
{
    public interface IConfigurationService
    {
        ConfigurationModel Create(int businessEntityTypeId, ConfigurationModel configuration);
    }
}
