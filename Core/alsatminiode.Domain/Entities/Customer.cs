using alsatminiode.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Domain.Entities
{
    public class Customer : BaseEntity
    {
        public string customerName { get; set; }
        public string customerSurname { get; set; }
        public string customerTC { get; set; }
        //public DateTime customerBirthDate { get; set; }
        public string customerMail { get; set; }
        public string customerGSM { get; set; }
        public string customerAddress { get; set; }
        public string customerPhoneIMEI { get; set; }
        public string customerIBAN { get; set; }
        public string customerPhoneDescription { get; set; }
        public string customerPaymentChoose { get; set; }
        public string customerReferenceCode { get; set; }
        public string customerRandomPassword { get; set; }
        public int customerTotalCost { get; set; }
        public float customerPhoneCost { get; set; }
        public PhoneBrand phoneBrand { get; set; }
        public PhoneModel phoneModel { get; set; }
        //public ICollection<PhoneQuestion> customerAnswers { get; set; }
        public Country customerCountry { get; set; }
        public City customerCity { get; set; }
        public District customerDistrict { get; set; }
        public PhoneSituation customerPhoneSituation { get; set; }
        public ICollection<CustomerInfo> customerInfos { get; set; }
        public string customerShippingCompanyName { get; set; }
        public bool didsendCustomerGSM { get; set; } = false;


    }
}
