using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using backendHackathone.Core.Services.FieldsService;
using backendHackathone.Core.Models;
using backendHackathone.DAL.Repositories.Fields;

namespace backendHackathone.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class FieldsController : ControllerBase
    {
        private readonly IFieldsService _service;
        private readonly IFieldRepository _repository;

        public FieldsController(IFieldsService service, IFieldRepository repository)
        {
            _service = service;
            _repository = repository;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "hello", "from", "travis", "3", "last try2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<IEnumerable<FieldModel>> Get([FromQuery] int businessEntityTypeId)
        {
            return _repository.Get(businessEntityTypeId)
                .Select(f => new FieldModel
                {
                    Id = f.Id,
                    Name = f.Name
                })
                .ToList();
        }

        // POST api/values
        [HttpPost]
        public FieldModel Post([FromQuery] int businessEntityTypeId, [FromBody] FieldModel value)
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
