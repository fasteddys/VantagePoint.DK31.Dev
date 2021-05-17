using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Hosting;
using MimeKit;
using Serenity;
using Serenity.ComponentModel;
using System;
using System.IO;

namespace VantagePoint.Common
{
    [SettingScope("Application"), SettingKey("MailSettings")]
    public class MailSettings
    {
        public string Host { get; set; }
        public int Port { get; set; }
        public bool UseSsl { get; set; }
        public string From { get; set; }
    }

    public class EmailHelper
    {
        public static void Send(string subject, string body, string address, string displayName = "")
        {
            var message = new MimeMessage();
            var config = Config.Get<MailSettings>();
            if (!string.IsNullOrEmpty(config.From))
                message.From.Add(MailboxAddress.Parse(config.From));
            message.To.Add(new MailboxAddress(displayName, address));
            message.Subject = subject;
            var bodyBuilder = new BodyBuilder
            {
                HtmlBody = body
            };
            message.Body = bodyBuilder.ToMessageBody();

            if (!string.IsNullOrEmpty(config.Host))
            {
                var client = new SmtpClient();
                client.Connect(config.Host, config.Port, config.UseSsl);
                client.Send(message);
                client.Disconnect(true);
            }
            else
            {
                var pickupPath = Path.Combine(Dependency.Resolve<IWebHostEnvironment>().ContentRootPath, "App_Data");
                pickupPath = Path.Combine(pickupPath, "Mail");
                Directory.CreateDirectory(pickupPath);
                message.WriteTo(Path.Combine(pickupPath, DateTime.Now.ToString("yyyyMMdd_HHmmss_fff") + ".eml"));
            }
        }
    }
}