using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using backendHackathone.Core.Services.FieldsService;
using backendHackathone.Core.Entities;
using backendHackathone.Core.Services;

namespace backendHackathone.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class BusinessEntityTypeController : ControllerBase
    {
        private readonly IBusinessEntityTypeService _service;

        public BusinessEntityTypeController(IBusinessEntityTypeService service)
        {
            _service = service;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "hello", "from", "travis", "3", "last try2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public BusinessEntityType Post([FromBody] BusinessEntityType businessEntityType)
        {
            return _service.Create(businessEntityType);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }
    }
}
