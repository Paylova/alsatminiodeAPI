using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Domain.Entities
{
    public class PhoneModelImageFile : File
    {
        public ICollection<PhoneModel> phoneModel { get; set; }
    }
}
