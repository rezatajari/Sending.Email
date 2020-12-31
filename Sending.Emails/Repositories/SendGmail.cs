using Sending.Emails.Interface;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Sending.Emails.Repositories
{
    public class SendGmail : ISend
    {
        public long Id { get; set; }
        public string To { get; set; }

        public async Task SendEmail()
        {

            Thread.Sleep(500);
            await Task.Run(() =>
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("==============Red===============");
                Console.WriteLine($"Id is: {this.Id} and send email is: GMAIL{this.To}");
                Console.WriteLine("=============================");
            });

        }
    }
}
