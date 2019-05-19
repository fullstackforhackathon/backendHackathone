using backendHackathone.Core.Models;
using backendHackathone.DAL.Repositories.FieldsMappingRuleRepository;
using backendHackathone.PresentLayer.Models;
using backendHackathone.PresentLayer.Services.FieldsMappingRuleService;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace backendHackathone.Controllers.v1
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class FieldsMappingRuleController : Controller
    {
        private readonly IFieldsMappingRuleService _service;
        private readonly IFieldsMappingRulesRepository _repository;

        public FieldsMappingRuleController(IFieldsMappingRuleService service, IFieldsMappingRulesRepository repository)
        {
            _service = service;
            _repository = repository;
        }

        // GET api/values/5
        [HttpGet]
        public ActionResult<IEnumerable<FieldsMappingRuleModel>> Get(int configurationId)
        {
            return _repository.Get(configurationId)
                .Select(rule => new FieldsMappingRuleModel
                {
                    ConfigurationId = rule.ConfigurationId,
                    IsVisible = rule.IsVisible,
                    OriginField = new FieldModel { Id = rule.OriginField.Id, Name = rule.OriginField.Name },
                    SourceField = new FieldModel { Id = rule.SourceField.Id, Name = rule.SourceField.Name }
                })
                .ToList();
        }

        // POST api/values
        [HttpPost]
        public FieldsMappingRuleModel Post([FromQuery] int businessEntityTypeId, [FromBody] FieldsMappingRuleModel fieldsMappingRule)
        {
            return _service.Create(businessEntityTypeId, fieldsMappingRule);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }
    }
}