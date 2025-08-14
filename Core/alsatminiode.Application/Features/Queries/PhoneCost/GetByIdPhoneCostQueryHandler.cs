using alsatminiode.Application.Repositories.PhoneCost;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Features.Queries.PhoneCost
{
    public class GetByIdPhoneCostQueryHandler : IRequestHandler<GetByIdPhoneCostQueryRequest, GetByIdPhoneCostQueryResponse>
    {
        IPhoneCostReadRepository _phoneCostReadRepository;

        public GetByIdPhoneCostQueryHandler(IPhoneCostReadRepository phoneCostReadRepository)
        {
            _phoneCostReadRepository = phoneCostReadRepository;
        }

        public async Task<GetByIdPhoneCostQueryResponse> Handle(GetByIdPhoneCostQueryRequest request, CancellationToken cancellationToken)
        {
            var phoneCost = _phoneCostReadRepository.GetWhere(d => d.phoneModel.Id == Guid.Parse(request.id)).Select(d => new
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
