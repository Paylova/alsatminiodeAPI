using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Features.Commands.PhoneModelCapacity.CreatePhoneModelCapacity
{
    public class CreatePhoneModelCapacityCommandRequest : IRequest<CreatePhoneModelCapacityCommandResponse>
    {
        public string Id { get; set; }
        public string phoneModelCapacityName { get; set; }
        public int phoneModelCapacityPrice { get; set; }
    }
}
