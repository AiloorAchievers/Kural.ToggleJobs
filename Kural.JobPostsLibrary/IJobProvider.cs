using Kural.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kural.JobPostsLibrary
{
    public interface IJobProvider
    {
        IEnumerable<JobPost> ExtractJobs(string keyword);
    }
}
