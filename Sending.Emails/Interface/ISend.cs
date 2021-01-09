using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sending.Emails.Interface
{
    public interface ISend
    {
        long Id { get; set; }
        string To { get; set; }
        Task SendEmail();
    }
}
