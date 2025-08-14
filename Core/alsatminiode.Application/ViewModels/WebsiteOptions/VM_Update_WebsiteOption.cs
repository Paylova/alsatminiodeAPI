using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.ViewModels.WebsiteOptions
{
    public class VM_Update_WebsiteOption
    {
        public string Id { get; set; }
        public string mailHost { get; set; }
        public string mailUsername { get; set; }
        public string mailPassword { get; set; }
        public string mailPort { get; set; }
        public string mailReplyMail { get; set; }
        public float giftCouponRate { get; set; }
        public Byte[] websiteLogo { get; set; }
    }
}
