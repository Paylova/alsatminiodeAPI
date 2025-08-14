using alsatminiode.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Domain.Entities
{
    public class CustomerInfo : BaseEntity
    {
        public string reviewOffer { get; set; } = "0";
        public string rewierDescription { get; set; } = string.Empty;
        public bool isItApproved { get; set; } = false;
        public ShippingCompany? shippingCompany { get; set; }
        public string trackingNumber { get; set; } = string.Empty;
        public Customer customer { get; set; }
    }
}
