using alsatminiode.Application.Repositories.PhoneCost;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Features.Queries.PhoneCost.GetBySinglePhoneCost
{
    public class GetBySinglePhoneCostQueryHandler : IRequestHandler<GetBySinglePhoneCostQueryRequest, GetBySinglePhoneCostQueryResponse>
    {
        readonly IPhoneCostReadRepository _phoneCostReadRepository;

        public GetBySinglePhoneCostQueryHandler(IPhoneCostReadRepository phoneCostReadRepository)
        {
            _phoneCostReadRepository = phoneCostReadRepository;
        }

        public async Task<GetBySinglePhoneCostQueryResponse> Handle(GetBySinglePhoneCostQueryRequest request, CancellationToken cancellationToken)
        {
            var phoneCost = _phoneCostReadRepository.GetWhere(d => d.Id == Guid.Parse(request.id)).Select(d => new
            {
                d.Id,
                d.phoneCost,
                d.phoneModel,
                d.phoneQuestion
            });

            return new()
            {
                phoneCost = phoneCost
            };
        }
    }
}
