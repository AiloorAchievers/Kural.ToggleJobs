using System;
using Xunit;
using Kural.JobPostsLibrary;

namespace Kural.JobPostsLibrary.Test
{
    public class JobPostLibrayTests
    {
        [Fact]
        public void ShouldThrowErrorsWhenNoParametersPassed()
        {
            var provider = new IndeedJobProvider();
            bool errorThrown = false;

            try
            {
                //Add a comment
                var result = provider.ExtractJobs("");
            }
            catch (ArgumentNullException ex)
            {
                errorThrown = true;
            }
            Assert.Equal(errorThrown, true);
        }
    }
}
