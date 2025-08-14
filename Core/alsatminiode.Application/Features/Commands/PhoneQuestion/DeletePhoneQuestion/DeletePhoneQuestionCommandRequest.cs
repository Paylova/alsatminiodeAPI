using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Features.Commands.PhoneQuestion.DeletePhoneQuestion
{
    public class DeletePhoneQuestionCommandRequest : IRequest<DeletePhoneQuestionCommandResponse>
    {
        public string id { get; set; }
    }
}
