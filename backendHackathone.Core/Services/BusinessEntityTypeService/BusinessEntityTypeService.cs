using backendHackathone.Core.Entities;
using backendHackathone.DAL.Repositories.BusinessEntityTypeRepository;

namespace backendHackathone.Core.Services.BusinessEntityTypeService
{
    public class BusinessEntityTypeService : IBusinessEntityTypeService
    {
        private IBusinessEntityTypeRepository _repository;
        public BusinessEntityTypeService(IBusinessEntityTypeRepository repository)
        {
            _repository = repository;
        }

        public BusinessEntityType Create(BusinessEntityType businessEntityType)
        {
            var result = _repository.Create(new DAL.Entities.BusinessEntityType
            {
                Id = businessEntityType.Id,
                Name = businessEntityType.Name
            });

            return new BusinessEntityType { Id= result.Id, Name= result.Name } ;
        }
    }
}
