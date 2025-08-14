using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Features.Queries.ShippingCompany.GetByIdShippingCompany
{
    public class GetByIdShippingComapnyQueryRequest : IRequest<GetByIdShippingComapnyQueryResponse>
    {
        public string id { get; set; }
    }
}
