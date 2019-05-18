using System;
using System.Collections.Generic;
using System.Text;

namespace backendHackathone.PresentLayer.Entities
{
    public class AgeRange
    {
        public int ConfigurationId { get; set; }
        public int Id { get; set; }
        public int StartAge { get; set; }
        public int EndAge { get; set; }
    }
}
