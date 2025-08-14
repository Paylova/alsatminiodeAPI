using alsatminiode.Application.Repositories.DistrictRepo;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Features.Queries.District.GetAllDistrict
{
    public class GetAllDistrictQueryHandler : IRequestHandler<GetAllDistrictQueryRequest, GetAllDistrictQueryResponse>
    {
        readonly IDistrictReadRepository _districtReadRepository;

        public GetAllDistrictQueryHandler(IDistrictReadRepository districtReadRepository)
        {
            _districtReadRepository = districtReadRepository;
        }
        DateTime CreatedDate = new();
        DateTime UpdatedDate = new();
        public async Task<GetAllDistrictQueryResponse> Handle(GetAllDistrictQueryRequest request, CancellationToken cancellationToken)
        {
            var totalCount = _districtReadRepository.GetAll(false).Count();
            var district = _districtReadRepository.GetAll(false).Skip(request.Page * request.Size).Take(request.Size).Select(d => new
            {
                d.Id,
                d.districtName,
                d.districtCity.cityName,
                d.districtCountry.countryName,
                CreatedDate = d.CreatedDate.ToShortDateString(),
                UpdatedDate = d.UpdatedDate.ToShortDateString()
            });
            return new()
            {
                district = district,
                totalCount = totalCount
            };
        }
    }
}
