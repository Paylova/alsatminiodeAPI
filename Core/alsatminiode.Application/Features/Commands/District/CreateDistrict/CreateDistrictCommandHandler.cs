using alsatminiode.Application.Repositories.CityRepo;
using alsatminiode.Application.Repositories.CountryRepo;
using alsatminiode.Application.Repositories.DistrictRepo;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Features.Commands.District.CreateDistrict
{
    public class CreateDistrictCommandHandler : IRequestHandler<CreateDistrictCommandRequest, CreateDistrictCommandResponse>
    {
        readonly IDistrictWriteRepository _districtWriteRepository;
        readonly ICityReadRepository _cityReadRepository;
        readonly ICountryReadRepository _countryReadRepository;

        public CreateDistrictCommandHandler(IDistrictWriteRepository districtWriteRepository, ICityReadRepository cityReadRepository, ICountryReadRepository countryReadRepository)
        {
            _districtWriteRepository = districtWriteRepository;
            _cityReadRepository = cityReadRepository;
            _countryReadRepository = countryReadRepository;
        }

        public async Task<CreateDistrictCommandResponse> Handle(CreateDistrictCommandRequest request, CancellationToken cancellationToken)
        {
            await _districtWriteRepository.SaveDistrictWithCityAndCountry(request.districtName, request.cityName, request.countryName);
            return new();
        }
    }
}
