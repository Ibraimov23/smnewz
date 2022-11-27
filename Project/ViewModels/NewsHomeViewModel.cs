using Project.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Globalization;

namespace Project.ViewModels
{
    public class NewsHomeViewModel
    {
        public IEnumerable<News> News { get; set; }
        public IEnumerable<News> MainNewses { get; set; }
        public News MainNews { get; set; }
    }
}
