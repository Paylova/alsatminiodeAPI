using alsatminiode.Application.Repositories.PhoneBrandRepo;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Features.Queries.PhoneBrand.GetSinglePhoneBrand
{
    public class GetSinglePhoneBrandQueryHandler : IRequestHandler<GetSinglePhoneBrandQueryRequest, GetSinglePhoneBrandQueryResponse>
    {
        readonly IPhoneBrandReadRepository _phoneBrandReadRepository;

        public GetSinglePhoneBrandQueryHandler(IPhoneBrandReadRepository phoneBrandReadRepository)
        {
            this._phoneBrandReadRepository = phoneBrandReadRepository;
        }

        public async Task<GetSinglePhoneBrandQueryResponse> Handle(GetSinglePhoneBrandQueryRequest request, CancellationToken cancellationToken)
        {
            var phoneBrand = _phoneBrandReadRepository.GetWhere(d => d.Id == Guid.Parse(request.id)).Select(p => new
            {
                p.Id,
                p.brandName,
                p.brandModels,
            });


            return new()
            {
                phoneBrand = phoneBrand
            };
        }
    }
}
