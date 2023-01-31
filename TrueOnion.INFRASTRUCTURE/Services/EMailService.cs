using MailKit.Net.Smtp;
using Microsoft.Extensions.Options;
using MimeKit;
using TrueOnion.APPLICATION.DTOs;
using TrueOnion.APPLICATION.Services;
using TrueOnion.APPLICATION.Settings;

namespace TrueOnion.INFRASTRUCTURE.OUTER.Services
{
    public class EMailService : IEMailService
    {
        private MailSetting _mailSetting { get; }

        public EMailService(IOptions<MailSetting> mailSetting)
        {
            _mailSetting = mailSetting.Value;
        }

        public async Task SendAsync(EMailDTO req)
        {
            MimeMessage email = new();
            email.Sender = MailboxAddress.Parse($"{_mailSetting.DisplayName} < {_mailSetting.EmailFrom}>");
            email.To.Add(MailboxAddress.Parse(req.To));
            email.Subject = req.Subject;
            BodyBuilder builder = new();
            builder.HtmlBody = req.Body;
            email.Body = builder.ToMessageBody();

            using SmtpClient smtp = new();
            smtp.ServerCertificateValidationCallback = (s, c, h, e) => true;
            smtp.Connect(_mailSetting.SmtpHost, _mailSetting.SmtpPort, MailKit.Security.SecureSocketOptions.StartTls);
            smtp.Authenticate(_mailSetting.SmtpUser, _mailSetting.SmtpPass);
            await smtp.SendAsync(email);
            smtp.Disconnect(true);


        }
    }
}
