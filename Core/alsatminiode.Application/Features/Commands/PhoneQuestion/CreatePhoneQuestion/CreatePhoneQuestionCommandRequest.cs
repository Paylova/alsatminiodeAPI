using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Features.Commands.PhoneQuestion.CreatePhoneQuestion
{
    public class CreatePhoneQuestionCommandRequest : IRequest<CreatePhoneQuestionCommandResponse>
    {
        public string QuestionText { get; set; }
        public long LowPrice { get; set; }
        public long HighPrice { get; set; }
    }
}
