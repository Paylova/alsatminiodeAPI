using alsatminiode.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Domain.Entities
{
    public class District : BaseEntity
    {
        public string districtName { get; set; }
        //public bool districtIsActive { get; set; }
        public City districtCity { get; set; }
        public Country districtCountry { get; set; }
    }
}
