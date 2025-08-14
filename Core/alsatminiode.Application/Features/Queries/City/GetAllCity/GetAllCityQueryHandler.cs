using alsatminiode.Application.Repositories.CityRepo;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Features.Queries.City.GetAllCity
{
    public class GetAllCityQueryHandler : IRequestHandler<GetAllCityQueryRequest, GetAllCityQueryResponse>
    {
        readonly ICityReadRepository _cityReadRepository;

        public GetAllCityQueryHandler(ICityReadRepository cityReadRepository)
        {
            _cityReadRepository = cityReadRepository;
        }

        public async Task<GetAllCityQueryResponse> Handle(GetAllCityQueryRequest request, CancellationToken cancellationToken)
        {
            DateTime CreatedDate = new();
            DateTime UpdatedDate = new();
            var totalCount = _cityReadRepository.GetAll(false).Count();
            var city = _cityReadRepository.GetAll(false).Skip(request.Page * request.Size).Take(request.Size).Select(c => new
            {
                c.Id,
                c.cityName,
                c.cityCountry.countryName,
                CreatedDate = c.CreatedDate.ToShortDateString(),
                UpdatedDate = c.UpdatedDate.ToShortDateString()
            });

            return new()
            {
                city = city,
                totalCount = totalCount
            };

        }
    }
}
