using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.ViewModels.Email.TemplateModel
{
    public class TeklifTemplateModel
    {
        public string customerName { get; set; }
        public string brandName { get; set; }
        public string modelName { get; set; }
        public float customerPhoneCost { get; set; }
        public string customerReferenceCode { get; set; }
        public string arasCode => "190 584 885 1503";
    }
}
