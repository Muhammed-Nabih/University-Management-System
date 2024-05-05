﻿
using MailKit.Net.Smtp;
using MimeKit;
using UniversityManagementSystem.Data.Helpers;
using UniversityManagementSystem.Service.Abstracts;
namespace UniversityManagementSystem.Service.Implementations
{
    public class EmailsService : IEmailsService
    {
        // Fields
        private readonly EmailSettings _emailSettings;
        /*******************************************************************************************/
        // Constructors
        public EmailsService(EmailSettings emailSettings)
        {
            _emailSettings = emailSettings;
        }

        /*******************************************************************************************/
        // Handle Functions
        public async Task<string> SendEmail(string email, string Message, string? reason)
        {
            try
            {
                //sending the Message of passwordResetLink
                using (var client = new SmtpClient())
                {
                    await client.ConnectAsync(_emailSettings.Host, _emailSettings.Port, true);
                    client.Authenticate(_emailSettings.FromEmail, _emailSettings.Password);
                    var bodybuilder = new BodyBuilder
                    {
                        HtmlBody = $"{Message}",
                        TextBody = "wellcome",
                    };
                    var message = new MimeMessage
                    {
                        Body = bodybuilder.ToMessageBody()
                    };
                    message.From.Add(new MailboxAddress("University System By : MOHAMED NABIH", _emailSettings.FromEmail));
                    message.To.Add(new MailboxAddress("testing", email));
                    message.Subject = reason == null ? "No Submitted" : reason;
                    await client.SendAsync(message);
                    await client.DisconnectAsync(true);
                }
                //end of sending email
                return "Success";
            }
            catch (Exception ex)
            {
                return "Failed";
            }
        }
        /*******************************************************************************************/
    }
}
