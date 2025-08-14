using alsatminiode.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Domain.Entities
{
    public class PhoneBrand : BaseEntity
    {
        public string brandName { get; set; }

        public ICollection<PhoneModel> brandModels { get; set; }

        public ICollection<PhoneBrandImageFile> phoneBrandImageFile { get; set; }
    }
}
