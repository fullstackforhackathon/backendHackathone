﻿namespace backendHackathone.DAL.Entities
{
    public class BusinessEntityTypeField
    {
        public int Id { get; set; }
        public int BusinessEntityTypeId { get; set; }
        public int FieldId { get; set; }

        public BusinessEntityType BusinessEntityType { get; set; }
        public Field Field { get; set; }
    }
}
