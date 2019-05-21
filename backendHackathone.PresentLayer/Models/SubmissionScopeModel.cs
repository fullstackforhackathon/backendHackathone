using System;

namespace backendHackathone.PresentLayer.Models
{
    public class SubmissionScopeModel
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int ReportId { get; set; }
        public string CompanyName { get; set; }
        public string FilialName { get; set; }
    }
}
