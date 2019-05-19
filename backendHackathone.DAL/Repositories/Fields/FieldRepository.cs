using backendHackathone.DAL.Contexts;
using backendHackathone.DAL.Entities;

namespace backendHackathone.DAL.Repositories.Fields
{
    public interface IFieldRepository
    {
        Field Create(int businessEntityTypeId, Field field);
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

            return _context.Fields.Find(field.Id);
        }
    }
}
