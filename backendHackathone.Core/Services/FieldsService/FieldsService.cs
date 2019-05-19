using backendHackathone.Core.Entities;
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

        public Field Create(int businessEntityTypeId, Field field)
        {
            var result = _repository.Create(businessEntityTypeId, new DAL.Entities.Field { Id = field.Id, Name = field.Name });

            return new Field { Id = result.Id, Name = result.Name };
        }
    }
}
