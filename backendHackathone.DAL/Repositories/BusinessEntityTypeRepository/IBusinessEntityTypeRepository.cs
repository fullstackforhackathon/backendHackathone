using backendHackathone.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace backendHackathone.DAL.Repositories.BusinessEntityTypeRepository
{
    public interface IBusinessEntityTypeRepository
    {
        BusinessEntityType Create(BusinessEntityType businessEntityType);
    }
}
