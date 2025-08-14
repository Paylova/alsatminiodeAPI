using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Features.Queries.PhoneBrand.GetSinglePhoneBrand
{
    public class GetSinglePhoneBrandQueryRequest : IRequest<GetSinglePhoneBrandQueryResponse>
    {
        public string id { get; set; }
    }
}
