using alsatminiode.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Domain.Entities
{
    public class PhoneModelCapacity : BaseEntity
    {
        public string phoneModelCapacityName { get; set; }
        public int phoneModelCapacityPrice { get; set; }
        public PhoneModel phoneModel { get; set; }
    }
}
