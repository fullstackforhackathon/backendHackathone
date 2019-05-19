using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using backendHackathone.Core.Services.FieldsService;
using backendHackathone.Core.Entities;

namespace backendHackathone.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class FieldsController : ControllerBase
    {
        private readonly IFieldsService _service;

        public FieldsController(IFieldsService service)
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
        public Field Post([FromQuery] int businessEntityTypeId, [FromBody] Field value)
        {
            return _service.Create(businessEntityTypeId, value);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }
    }
}
