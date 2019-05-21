using System.Collections.Generic;

namespace backendHackathone.DAL.Entities
{
    public class Field
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public IList<BusinessEntityTypeField> BusinessEntityTypeField { get; set; }
    }
}
