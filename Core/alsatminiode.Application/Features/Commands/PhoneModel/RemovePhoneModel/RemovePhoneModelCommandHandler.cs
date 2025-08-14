using alsatminiode.Application.Repositories.PhoneCost;
using alsatminiode.Application.Repositories.PhoneModelRepo;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using F = alsatminiode.Domain.Entities;

namespace alsatminiode.Application.Features.Commands.PhoneModel.RemovePhoneModel
{
    public class RemovePhoneModelCommandHandler : IRequestHandler<RemovePhoneModelCommandRequest, RemovePhoneModelCommandResponse>
    {
        readonly IPhoneModelWriteRepository _phoneModelWriteRepository;
        readonly IPhoneModelReadRepository _phoneModelReadRepository;
        readonly IPhoneCostReadRepository _phoneCostReadRepository;
        readonly IPhoneCostWriteRepository _phoneCostWriteRepository;

        public RemovePhoneModelCommandHandler(IPhoneModelWriteRepository phoneModelWriteRepository, IPhoneCostReadRepository phoneCostReadRepository, IPhoneCostWriteRepository phoneCostWriteRepository, IPhoneModelReadRepository phoneModelReadRepository)
        {
            _phoneModelWriteRepository = phoneModelWriteRepository;
            _phoneCostReadRepository = phoneCostReadRepository;
            _phoneCostWriteRepository = phoneCostWriteRepository;
            _phoneModelReadRepository = phoneModelReadRepository;
        }

        public async Task<RemovePhoneModelCommandResponse> Handle(RemovePhoneModelCommandRequest request, CancellationToken cancellationToken)
        {
            //var PhoneCost = _phoneModelReadRepository.GetWhere(x => x.Id == Guid.Parse(request.id));
            // List<F::PhoneModel> phoneModels = PhoneCost.ToList();
            //_phoneCostWriteRepository.RemoveRange(phoneModels);
            await _phoneModelWriteRepository.RemoveAsync(request.id);
            await _phoneModelWriteRepository.SaveAsync();
            return new();
        }
    }
}
