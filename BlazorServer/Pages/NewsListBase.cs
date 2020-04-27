using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorServer.Data;
using BlazorServer.Service;

namespace BlazorServer.Pages
{
    public class NewsListBase : ComponentBase
    {
        [Inject]
        public INewsService NewsService { get; set; }
        public IEnumerable<NewsItem> newsList { get; set; }

        protected override async Task OnInitializedAsync()
        {

            newsList=(await NewsService.GetNews()).ToList();
        }

        public async Task<IEnumerable<NewsItem>> NewsListGrid(System.Threading.CancellationToken cancellationToken = default) {
            return await Task.FromResult(newsList);
        }
        private void loadEmployee() {


            NewsItem n1 = new NewsItem
            {
                Author = "Rabi",
                 Title = "ABP",
                 Desription="Banglar 1 no news channel",
                Url = new System.Uri("https://www.nasa.gov/press-release/media-invited-to-artemis-day-unveiling-of-moon-mission-rocket-stage"),
                ImageUrl= new System.Uri("https://raw.githubusercontent.com/DevTides/NewsApi/master/img16.jpg"),
                PublishedAt="xxxxxx"




            };
            NewsItem n2 = new NewsItem
            {
                Author = "Rabi",
                Title = "ABP",
                Desription = "Banglar 1 no news channel",
                Url = new System.Uri("https://www.nasa.gov/press-release/media-invited-to-artemis-day-unveiling-of-moon-mission-rocket-stage"),
                ImageUrl = new System.Uri("https://raw.githubusercontent.com/DevTides/NewsApi/master/img16.jpg"),
                PublishedAt = "xxxxxx"





            };
            NewsItem n3 = new NewsItem
            {
                Author = "Rabi",
                Title = "ABP",
                Desription = "Banglar 1 no news channel",
                Url = new System.Uri("https://www.nasa.gov/press-release/media-invited-to-artemis-day-unveiling-of-moon-mission-rocket-stage"),
                ImageUrl = new System.Uri("https://raw.githubusercontent.com/DevTides/NewsApi/master/img16.jpg"),
                PublishedAt = "xxxxxx"




            };
            NewsItem n4 = new NewsItem
            {
                Author = "Rabi",
                Title = "ABP",
                Desription = "Banglar 1 no news channel",
                Url = new System.Uri("https://www.nasa.gov/press-release/media-invited-to-artemis-day-unveiling-of-moon-mission-rocket-stage"),
                ImageUrl = new System.Uri("https://raw.githubusercontent.com/DevTides/NewsApi/master/img16.jpg"),
                PublishedAt = "xxxxxx"




            };
            newsList = new List<NewsItem> { n1,n2,n3,n4};
        }
    }
}
