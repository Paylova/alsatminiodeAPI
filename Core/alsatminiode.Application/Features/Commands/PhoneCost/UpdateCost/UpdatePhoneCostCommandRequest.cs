using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Features.Commands.PhoneCost.UpdateCost
{
    public class UpdatePhoneCostCommandRequest : IRequest<UpdatePhoneCostCommandResponse>
    {
        public string id { get; set; }
        public short phoneCost { get; set; }
    }
}
