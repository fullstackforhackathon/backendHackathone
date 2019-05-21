using backendHackathone.Core.Services.FieldsService;
using backendHackathone.DAL.Entities;
using backendHackathone.DAL.Repositories.FieldsMappingRuleRepository;
using backendHackathone.PresentLayer.Models;

namespace backendHackathone.PresentLayer.Services.FieldsMappingRuleService
{
    public class FieldsMappingRuleService : IFieldsMappingRuleService
    {
        private readonly IFieldsMappingRulesRepository _repository;
        private readonly IFieldsService _fieldsService;

        public FieldsMappingRuleService(IFieldsMappingRulesRepository repository, IFieldsService fieldsService)
        {
            _repository = repository;
            _fieldsService = fieldsService;
        }

        public FieldsMappingRuleModel Create(int businessEntityTypeId, FieldsMappingRuleModel fieldsMappingRule)
        {
            var originField = _fieldsService.Create(businessEntityTypeId, fieldsMappingRule.OriginField);
            var sourceField = _fieldsService.Create(businessEntityTypeId, fieldsMappingRule.SourceField);

            var result = _repository.Create(new FieldsMappingRule
            {
                ConfigurationId = fieldsMappingRule.ConfigurationId,
                IsVisible = true,
                OriginFieldId = originField.Id,
                SourceFieldId = sourceField.Id
            });

            return new FieldsMappingRuleModel
            {
                Id = result.Id,
                ConfigurationId = result.ConfigurationId,
                IsVisible = result.IsVisible,
                OriginField = originField,
                SourceField = sourceField
            };
        }
    }
}
