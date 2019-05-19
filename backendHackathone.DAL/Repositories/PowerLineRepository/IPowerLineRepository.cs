using backendHackathone.DAL.Entities;
using System.Collections.Generic;
using System.Linq;

namespace backendHackathone.DAL.Repositories.PowerLineRepository
{
    public class PowerLineWithCustomFields
    {
        public PowerLine PowerLine { get; set; }
        public Dictionary<string, string> Fields { get; set; }
    }

    public interface IPowerLineRepository
    {
        IQueryable<PowerLineWithCustomFields> GetAll(int submissionScopeId);
        PowerLine Create(PowerLine powerLine);
    }
}
