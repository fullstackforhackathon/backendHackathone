namespace backendHackathone.Core.Models
{
    public class FieldValueModel
    {
        public int Id { get; set; }
        public int BusinessEntityId { get; set; }
        public int FieldId { get; set; }

        private IBusinessEntityModel BusinessEntity { get; set; }
        public FieldModel Field { get; set; }
    }
}
