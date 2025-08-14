using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.ViewModels.Email.QueuedEmail
{
    public class QueuedEmail
    {
        public string FromName { get; set; }
        public string To { get; set; }
        public string ToName { get; set; }
        public string CC { get; set; }
        public string Bcc { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public int SentTries { get; set; }
        public DateTime? SentDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? StartDate { get; set; }
    }
}
