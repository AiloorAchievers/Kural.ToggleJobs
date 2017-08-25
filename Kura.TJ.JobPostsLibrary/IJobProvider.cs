using System;
using System.Collections.Generic;
using TJ.Entities;

namespace Kura.TJ.JobPostsLibrary
{
    public interface IJobProvider
    {
        IEnumerable<JobPost> ExtractJobs(string keyword);
    }
}
