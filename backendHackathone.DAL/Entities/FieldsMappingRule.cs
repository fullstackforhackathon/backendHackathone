namespace backendHackathone.DAL.Entities
{
    public class FieldsMappingRule
    {
        public int Id { get; set; }
        public int ConfigurationId { get; set; }
        public int OriginFieldId { get; set; }
        public int SourceFieldId { get; set; }
        public bool IsVisible { get; set; }

        public Field OriginField { get; set; }
        public Field SourceField { get; set; }
    }
}
