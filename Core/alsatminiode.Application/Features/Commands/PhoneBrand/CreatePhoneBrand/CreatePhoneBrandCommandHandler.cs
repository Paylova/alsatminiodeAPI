using alsatminiode.Application.Repositories.PhoneBrandRepo;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Features.Commands.PhoneBrand.CreatePhoneBrand
{
    public class CreatePhoneBrandCommandHandler : IRequestHandler<CreatePhoneBrandCommandRequest, CreatePhoneBrandCommandResponse>
    {
        readonly IPhoneBrandWriteRepository _phoneBrandWriteRepository;

        public CreatePhoneBrandCommandHandler(IPhoneBrandWriteRepository phoneBrandWriteRepository)
        {
            _phoneBrandWriteRepository = phoneBrandWriteRepository;
        }

        public async Task<CreatePhoneBrandCommandResponse> Handle(CreatePhoneBrandCommandRequest request, CancellationToken cancellationToken)
        {
            await _phoneBrandWriteRepository.AddAsync(new()
            {
                brandName = request.brandName,
            });
            await _phoneBrandWriteRepository.SaveAsync();

            return new();
        }
    }
}
