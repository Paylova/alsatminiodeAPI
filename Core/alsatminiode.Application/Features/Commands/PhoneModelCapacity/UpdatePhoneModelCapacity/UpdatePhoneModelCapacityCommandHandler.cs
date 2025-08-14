using alsatminiode.Application.Repositories.PhoneModelCapacityRepo;
using alsatminiode.Application.Repositories.PhoneModelRepo;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Features.Commands.PhoneModelCapacity.UpdatePhoneModelCapacity
{
    public class UpdatePhoneModelCapacityCommandHandler : IRequestHandler<UpdatePhoneModelCapacityCommandRequest, UpdatePhoneModelCapacityCommandResponse>
    {
        readonly IPhoneModelCapacityReadRepository _phoneModelCapacityReadRepository;
        readonly IPhoneModelCapacityWriteRepository _phoneModelCapacityWriteRepository;
        readonly IPhoneModelReadRepository _phoneModelReadRepository;

        public UpdatePhoneModelCapacityCommandHandler(IPhoneModelCapacityReadRepository phoneModelCapacityReadRepository, IPhoneModelCapacityWriteRepository phoneModelCapacityWriteRepository, IPhoneModelReadRepository phoneModelReadRepository)
        {
            _phoneModelCapacityReadRepository = phoneModelCapacityReadRepository;
            _phoneModelCapacityWriteRepository = phoneModelCapacityWriteRepository;
            _phoneModelReadRepository = phoneModelReadRepository;
        }

        public async Task<UpdatePhoneModelCapacityCommandResponse> Handle(UpdatePhoneModelCapacityCommandRequest request, CancellationToken cancellationToken)
        {
            //var phoneModel = await _phoneModelReadRepository.GetByIdAsync(request.phoneModelId);
            alsatminiode.Domain.Entities.PhoneModelCapacity phoneModelCapacity = await _phoneModelCapacityReadRepository.GetByIdAsync(request.id);
            phoneModelCapacity.phoneModelCapacityName = request.phoneModelCapacityName;
            phoneModelCapacity.phoneModelCapacityPrice = request.phoneModelCapacityPrice;
            //phoneModelCapacity.phoneModel = phoneModel;
            await _phoneModelCapacityWriteRepository.SaveAsync();
            return new();
        }
    }
}
