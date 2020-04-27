using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServer.Data
{
    public class NewsItem
    {
        
        public string Author { get; set; }

        public string Title { get; set; }

        public string Desription { get; set; }

        public Uri ImageUrl { get; set; }

        public Uri Url { get; set; }

        public string PublishedAt { get; set; }

       
    }
}
