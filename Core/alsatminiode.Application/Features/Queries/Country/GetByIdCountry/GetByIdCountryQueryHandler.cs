using alsatminiode.Application.Repositories.CountryRepo;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Features.Queries.Country.GetByIdCountry
{
    public class GetByIdCountryQueryHandler : IRequestHandler<GetByIdCountryQueryRequest, GetByIdCountryQueryResponse>
    {
        readonly ICountryReadRepository _countryReadRepository;

        public GetByIdCountryQueryHandler(ICountryReadRepository countryReadRepository)
        {
            _countryReadRepository = countryReadRepository;
        }

        public async Task<GetByIdCountryQueryResponse> Handle(GetByIdCountryQueryRequest request, CancellationToken cancellationToken)
        {
            var country = _countryReadRepository.GetWhere(c => c.Id == Guid.Parse(request.id)).Select(c => new
            {
                c.Id,
                c.countryName,
                c.countryCities
            });
            return new()
            {
                country = country,
            };
        }
    }
}
