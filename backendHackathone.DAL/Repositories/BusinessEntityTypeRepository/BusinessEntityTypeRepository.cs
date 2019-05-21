using backendHackathone.DAL.Contexts;
using backendHackathone.DAL.Entities;

namespace backendHackathone.DAL.Repositories.BusinessEntityTypeRepository
{
    public class BusinessEntityTypeRepository : IBusinessEntityTypeRepository
    {
        private readonly EntityContext _context;

        public BusinessEntityTypeRepository(EntityContext context)
        {
            _context = context;
        }

        public BusinessEntityType Create(BusinessEntityType businessEntityType)
        {
            if (businessEntityType != null)
            {
                _context.BusinessEntityTypes.Add(businessEntityType);
                _context.SaveChanges();
            }

            return _context.BusinessEntityTypes.Find(businessEntityType.Id);
        }
    }
}
