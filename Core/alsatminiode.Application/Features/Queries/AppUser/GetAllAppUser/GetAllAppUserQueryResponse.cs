using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Features.Queries.AppUser.GetAllAppUser
{
    public class GetAllAppUserQueryResponse
    {
        public int totalCount { get; set; }
        public object AppUser { get; set; }
    }
}
