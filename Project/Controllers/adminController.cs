using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Project.Data;
using Project.Models;
using Project.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Controllers
{
    [Authorize]

    public class adminController : Controller
    {
        private readonly ApplicationContext _context;

        public adminController(ApplicationContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            NewsSubscriptAdminViewModel viewModel = new NewsSubscriptAdminViewModel
            {
                Newses = await _context.News.Include(p=> p.Category).ToListAsync(),
                Subscriptions = await _context.Subscription.ToListAsync()

            };
            return View(viewModel);
        }

        [HttpGet]
        [ActionName("news-description")]
        public async Task<IActionResult> Newsdesc(int newsId)
        {
            ViewData["newsId"] = newsId;
            var check = await _context.News.Include(p=> p.Descriptions).FirstOrDefaultAsync(p => p.Id == newsId);
            if (check != null) return View(check.Descriptions); else return NotFound();
        }

        [HttpGet]
        [ActionName("news-internal")]
        public async Task<IActionResult> Newsinternal(int descId)
        {
            ViewData["descId"] = descId;
            var check = await _context.Descriptions.Include(p => p.BulletInfo).FirstOrDefaultAsync(p => p.Id == descId);
            ViewData["newsId"] = check.NewsId;
            if (check != null) return View(check.BulletInfo); else return NotFound();
        }

        [HttpPost, ActionName("deletenews")]
        public async Task<IActionResult> DeleteConfirmed(int id,int child)
        {
            News news = await _context.News.FindAsync(id);
            _context.News.Remove(news);
            await _context.SaveChangesAsync();
            NewsSubscriptAdminViewModel viewModel = new NewsSubscriptAdminViewModel
            {
                Newses = await _context.News.Include(p => p.Category).ToListAsync(),
                Subscriptions = await _context.Subscription.ToListAsync()
            };
            return PartialView("index",viewModel);
        }
        [HttpPost, ActionName("delnewsdesc")]
        public async Task<IActionResult> DeleteDesc(int id,int child)
        {
            var desc = await _context.Descriptions.FindAsync(id);
            _context.Descriptions.Remove(desc);
            await _context.SaveChangesAsync();
            var items = await _context.News.Include(p=> p.Descriptions).FirstOrDefaultAsync(p => p.Id == child);
            return PartialView("news-description", items.Descriptions);
        }
        [HttpPost, ActionName("delnewsintern")]
        public async Task<IActionResult> DeleteIntern(int id, int child)
        {
            var intern = await _context.BulletInfos.FindAsync(id);
            _context.BulletInfos.Remove(intern);
            await _context.SaveChangesAsync();
            var items = await _context.Descriptions.Include(p=> p.BulletInfo).FirstOrDefaultAsync(p => p.Id == child);
            return PartialView("news-internal", items.BulletInfo);
        }
        [HttpPost, ActionName("deletesubscript")]
        public async Task<IActionResult> DeleteSub(int id, int child)
        {
            var subscription = await _context.Subscription.FindAsync(id);
            _context.Subscription.Remove(subscription);
            await _context.SaveChangesAsync();
            NewsSubscriptAdminViewModel viewModel = new NewsSubscriptAdminViewModel
            {
                Newses = await _context.News.Include(p => p.Category).ToListAsync(),
                Subscriptions = await _context.Subscription.ToListAsync()

            };
            return PartialView("index", viewModel);
        }
    }
}
