using backendHackathone.DAL.Contexts;
using backendHackathone.DAL.Entities;
using System.Linq;

namespace backendHackathone.DAL.Repositories.FieldsMappingRuleRepository
{
    public class FieldsMappingRulesRepository : IFieldsMappingRulesRepository
    {
        private readonly EntityContext _context;

        public FieldsMappingRulesRepository(EntityContext context)
        {
            _context = context;
        }

        public FieldsMappingRule Create(FieldsMappingRule fieldsMappingRule)
        {
            if (fieldsMappingRule != null)
            {
                _context.FieldsMappingRules.Add(fieldsMappingRule);
                _context.SaveChanges();
            }

            return fieldsMappingRule;
        }

        public IQueryable<FieldsMappingRule> Get(int configurationId)
        {
            return _context.FieldsMappingRules
                .Where(r => r.ConfigurationId == configurationId);
        }
    }
}
