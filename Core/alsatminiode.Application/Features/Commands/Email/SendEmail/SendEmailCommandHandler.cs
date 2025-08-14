using alsatminiode.Application.Abstractions.Services.Mesages;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Features.Commands.Email.SendEmail
{
    public class SendEmailCommandHandler : IRequestHandler<SendEmailCommandRequest, SendEmailCommandResponse>
    {
        private readonly IMailService mailService;

        public SendEmailCommandHandler(IMailService mailService)
        {
            this.mailService = mailService;
        }

        public async Task<SendEmailCommandResponse> Handle(SendEmailCommandRequest request, CancellationToken cancellationToken)
        {
            await mailService.SendEmailAsync(request);
            return new();
        }
    }
}
