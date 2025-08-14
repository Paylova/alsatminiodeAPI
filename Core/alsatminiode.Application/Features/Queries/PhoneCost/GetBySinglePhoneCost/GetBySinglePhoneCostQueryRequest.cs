using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Features.Queries.PhoneCost.GetBySinglePhoneCost
{
    public class GetBySinglePhoneCostQueryRequest : IRequest<GetBySinglePhoneCostQueryResponse>
    {
        public string id { get; set; }
    }
}
