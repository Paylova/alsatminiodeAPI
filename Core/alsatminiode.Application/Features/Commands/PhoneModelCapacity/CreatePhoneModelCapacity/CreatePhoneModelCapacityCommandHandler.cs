using alsatminiode.Application.Repositories.PhoneModelCapacityRepo;
using alsatminiode.Application.Repositories.PhoneModelRepo;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Features.Commands.PhoneModelCapacity.CreatePhoneModelCapacity
{
    public class CreatePhoneModelCapacityCommandHandler : IRequestHandler<CreatePhoneModelCapacityCommandRequest, CreatePhoneModelCapacityCommandResponse>
    {
        readonly IPhoneModelReadRepository _phoneModelReadRepository;
        readonly IPhoneModelCapacityWriteRepository _phoneModelCapacityWriteRepository;

        public CreatePhoneModelCapacityCommandHandler(IPhoneModelReadRepository phoneModelReadRepository, IPhoneModelCapacityWriteRepository phoneModelCapacityWriteRepository)
        {
            _phoneModelReadRepository = phoneModelReadRepository;
            _phoneModelCapacityWriteRepository = phoneModelCapacityWriteRepository;
        }

        public async Task<CreatePhoneModelCapacityCommandResponse> Handle(CreatePhoneModelCapacityCommandRequest request, CancellationToken cancellationToken)
        {
            var phoneModel = await _phoneModelReadRepository.GetSingleAsync(d => d.Id == Guid.Parse(request.Id));
            await _phoneModelCapacityWriteRepository.AddAsync(new()
            {
                phoneModel = phoneModel,
                phoneModelCapacityName = request.phoneModelCapacityName,
                phoneModelCapacityPrice = request.phoneModelCapacityPrice
            });
            await _phoneModelCapacityWriteRepository.SaveAsync();
            return new();
        }
    }
}
