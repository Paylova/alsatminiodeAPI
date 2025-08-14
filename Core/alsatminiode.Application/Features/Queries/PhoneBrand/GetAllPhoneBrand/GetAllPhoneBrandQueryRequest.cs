using alsatminiode.Application.RequestParameters;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Features.Queries.PhoneBrand.GetAllPhoneBrand
{
    public class GetAllPhoneBrandQueryRequest : Pagination,IRequest<GetAllPhoneBrandQueryResponse>
    {
    }
}
