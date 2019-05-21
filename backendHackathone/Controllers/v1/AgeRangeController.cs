using backendHackathone.PresentLayer.Models;
using backendHackathone.PresentLayer.Services.AgeRangeService;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace backendHackathone.Controllers.v1
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class AgeRangeController : ControllerBase
    {
        private readonly IAgeRangeService _service;

        public AgeRangeController(IAgeRangeService service)
        {
            _service = service;
        }

        //[HttpGet]
        //public IEnumerable<AgeRangeModel> Get([FromQuery]int configurationId)
        //{
        //    return _service.Get(configurationId);
        //}

        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new [] { "test", "travis"};
        }

        [HttpPut]
        public AgeRangeModel Put([FromBody]AgeRangeModel ageRangeModel)
        {
            return _service.Update(ageRangeModel);
        }

        [HttpPost]
        public AgeRangeModel Post([FromQuery]int configurationId, [FromBody]AgeRangeModel ageRangeModel)
        {
            return _service.Create(configurationId, ageRangeModel);
        }
    }
}
