using System.Collections.Generic;

namespace backendHackathone.PresentLayer.Models
{
    public class ConfigurationModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public IList<AgeRangeModel> AgeRanges { get; set; }
        public IList<FieldsMappingRuleModel> FieldsMappingRules { get; set; }
    }
}
