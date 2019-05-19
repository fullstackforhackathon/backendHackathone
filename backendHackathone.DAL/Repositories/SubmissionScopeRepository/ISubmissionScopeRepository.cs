using backendHackathone.DAL.Entities;

namespace backendHackathone.DAL.Repositories.SubmissionScopeRepository
{
    public interface ISubmissionScopeRepository
    {
        SubmissionScope Create(SubmissionScope submissionScope);
    }
}
