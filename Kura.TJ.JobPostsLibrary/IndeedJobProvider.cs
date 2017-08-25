using System;
using System.Collections.Generic;
using System.Text;
using TJ.Entities;

namespace Kura.TJ.JobPostsLibrary
{
    public class IndeedJobProvider : IJobProvider
    {
        public IEnumerable<JobPost> ExtractJobs(string keyword)
        {
            if (string.IsNullOrEmpty(keyword))
                throw new ArgumentNullException("Keyword cannot be empty");

            return new List<JobPost>();
        }
    }
}
