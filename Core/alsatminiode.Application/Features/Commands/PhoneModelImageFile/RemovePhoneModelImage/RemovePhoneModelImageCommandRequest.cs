using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Features.Commands.PhoneModelImageFile.RemovePhoneModelImage
{
    public class RemovePhoneModelImageCommandRequest : IRequest<RemovePhoneModelImageCommandResponse>
    {
        public string id { get; set; }
        public string? imageId { get; set; }
    }
}
