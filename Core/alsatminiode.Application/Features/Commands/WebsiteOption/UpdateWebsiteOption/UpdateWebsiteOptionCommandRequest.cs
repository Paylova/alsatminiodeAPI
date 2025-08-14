using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Features.Commands.WebsiteOption.UpdateWebsiteOption
{
    public class UpdateWebsiteOptionCommandRequest : IRequest<UpdateWebsiteOptionCommandResponse>
    {
        public string id { get; set; }
        public string mailHost { get; set; }
        public string mailUsername { get; set; }
        public string mailPassword { get; set; }
        public string mailPort { get; set; }
        public string mailReplyMail { get; set; }
        public float giftCouponRate { get; set; }
    }
}
