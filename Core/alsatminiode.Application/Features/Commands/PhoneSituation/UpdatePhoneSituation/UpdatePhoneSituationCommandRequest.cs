using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Features.Commands.PhoneSituation.UpdatePhoneSituation
{
    public class UpdatePhoneSituationCommandRequest : IRequest<UpdatePhoneSituationCommandResponse>
    {
        public string id { get; set; }
        public string phoneSituation { get; set; }
    }
}
