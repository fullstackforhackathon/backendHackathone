using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using backendHackathone.DAL.Contexts;
using backendHackathone.DAL.Entities;

namespace backendHackathone.DAL.Repositories.AgeRangeRepository
{
    public class AgeRangeRepository : IAgeRangeRepository
    {
        private readonly EntityContext _context;

        public AgeRangeRepository(EntityContext context)
        {
            _context = context;
        }

        public AgeRange Create(AgeRange ageRange)
        {
            _context.AgeRanges.Add(ageRange);
            _context.SaveChanges();

            return ageRange;
        }

        public IQueryable<AgeRange> Get(int configurationId) =>
            _context.AgeRanges.Where(ar => ar.ConfigurationId == configurationId);

        public AgeRange Update(AgeRange ageRange)
        {
            _context.Update(ageRange);
            _context.SaveChanges();

            return ageRange;
        }
    }
}
