using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Features.Queries.Country.GetByIdCountry
{
    public class GetByIdCountryQueryRequest : IRequest<GetByIdCountryQueryResponse>
    {
        public string id { get; set; }
    }
}
