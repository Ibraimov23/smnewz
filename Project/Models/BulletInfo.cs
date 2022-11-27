using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Models
{
    public class BulletInfo
    {
        public int Id { get; set; }
        [Required]
        public string Slot { get; set; }
        public int DescriptionId { get; set; }
        public Description Description { get; set; }
    }
}
