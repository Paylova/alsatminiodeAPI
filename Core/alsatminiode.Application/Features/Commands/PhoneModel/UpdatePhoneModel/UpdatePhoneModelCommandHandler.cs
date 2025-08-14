using alsatminiode.Application.Repositories.PhoneModelRepo;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Features.Commands.PhoneModel.UpdatePhoneModel
{
    public class UpdatePhoneModelCommandHandler : IRequestHandler<UpdatePhoneModelCommandRequest, UpdatePhoneModelCommandResponse>
    {
        readonly IPhoneModelReadRepository _phoneModelReadRepository;
        readonly IPhoneModelWriteRepository _phoneModelWriteRepository;

        public UpdatePhoneModelCommandHandler(IPhoneModelReadRepository phoneModelReadRepository, IPhoneModelWriteRepository phoneModelWriteRepository)
        {
            _phoneModelReadRepository = phoneModelReadRepository;
            _phoneModelWriteRepository = phoneModelWriteRepository;
        }

        public async Task<UpdatePhoneModelCommandResponse> Handle(UpdatePhoneModelCommandRequest request, CancellationToken cancellationToken)
        {
            alsatminiode.Domain.Entities.PhoneModel phoneModel = await _phoneModelReadRepository.GetByIdAsync(request.id);
            phoneModel.modelName = request.modelName;
            phoneModel.modelFirstPrice = request.modelFirstPrice;
            phoneModel.modelLastPrice = request.modelLastPrice;
            await _phoneModelWriteRepository.SaveAsync();
            return new();
        }
    }
}
