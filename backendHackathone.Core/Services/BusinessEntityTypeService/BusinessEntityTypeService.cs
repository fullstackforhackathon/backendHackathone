using backendHackathone.Core.Models;
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

        public BusinessEntityTypeModel Create(BusinessEntityTypeModel businessEntityTypeModel)
        {
            var result = _repository.Create(new DAL.Entities.BusinessEntityType
            {
                Id = businessEntityTypeModel.Id,
                Name = businessEntityTypeModel.Name
            });

            return new BusinessEntityTypeModel { Id= result.Id, Name= result.Name } ;
        }
    }
}
