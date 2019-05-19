using backendHackathone.DAL.Entities;
using System.Linq;

namespace backendHackathone.DAL.Repositories.FieldsMappingRuleRepository
{
    public interface IFieldsMappingRulesRepository
    {
        FieldsMappingRule Create(FieldsMappingRule fieldsMappingRule);
        IQueryable<FieldsMappingRule> Get(int configurationId);
    }
}
