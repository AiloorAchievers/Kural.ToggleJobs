using System;

namespace TJ.Entities
{
    public class JobPost
    {
        public int JobId { get; set; }
        public string JobTitle { get; set; }

        public string JobDescription { get; set; }

        public DateTime JobPostDate { get; set; }
    }
}
