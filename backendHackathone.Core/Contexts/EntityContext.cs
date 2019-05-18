using System;
using System.Collections.Generic;
using System.Text;
using backendHackathone.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace backendHackathone.Core.Contexts
{
    public class EntityContext : DbContext
    {
        public DbSet<BusinessEntityType> BusinessEntityTypes { get; set; }
        public DbSet<Field> Fields { get; set; }
        public DbSet<FieldValue> FieldValues { get; set; }
        public DbSet<PowerLine> PowerLinesData { get; set; }

        public EntityContext(DbContextOptions<EntityContext> options)
            : base(options) { }
    }
}
