using backendHackathone.DAL.Contexts;
using backendHackathone.DAL.Entities;

namespace backendHackathone.DAL.Repositories.SubmissionScopeRepository
{
    public class SubmissionScopeRepository : ISubmissionScopeRepository
    {
        private readonly EntityContext _context;
        public SubmissionScopeRepository(EntityContext context)
        {
            _context = context;
        }

        public SubmissionScope Create(SubmissionScope submissionScope)
        {
            if (submissionScope != null)
            {
                _context.SubmissionScopes.Add(submissionScope);
                _context.SaveChanges();
            }

            return submissionScope;
        }
    }
}
