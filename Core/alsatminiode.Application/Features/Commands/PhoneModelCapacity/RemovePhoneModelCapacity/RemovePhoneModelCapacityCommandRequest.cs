using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Features.Commands.PhoneModelCapacity.RemovePhoneModelCapacity
{
    public class RemovePhoneModelCapacityCommandRequest : IRequest<RemovePhoneModelCapacityCommandResponse>
    {
        public string id { get; set; }
    }
}
