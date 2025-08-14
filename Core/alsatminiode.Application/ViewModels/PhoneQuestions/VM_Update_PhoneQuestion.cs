using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.ViewModels.PhoneQuestions
{
    public class VM_Update_PhoneQuestion
    {
        public string Id { get; set; }
        public string QuestionText { get; set; }
        public long LowPrice { get; set; }
        public long HighPrice { get; set; }
    }
}
