using System.Collections.Generic;

namespace backendHackathone.PresentLayer.Models
{
    public class UserTable
    {
        public Dictionary<string, IList<object>> Data { get; set; } = new Dictionary<string, IList<object>>();
    }
}
