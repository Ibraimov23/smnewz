using MailKit.Net.Smtp;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Services
{
    public class EmailService
    {
        private readonly IServiceScopeFactory serviceScopeFactory;

        public EmailService(IServiceScopeFactory serviceScopeFactory)
        {
            this.serviceScopeFactory = serviceScopeFactory;
        }
        public async Task SendEmailAsync(string email, string subject, string message)
        {
            var emailMessage = new MimeMessage();
            var scope = serviceScopeFactory.CreateScope();
            var _configuration = scope.ServiceProvider.GetService<IConfiguration>();
            var pass = "smtp123456";
            var from = "news@gmail.com";
            var gateway = "smtp.wnpop.com";
            var port = 44349;
            emailMessage.From.Add(new MailboxAddress("News", from));
            emailMessage.To.Add(new MailboxAddress("", email));
            emailMessage.Subject = subject;
            emailMessage.Body = new TextPart(MimeKit.Text.TextFormat.Html)
            {
                Text = message
            };

            using (var client = new SmtpClient())
            {
                await client.ConnectAsync(gateway, Convert.ToInt32(port), false);
                await client.AuthenticateAsync(from, pass);
                await client.SendAsync(emailMessage);
                await client.DisconnectAsync(true);
            }
        }
    }
}
