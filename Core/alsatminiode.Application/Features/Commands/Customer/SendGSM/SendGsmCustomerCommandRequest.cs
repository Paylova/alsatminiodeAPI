using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Features.Commands.Customer.SendGSM
{
    public class SendGsmCustomerCommandRequest : IRequest<SendGsmCustomerCommandResponse>
    {
        public string id { get; set; }
        public bool didsendCustomerGSM { get; set; }
        public string customerGSM { get; set; }
        public string customerName { get; set; }
    }
}
