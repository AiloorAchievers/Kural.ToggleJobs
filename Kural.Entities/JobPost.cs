using System;
using System.Collections.Generic;
using System.Text;

namespace Kural.Entities
{
    public class JobPost
    {
        public int JobId { get; set; }
        public string JobTitle { get; set; }

        public string JobDescription { get; set; }

        public DateTime JobPostDate { get; set; }
    }
}
