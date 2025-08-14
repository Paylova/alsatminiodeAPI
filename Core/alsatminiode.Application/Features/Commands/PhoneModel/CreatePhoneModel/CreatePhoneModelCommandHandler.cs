using alsatminiode.Application.Repositories.PhoneCost;
using alsatminiode.Application.Repositories.PhoneModelRepo;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Features.Commands.PhoneModel.CreatePhoneModel
{
    public class CreatePhoneModelCommandHandler : IRequestHandler<CreatePhoneModelCommandRequest, CreatePhoneModelCommandResponse>
    {
        readonly IPhoneModelWriteRepository _phoneModelWriteRepository;
        readonly IPhoneCostWriteRepository _phoneCostWriteRepository;
        readonly IPhoneModelReadRepository _phoneModelReadRepository;

        public CreatePhoneModelCommandHandler(IPhoneModelWriteRepository phoneModelWriteRepository, IPhoneCostWriteRepository phoneCostWriteRepository, IPhoneModelReadRepository phoneModelReadRepository)
        {
            _phoneModelWriteRepository = phoneModelWriteRepository;
            _phoneCostWriteRepository = phoneCostWriteRepository;
            _phoneModelReadRepository = phoneModelReadRepository;
        }

        public async Task<CreatePhoneModelCommandResponse> Handle(CreatePhoneModelCommandRequest request, CancellationToken cancellationToken)
        {
            

            await _phoneModelWriteRepository.SaveChangesModelBrand(request.modelName, request.modelFirstPrice, request.modelLastPrice, request.brandName);

            var phoneModelId = await _phoneModelReadRepository.GetSingleAsync(d => d.modelName == request.modelName);
            
            await _phoneCostWriteRepository.saveAll("5DC9F931-6DCB-4B45-ECF3-08DA4EE899CE", phoneModelId.Id.ToString(), 0);
            await _phoneCostWriteRepository.saveAll("40BC6031-2544-4F6C-ECF4-08DA4EE899CE", phoneModelId.Id.ToString(), 0);
            await _phoneCostWriteRepository.saveAll("C7E02A3A-A218-4DC2-ECF5-08DA4EE899CE", phoneModelId.Id.ToString(), 0);
            await _phoneCostWriteRepository.saveAll("48C6902F-4FB8-4D82-ECF6-08DA4EE899CE", phoneModelId.Id.ToString(), 0);
            await _phoneCostWriteRepository.saveAll("0E8B5563-ED09-49C3-ECF7-08DA4EE899CE", phoneModelId.Id.ToString(), 0);
            await _phoneCostWriteRepository.saveAll("4CA67AF1-E321-41F0-ECF8-08DA4EE899CE", phoneModelId.Id.ToString(), 0);
            await _phoneCostWriteRepository.saveAll("74289CAE-5032-4337-ECF9-08DA4EE899CE", phoneModelId.Id.ToString(), 0);
            await _phoneCostWriteRepository.saveAll("4CD8F564-2AFA-4BE1-ECFA-08DA4EE899CE", phoneModelId.Id.ToString(), 0);

            return new();
        }
    }
}
