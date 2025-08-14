using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Features.Queries.Customer.GetByIdCustomer
{
    public class GetByIdCustomerQueryRequest : IRequest<GetByIdCustomerQueryResponse>
    {
        public string id { get; set; }
    }
}
