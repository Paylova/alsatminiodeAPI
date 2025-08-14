using alsatminiode.Application.Repositories.PhoneSituationRepo;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Features.Queries.PhoneSituation.GetAllPhoneSituation
{
    public class GetAllPhoneSituationQueryHandler : IRequestHandler<GetAllPhoneSituationQueryRequest, GetAllPhoneSituationQueryResponse>
    {
        readonly IPhoneSituationReadRepository _phoneSituationReadRepository;

        public GetAllPhoneSituationQueryHandler(IPhoneSituationReadRepository phoneSituationReadRepository)
        {
            _phoneSituationReadRepository = phoneSituationReadRepository;
        }
        DateTime CreatedDate = new();
        DateTime UpdatedDate = new();
        public async Task<GetAllPhoneSituationQueryResponse> Handle(GetAllPhoneSituationQueryRequest request, CancellationToken cancellationToken)
        {
            var totalCount = _phoneSituationReadRepository.GetAll(false).Count();
            var phoneSituation = _phoneSituationReadRepository.GetAll(false).Skip(request.Page * request.Size).Take(request.Size).Select(p => new
            {
                p.Id,
                p.phoneSituation,
                CreatedDate = p.CreatedDate.ToShortDateString(),
                UpdatedDate = p.UpdatedDate.ToShortDateString()
            });

            return new()
            {
                phoneSituation = phoneSituation,
                totalCount = totalCount
            };
        }
    }
}
