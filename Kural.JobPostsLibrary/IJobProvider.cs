using Kural.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Kural.JobPostsLibrary
{
    public interface IJobProvider
    {
        Task<IEnumerable<JobPost>> ExtractJobs();
        //Now a branch for feature goes straight to main
    }
}
