using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Features.Commands.PhoneSituation.CreatePhoneSituation
{
    public class CreatePhoneSituationCommandRequest : IRequest<CreatePhoneSituationCommandResponse>
    {
        public string phoneSituation { get; set; }
    }
}
