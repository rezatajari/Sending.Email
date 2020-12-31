using Sending.Emails.Interface;
using Sending.Emails.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sending.Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            // تعریف متغییر ها
            var randomEmail = new Random();
            int random;
            string typeEmail, emailTo;
            var createEmail = new EmailModel();
            var sendFactory = new SendFactory();
            var senders = new List<ISend>();

            // ساخت لیست هزار ایمیل به صورت رندوم
            for (int i = 1; i <= 1000; i++)
            {
                random = randomEmail.Next(1, 5);
                typeEmail = GetTypeEmail(random);
                emailTo = $"@{typeEmail}.com";
                createEmail.Id = i;
                createEmail.To = emailTo;
                senders.Add(sendFactory.Create(createEmail));
            }
            CallEmails(senders).Wait();
        }

        static string GetTypeEmail(int getRandom)
        {
            string emailType;
            switch (getRandom)
            {
                case 1:
                    emailType = "gmail";
                    break;
                case 2:
                    emailType = "yahoo";
                    break;
                case 3:
                    emailType = "ir";
                    break;
                case 4:
                    emailType = "outlook";
                    break;
                default:
                    emailType = "no exist correct value";
                    break;
            }
            return emailType;
        }

        static async Task CallEmails(List<ISend> senders)
        {
            foreach (var sender in senders)
                await sender.SendEmail();
        }
    }
}

