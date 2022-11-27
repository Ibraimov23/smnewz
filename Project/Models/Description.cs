using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Models
{
    public class Description
    {
        public int Id { get; set; }
        [Required]
        public string Header { get; set; }
        [Required]
        public string Link { get; set; }
        public int NewsId { get; set; }
        public News News { get; set; }
        public ICollection<BulletInfo> BulletInfo { get; set; }
    }
}
