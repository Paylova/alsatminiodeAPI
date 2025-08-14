using alsatminiode.Application.Repositories.PhoneModelCapacityRepo;
using alsatminiode.Application.Repositories.PhoneModelRepo;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Features.Queries.PhoneModelCapacity.GetByIdPhoneModelCapacityWithPhoneModel
{
    public class GetByIdPhoneModelCapacityWithPhoneModelHandler : IRequestHandler<GetByIdPhoneModelCapacityWithPhoneModelRequest, GetByIdPhoneModelCapacityWithPhoneModelResponse>
    {
        readonly IPhoneModelReadRepository _phoneModelReadRepository;
        readonly IPhoneModelCapacityReadRepository _phoneModelCapacityReadRepository;

        public GetByIdPhoneModelCapacityWithPhoneModelHandler(IPhoneModelReadRepository phoneModelReadRepository, IPhoneModelCapacityReadRepository phoneModelCapacityReadRepository)
        {
            _phoneModelReadRepository = phoneModelReadRepository;
            _phoneModelCapacityReadRepository = phoneModelCapacityReadRepository;
        }

        public async Task<GetByIdPhoneModelCapacityWithPhoneModelResponse> Handle(GetByIdPhoneModelCapacityWithPhoneModelRequest request, CancellationToken cancellationToken)
        {
            var phoneModel = await _phoneModelReadRepository.GetByIdAsync(request.id);

            var phoneModelCapacity = _phoneModelCapacityReadRepository.GetWhere(c => c.phoneModel.Id == Guid.Parse(request.id)).Select(c => new
            {
                c.Id,
                c.phoneModelCapacityName,
                c.phoneModelCapacityPrice,
                c.phoneModel
            });
            return new()
            {
                phoneModelCapacity = phoneModelCapacity
            };
        }
    }
}
