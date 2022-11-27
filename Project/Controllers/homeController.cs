using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Project.Data;
using Project.Models;
using Project.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Project.Controllers
{
    public class homeController : Controller
    {
        private readonly ILogger<homeController> _logger;
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly ApplicationContext _applicationContext;

        public homeController(ILogger<homeController> logger, UserManager<User> userManager, SignInManager<User> signInManager, ApplicationContext applicationContext)
        {
            _logger = logger;
            _userManager = userManager;
            _signInManager = signInManager;
            _applicationContext = applicationContext;
        }

        public async Task<IActionResult> Index(string category)
        {
            IQueryable<News> news = _applicationContext.News.Include(p => p.Category).Include(p => p.Descriptions);

            NewsHomeViewModel newsHomeViewModel = new NewsHomeViewModel()
            {
                MainNewses = await news.Where(p => p.CreatedAt.Month <= DateTime.Now.Month && p.Descriptions.Count > 0).Take(5)
                .OrderByDescending(x => x.CreatedAt).ToListAsync(),
                MainNews = await news.OrderBy(x => x.CreatedAt).LastOrDefaultAsync(),
                News = await news.Where(p => p.CreatedAt.Month == DateTime.Now.Month).ToListAsync()
            };
            newsHomeViewModel.News = category != null ? news.Where(p => p.Category.Name == category) :
            await news.OrderByDescending(x => x.CreatedAt).ToListAsync();
            ViewData["category"] = "The latest";

            return View(newsHomeViewModel);
        }

        [HttpGet]
        [Route("/categories")]
        public async Task<IActionResult> Categories(string category)
        {
            IQueryable<News> news = _applicationContext.News.Include(p => p.Category).Include(p => p.Descriptions)
            .Where(p => p.Category.Name == category);
            NewsHomeViewModel newsHomeViewModel = new NewsHomeViewModel()
            {
                MainNewses = await news.Where(p => p.CreatedAt.Month <= DateTime.Now.Month && p.Descriptions.Count > 0).Take(5)
                 .OrderByDescending(x => x.CreatedAt).ToListAsync(),
                MainNews = await news.OrderBy(x => x.CreatedAt).LastOrDefaultAsync(),
                News = await news.Where(p => p.CreatedAt.Month == DateTime.Now.Month)
                .OrderByDescending(x => x.CreatedAt).ToListAsync()
            };
            return View(newsHomeViewModel);
        }

        [HttpGet]
        [Route("/details")]
        public async Task<IActionResult> Details(int id)
        {
            IQueryable<News> news = _applicationContext.News.Include(p => p.Category).Include(p => p.Descriptions)
                .ThenInclude(p => p.BulletInfo);
            News newsId = await news.FirstOrDefaultAsync(p => p.Id == id);
            news = news.Where(p => p.Category.Name == newsId.Category.Name);
            NewsHomeViewModel newsHomeViewModel = new NewsHomeViewModel()
            {
                MainNews = newsId,
                News = await news.Where(p => p.CreatedAt.Month == DateTime.Now.Month)
                .OrderByDescending(x => x.CreatedAt).ToListAsync()
            };
            ViewData["category"] = newsHomeViewModel.MainNews.Category.Name;
            ViewData["categColor"] = newsHomeViewModel.MainNews.Category.Color;
            return View(newsHomeViewModel);
        }

        [Route("/archive")]
        public async Task<IActionResult> Archive(string search)
        {
            IQueryable<News> news = _applicationContext.News.Include(p => p.Category);
            if (!String.IsNullOrEmpty(search) && search.Length > 2)
                return PartialView(news.Where(u =>u.Header.Contains(search)));
            news = news.Where(p => p.CreatedAt.Month == DateTime.Now.Month).OrderByDescending(p => p.CreatedAt);
            return View(await news.ToListAsync());
        }

        [Route("/sign-up")]
        public async Task<IActionResult> Signup()
        {
            IQueryable<News> news = _applicationContext.News
                .Include(p => p.Category).Include(p => p.Descriptions);
            News last = await news.OrderBy(x => x.CreatedAt).LastOrDefaultAsync();

            NewsHomeViewModel viewModel = new NewsHomeViewModel()
            {
                MainNews = last,
                MainNewses = await news.OrderByDescending(x => x.CreatedAt).Where(p => p.CreatedAt.Date == last.CreatedAt.Date).ToListAsync()
            };
            string date = last.CreatedAt.ToLongDateString();
            ViewData["date"] = date.Substring(date.IndexOf(',') + 2);

            return View(viewModel);
        }

        [Route("/days")]
        public async Task<IActionResult> Days(string datetime)
        {
            IQueryable<News> news = _applicationContext.News
                .Include(p => p.Category).Include(p => p.Descriptions).Where(p => p.CreatedAt.Date == DateTime.Parse(datetime));
            
            News last = await news.OrderBy(x => x.CreatedAt).LastOrDefaultAsync();
            NewsHomeViewModel viewModel = new NewsHomeViewModel()
            {
                MainNews = last,
                MainNewses = await news.OrderByDescending(x => x.CreatedAt).ToListAsync()
            };
            string date = last.CreatedAt.ToLongDateString();
            ViewData["date"] = date.Substring(date.IndexOf(',') + 2);

            return View(viewModel);
        }

        [HttpGet]
        [Route("/login")]
        public IActionResult Login(string returnUrl = null)
        {
            return View(new LoginViewModel { ReturnUrl = returnUrl });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("/login")]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                User user = await _applicationContext.Users.FirstOrDefaultAsync(p => p.UserName == model.UserName);
                if (user == null)
                {
                    return View(model);
                }

                Microsoft.AspNetCore.Identity.SignInResult result =
                await _signInManager.PasswordSignInAsync(user,
                model.Password, model.RememberMe, false);
                if (result.Succeeded)
                {
                    if (!string.IsNullOrEmpty(model.ReturnUrl) && Url.IsLocalUrl(model.ReturnUrl))
                    {
                        return Redirect(model.ReturnUrl);
                    }
                    else
                    {
                        return RedirectToAction("Index", "Admin");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Неправильный логин и (или) пароль");
                }
            }
            return View(model);
        }


        [HttpGet]
        [Route("/out")]
        public async Task<IActionResult> LogOff()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("index", "home");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
