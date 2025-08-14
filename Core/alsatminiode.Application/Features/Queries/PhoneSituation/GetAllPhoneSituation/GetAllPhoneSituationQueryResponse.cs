using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Features.Queries.PhoneSituation.GetAllPhoneSituation
{
    public class GetAllPhoneSituationQueryResponse
    {
        public int totalCount { get; set; }
        public object phoneSituation { get; set; }
    }
}
