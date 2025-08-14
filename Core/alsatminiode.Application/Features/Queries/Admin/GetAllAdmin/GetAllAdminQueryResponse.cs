using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Features.Queries.Admin.GetAllAdmin
{
    public class GetAllAdminQueryResponse
    {
        public int totalCount { get; set; }
        public object admin { get; set; }
    }
}
