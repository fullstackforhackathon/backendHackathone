using backendHackathone.Core.Models;

namespace backendHackathone.Core.Services.FieldsService
{
    public interface IFieldsService
    {
        FieldModel Create(int businessEntityTypeId, FieldModel fieldModel);
    }
}
