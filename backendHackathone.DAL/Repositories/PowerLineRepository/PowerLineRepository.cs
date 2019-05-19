using backendHackathone.DAL.Contexts;
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
            throw new NotImplementedException();
            var powerLines = _context.PowerLinesData
                .Where(x => x.SubmissionScopeId == submissionScopeId);

            var customFields = powerLines.Select(x => x.FieldValues);

                //.Select(x => new PowerLineWithCustomFields
                //{
                //    PowerLine = x,
                //    Fields = x.FieldValues
                //    .Select(adFields => new { key = adFields.Field.Name, value = adFields.Value })
                //    .ToDictionary(x => x.key);
                //});
        }
    }
}
