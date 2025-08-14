using alsatminiode.Application.Abstractions.Services.Mesages;
using alsatminiode.Application.Repositories.WebsiteOptionRepo;
using alsatminiode.Application.ViewModels.Email.QueuedEmail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Infrastructure.Services.Mesages
{
    public class MessageService : IMessageService
    {
        readonly IWebsiteOptionReadRepository _websiteOptionReadRepository;

        public MessageService(IWebsiteOptionReadRepository websiteOptionReadRepository)
        {
            _websiteOptionReadRepository = websiteOptionReadRepository;
        }

        public async Task InsertQueuedEmail(QueuedEmail queuedEmail)
        {
            var websiteOption = await _websiteOptionReadRepository.GetSingleAsync(x => x.Id == Guid.Parse("3541C1DF-C61A-4980-BF78-186942C4410C"));


            if (queuedEmail == null)
                throw new ArgumentNullException(nameof(queuedEmail));

            SmtpClient client = new SmtpClient(websiteOption.mailHost, Convert.ToInt32(websiteOption.mailPort));
            MailAddress fromAddress = new MailAddress(websiteOption.mailUsername, "Alsat-miniöde");
            MailAddress toAddress = new MailAddress(queuedEmail.To);
            MailMessage msg = new MailMessage(fromAddress, toAddress);
            msg.Subject = queuedEmail.Subject;
            msg.IsBodyHtml = true;
            msg.Body = queuedEmail.Body;
            //msg.ReplyToList.Add("lovacontact@lova.com");
            NetworkCredential userInfo = new NetworkCredential(websiteOption.mailUsername, websiteOption.mailPassword);
            client.Credentials = userInfo;
            client.EnableSsl = true;
            client.UseDefaultCredentials = true;
            
            try
            {
                client.SendMailAsync(msg).ConfigureAwait(true);
            }
            catch (OverflowException ex)
            {
                throw new Exception("Mail gönderirken bir hata oluştu", ex);
            }
            catch (ArgumentNullException ex)
            {
                throw new Exception("Mail gönderirken bir hata oluştu", ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Mail gönderirken bir hata oluştu", ex);
            }
            finally
            {

            }
        }
    }
}
