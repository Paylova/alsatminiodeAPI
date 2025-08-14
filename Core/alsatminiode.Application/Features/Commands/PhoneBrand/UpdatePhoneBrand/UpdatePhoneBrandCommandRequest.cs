using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Features.Commands.PhoneBrand.UpdatePhoneBrand
{
    public class UpdatePhoneBrandCommandRequest : IRequest<UpdatePhoneBrandCommandResponse>
    {
        public string id { get; set; }
        public string brandName { get; set; }
    }
}
