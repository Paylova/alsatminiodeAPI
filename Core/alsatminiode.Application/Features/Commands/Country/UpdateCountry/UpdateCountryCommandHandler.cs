using alsatminiode.Application.Repositories.CountryRepo;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Features.Commands.Country.UpdateCountry
{
    public class UpdateCountryCommandHandler : IRequestHandler<UpdateCountryCommandRequest, UpdateCountryCommandResponse>
    {
        readonly ICountryReadRepository _countryReadRepository;
        readonly ICountryWriteRepository _countryWriteRepository;

        public UpdateCountryCommandHandler(ICountryReadRepository countryReadRepository, ICountryWriteRepository countryWriteRepository)
        {
            _countryReadRepository = countryReadRepository;
            _countryWriteRepository = countryWriteRepository;
        }

        public async Task<UpdateCountryCommandResponse> Handle(UpdateCountryCommandRequest request, CancellationToken cancellationToken)
        {
            alsatminiode.Domain.Entities.Country country = await _countryReadRepository.GetByIdAsync(request.id);
            country.countryName = request.countryName;
            await _countryWriteRepository.SaveAsync();
            return new();
        }
    }
}
