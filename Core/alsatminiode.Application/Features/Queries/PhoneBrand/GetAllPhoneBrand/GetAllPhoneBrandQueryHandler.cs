using alsatminiode.Application.Repositories.PhoneBrandRepo;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Features.Queries.PhoneBrand.GetAllPhoneBrand
{
    public class GetAllPhoneBrandQueryHandler : IRequestHandler<GetAllPhoneBrandQueryRequest, GetAllPhoneBrandQueryResponse>
    {
        readonly IPhoneBrandReadRepository _phoneBrandReadRepository;

        public GetAllPhoneBrandQueryHandler(IPhoneBrandReadRepository phoneBrandReadRepository)
        {
            _phoneBrandReadRepository = phoneBrandReadRepository;
        }
        DateTime CreatedDate = new();
        DateTime UpdatedDate = new();
        public async Task<GetAllPhoneBrandQueryResponse> Handle(GetAllPhoneBrandQueryRequest request, CancellationToken cancellationToken)
        {
            var totalCount = _phoneBrandReadRepository.GetAll(false).Count();
            var phoneBrand = _phoneBrandReadRepository.GetAll(false).Skip(request.Page * request.Size).Take(request.Size).Select(p => new
            {
                p.Id,
                p.brandName,
                p.brandModels,
                CreatedDate = p.CreatedDate.ToShortDateString(),
                UpdatedDate = p.UpdatedDate.ToShortDateString()
            });

            return new()
            {
                phoneBrand = phoneBrand,
                totalCount = totalCount,
            };
        }
    }
}
