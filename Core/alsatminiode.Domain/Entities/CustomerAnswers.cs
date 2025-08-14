using alsatminiode.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Domain.Entities
{
    public class CustomerAnswers : BaseEntity
    {
        public Customer customer { get; set; }
        public PhoneCost phoneCost { get; set; }
    }
}
