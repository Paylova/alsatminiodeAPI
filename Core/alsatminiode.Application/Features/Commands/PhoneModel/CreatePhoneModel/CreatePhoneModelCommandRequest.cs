using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Features.Commands.PhoneModel.CreatePhoneModel
{
    public class CreatePhoneModelCommandRequest : IRequest<CreatePhoneModelCommandResponse>
    {

        public string modelName { get; set; }
        //public bool modelIsActive { get; set; }
        public int modelFirstPrice { get; set; }
        public int modelLastPrice { get; set; }
        public string brandName { get; set; }
    }
}
