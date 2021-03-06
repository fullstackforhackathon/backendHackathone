﻿using backendHackathone.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace backendHackathone.DAL.Contexts
{
    public class EntityContext : DbContext
    {
        public DbSet<BusinessEntityType> BusinessEntityTypes { get; set; }
        public DbSet<Field> Fields { get; set; }
        public DbSet<FieldValue> FieldValues { get; set; }
        public DbSet<BusinessEntityTypeField> BusinessEntityTypeFields { get; set; }
        public DbSet<PowerLine> PowerLinesData { get; set; }

        public DbSet<AgeRange> AgeRanges { get; set; }
        public DbSet<Configuration> Configurations { get; set; }
        public DbSet<FieldsMappingRule> FieldsMappingRules { get; set; }
        public DbSet<SubmissionScope> SubmissionScopes { get; set; }

        public EntityContext(DbContextOptions<EntityContext> options)
            : base(options) { }
    }
}
