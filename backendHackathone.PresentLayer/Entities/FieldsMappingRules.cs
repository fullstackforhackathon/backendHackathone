using System;
using System.Collections.Generic;
using System.Text;

namespace backendHackathone.PresentLayer.Entities
{
    public class FieldsMappingRules
    {
        public int ConfigurationId { get; set; }
        public int OriginField { get; set; }
        public int SourceField { get; set; }
        public bool IsVisible { get; set; }
    }
}
