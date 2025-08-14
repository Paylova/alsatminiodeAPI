using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Features.Commands.City.UpdateCity
{
    public class UpdateCityCommandRequest: IRequest<UpdateCityCommandResponse>
    {
        public string id { get; set; }
        public string cityName { get; set; }
        public string countryId { get; set; }
    }
}
