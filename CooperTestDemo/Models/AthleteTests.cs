using System;
using System.Collections.Generic;

namespace CooperTestDemo.Entities
{
    public partial class AthleteTests
    {
        public int Id { get; set; }
        public int? AthleteId { get; set; }
        public int? TestId { get; set; }
        public decimal? Distance { get; set; }
        public string RecordStatus { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastUpdated { get; set; }
        public string UpdatedBy { get; set; }

        public Athlete Athlete { get; set; }
        public Tests Test { get; set; }
    }
}
