using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Features.Queries.PhoneBrandImageFile.GetAllPhoneBrandImageFile
{
    public class GetPhoneBrandImagesQueryResponse
    {
        public string FilePath { get; set; }
        public string FileName { get; set; }
        public Guid id { get; set; }
    }
}
