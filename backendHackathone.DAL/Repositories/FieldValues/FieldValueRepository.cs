using backendHackathone.DAL.Contexts;
using backendHackathone.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace backendHackathone.DAL.Repositories.FieldValues
{
    public interface IFieldValueRepository
    {
        FieldValue Create(FieldValue fieldValue);
    }

    public class FieldValueRepository : IFieldValueRepository
    {
        private readonly EntityContext _context;

        public FieldValueRepository(EntityContext context)
        {
            _context = context;
        }

        public FieldValue Create(FieldValue fieldValue)
        {
            _context.FieldValues.Add(fieldValue);
            _context.SaveChanges();

            return fieldValue;
        }
    }
}
