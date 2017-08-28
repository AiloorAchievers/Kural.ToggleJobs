using System;
using System.Collections.Generic;
using System.Text;

namespace Kural.Entities
{
    public class SearchParameters
    {
        public string BaseUri { get; set; }

        public string PublisherId { get; set; }

        public string Keyword { get; set; }

        public string ApiVersion { get; set; }

        public string Country { get; set; }

        public string State { get; set; }

        public int NoOfResults { get; set; }
    }
}
