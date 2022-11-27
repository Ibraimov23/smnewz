using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Project.Data;
using Project.Models;

namespace Project.Controllers
{
    public class subscriptionController : Controller
    {
        private readonly ApplicationContext _context;
        private readonly IServiceScopeFactory serviceScopeFactory;

        public subscriptionController(ApplicationContext context, IServiceScopeFactory serviceScopeFactory)
        {
            _context = context;
            this.serviceScopeFactory = serviceScopeFactory;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Subscription.ToListAsync());
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(string value)
        {
            Subscription subscription = new Subscription() { Email = value };
            if (ModelState.IsValid)
            {
                _context.Add(subscription);
                await _context.SaveChangesAsync();
                return Redirect("/sign-up");
            }
            return View(subscription);
        }


        private bool CategoryExists(int id)
        {
            return _context.Subscription.Any(e => e.Id == id);
        }
    }
}
