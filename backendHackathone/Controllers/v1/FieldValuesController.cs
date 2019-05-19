using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using backendHackathone.Core.Services.FieldsService;
using backendHackathone.Core.Models;
using backendHackathone.DAL.Repositories.Fields;
using backendHackathone.DAL.Repositories.FieldValues;
using backendHackathone.DAL.Entities;

namespace backendHackathone.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class FieldValuesController : ControllerBase
    {
        private readonly IFieldValueRepository _repository;

        public FieldValuesController(IFieldValueRepository repository)
        {
            _repository = repository;
        }
      
        [HttpGet]
        public ActionResult<IEnumerable<FieldModel>> Get([FromQuery] int businessEntityTypeId)
        {
            return null;
            //return _repository.Get(businessEntityTypeId)
            //    .Select(f => new FieldModel
            //    {
            //        Id = f.Id,
            //        Name = f.Name
            //    })
            //    .ToList();
        }

        // POST api/values
        [HttpPost]
        public FieldValue Post([FromBody]FieldValue value)
        {
            return _repository.Create(value);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }
    }
}
