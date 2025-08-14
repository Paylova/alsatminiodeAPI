using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Features.Commands.PhoneModelCapacity.UpdatePhoneModelCapacity
{
    public class UpdatePhoneModelCapacityCommandRequest : IRequest<UpdatePhoneModelCapacityCommandResponse>
    {
        public string id { get; set; }
        public string phoneModelCapacityName { get; set; }
        public int phoneModelCapacityPrice { get; set; }
        //public string phoneModelId { get; set; }
    }
}
