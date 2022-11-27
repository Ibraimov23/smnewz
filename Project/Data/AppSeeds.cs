using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Project.Data;
using Project.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Project
{
    public class AppSeeds
    {
        public static async Task CreateDataAsync(IServiceProvider service)
        {
            UserManager<User> userManager = service.GetRequiredService<UserManager<User>>();

            string adminEmail = "admin@gmail.com";
            string login = "admin";
            User existingAdmin = await userManager.FindByEmailAsync(adminEmail);

            if (existingAdmin == null)
            {
                User user = new User
                {
                    Email = adminEmail,
                    UserName = login,
                };
                var result = await userManager.CreateAsync(user, "123456");
            }
            var context = service.GetRequiredService<ApplicationContext>();
            if (!context.Categories.Any())
            {
                context.Categories.Add(entity: new Category() { Name = "Technology", Color= "#137547",Emoji = "U+1f4bb" });
                context.Categories.Add(entity: new Category() { Name = "Entertainment",Color= "#DDA448", Emoji = "U+1F37F" });
                context.Categories.Add(entity: new Category() { Name = "Politics", Color= "#562C2C", Emoji = "U+2696" });
                context.SaveChanges();
            }
            /*if(!context.News.Any())
            {
                Category category = await context.Categories.FirstOrDefaultAsync(p => p.Name == "Politics");
                context.News.Add(entity: new News() { Header = "First News", Context = "Police in San Francisco, CA, can now watch private security camera feeds in real-time after the city board approved the measure, which the ACLU opposed.",
                   ImageLink= "https://d3e54v103j8qbb.cloudfront.net/img/background-image.svg",CategoryId = category.Id,CreatedAt = DateTime.Now  });
                context.SaveChanges();
            }*/

        }

    }
}
