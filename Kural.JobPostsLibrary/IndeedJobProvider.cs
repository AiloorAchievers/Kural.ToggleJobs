using Kural.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;

namespace Kural.JobPostsLibrary
{
    public class IndeedJobProvider : IJobProvider
    {
        public IJobQueryBuilder _jobQueryBuilder;
        public SearchParameters _searchParameters;
        public IndeedJobProvider(IJobQueryBuilder jobQueryBuilder, SearchParameters searchParameters)
        {
            _jobQueryBuilder = jobQueryBuilder;
            _searchParameters = searchParameters;
        }
        public async Task<IEnumerable<JobPost>> ExtractJobs()
        {
            var actualQuery = _jobQueryBuilder.BuildQuery(_searchParameters);

            if (string.IsNullOrEmpty(actualQuery))
                throw new ArgumentNullException("Search input cannot be empty");

            using (HttpClient indeedApiClient = new HttpClient())
            {
                //indeedApiClient.BaseAddress = new Uri(actualQuery);
                var response = await indeedApiClient.GetAsync(actualQuery);
                response.EnsureSuccessStatusCode();
                var stringResult = await response.Content.ReadAsStringAsync();


            }

            return new List<JobPost>();
        }


      }
}
