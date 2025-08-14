using alsatminiode.Application.Repositories.PhoneBrandRepo;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Features.Commands.PhoneBrand.UpdatePhoneBrand
{
    public class UpdatePhoneBrandCommandHandler : IRequestHandler<UpdatePhoneBrandCommandRequest, UpdatePhoneBrandCommandResponse>
    {
        readonly IPhoneBrandReadRepository _phoneBrandReadRepository;
        readonly IPhoneBrandWriteRepository _phoneBrandWriteRepository;

        public UpdatePhoneBrandCommandHandler(IPhoneBrandReadRepository phoneBrandReadRepository, IPhoneBrandWriteRepository phoneBrandWriteRepository)
        {
            _phoneBrandReadRepository = phoneBrandReadRepository;
            _phoneBrandWriteRepository = phoneBrandWriteRepository;
        }

        public async Task<UpdatePhoneBrandCommandResponse> Handle(UpdatePhoneBrandCommandRequest request, CancellationToken cancellationToken)
        {
            alsatminiode.Domain.Entities.PhoneBrand phoneBrand = await _phoneBrandReadRepository.GetByIdAsync(request.id);
            phoneBrand.brandName = request.brandName;
            await _phoneBrandWriteRepository.SaveAsync();

            return new();
        }
    }
}
