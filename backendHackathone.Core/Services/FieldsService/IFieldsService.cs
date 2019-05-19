using backendHackathone.Core.Entities;

namespace backendHackathone.Core.Services.FieldsService
{
    public interface IFieldsService
    {
        Field Create(int businessEntityTypeId, Field field);
    }
}
