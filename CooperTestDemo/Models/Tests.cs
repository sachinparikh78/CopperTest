using System;
using System.Collections.Generic;

namespace CooperTestDemo.Entities
{
    public partial class Tests
    {
        public Tests()
        {
            AthleteTests = new HashSet<AthleteTests>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? TestDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string RecordStatus { get; set; }
        public DateTime? LastUpdated { get; set; }
        public string UpdatedBy { get; set; }

        public ICollection<AthleteTests> AthleteTests { get; set; }
                
    }
}
