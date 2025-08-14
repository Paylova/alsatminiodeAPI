using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Features.Queries.Country.GetAllCountry
{
    public class GetAllCountryQueryRequest : RequestParameters.Pagination, IRequest<GetAllCountryQueryResponse>
    {
    }
}
