using System;
using System.Collections.Generic;
using System.Text;

namespace CooperTestDemo.Entities
{
    public class testEntity
    {
        public DateTime testDate { get; set; }
        public int participantCnt { get; set; }
        public string testType { get; set; }
        public List<Tests> lstTests { get; set; }
    }

    public class athleteEntity
    {
        public string name { get; set; }
        public double distance { get; set; }
        public int test_id { get; set; }
        public int athleteTestId { get; set; }
        public int athleteId { get; set; }
        public string test_name { get; set; }
        public bool isForDelete { get; set; }
        public bool deleteTest { get; set; }
        public List<AthleteTests> lstAthletes { get; set; }
    }

    public class CommonResp
    {
        public bool flag { get; set; }
        public string message { get; set; }
    }

    public static class Constants
    {
        public static string ACTIVE = "Active";
        public static string DELETED = "Deleted";
    }
}

