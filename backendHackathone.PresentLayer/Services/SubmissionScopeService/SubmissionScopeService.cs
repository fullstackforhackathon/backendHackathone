using backendHackathone.DAL.Repositories.SubmissionScopeRepository;
using backendHackathone.PresentLayer.Entities;

namespace backendHackathone.PresentLayer.Services.SubmissionScopeService
{
    public class SubmissionScopeService : ISubmissionScopeService
    {
        private readonly ISubmissionScopeRepository _repository;

        public SubmissionScopeService(ISubmissionScopeRepository repository)
        {
            _repository = repository;
        }

        public SubmissionScope Create(SubmissionScope submissionScope)
        {
            var result = _repository.Create(new DAL.Entities.SubmissionScope
            {
                CompanyName = submissionScope.CompanyName,
                Date = submissionScope.Date,
                FilialName = submissionScope.FilialName,
                ReportId = submissionScope.ReportId
            });

            return new SubmissionScope
            {
                CompanyName = result.CompanyName,
                Date = result.Date,
                FilialName = result.FilialName,
                ReportId = result.ReportId
            };
        }
    }
}
