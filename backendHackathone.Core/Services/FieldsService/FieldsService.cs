using backendHackathone.Core.Models;
using backendHackathone.DAL.Entities;
using backendHackathone.DAL.Repositories.Fields;

namespace backendHackathone.Core.Services.FieldsService
{
    public class FieldsService : IFieldsService
    {
        private readonly IFieldRepository _repository;

        public FieldsService(IFieldRepository repository)
        {
            _repository = repository;
        }

        public FieldModel Create(int businessEntityTypeId, FieldModel fieldModel)
        {
            var result = _repository.Create(businessEntityTypeId, new Field { Id = fieldModel.Id, Name = fieldModel.Name });

            return new FieldModel { Id = result.Id, Name = result.Name };
        }
    }
}
