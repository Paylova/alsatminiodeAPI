using alsatminiode.Application.ViewModels.Email.TemplateModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Abstractions.Services.Mesages
{
    public interface IMessageTemplateService
    {
        Task<string> GetTeklifAsync(TeklifTemplateModel teklifTemplateModel);
    }
}
