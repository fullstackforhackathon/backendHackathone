using backendHackathone.DAL.Repositories.SubmissionScopeRepository;
using backendHackathone.PresentLayer.Models;

namespace backendHackathone.PresentLayer.Services.SubmissionScopeService
{
    public class SubmissionScopeService : ISubmissionScopeService
    {
        private readonly ISubmissionScopeRepository _repository;

        public SubmissionScopeService(ISubmissionScopeRepository repository)
        {
            _repository = repository;
        }

        public SubmissionScopeModel Create(SubmissionScopeModel submissionScopeModel)
        {
            var result = _repository.Create(new DAL.Entities.SubmissionScope
            {
                CompanyName = submissionScopeModel.CompanyName,
                Date = submissionScopeModel.Date,
                FilialName = submissionScopeModel.FilialName,
                ReportId = submissionScopeModel.ReportId
            });

            return new SubmissionScopeModel
            {
                CompanyName = result.CompanyName,
                Date = result.Date,
                FilialName = result.FilialName,
                ReportId = result.ReportId
            };
        }
    }
}
