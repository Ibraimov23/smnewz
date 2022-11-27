using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Project.Data;
using Project.Models;
using Project.ViewModels;

namespace Project.Controllers
{
    [Authorize]
    public class newsController : Controller
    {
        private readonly ApplicationContext _context;

        public newsController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewData["Categories"] = new SelectList(_context.Categories, "Id", "Name");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Header,Context,ImageLink,CategoryId,CreatedAt")] News news)
        {
            if (ModelState.IsValid)
            {
                _context.Add(news);
                await _context.SaveChangesAsync();
                return RedirectToAction("index", "admin");
            }
            ViewData["Categories"] = new SelectList(_context.Categories, "Id", "Name", news.CategoryId);
            return RedirectToAction("index", "admin");
        }
        [HttpGet]
        [ActionName("create-desc")]
        public IActionResult CreateDesc(int newsId)
        {
            var check = _context.News.FirstOrDefaultAsync(p => p.Id == newsId);
            ViewData["newsId"] = newsId;
            if (check != null) return View(); else return NotFound();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateDesc([Bind("Id,Header,Link")] Description desc, int newsId)
        {
            if (ModelState.IsValid)
            {
                desc.NewsId = newsId;
                _context.Add(desc);
                await _context.SaveChangesAsync();
                return RedirectToAction("news-description", "admin", new { newsId = newsId });
            }
            return RedirectToAction("news-description", "admin", new { newsId = newsId });
        }
        [HttpGet]
        [ActionName("create-intern")]
        public IActionResult CreateIntern(int descId)
        {
            var check = _context.Descriptions.FirstOrDefaultAsync(p => p.Id == descId);
            ViewData["descId"] = descId;
            if (check != null) return View(); else return NotFound();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateIntern([Bind("Id,Slot")] BulletInfo bulletInfo,int descId)
        {
            if (ModelState.IsValid)
            {
                bulletInfo.DescriptionId = descId;
                _context.Add(bulletInfo);
                await _context.SaveChangesAsync();
                return RedirectToAction("news-internal", "admin", new { descId = descId });
            }
            return RedirectToAction("news-internal", "admin", new { descId = descId });
        }
        private bool NewsExists(int id)
        {
            return _context.News.Any(e => e.Id == id);
        }
    }
}
