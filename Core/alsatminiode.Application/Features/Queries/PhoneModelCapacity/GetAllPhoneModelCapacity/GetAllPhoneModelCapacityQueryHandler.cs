using alsatminiode.Application.Repositories.PhoneModelCapacityRepo;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Features.Queries.PhoneModelCapacity.GetAllPhoneModelCapacity
{
    public class GetAllPhoneModelCapacityQueryHandler : IRequestHandler<GetAllPhoneModelCapacityQueryRequest, GetAllPhoneModelCapacityQueryResponse>
    {
        readonly IPhoneModelCapacityReadRepository _phoneModelCapacityReadRepository;

        public GetAllPhoneModelCapacityQueryHandler(IPhoneModelCapacityReadRepository phoneModelCapacityReadRepository)
        {
            _phoneModelCapacityReadRepository = phoneModelCapacityReadRepository;
        }
        DateTime CreatedDate = new();
        DateTime UpdatedDate = new();
        public async Task<GetAllPhoneModelCapacityQueryResponse> Handle(GetAllPhoneModelCapacityQueryRequest request, CancellationToken cancellationToken)
        {
            var totalCount = _phoneModelCapacityReadRepository.GetAll(false).Count();
            var phoneModelCapacity = _phoneModelCapacityReadRepository.GetAll(false).Skip(request.Page * request.Size).Take(request.Size).Select(m => new
            {
                m.Id,
                m.phoneModelCapacityName,
                m.phoneModelCapacityPrice,
                m.phoneModel,
                CreatedDate = m.CreatedDate.ToShortDateString(),
                UpdatedDate = m.UpdatedDate.ToShortDateString(),
            });
            return new()
            {
                totalCount = totalCount,
                phoneModelCapacity = phoneModelCapacity
            };
        }
    }
}
