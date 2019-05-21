using backendHackathone.PresentLayer.Models;
using backendHackathone.PresentLayer.Services.ConfigurationService;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using backendHackathone.Core.Models;
using backendHackathone.DAL.Repositories.ConfigurationRepository;

namespace backendHackathone.Controllers.v1
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ConfigurationController : Controller
    {
        private readonly IConfigurationService _service;
        private readonly IConfigurationRepository _repository;

        public ConfigurationController(IConfigurationService service, IConfigurationRepository repository)
        {
            _service = service;
            _repository = repository;
        }

        // GET api/values/5
        [HttpGet]
        public ActionResult<ConfigurationModel> Get(int configurationId)
        {
            var result = _repository.Get(configurationId);
            return new ConfigurationModel
            {
                Id = result.Id,
                Name = result.Name,
                AgeRanges = result.AgeRanges.Select(ar => new AgeRangeModel
                {
                    Id = ar.Id,
                    ConfigurationId = ar.ConfigurationId,
                    StartAge = ar.StartAge,
                    EndAge = ar.EndAge
                }).ToList(),
                FieldsMappingRules = result.FieldsMappingRules.Select(rule => new FieldsMappingRuleModel
                {
                    Id = rule.Id,
                    ConfigurationId = rule.ConfigurationId,
                    IsVisible = rule.IsVisible,
                    OriginField = new FieldModel { Id = rule.OriginField.Id, Name = rule.OriginField.Name },
                    SourceField = new FieldModel { Id = rule.SourceField.Id, Name = rule.SourceField.Name }
                }).ToList()
            };
        }

        // POST api/values
        [HttpPost]
        public ConfigurationModel Post([FromQuery] int businessEntityTypeId, [FromBody] ConfigurationModel configurationModel)
        {
            return _service.Create(businessEntityTypeId, configurationModel);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }
    }
}
