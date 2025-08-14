using alsatminiode.Application.Repositories.WebsiteOptionRepo;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Features.Queries.WebsiteOption.GetByIdWebsiteOption
{
    public class GetByIdWebsiteOptionQueryHandler : IRequestHandler<GetByIdWebsiteOptionQueryRequest, GetByIdWebsiteOptionQueryResponse>
    {
        readonly IWebsiteOptionReadRepository _websiteOptionReadRepository;

        public GetByIdWebsiteOptionQueryHandler(IWebsiteOptionReadRepository websiteOptionReadRepository)
        {
            _websiteOptionReadRepository = websiteOptionReadRepository;
        }

        public async Task<GetByIdWebsiteOptionQueryResponse> Handle(GetByIdWebsiteOptionQueryRequest request, CancellationToken cancellationToken)
        {
            var option = _websiteOptionReadRepository.GetWhere(o => o.Id == Guid.Parse(request.id)).Select(o => new
            {
                o.Id,
                o.mailHost,
                o.mailUsername,
                o.mailPassword,
                o.mailPort,
                o.mailReplyMail,
                o.giftCouponRate
            });
            return new()
            {
                websiteOption = option
            };
        }
    }
}
