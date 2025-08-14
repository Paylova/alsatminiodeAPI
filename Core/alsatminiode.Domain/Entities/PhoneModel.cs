using alsatminiode.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Domain.Entities
{
    public class PhoneModel : BaseEntity
    {
        public string modelName { get; set; }
        //public bool modelIsActive { get; set; }
        public int modelFirstPrice { get; set; }
        public int modelLastPrice { get; set; }
        public ICollection<PhoneModelImageFile> phoneModelImageFile { get; set; }
        public PhoneBrand modelBrand { get; set; }
    }
}
