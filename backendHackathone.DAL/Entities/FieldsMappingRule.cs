namespace backendHackathone.DAL.Entities
{
    public class FieldsMappingRule
    {
        public int Id { get; set; }
        public int ConfigurationId { get; set; }
        public bool IsVisible { get; set; }

        public Field OriginField { get; set; }
        public Field SourceField { get; set; }
    }
}
