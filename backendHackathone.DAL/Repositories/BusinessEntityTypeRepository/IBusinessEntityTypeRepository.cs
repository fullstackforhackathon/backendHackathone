using backendHackathone.DAL.Entities;

namespace backendHackathone.DAL.Repositories.BusinessEntityTypeRepository
{
    public interface IBusinessEntityTypeRepository
    {
        BusinessEntityType Create(BusinessEntityType businessEntityType);
    }
}
