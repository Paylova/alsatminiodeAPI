using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Features.Queries.PhoneModel.PhoneModelImageFile.GetPhoneModelImage
{
    public class GetPhoneModelImageCommandHandler : IRequestHandler<GetPhoneModelImageCommandRequest, GetPhoneModelImageCommandResponse>
    {
        public async Task<GetPhoneModelImageCommandResponse> Handle(GetPhoneModelImageCommandRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
