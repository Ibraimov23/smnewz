using Project.Models;
using Project.Workers;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Project.Data;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace Project.Quartz
{
    public class DataJob : IJob
    {
        private readonly ApplicationContext _context;
        private readonly IServiceScopeFactory _serviceScopeFactory;
        private readonly ILogger<Startup> _logger;

        public DataJob(IServiceScopeFactory serviceScopeFactory, ApplicationContext context, ILogger<Startup> logger)
        {
            _serviceScopeFactory = serviceScopeFactory;
            _context = context;
            _logger = logger;
        }

        public async Task Execute(IJobExecutionContext context)
        {
            List<Subscription> subscriptions = new List<Subscription>();
            IQueryable<News> newses = null;
            string newshtml = null;
            string sait = "https://u1803403.plsk.regruhosting.ru";
            DateTime? date = DateTime.Now.Date;

            using (var scope = _serviceScopeFactory.CreateScope())
            {
                try
                {
                    IEmailSender emailsender = scope.ServiceProvider.GetService<IEmailSender>();
                    ApplicationContext Appcontext = scope.ServiceProvider.GetService<ApplicationContext>();
                    subscriptions = Appcontext.Subscription.ToList();
                    newses = Appcontext.News.Include(p => p.Category).Include(p => p.Descriptions)
                    .Where(p => p.CreatedAt.Date == date);
                    if (subscriptions.Count > 0 && newses.Count() > 0)
                    {
                        foreach (News news in newses.ToList())
                        {
                            if (news.Descriptions.Count > 0)
                            {
                                newshtml += $"<table align='center' width='100%' border='0' cellpadding='0' cellspacing='0' role='presentation' style='background-size:auto'><tbody><tr><td><table class='m_-3814638262255129232row-content m_-3814638262255129232stack' align='center' border='0' cellpadding='0' cellspacing='0' role='presentation' style='background-color:#fff;background-size:auto;color:#000;width:650px' width='650'><tbody><tr><td class='m_-3814638262255129232column' width='100%' style='font-weight:400;text-align:left;border-bottom:0px solid #fff;border-left:0 solid #e6e6e6;border-right:0 solid #e6e6e6;border-top:0 solid #f5f5f5;padding-left:15px;padding-right:15px;vertical-align:top;padding-top:20px;padding-bottom:30px;'><table width='100%' border='0' cellpadding='0' cellspacing='0' role='presentation' style='word-break:break-word'><tbody><tr><td style='padding-bottom:5px'><div style='font-family:Arial,sans-serif'><div style='font-size:14px;font-family:'Helvetica Neue',Helvetica,Arial,sans-serif;color:#000;line-height:1.2'><p style='margin:0;font-size:14px'> " +
                  /*news emoji*/$"<strong><span style='font-size:17px;'><span style='margin-right: 5px;'><span><span>{char.ConvertFromUtf32(int.Parse(news.Category.Emoji.Substring(2), System.Globalization.NumberStyles.HexNumber)) }</span></span></span>" +
                 /*news header*/$"<span><span><span>{news.Header}</span></span></span></span></strong></p></div></div></td></tr></tbody></table><table width='100%' border='0' cellpadding='0' cellspacing='0' role='presentation' style='word-break:break-word'><tbody><tr><td><div style='font-family:Arial,sans-serif'><div style='font-size: 12px;color: #555;line-height: 1.5;'><p style='margin:0;font-size:16px;'> " +
                   /*news desc*/$"<span style='font-size:16px;color:#000000;'>{news.Context}</span><span style='font-size:16px;color:#2b59d6'><a href='https://e.customeriomail.com/e/c/eyJlbWFpbF9pZCI6IlJNN2lCZ0lBQVlOdEFzOFAzcmwtMzY0WjNPanJJQT09IiwiaHJlZiI6Imh0dHBzOi8vd3d3LmJvbnNhaW5ld3MuY29tL2NvbnRlbnQvZG93LWRyb3BzLWFnYWluIiwiaW50ZXJuYWwiOiJjZWUyMDYwMTkyNzBjM2RhMDIiLCJsaW5rX2lkIjoxOTN9/e0ebffbbe9a8a04c979b92b441547b1ba5f510958433fa19fb851cf217902663' style='text-decoration:none;color:#2b59d6' rel='noopener' target='_blank' data-saferedirecturl='https://www.google.com/url?q=https://e.customeriomail.com/e/c/eyJlbWFpbF9pZCI6IlJNN2lCZ0lBQVlOdEFzOFAzcmwtMzY0WjNPanJJQT09IiwiaHJlZiI6Imh0dHBzOi8vd3d3LmJvbnNhaW5ld3MuY29tL2NvbnRlbnQvZG93LWRyb3BzLWFnYWluIiwiaW50ZXJuYWwiOiJjZWUyMDYwMTkyNzBjM2RhMDIiLCJsaW5rX2lkIjoxOTN9/e0ebffbbe9a8a04c979b92b441547b1ba5f510958433fa19fb851cf217902663&amp;source=gmail&amp;ust=1664443581682000&amp;usg=AOvVaw3xmQsjbkcsVfkFEH5kBlRo'><strong></strong></a></span></p>" +
                                $"<p style='margin: 0; font-size:12px'><span style='color:#2b59d6;font-size:16px'><a href='https://{sait}/details?id={news.Id}' style='text-decoration:none;color:#2b59d6' rel='noopener' target='_blank' data-saferedirecturl='https://www.google.com/url?q=https://e.customeriomail.com/e/c/eyJlbWFpbF9pZCI6IlJNN2lCZ0lBQVlObjNJVEZuTk5jclVkeTFIYXJQdz09IiwiaHJlZiI6Imh0dHBzOi8vd3d3LmJvbnNhaW5ld3MuY29tL2NvbnRlbnQvc2Vjb25kLWFjdC1vZi1zYW5keS1ob29rLXRyaWFsIiwiaW50ZXJuYWwiOiJjZWUyMDYwMTkyNzBjM2RhMDIiLCJsaW5rX2lkIjoxOTN9/d778670345450588c11a87352e8506180c9c97c722bac483a6db4b8089077a71&amp;source=gmail&amp;ust=1664468581049000&amp;usg=AOvVaw0_ImTmrTXhIp-2mwphW9de'><strong>Go deeper →</strong></a></span></p></div></div></td></tr></tbody></table></td></tr></tbody></table></td></tr></tbody></table> ";
                            }
                            else
                            {
                                newshtml += $"<table align='center' width='100%' border='0' cellpadding='0' cellspacing='0' role='presentation' style='background-size:auto'><tbody><tr><td><table class='m_-3814638262255129232row-content m_-3814638262255129232stack' align='center' border='0' cellpadding='0' cellspacing='0' role='presentation' style='background-color:#fff;background-size:auto;color:#000;width:650px' width='650'><tbody><tr><td class='m_-3814638262255129232column' width='100%' style='font-weight:400;text-align:left;border-bottom:0px solid #fff;border-left:0 solid #e6e6e6;border-right:0 solid #e6e6e6;border-top:0 solid #f5f5f5;padding-left:15px;padding-right:15px;vertical-align:top;padding-top:20px;padding-bottom:30px;'><table width='100%' border='0' cellpadding='0' cellspacing='0' role='presentation' style='word-break:break-word'><tbody><tr><td style='padding-bottom:5px'><div style='font-family:Arial,sans-serif'><div style='font-size:14px;font-family:'Helvetica Neue',Helvetica,Arial,sans-serif;color:#000;line-height:1.2'><p style='margin:0;font-size:14px'> " +
                  /*news emoji*/$"<strong><span style='font-size:17px;'><span style='margin-right: 5px;'><span><span>{char.ConvertFromUtf32(int.Parse(news.Category.Emoji.Substring(2), System.Globalization.NumberStyles.HexNumber)) }</span></span></span>" +
                 /*news header*/$"<span><span><span>{news.Header}</span></span></span></span></strong></p></div></div></td></tr></tbody></table><table width='100%' border='0' cellpadding='0' cellspacing='0' role='presentation' style='word-break:break-word'><tbody><tr><td><div style='font-family:Arial,sans-serif'><div style='font-size: 12px;color: #555;line-height: 1.5;'><p style='margin:0;font-size:16px;'> " +
                   /*news desc*/$"<span style='font-size:16px;color:#000000'>{news.Context}</span><span style='font-size:16px;color:#2b59d6'><a href= 'https://e.customeriomail.com/e/c/eyJlbWFpbF9pZCI6IlJNN2lCZ0lBQVlOdEFzOFAzcmwtMzY0WjNPanJJQT09IiwiaHJlZiI6Imh0dHBzOi8vd3d3LmJvbnNhaW5ld3MuY29tL2NvbnRlbnQvZG93LWRyb3BzLWFnYWluIiwiaW50ZXJuYWwiOiJjZWUyMDYwMTkyNzBjM2RhMDIiLCJsaW5rX2lkIjoxOTN9/e0ebffbbe9a8a04c979b92b441547b1ba5f510958433fa19fb851cf217902663' style='text-decoration:none;color:#2b59d6' rel='noopener' target= '_blank' data-saferedirecturl='https://www.google.com/url?q=https://e.customeriomail.com/e/c/eyJlbWFpbF9pZCI6IlJNN2lCZ0lBQVlOdEFzOFAzcmwtMzY0WjNPanJJQT09IiwiaHJlZiI6Imh0dHBzOi8vd3d3LmJvbnNhaW5ld3MuY29tL2NvbnRlbnQvZG93LWRyb3BzLWFnYWluIiwiaW50ZXJuYWwiOiJjZWUyMDYwMTkyNzBjM2RhMDIiLCJsaW5rX2lkIjoxOTN9/e0ebffbbe9a8a04c979b92b441547b1ba5f510958433fa19fb851cf217902663&amp;source=gmail&amp;ust=1664443581682000&amp;usg=AOvVaw3xmQsjbkcsVfkFEH5kBlRo'><strong></strong></a></span></p></div></div></td></tr></tbody></table></td></tr></tbody></table></td></tr></tbody></table> ";
                            }
                        }
                        foreach (var c in subscriptions)
                        {
                            await emailsender.SendEmailAsync(
                                 $"{c.Email}",
                                 "Elijah McClain autopsy released, Celtics kick out Udoka, and Biden promises to protect Roe",
                                 $"<u></u><div style='margin: 0;padding: 0;background-color: #fff;'> " +
                                 $"<table width='100%' border='0' cellpadding='0' cellspacing='0' role='presentation' style='background-color:#fff;'>" +
                                 $"<tbody><tr><td>" +
                                 $"<table align='center' width='100%' border='0' cellpadding='0' cellspacing='0' role='presentation'>" +
                                 $"<tbody><tr><td><table class='m_458555208411688549row-content m_458555208411688549stack' align='center' border='0' cellpadding='0' cellspacing='0' role='presentation' style='color:#000;width:650px;' width='650'><tbody><tr><td class='m_458555208411688549column' width='100%' style='font-weight:400;text-align:left;vertical-align:top;padding-top:0;padding-bottom:0;border-top:0;border-right:0;border-bottom:0;border-left:0;'>" +
                                 $"<div style='height:0;line-height:0;font-size:1px;'></div> " +
                                 $"</td></tr></tbody></table></td></tr></tbody></table> " +
                                 $"<table align='center' width='100%' border='0' cellpadding='0' cellspacing='0' role='presentation' style='background-size:auto'>" +
                                 $"<tbody><tr><td><table class='m_458555208411688549row-content m_458555208411688549stack' align='center' border='0' cellpadding='0' cellspacing='0' role='presentation' style='background-size:auto;background-color:#fff;border-bottom:0 solid #2b59d6;border-left:0 solid #2b59d6;border-radius:0;border-right:0 solid #2b59d6;border-top:0 solid #2b59d6;color:#000;width:650px' width='650'>" +
                                 $"<tbody><tr><td class='m_458555208411688549column' width='100%' style='font-weight:400;text-align:left;border-bottom:0 solid #e6e6e6;border-left:0 solid #e6e6e6;border-right:0 solid #e6e6e6;border-top:0 solid #f5f5f5;padding-left:15px;padding-right:15px;vertical-align:top;padding-top:30px;padding-bottom:30px'>" +
                        /*table*/$"<table class='m_458555208411688549image_block' width='100%' style='margin:auto;' border='0' cellpadding='0' cellspacing='0' role='presentation'><tbody><tr>" +
                           /*td*/$"<td style='padding-bottom:10px;width:100%;padding-right:0;padding-left:0;'><div align='center' style='line-height:10px;'><a href='https://{sait}/days?datetime={date}' style='outline:none;' target='_blank' data-saferedirecturl='https://www.google.com/url?q=https://e.customeriomail.com/e/c/eyJlbWFpbF9pZCI6IlJNN2lCZ0lBQVlOdEFzOFAzcmwtMzY0WjNPanJJQT09IiwiaHJlZiI6Imh0dHBzOi8vd3d3LmJvbnNhaW5ld3MuY29tL2RheXMvMjAyMi0wOS0yMyIsImludGVybmFsIjoiY2VlMjA2MDE5MjcwYzNkYTAyIiwibGlua19pZCI6MTkyfQ/a7f88b39da9812c03ba311ee1c76ef3c99b3933726193383d6edf5cbb9afcda3&amp;source=gmail&amp;ust=1664358379016000&amp;usg=AOvVaw2zFFFveto1OsSrgM4rsXR-'>" +
                  /*bonsai logo*/$"<img src='https://ci3.googleusercontent.com/proxy/-zqfTPC5i_FNW5V2BhGQfpqC6MjDEoETAnN6a-vgOi0yaWMjA1QNhAGKIvr3IUKdARU_zgwqSKbA67T-QQKdwZQNAfDhYWcmXwU4yAwH1jNGzVcUjGWnb0HOTMwpCixl5bxKZ1DG9-dC9uLMi3j3bHFqYcfBehTN0MQ=s0-d-e1-ft#https://userimg-bee.customeriomail.com/images/client-env-110926/Bonsai%20Google%20News%20Rec%20Dark.png' style='display:block;height:auto;border:0;width:124px;max-width:100%;' class='CToWUd' data-bit='iit'></a></div></td></tr></tbody>" +
                        /*table*/$"</table><table width='100%' style='margin:auto;' border='0' cellpadding='0' cellspacing='0' role='presentation'><tbody><tr><td style='padding-bottom:20px;padding-left:20px;padding-right:20px;text-align:center;width:100%'><h3 style='margin:0;color:#000;direction:ltr;font-family:Tahoma,Verdana,Segoe,sans-serif;font-size:16px;font-weight:400;letter-spacing:normal;line-height:120%;text-align:center;margin-top:0;margin-bottom:0'> " +
                  /*bonsai desc*/$"<span>Today’s trending stories distilled into one-minute bites</span></h3></td></tr></tbody></table>" +
                        /*table*/$"<table width='100%' style='margin:auto;' border='0' cellpaddin='0' cellspacing='0' role='presentation'><tbody><tr><td style='padding-bottom:10px;padding-left:20px;padding-right:20px;text-align:center;width:100%;'><h2 style='margin:0;color:#000;font-size:22px;font-weight:400;letter-spacing:normal;line-height:120%;text-align:center;margin-top:0;margin-bottom:0;'> " +
                 /*bonsai desc2*/$"<strong>The special master wants more from Trump's team, Trombone Champion takes over Twitter, and drama follows the Celtics coach</strong></h2></td></tr></tbody></table>" +
                        /*table*/$"<table width='100%' style='margin:auto;' border='0' cellpadding='0' cellspacing ='0' role='presentation' style='word-break:break-word'><tbody><tr>" +
                                 $"<td><div style='font-family:Arial,sans-serif'><div style='font-size:14px;font-family:Helvetica,Arial,sans-serif;color:#555;line-height:1.2;'><p style='margin:0;font-size:14px;text-align:center;'> " +
                  /*bonsai data*/$"<span style='color:#000000;'>{date}</span></p></div></div></td></tr></tbody></table>" +
                        /*table*/$"<table width='100%' style='margin:auto;' border='0' cellpadding='0' cellspacing='0' role='presentation' style='word-break:break-word'><tbody><tr>" +
                                 $"<td style='padding-left:20px;padding-right:20px;padding-top:5px;'><div style='font-family:sans-serif'><div style='font-size:14px;color:#555;line-height:1.2;font-family:Tahoma,Verdana,Segoe,sans-serif'><p style='margin:0;font-size:14px;text-align:center'> " +
                                 $"<a href='https://{sait}/days?datetime={date}' style='text-decoration:none;color:#2b59d6;' rel='noopener' target='_blank' data-saferedirecturl='https://www.google.com/url?q=https://e.customeriomail.com/e/c/eyJlbWFpbF9pZCI6IlJNN2lCZ0lBQVlOdEFzOFAzcmwtMzY0WjNPanJJQT09IiwiaHJlZiI6Imh0dHBzOi8vd3d3LmJvbnNhaW5ld3MuY29tL2RheXMvMjAyMi0wOS0yMyIsImludGVybmFsIjoiY2VlMjA2MDE5MjcwYzNkYTAyIiwibGlua19pZCI6MTkyfQ/a7f88b39da9812c03ba311ee1c76ef3c99b3933726193383d6edf5cbb9afcda3&amp;source=gmail&amp;ust=1664358379016000&amp;usg=AOvVaw2zFFFveto1OsSrgM4rsXR-'>" +
                  /*bonsai view*/$"<span style='color:#8d8b8b'>View in browser</span></a></p></div></div></td></tr></tbody></table></td></tr></tbody></table></td></tr></tbody></table> " +
                                 /*новости*/
                                 newshtml
                                );
                        }
                    }
                }
                catch (Exception ex)
                {
                    _logger.LogInformation(ex.ToString());
                }                   
            }
        }
    }
}
