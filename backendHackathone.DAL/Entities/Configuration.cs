using System.Collections;
using System.Collections.Generic;

namespace backendHackathone.DAL.Entities
{
    public class Configuration
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public IList<AgeRange> AgeRanges { get; set; }
        public IList<FieldsMappingRule> FieldsMappingRules { get; set; }
    }
}
