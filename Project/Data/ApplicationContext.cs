using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Project.Models;

namespace Project.Data
{
    public class ApplicationContext : IdentityDbContext<User>
    {
        public DbSet<News> News { get; set; }
        public DbSet<Description> Descriptions { get; set; }
        public DbSet<BulletInfo> BulletInfos { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Subscription> Subscription { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
        }

    }
}
