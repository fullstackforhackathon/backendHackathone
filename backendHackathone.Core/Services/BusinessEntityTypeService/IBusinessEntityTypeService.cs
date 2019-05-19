using backendHackathone.Core.Entities;

namespace backendHackathone.Core.Services
{
    public interface IBusinessEntityTypeService
    {
        BusinessEntityType Create(BusinessEntityType businessEntityType);
    }
}