using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Project.Models
{
    public class News
    {
        public int Id { get; set; }
        [Required]
        public string Header { get; set; }

        [Required]
        [StringLength(455, MinimumLength = 80, ErrorMessage = "Длина строки должна быть от 80 символов")]
        public string Context { get; set; }
        public string ImageLink { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public ICollection<Description> Descriptions { get; set; }
        public DateTime CreatedAt { get; set; }

        public News()
        {
            this.CreatedAt = DateTime.Now;
        }
    }

}
