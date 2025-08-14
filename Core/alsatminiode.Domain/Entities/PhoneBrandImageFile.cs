using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Domain.Entities
{
    public class PhoneBrandImageFile : File
    {
        public ICollection<PhoneBrand> phoneBrand { get; set; }
    }
}
