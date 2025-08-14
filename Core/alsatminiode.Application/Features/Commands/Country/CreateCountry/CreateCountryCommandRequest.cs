using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Features.Commands.Country.CreateCountry
{
    public class CreateCountryCommandRequest : IRequest<CreateCountryCommandResponse>
    {
        public string countryName { get; set; }
    }
}
