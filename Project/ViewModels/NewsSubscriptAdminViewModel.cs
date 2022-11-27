using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Project.Models;

namespace Project.ViewModels
{
    public class NewsSubscriptAdminViewModel
    {
        public IEnumerable<News> Newses { get; set; }
        public IEnumerable<Subscription> Subscriptions { get; set; }
    }
}
