using alsatminiode.Application.Repositories.PhoneBrandRepo;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Features.Commands.PhoneBrand.RemovePhoneBrand
{
    public class RemovePhoneBrandCommandHandler : IRequestHandler<RemovePhoneBrandCommandRequest, RemovePhoneBrandCommandResponse>
    {
        readonly IPhoneBrandWriteRepository _phoneBrandWriteRepository;

        public RemovePhoneBrandCommandHandler(IPhoneBrandWriteRepository phoneBrandWriteRepository)
        {
            _phoneBrandWriteRepository = phoneBrandWriteRepository;
        }

        public async Task<RemovePhoneBrandCommandResponse> Handle(RemovePhoneBrandCommandRequest request, CancellationToken cancellationToken)
        {
            await _phoneBrandWriteRepository.RemoveAsync(request.id);
            await _phoneBrandWriteRepository.SaveAsync();

            return new();
        }
    }
}
