using backendHackathone.DAL.Entities;

namespace backendHackathone.DAL.Repositories.ConfigurationRepository
{
    public interface IConfigurationRepository
    {
        Configuration Create(Configuration configuration);
        Configuration Get(int configurationId);
    }
}
