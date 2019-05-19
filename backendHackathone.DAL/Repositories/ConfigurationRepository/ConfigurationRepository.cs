using System.Linq;
using backendHackathone.DAL.Contexts;
using backendHackathone.DAL.Entities;

namespace backendHackathone.DAL.Repositories.ConfigurationRepository
{
    public class ConfigurationRepository : IConfigurationRepository
    {
        private readonly EntityContext _context;

        public ConfigurationRepository(EntityContext context)
        {
            _context = context;
        }

        public Configuration Create(Configuration configuration)
        {
            if (configuration != null)
            {
               _context.Configurations.Add(configuration);
               _context.SaveChanges();
            }

            return configuration;
        }

        public Configuration Get(int configurationId)
        {
            return _context.Configurations
                .SingleOrDefault(c => c.Id == configurationId);
        }
    }
}
