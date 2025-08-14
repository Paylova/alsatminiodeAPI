using alsatminiode.Application.Repositories.WebsiteOptionRepo;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Features.Commands.WebsiteOption.UpdateWebsiteOption
{
    public class UpdateWebsiteOptionCommandHandler : IRequestHandler<UpdateWebsiteOptionCommandRequest, UpdateWebsiteOptionCommandResponse>
    {
        readonly IWebsiteOptionReadRepository _websiteOptionReadRepository;
        readonly IWebsiteOptionWriteRepository _websiteOptionWriteRepository;

        public UpdateWebsiteOptionCommandHandler(IWebsiteOptionReadRepository websiteOptionReadRepository, IWebsiteOptionWriteRepository websiteOptionWriteRepository)
        {
            _websiteOptionReadRepository = websiteOptionReadRepository;
            _websiteOptionWriteRepository = websiteOptionWriteRepository;
        }

        public async Task<UpdateWebsiteOptionCommandResponse> Handle(UpdateWebsiteOptionCommandRequest request, CancellationToken cancellationToken)
        {
            alsatminiode.Domain.Entities.WebsiteOption websiteOption = await _websiteOptionReadRepository.GetByIdAsync(request.id);
            websiteOption.mailHost = request.mailHost;
            websiteOption.mailUsername = request.mailUsername;
            websiteOption.mailPassword = request.mailPassword;  
            websiteOption.mailPort = request.mailPort;
            websiteOption.mailReplyMail = request.mailReplyMail;
            websiteOption.giftCouponRate = request.giftCouponRate;
            await _websiteOptionWriteRepository.SaveAsync();
            return new();

        }
    }
}
