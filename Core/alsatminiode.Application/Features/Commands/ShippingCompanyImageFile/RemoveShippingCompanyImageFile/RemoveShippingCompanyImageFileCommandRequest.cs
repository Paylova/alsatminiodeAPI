using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Features.Commands.ShippingCompanyImageFile.RemoveShippingCompanyImageFile
{
    public class RemoveShippingCompanyImageFileCommandRequest : IRequest<RemoveShippingCompanyImageFileCommandResponse>
    {
        public string id { get; set; }
        public string? ImageId { get; set; }
    }
}
