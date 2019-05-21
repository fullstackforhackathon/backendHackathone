using backendHackathone.Core.Models;
using backendHackathone.PresentLayer.Models;

namespace backendHackathone.PresentLayer.Models
{
    public class FieldsMappingRuleModel
    {
        public int Id { get; set; }
        public int ConfigurationId { get; set; }
        public bool IsVisible { get; set; }

        public FieldModel OriginField { get; set; }
        public FieldModel SourceField { get; set; }
    }
}
