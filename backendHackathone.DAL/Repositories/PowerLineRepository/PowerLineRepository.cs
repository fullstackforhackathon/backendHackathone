using backendHackathone.DAL.Contexts;
using backendHackathone.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace backendHackathone.DAL.Repositories.PowerLineRepository
{
    public class PowerLineRepository : IPowerLineRepository
    {
        private readonly EntityContext _context;

        public PowerLineRepository(EntityContext context)
        {
            _context = context;
        }

        public IQueryable<PowerLineWithCustomFields> GetAll(int submissionScopeId)
        {
            var powerLines = _context.PowerLinesData
                .Where(x => x.SubmissionScopeId == submissionScopeId)
                .Select(x => new PowerLineWithCustomFields()
                {
                    PowerLine = x,
                    Fields = x.FieldValues.Where(fv => fv.BusinessEntityId == 1).ToDictionary(y => y.Field.Name, v => v.Value)
                });

            return powerLines;
        }

        public PowerLine Create(PowerLine powerLine)
        {
            _context.PowerLinesData.Add(powerLine);
            _context.SaveChanges();

            return powerLine;
        }
    }
}
