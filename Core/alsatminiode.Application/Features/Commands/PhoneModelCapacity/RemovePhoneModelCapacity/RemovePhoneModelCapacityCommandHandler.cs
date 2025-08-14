using alsatminiode.Application.Repositories.PhoneModelCapacityRepo;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Features.Commands.PhoneModelCapacity.RemovePhoneModelCapacity
{
    public class RemovePhoneModelCapacityCommandHandler : IRequestHandler<RemovePhoneModelCapacityCommandRequest, RemovePhoneModelCapacityCommandResponse>
    {
        readonly IPhoneModelCapacityWriteRepository _phoneModelCapacityWriteRepository;

        public RemovePhoneModelCapacityCommandHandler(IPhoneModelCapacityWriteRepository phoneModelCapacityWriteRepository)
        {
            _phoneModelCapacityWriteRepository = phoneModelCapacityWriteRepository;
        }

        public async Task<RemovePhoneModelCapacityCommandResponse> Handle(RemovePhoneModelCapacityCommandRequest request, CancellationToken cancellationToken)
        {
            await _phoneModelCapacityWriteRepository.RemoveAsync(request.id);
            await _phoneModelCapacityWriteRepository.SaveAsync();
            return new();
        }
    }
}
