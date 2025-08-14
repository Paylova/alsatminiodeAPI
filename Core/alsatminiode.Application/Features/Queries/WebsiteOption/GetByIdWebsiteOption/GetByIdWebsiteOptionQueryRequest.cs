using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Features.Queries.WebsiteOption.GetByIdWebsiteOption
{
    public class GetByIdWebsiteOptionQueryRequest : IRequest<GetByIdWebsiteOptionQueryResponse>
    {
        public string id { get; set; }
    }
}
