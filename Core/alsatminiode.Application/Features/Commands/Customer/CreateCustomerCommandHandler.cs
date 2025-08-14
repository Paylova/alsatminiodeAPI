using alsatminiode.Application.Abstractions.Services.Mesages;
using alsatminiode.Application.Repositories.CityRepo;
using alsatminiode.Application.Repositories.CountryRepo;
using alsatminiode.Application.Repositories.CustomerRepo;
using alsatminiode.Application.Repositories.DistrictRepo;
using alsatminiode.Application.Repositories.PhoneBrandRepo;
using alsatminiode.Application.Repositories.PhoneModelRepo;
using alsatminiode.Application.Repositories.PhoneSituationRepo;
using alsatminiode.Application.ViewModels.Email.EmailSendData;
using alsatminiode.Application.ViewModels.Email.QueuedEmail;
using alsatminiode.Application.ViewModels.Email.TemplateModel;
using MediatR;
using F = alsatminiode.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using FF = alsatminiode.Domain.Entities.Customer;

namespace alsatminiode.Application.Features.Commands.Customer
{
    public class CreateCustomerCommandHandler : IRequestHandler<CreateCustomerCommandRequest, CreateCustomerReqeustResponse>
    {
        readonly ICustomerWriteRepository _customerWriteRepository;
        readonly IPhoneBrandReadRepository _phoneBrandReadRepository;
        readonly IPhoneModelReadRepository _phoneModelReadRepository;
        readonly ICountryReadRepository _countryReadRepository;
        readonly ICityReadRepository _cityReadRepository;
        readonly IDistrictReadRepository _districtReadRepository;
        readonly IPhoneSituationReadRepository _phoneSituationReadRepository;
        readonly HttpClient _httpClient;


        public CreateCustomerCommandHandler(ICustomerWriteRepository customerWriteRepository, IPhoneBrandReadRepository phoneBrandReadRepository, IPhoneModelReadRepository phoneModelReadRepository, ICountryReadRepository countryReadRepository, ICityReadRepository cityReadRepository, IDistrictReadRepository districtReadRepository, IPhoneSituationReadRepository phoneSituationReadRepository, HttpClient httpClient)
        {
            _customerWriteRepository = customerWriteRepository;
            _phoneBrandReadRepository = phoneBrandReadRepository;
            _phoneModelReadRepository = phoneModelReadRepository;
            _countryReadRepository = countryReadRepository;
            _cityReadRepository = cityReadRepository;
            _districtReadRepository = districtReadRepository;
            _phoneSituationReadRepository = phoneSituationReadRepository;
            _httpClient = httpClient;
        }

        public async Task<CreateCustomerReqeustResponse> Handle(CreateCustomerCommandRequest request, CancellationToken cancellationToken)
        {

            var phoneBrand = await _phoneBrandReadRepository.GetSingleAsync(x => x.Id == Guid.Parse(request.phoneBrand));
            var phoneModel = await _phoneModelReadRepository.GetSingleAsync(x => x.Id == Guid.Parse(request.phoneModel));
            var customerCountry = await _countryReadRepository.GetSingleAsync(x => x.Id == Guid.Parse(request.customerCountry));
            var customerCity = await _cityReadRepository.GetSingleAsync(x => x.Id == Guid.Parse(request.customerCity));
            var customerDistrict = await _districtReadRepository.GetSingleAsync(x => x.Id == Guid.Parse(request.customerDistrict));
            var customerPhoneSituation = await _phoneSituationReadRepository.GetSingleAsync(x => x.Id == Guid.Parse(request.customerPhoneSituation));


            var customer = new F::Customer
            {
                customerName = request.customerName,
                customerSurname = request.customerSurname,
                customerTC = request.customerTC,
                //customerBirthDate = request.customerBirthDate,
                customerMail = request.customerMail,
                customerGSM = request.customerGSM,
                customerAddress = request.customerAddress,
                customerPhoneIMEI = request.customerPhoneIMEI,
                customerIBAN = request.customerIBAN,
                customerPhoneDescription = request.customerPhoneDescription,
                customerPaymentChoose = request.customerPaymentChoose,
                customerReferenceCode = request.customerReferenceCode,
                customerTotalCost = request.customerTotalCost,
                customerPhoneCost = request.customerPhoneCost,
                phoneBrand = phoneBrand,
                phoneModel = phoneModel,
                customerCountry = customerCountry,
                customerCity = customerCity,
                customerDistrict = customerDistrict,
                customerPhoneSituation = customerPhoneSituation,
                customerShippingCompanyName = request.customerShippingCompanyName,
                customerRandomPassword = request.customerRandomPassword
            };
            string gsm;
            gsm = request.customerGSM;
            gsm = gsm.Replace("(", "");
            gsm = gsm.Replace(")", "");
            gsm = gsm.Replace(" ", "");
            gsm = gsm.Replace("-", "");
            await _httpClient.GetStringAsync($"https://api.netgsm.com.tr/sms/send/get?usercode=8503089920&password=n3-74761&gsmno={gsm}&message={"Merhaba " + request.customerName + " cihazın için ön teklif kaydı oluşturuldu. Referans kodun : " + request.customerReferenceCode}&msgheader=EMPEROR&dil=TR");
            await _customerWriteRepository.AddAsync(customer);
            await _customerWriteRepository.SaveAsync();


            return new()
            {
                customerId = customer.Id.ToString()
            };
        }



    }
}
