namespace backendHackathone.DAL.Entities
{
    public class FieldValue
    {
        public int Id { get; set; }
        public int BusinessEntityId { get; set; }
        public int FieldId { get; set; }

        private IBusinessEntity BusinessEntity { get; set; }
        public Field Field { get; set; }
    }
}
