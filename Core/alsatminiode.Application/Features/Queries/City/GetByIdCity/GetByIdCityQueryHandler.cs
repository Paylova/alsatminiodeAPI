using alsatminiode.Application.Repositories.CityRepo;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Features.Queries.City.GetByIdCity
{
    public class GetByIdCityQueryHandler : IRequestHandler<GetByIdCityQueryRequest, GetByIdCityQueryResponse>
    {
        ICityReadRepository _cityReadRepository;

        public GetByIdCityQueryHandler(ICityReadRepository cityReadRepository)
        {
            _cityReadRepository = cityReadRepository;
        }
        public async Task<GetByIdCityQueryResponse> Handle(GetByIdCityQueryRequest request, CancellationToken cancellationToken)
        {
            var city = _cityReadRepository.GetWhere(c => c.Id == Guid.Parse(request.id)).Select(c => new
            {
                c.Id,
                c.cityName,
                c.cityCountry,
                c.cityDistricts
            });

            return new()
            {
                city = city,
            };
            
        }
    }
}
