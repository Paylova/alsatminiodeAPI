using alsatminiode.Application.Abstractions.Services.Mesages;
using alsatminiode.Application.ViewModels.Email.Common;
using alsatminiode.Application.ViewModels.Email.TemplateModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Infrastructure.Services.Mesages
{
    public class MessageTemplateService : IMessageTemplateService
    {
        public async Task<string> GetTeklifAsync(TeklifTemplateModel teklifTemplateModel)
        {
            string filePath = @"E:\alsatminiode\alsatminiodeAPI\Infrastructure\alsatminiode.Infrastructure\mailTemplate\Email\TeklifEmail\version_1\index.html";
            var htmlBody = await File.ReadAllTextAsync(filePath);
            var social = new SocialMediaModel();
            htmlBody = htmlBody.Replace("{facebook}", social.facebookAddress);
            htmlBody = htmlBody.Replace("{instagram}", social.instagramAddress);
            htmlBody = htmlBody.Replace("{WhatsApp}", social.whatsappNumber);
            htmlBody = htmlBody.Replace("{name}", teklifTemplateModel.customerName);
            htmlBody = htmlBody.Replace("{marka}", teklifTemplateModel.brandName);
            htmlBody = htmlBody.Replace("{model}", teklifTemplateModel.modelName);
            htmlBody = htmlBody.Replace("{teklif}", teklifTemplateModel.customerPhoneCost.ToString());
            htmlBody = htmlBody.Replace("{referansCode}", teklifTemplateModel.customerReferenceCode);
            htmlBody = htmlBody.Replace("{arasCode}", teklifTemplateModel.arasCode);
            return htmlBody;
        }
    }
}
