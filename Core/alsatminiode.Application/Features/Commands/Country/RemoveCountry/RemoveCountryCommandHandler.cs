using alsatminiode.Application.Repositories.CountryRepo;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Features.Commands.Country.RemoveCountry
{
    public class RemoveCountryCommandHandler : IRequestHandler<RemoveCountryCommandRequest, RemoveCountryCommandResponse>
    {
        readonly ICountryWriteRepository _countryWriteRepository;

        public RemoveCountryCommandHandler(ICountryWriteRepository countryWriteRepository)
        {
            _countryWriteRepository = countryWriteRepository;
        }

        public async Task<RemoveCountryCommandResponse> Handle(RemoveCountryCommandRequest request, CancellationToken cancellationToken)
        {
            await _countryWriteRepository.RemoveAsync(request.id);
            await _countryWriteRepository.SaveAsync();
            return new();
        }
    }
}
