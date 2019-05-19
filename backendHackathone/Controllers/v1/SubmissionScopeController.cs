using backendHackathone.PresentLayer.Models;
using backendHackathone.PresentLayer.Services.SubmissionScopeService;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backendHackathone.Controllers.v1
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class SubmissionScopeController : ControllerBase
    {
        private readonly ISubmissionScopeService _service;

        public SubmissionScopeController(ISubmissionScopeService service)
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
        public SubmissionScopeModel Post([FromBody] SubmissionScopeModel value)
        {
            return _service.Create(value);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }
    }
}
