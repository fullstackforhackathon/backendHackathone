using System.Linq;
using backendHackathone.DAL.Contexts;
using backendHackathone.DAL.Entities;

namespace backendHackathone.DAL.Repositories.Fields
{
    public interface IFieldRepository
    {
        Field Create(int businessEntityTypeId, Field field);
        IQueryable<Field> Get(int businessEntityTypeId);
    }

    public class FieldRepository : IFieldRepository
    {
        private readonly EntityContext _context;

        public FieldRepository(EntityContext context)
        {
            _context = context;
        }

        public Field Create(int businessEntityTypeId, Field field)
        {
            if (field != null)
            {
                _context.Fields.Add(field);
                _context.BusinessEntityTypeFields.Add(new BusinessEntityTypeField
                {
                    BusinessEntityTypeId = businessEntityTypeId,
                    Field = field
                });

                _context.SaveChanges();
            }

            return field;
        }

        public IQueryable<Field> Get(int businessEntityTypeId)
        {
            return _context.Fields
                .Where(f => f.BusinessEntityTypeField.Any(et => et.BusinessEntityTypeId == businessEntityTypeId));
        }
    }
}
