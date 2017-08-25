using System;
using Xunit;
using Kura.TJ.JobPostsLibrary;

namespace TJ.JobPostsLibrary.Test
{
    public class IJProviderTests
    {
        
        [Fact]
        
        public void GivenWhenEmptySearchCriteriaThenThrowException()
        {
            IndeedJobProvider provider = new Kura.TJ.JobPostsLibrary.IndeedJobProvider();
            bool errorThrown = false;

            try
            {
                var result = provider.ExtractJobs("");
            }
            catch (ArgumentNullException ex)
            {
                errorThrown = true;
            }
            Assert.Equal(errorThrown, true);
        }
        [Fact]
        public void GivenSearchCriteriaThenExtractJobs()
        {

        }
    }
}
