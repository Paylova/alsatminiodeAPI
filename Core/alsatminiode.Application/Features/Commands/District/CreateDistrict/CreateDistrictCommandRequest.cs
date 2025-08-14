using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Features.Commands.District.CreateDistrict
{
    public class CreateDistrictCommandRequest : IRequest<CreateDistrictCommandResponse>
    {
        public string districtName { get; set; }
        public string cityName { get; set; }
        public string countryName { get; set; }
    }
}
