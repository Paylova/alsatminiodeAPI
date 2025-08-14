using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Features.Commands.PhoneCost
{
    public class CreatePhoneCostCommandHandler : IRequestHandler<CreatePhoneCostCommandRequest, CreatePhoneCostCommandResponse>
    {
        public Task<CreatePhoneCostCommandResponse> Handle(CreatePhoneCostCommandRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
