using alsatminiode.Application.ViewModels.Email;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Features.Commands.Email.SendEmail
{
    public class SendEmailCommandRequest : MailRequest, IRequest<SendEmailCommandResponse>
    {
    }
}
