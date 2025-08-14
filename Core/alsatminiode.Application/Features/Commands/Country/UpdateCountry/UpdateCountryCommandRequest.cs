using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Features.Commands.Country.UpdateCountry
{
    public class UpdateCountryCommandRequest : IRequest<UpdateCountryCommandResponse>
    {
        public string id { get; set; }
        public string countryName { get; set; }
    }
}
