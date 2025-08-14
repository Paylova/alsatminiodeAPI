using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Features.Commands.Customer
{
    public class CreateCustomerCommandRequest : IRequest<CreateCustomerReqeustResponse>
    {
        public string customerName { get; set; }
        public string customerSurname { get; set; }
        public string customerTC { get; set; }
        public DateTime customerBirthDate { get; set; }
        public string customerMail { get; set; }
        public string customerGSM { get; set; }
        public string customerAddress { get; set; }
        public string customerPhoneIMEI { get; set; }
        public string customerIBAN { get; set; }
        public string customerPhoneDescription { get; set; }
        public string customerPaymentChoose { get; set; }
        public string customerReferenceCode { get; set; }
        public int customerTotalCost { get; set; }
        public float customerPhoneCost { get; set; }
        public string phoneBrand { get; set; }
        public string phoneModel { get; set; }

        //public ICollection<PhoneQuestion> customerAnswers { get; set; }
        public string customerCountry { get; set; }
        public string customerCity { get; set; }
        public string customerDistrict { get; set; }
        public string customerPhoneSituation { get; set; }
        public string customerShippingCompanyName { get; set; }
        public string customerRandomPassword { get; set; }
    }
}
