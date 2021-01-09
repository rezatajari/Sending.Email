using Sending.Emails.Interface;
using Sending.Emails.Model;
using Sending.Emails.Repositories;

namespace Sending.Emails
{
    public class SendFactory
    {
        public ISend Create(EmailModel emailModel)
        {
            if (emailModel.To.Contains("gmail"))
            {
                return new SendGmail() { Id = emailModel.Id, To = emailModel.To };
            }
            else if (emailModel.To.Contains("yahoo"))
            {
                return new SendYahoo() { Id = emailModel.Id, To = emailModel.To };
            }
            else if (emailModel.To.Contains("ir"))
            {
                return new SendIr() { Id = emailModel.Id, To = emailModel.To };
            }
            else
            {
                return new SendOutlook() { Id = emailModel.Id, To = emailModel.To };
            }
        }
    }
}
