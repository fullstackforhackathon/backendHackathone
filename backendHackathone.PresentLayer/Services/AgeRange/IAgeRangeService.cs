using backendHackathone.PresentLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace backendHackathone.PresentLayer.Services.AgeRange
{
    public interface IAgeRangeService
    {
        IEnumerable<AgeRangeModel> Get(int configurationId);
        AgeRangeModel Create(int configurationId, AgeRangeModel ageRange);
        AgeRangeModel Update(AgeRangeModel ageRange);
    }
}
