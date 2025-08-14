using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.ViewModels.Email.EmailSendData
{
    public class EmailSendDataModel
    {
        public string ReceiverEmail { get; set; }
        public string ReceiverFullName { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public DateTime? StartDate { get; set; }
    }
}
