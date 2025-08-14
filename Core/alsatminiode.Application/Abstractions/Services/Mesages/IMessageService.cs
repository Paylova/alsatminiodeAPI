using alsatminiode.Application.ViewModels.Email.QueuedEmail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Abstractions.Services.Mesages
{
    public interface IMessageService
    {
        Task InsertQueuedEmail(QueuedEmail queuedEmail);
    }
}
