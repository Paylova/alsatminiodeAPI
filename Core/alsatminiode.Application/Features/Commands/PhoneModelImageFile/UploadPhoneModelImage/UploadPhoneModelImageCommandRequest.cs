using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Features.Commands.PhoneModelImageFile.UploadPhoneModelImage
{
    public class UploadPhoneModelImageCommandRequest : IRequest<UploadPhoneModelImageCommandResponse>
    {
        public string id { get; set; }
        public IFormFileCollection? Files { get; set; }
    }
}
