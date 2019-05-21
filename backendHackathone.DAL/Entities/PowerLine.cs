using System.Collections.Generic;

namespace backendHackathone.DAL.Entities
{
    public class PowerLine : IBusinessEntity
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public string DispatchNumber { get; set; }
        public string Name { get; set; }
        public int Voltage { get; set; }
        public int CommissioningYear { get; set; }
        public int NumberOfChains { get; set; }
        public double SummaryLength { get; set; }
        public double SummaryLengthByChain { get; set; }
        public double Length { get; set; }
        public double LengthByChain { get; set; }
        public string LineMark { get; set; }
        public string TechnicalStatus { get; set; }

        public SubmissionScope SubmissionScope { get; set; }
        public int SubmissionScopeId { get; set; }

        public IList<FieldValue> FieldValues { get; set; }
    }
}
