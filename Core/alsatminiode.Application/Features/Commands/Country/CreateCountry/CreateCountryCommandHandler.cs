using alsatminiode.Application.Repositories.CountryRepo;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Features.Commands.Country.CreateCountry
{
    public class CreateCountryCommandHandler : IRequestHandler<CreateCountryCommandRequest, CreateCountryCommandResponse>
    {
        readonly ICountryWriteRepository _countryWriteRepository;

        public CreateCountryCommandHandler(ICountryWriteRepository countryWriteRepository)
        {
            _countryWriteRepository = countryWriteRepository;
        }

        public async Task<CreateCountryCommandResponse> Handle(CreateCountryCommandRequest request, CancellationToken cancellationToken)
        {
            await _countryWriteRepository.AddAsync(new()
            {
                countryName = request.countryName
            });
            await _countryWriteRepository.SaveAsync();
            return new();
        }
    }
}
