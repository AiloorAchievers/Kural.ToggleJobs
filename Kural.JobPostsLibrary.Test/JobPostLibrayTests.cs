using System;
using Xunit;
using Kural.JobPostsLibrary;
using Kural.Entities;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;

namespace Kural.JobPostsLibrary.Test
{
    public class JobPostLibrayTests
    {
        
        public JobPostLibrayTests()
        {
            
        }

        [Fact]
        public async void ShouldThrowErrorsWhenNoParametersPassed()
        {
           // IJobQueryBuilder jobQueryBuilder = new IndeedJobQueryBuilder();
            SearchParameters searchParameters = new SearchParameters();
            searchParameters.BaseUri = "test.org";
            var builder = new Moq.Mock<IJobQueryBuilder>();

            builder.Setup(x => x.BuildQuery(searchParameters)).Returns(@"http://api.indeed.com/ads/apisearch?publisher=5900889289818337&q=java&l=austin%2C+tx&v=2");

            bool errorThrown = false;

            try
            {
                //Add a comment
                var jobProvider = new IndeedJobProvider(builder.Object, searchParameters);
                var result = await jobProvider.ExtractJobs();

                Assert.True(result != null);
            }
            catch (ArgumentNullException ex)
            {
                errorThrown = true;
            }
            Assert.Equal(errorThrown, true);
        }
    }
}
