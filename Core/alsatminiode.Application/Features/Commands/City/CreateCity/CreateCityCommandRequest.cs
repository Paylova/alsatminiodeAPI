using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Features.Commands.City.CreateCity
{
    public class CreateCityCommandRequest : IRequest<CreateCityCommandResponse>
    {
        public string cityName { get; set; }
        public string countryName { get; set; }


    }
}
