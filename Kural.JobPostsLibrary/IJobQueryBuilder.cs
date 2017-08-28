using System;
using System.Collections.Generic;
using System.Text;
using Kural.Entities;
namespace Kural.JobPostsLibrary
{
    public interface IJobQueryBuilder
    {
        string BuildQuery(SearchParameters searchParams);
    }
}
