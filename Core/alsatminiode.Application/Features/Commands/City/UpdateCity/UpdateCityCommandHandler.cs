using alsatminiode.Application.Repositories.CityRepo;
using alsatminiode.Application.Repositories.CountryRepo;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Features.Commands.City.UpdateCity
{
    public class UpdateCityCommandHandler : IRequestHandler<UpdateCityCommandRequest, UpdateCityCommandResponse>
    {
        readonly ICityReadRepository _cityReadRepository;
        readonly ICityWriteRepository _cityWriteRepository;
        readonly ICountryReadRepository _countryReadRepository;

        public UpdateCityCommandHandler(ICityReadRepository cityReadRepository, ICityWriteRepository cityWriteRepository, ICountryReadRepository countryReadRepository)
        {
            _cityReadRepository = cityReadRepository;
            _cityWriteRepository = cityWriteRepository;
            _countryReadRepository = countryReadRepository;
        }

        public async Task<UpdateCityCommandResponse> Handle(UpdateCityCommandRequest request, CancellationToken cancellationToken)
        {
            alsatminiode.Domain.Entities.City city = await _cityReadRepository.GetByIdAsync(request.id);
            alsatminiode.Domain.Entities.Country country = await _countryReadRepository.GetByIdAsync(request.countryId);
            city.cityName = request.cityName;
            city.cityCountry = country;
            await _cityWriteRepository.SaveAsync();
            return new();
        }
    }
}
