using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Features.Queries.Customer.GetAllCustomer
{
    public class GetAllCustomerQueryResponse
    {
        public int totalCount { get; set; }
        public object customer { get; set; }
    }
}
