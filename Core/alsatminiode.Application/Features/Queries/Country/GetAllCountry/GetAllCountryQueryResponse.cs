using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Features.Queries.Country.GetAllCountry
{
    public class GetAllCountryQueryResponse
    {
        public int totalCount { get; set; }
        public object country { get; set; }
    }
}
