using System;
using System.Collections.Generic;
using System.Text;
using Kural.Entities;

namespace Kural.JobPostsLibrary
{
    public class IndeedJobQueryBuilder: IJobQueryBuilder
    {
        
        public IndeedJobQueryBuilder()
        {
        }
        public string BuildQuery(SearchParameters searchParameters)
        {
            //TODO:Convert to fluent API
            StringBuilder queryBuilder = new StringBuilder();
            queryBuilder.Append(searchParameters.BaseUri);
            if (searchParameters.BaseUri.IndexOf("?") <= 0)
                queryBuilder.Append("?");

            queryBuilder.Append("publisher=" + searchParameters.PublisherId +"&");
            queryBuilder.Append("q=" + searchParameters.Keyword + "&");
            queryBuilder.Append("apiVersion=" + searchParameters.ApiVersion + "&");
            queryBuilder.Append("noOfResults=" + searchParameters.NoOfResults);

            return queryBuilder.ToString();

        }
    }
}
