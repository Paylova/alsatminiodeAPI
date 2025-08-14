using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Features.Commands.PhoneBrand.RemovePhoneBrand
{
    public class RemovePhoneBrandCommandRequest : IRequest<RemovePhoneBrandCommandResponse>
    {
        public string id { get; set; }
    }
}
