﻿using System;
using System.Collections.Generic;
using System.Text;

namespace backendHackathone.PresentLayer.Entities
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