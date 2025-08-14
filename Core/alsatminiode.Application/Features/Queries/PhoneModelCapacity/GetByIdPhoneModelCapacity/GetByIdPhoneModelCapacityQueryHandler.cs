using alsatminiode.Application.Repositories.PhoneModelCapacityRepo;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Features.Queries.PhoneModelCapacity.GetByIdPhoneModelCapacity
{
    public class GetByIdPhoneModelCapacityQueryHandler : IRequestHandler<GetByIdPhoneModelCapacityQueryRequest, GetByIdPhoneModelCapacityQueryResponse>
    {
        readonly IPhoneModelCapacityReadRepository _phoneModelCapacityReadRepository;

        public GetByIdPhoneModelCapacityQueryHandler(IPhoneModelCapacityReadRepository phoneModelCapacityReadRepository)
        {
            _phoneModelCapacityReadRepository = phoneModelCapacityReadRepository;
        }

        public async Task<GetByIdPhoneModelCapacityQueryResponse> Handle(GetByIdPhoneModelCapacityQueryRequest request, CancellationToken cancellationToken)
        {
            var phoneModelCapacity = _phoneModelCapacityReadRepository.GetWhere(c => c.Id == Guid.Parse(request.id)).Select(c => new
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
