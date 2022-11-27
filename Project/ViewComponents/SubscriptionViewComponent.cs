using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project.Data;
using Project.Models;
using Project.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.ViewComponents
{

    [ViewComponent(Name = "Subscription")]
    public class SubscriptionViewComponent : ViewComponent
    {
        private readonly ApplicationContext db;

        public SubscriptionViewComponent(ApplicationContext context) => db = context;

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var items = await GetItemsAsync();
            string date = items.MainNews.CreatedAt.ToLongDateString();
            ViewData["date"] = date.Substring(date.IndexOf(',') + 2);
            return View(items);
        }

        private async Task<NewsHomeViewModel> GetItemsAsync()
        {
            IQueryable <News> news = db.News.Include(p => p.Category).Include(p=> p.Descriptions);
            News last = await news.OrderBy(x => x.CreatedAt).LastOrDefaultAsync();
            NewsHomeViewModel viewModel = new NewsHomeViewModel();
            if (last != null){
                viewModel.MainNewses = await news.Where(p => p.CreatedAt.Date == last.CreatedAt.Date).OrderByDescending(x => x.CreatedAt).ToListAsync();
                viewModel.MainNews = last;}
            else{
                viewModel.MainNewses = new List<News>();
                viewModel.MainNews = new News();}
            return viewModel;
        }
    }
}