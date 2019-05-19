using backendHackathone.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace backendHackathone.DAL.Repositories.AgeRangeRepository
{
    public interface IAgeRangeRepository
    {
        IQueryable<AgeRange> Get(int configurationId);
        AgeRange Create(AgeRange ageRange);
        AgeRange Update(AgeRange ageRange);
    }
}
