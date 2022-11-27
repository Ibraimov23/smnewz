using MailKit;
using MailKit.Net.Imap;
using MailKit.Search;
using MailKit.Security;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MimeKit;
using MimeKit.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
//using System.Net.Mail;
using System.Threading.Tasks;

namespace Project.Workers
{
	public class EmailSender : IEmailSender
	{
		private readonly IServiceScopeFactory serviceScopeFactory;

		public EmailSender(IServiceScopeFactory serviceScopeFactory)
		{
			this.serviceScopeFactory = serviceScopeFactory;
		}
		public async Task SendEmailAsync(string to, string subject, string message)
		{
			var from = "vises39527@xitudy.com";
			var fromName = "AKIAQZKXCLHKAW2QJMOJ";
			var pass = "BASCDMYDOPNVjXs/ytVs59/ykpCNVurDasXz2HF7dGxa";
			var host = "email-smtp.eu-central-1.amazonaws.com";
			var port = 587;
			MimeMessage emailMessage = new MimeMessage();
			emailMessage.From.Add(new MailboxAddress("Bonsai", from));
			emailMessage.To.Add(new MailboxAddress("", to));
			emailMessage.Subject = subject;
			emailMessage.Body = new TextPart(MimeKit.Text.TextFormat.Html)
			{
				Text = message
			};
			using (var client = new MailKit.Net.Smtp.SmtpClient())
			{
				await client.ConnectAsync(host, Convert.ToInt32(port), false);
				await client.AuthenticateAsync(fromName, pass);
				await client.SendAsync(emailMessage);
				await client.DisconnectAsync(true);
			}	
		}
	}
}
