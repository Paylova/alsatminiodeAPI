using alsatminiode.Application.Repositories.CustomerRepo;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Features.Commands.Customer.SendGSM
{
    public class SendGsmCustomerCommandHandler : IRequestHandler<SendGsmCustomerCommandRequest, SendGsmCustomerCommandResponse>
    {
        ICustomerReadRepository _customerReadRepository;
        ICustomerWriteRepository _customerWriteRepository;
        readonly HttpClient _httpClient;

        public SendGsmCustomerCommandHandler(ICustomerReadRepository customerReadRepository, ICustomerWriteRepository customerWriteRepository, HttpClient httpClient)
        {
            _customerReadRepository = customerReadRepository;
            _customerWriteRepository = customerWriteRepository;
            _httpClient = httpClient;
        }

        public async Task<SendGsmCustomerCommandResponse> Handle(SendGsmCustomerCommandRequest request, CancellationToken cancellationToken)
        {
            alsatminiode.Domain.Entities.Customer customer = await _customerReadRepository.GetByIdAsync(request.id);
            customer.didsendCustomerGSM = request.didsendCustomerGSM;

            string gsm;
            gsm = request.customerGSM;
            gsm = gsm.Replace("(", "");
            gsm = gsm.Replace(")", "");
            gsm = gsm.Replace(" ", "");
            gsm = gsm.Replace("-", "");
            await _httpClient.GetStringAsync($"https://api.netgsm.com.tr/sms/send/get?usercode=8503089920&password=n3-74761&gsmno={gsm}&message={"Merhaba " + request.customerName + " cihazın elimize ulaştı. Şimdi inceleme işlemindeyiz sana en yakın zamanda son teklifi SMS olarak veya arayacak bilgilendireceğiz."}&msgheader=EMPEROR&dil=TR");

            await _customerWriteRepository.SaveAsync();
            return new();
        }
    }
}
