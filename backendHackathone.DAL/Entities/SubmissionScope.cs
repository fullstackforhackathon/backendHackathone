using System;

namespace backendHackathone.DAL.Entities
{
    public class SubmissionScope
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int ReportId { get; set; }
        public string CompanyName { get; set; }
        public string FilialName { get; set; }
    }
}
