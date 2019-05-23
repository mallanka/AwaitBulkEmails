using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

namespace AwaitBulkEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            SendEmailAsync().GetAwaiter();
        }
        public static async Task SendEmailAsync()
        {
            MailAddress from = new MailAddress("mallanka2@mail.ru");
            MailAddress to = new MailAddress("mallanka@mail.ru");
            MailMessage mailMessage = new MailMessage(from, to);
            mailMessage.Subject = "subject";
            mailMessage.Body = "test message";
            SmtpClient smpt = new SmtpClient("smtp.yandex.ru", 25);
            smpt.Credentials = new NetworkCredential("mallanka2@mail.ru", "********");
            await smpt.SendMailAsync(mailMessage);
        }
    }
}
