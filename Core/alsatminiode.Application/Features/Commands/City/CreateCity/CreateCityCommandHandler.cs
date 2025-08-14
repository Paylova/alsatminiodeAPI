using alsatminiode.Application.Repositories.CityRepo;
using alsatminiode.Application.Repositories.CountryRepo;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Features.Commands.City.CreateCity
{
    public class CreateCityCommandHandler : IRequestHandler<CreateCityCommandRequest, CreateCityCommandResponse>
    {
        readonly ICityWriteRepository _cityWriteRepository;

        public CreateCityCommandHandler(ICityWriteRepository cityWriteRepository)
        {
            _cityWriteRepository = cityWriteRepository;
        }

        public async Task<CreateCityCommandResponse> Handle(CreateCityCommandRequest request, CancellationToken cancellationToken)
        {
            await _cityWriteRepository.SaveByCountryNameAndCityNameAsync(request.countryName, request.cityName);
            return new();
        }



    }
}
