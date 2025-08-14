using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Features.Commands.PhoneModel.UpdatePhoneModel
{
    public class UpdatePhoneModelCommandRequest : IRequest<UpdatePhoneModelCommandResponse>
    {
        public string id { get; set; }
        public string modelName { get; set; }
        public int modelFirstPrice { get; set; }
        public int modelLastPrice { get; set; }
    }
}
