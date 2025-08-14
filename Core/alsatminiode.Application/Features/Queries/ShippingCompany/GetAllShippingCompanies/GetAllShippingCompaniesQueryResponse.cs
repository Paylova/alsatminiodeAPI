using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Features.Queries.ShippingCompany.GetAllShippingCompanies
{
    public class GetAllShippingCompaniesQueryResponse
    {
        public int totalCount { get; set; }
        public object shippingCompany { get; set; }
    }
}
