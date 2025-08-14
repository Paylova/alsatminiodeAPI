using alsatminiode.Application.Repositories.PhoneCost;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Features.Commands.PhoneCost.UpdateCost
{
    public class UpdatePhoneCostCommandHandler : IRequestHandler<UpdatePhoneCostCommandRequest, UpdatePhoneCostCommandResponse>
    {
        readonly IPhoneCostReadRepository _phoneCostReadRepository;
        readonly IPhoneCostWriteRepository _phoneCostWriteRepository;

        public UpdatePhoneCostCommandHandler(IPhoneCostReadRepository phoneCostReadRepository, IPhoneCostWriteRepository phoneCostWriteRepository)
        {
            _phoneCostReadRepository = phoneCostReadRepository;
            _phoneCostWriteRepository = phoneCostWriteRepository;
        }

        public async Task<UpdatePhoneCostCommandResponse> Handle(UpdatePhoneCostCommandRequest request, CancellationToken cancellationToken)
        {
            alsatminiode.Domain.Entities.PhoneCost phoneCost = await _phoneCostReadRepository.GetByIdAsync(request.id);
            phoneCost.phoneCost = request.phoneCost;
            await _phoneCostWriteRepository.SaveAsync();

            return new();
        }
    }
}
