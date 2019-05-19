using backendHackathone.Core.Models;

namespace backendHackathone.Core.Services
{
    public interface IBusinessEntityTypeService
    {
        BusinessEntityTypeModel Create(BusinessEntityTypeModel businessEntityTypeModel);
    }
}