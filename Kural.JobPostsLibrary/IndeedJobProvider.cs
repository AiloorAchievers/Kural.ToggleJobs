using Kural.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kural.JobPostsLibrary
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
