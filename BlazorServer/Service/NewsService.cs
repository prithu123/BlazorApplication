using BlazorServer.Data;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace BlazorServer.Service
{
    public class NewsService : INewsService
    {
        public readonly HttpClient httpClient;
        public NewsService(HttpClient httpClient) {
            this.httpClient = httpClient;
               
        }
        public async Task<IEnumerable<NewsItem>> GetNews()
        {
            return
                await httpClient
                .GetJsonAsync<NewsItem[]>
                ("DevTides/NewsApi/master/news.json");
        }
    }
}
