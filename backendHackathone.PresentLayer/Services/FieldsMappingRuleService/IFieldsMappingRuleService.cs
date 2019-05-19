using backendHackathone.PresentLayer.Models;

namespace backendHackathone.PresentLayer.Services.FieldsMappingRuleService
{
    public interface IFieldsMappingRuleService
    {
        FieldsMappingRuleModel Create(int businessEntityTypeId, FieldsMappingRuleModel fieldsMappingRule);
    }
}
