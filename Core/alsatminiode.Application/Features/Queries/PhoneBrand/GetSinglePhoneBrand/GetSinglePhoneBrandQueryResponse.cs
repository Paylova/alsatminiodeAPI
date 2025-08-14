using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using F = alsatminiode.Domain.Entities;

namespace alsatminiode.Application.Features.Queries.PhoneBrand.GetSinglePhoneBrand
{
    public class GetSinglePhoneBrandQueryResponse
    {
        //public List<F::PhoneModel> phoneModels { get; set; }
        public object phoneBrand { get; set; }
    }
}
