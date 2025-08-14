using alsatminiode.Application.Repositories.CountryRepo;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Features.Queries.Country.GetAllCountry
{
    public class GetAllCountryQueryHandler : IRequestHandler<GetAllCountryQueryRequest, GetAllCountryQueryResponse>
    {
        readonly ICountryReadRepository _countryReadRepository;

        public GetAllCountryQueryHandler(ICountryReadRepository countryReadRepository)
        {
            _countryReadRepository = countryReadRepository;
        }
        DateTime CreatedDate = new();
        DateTime UpdatedDate = new();
        public async Task<GetAllCountryQueryResponse> Handle(GetAllCountryQueryRequest request, CancellationToken cancellationToken)
        {
            var totalCount = _countryReadRepository.GetAll(false).Count();
            var country = _countryReadRepository.GetAll(false).Skip(request.Page * request.Size).Take(request.Size).Select(c => new
            {
                c.Id,
                c.countryName,
                CreatedDate = c.CreatedDate.ToShortDateString(),
                UpdatedDate = c.UpdatedDate.ToShortDateString()

            });
            return new()
            {
                country = country,
                totalCount = totalCount
            };
        }
    }
}
