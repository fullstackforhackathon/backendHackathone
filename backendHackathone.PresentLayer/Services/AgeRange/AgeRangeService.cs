using System.Collections.Generic;
using System.Linq;
using backendHackathone.DAL.Repositories.AgeRangeRepository;
using backendHackathone.PresentLayer.Models;

namespace backendHackathone.PresentLayer.Services.AgeRange
{
    public class AgeRangeService : IAgeRangeService
    {
        private readonly IAgeRangeRepository _repository;
        public AgeRangeService(IAgeRangeRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<AgeRangeModel> Get(int configurationId)
        {
            return _repository.Get(configurationId).Select(x => new AgeRangeModel
            {
                ConfigurationId = x.ConfigurationId,
                StartAge = x.StartAge,
                EndAge = x.EndAge,
                Id = x.Id
            });
        }

        public AgeRangeModel Create(int configurationId, AgeRangeModel ageRange)
        {
            var result = _repository.Create(new DAL.Entities.AgeRange
            {
                ConfigurationId = configurationId,
                EndAge = ageRange.EndAge,
                StartAge = ageRange.StartAge
            });

            return new AgeRangeModel
            {
                Id = result.Id,
                ConfigurationId = result.ConfigurationId,
                StartAge = result.StartAge,
                EndAge = result.EndAge
            };
        }

        public AgeRangeModel Update(AgeRangeModel ageRange)
        {
            var result = _repository.Update(new DAL.Entities.AgeRange
            {
                ConfigurationId = ageRange.ConfigurationId,
                EndAge = ageRange.EndAge,
                StartAge = ageRange.StartAge,
                Id = ageRange.Id
            });

            return new AgeRangeModel
            {
                Id = result.Id,
                ConfigurationId = result.ConfigurationId,
                StartAge = result.StartAge,
                EndAge = result.EndAge
            };
        }
    }
}
