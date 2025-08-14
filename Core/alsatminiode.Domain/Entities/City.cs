using alsatminiode.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Domain.Entities
{
    public class City : BaseEntity
    {
        public string cityName { get; set; }
        //public bool cityIsActive { get; set; }
        public Country cityCountry { get; set; }
        public ICollection<District> cityDistricts { get; set; }

    }
}
