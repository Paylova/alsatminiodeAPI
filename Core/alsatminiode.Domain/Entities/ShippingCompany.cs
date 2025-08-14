using alsatminiode.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Domain.Entities
{
    public class ShippingCompany : BaseEntity
    {
        public string companyName { get; set; }
        public string companyDealCode { get; set; }
        public ICollection<ShippingCompanyImageFile> shippingCompanyImageFile { get; set; }
    }
}
