using backendHackathone.Core.Entities;

namespace backendHackathone.PresentLayer.Entities
{
    public class FieldsMappingRules
    {
        public int Id { get; set; }
        public int ConfigurationId { get; set; }
        public bool IsVisible { get; set; }

        public Field OriginField { get; set; }
        public Field SourceField { get; set; }
    }
}
