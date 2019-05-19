using backendHackathone.DAL.Entities;
using backendHackathone.DAL.Repositories.ConfigurationRepository;
using backendHackathone.PresentLayer.Models;
using backendHackathone.PresentLayer.Services.AgeRangeService;
using System.Linq;
using backendHackathone.PresentLayer.Services.FieldsMappingRuleService;

namespace backendHackathone.PresentLayer.Services.ConfigurationService
{
    public class ConfigurationService : IConfigurationService
    {
        private readonly IConfigurationRepository _repository;
        private readonly IAgeRangeService _ageRangeService;
        private readonly IFieldsMappingRuleService _fieldsMappingRuleService;

        public ConfigurationService(IConfigurationRepository repository, IAgeRangeService ageRangeService, IFieldsMappingRuleService fieldsMappingRuleService)
        {
            _repository = repository;
            _ageRangeService = ageRangeService;
            _fieldsMappingRuleService = fieldsMappingRuleService;
        }

        public ConfigurationModel Create(int businessEntityTypeId, ConfigurationModel configuration)
        {
            var result = _repository.Create(new Configuration { Name = configuration.Name });

            var ageRanges = configuration.AgeRanges.Select(ar => _ageRangeService.Create(result.Id, ar)).ToList();
            var fields = configuration.FieldsMappingRules.Select(rule => _fieldsMappingRuleService.Create(businessEntityTypeId, rule)).ToList();

            return new ConfigurationModel { Id = result.Id, Name = result.Name, AgeRanges = ageRanges, FieldsMappingRules = fields };
        }
    }
}
