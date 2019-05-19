namespace backendHackathone.Core.Models
{
    public class BusinessEntityTypeFieldModel
    {
        public int Id { get; set; }
        public int BusinessEntityTypeId { get; set; }
        public int FieldId { get; set; }

        public BusinessEntityTypeModel BusinessEntityTypeModel { get; set; }
        public FieldModel Field { get; set; }
    }
}
