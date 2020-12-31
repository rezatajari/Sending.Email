using Sending.Emails.Interface;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Sending.Emails.Repositories
{
    public class SendYahoo : ISend
    {
        public long Id { get; set; }
        public string To { get; set; }

        public async Task SendEmail()
        {
            Thread.Sleep(500);

            await Task.Run(() =>
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("==============Green===============");
                Console.WriteLine($"Id is: {this.Id} and send email is: YAHOO{this.To}");
                Console.WriteLine("=============================");
            });

        }
    }
}
