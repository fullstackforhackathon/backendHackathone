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
            // var powerLines = _context.PowerLinesData.Where(x => x.)
        }
    }
}
