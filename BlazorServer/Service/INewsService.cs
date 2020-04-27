using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorServer.Data;

namespace BlazorServer.Service
{
   public  interface INewsService
    {
        Task<IEnumerable<NewsItem>> GetNews();
    }
}
