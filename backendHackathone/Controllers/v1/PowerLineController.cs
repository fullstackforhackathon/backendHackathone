using backendHackathone.DAL.Entities;
using backendHackathone.DAL.Repositories.PowerLineRepository;
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
    public class PowerLineController : ControllerBase
    {
        //private readonly ISubmissionScopeService _service;
        private readonly IPowerLineRepository _repository; 

        public PowerLineController(IPowerLineRepository repository)
        {
            _repository = repository;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<PowerLineWithCustomFields> Get([FromQuery]int submissionScopeModelId)
        {
            return _repository.GetAll(submissionScopeModelId);
        }

        [HttpPost]
        public PowerLine Post(PowerLine powerLine)
        {
            return _repository.Create(powerLine);
        }

    }
}
