using alsatminiode.Application.Repositories.CustomerRepo;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Features.Queries.Customer.GetByIdCustomer
{
    public class GetByIdCustomerQueryHandler : IRequestHandler<GetByIdCustomerQueryRequest, GetByIdCustomerQueryResponse>
    {
        readonly ICustomerReadRepository _customerReadRepository;

        public GetByIdCustomerQueryHandler(ICustomerReadRepository customerReadRepository)
        {
            _customerReadRepository = customerReadRepository;
        }

        public async Task<GetByIdCustomerQueryResponse> Handle(GetByIdCustomerQueryRequest request, CancellationToken cancellationToken)
        {
            var customer = _customerReadRepository.GetWhere(x => x.Id == Guid.Parse(request.id)).Select(c => new
            {
                c.Id,
                c.customerName,
                c.customerSurname,
                c.customerTC,
                c.customerMail,
                c.customerGSM,
                c.customerAddress,
                c.customerPhoneIMEI,
                c.customerIBAN,
                c.customerPhoneDescription,
                c.customerPaymentChoose,
                c.customerReferenceCode,
                c.customerTotalCost,
                c.customerPhoneCost,
                c.phoneBrand.brandName,
                c.phoneModel.modelName,
                c.customerCountry.countryName,
                c.customerCity.cityName,
                c.customerDistrict.districtName,
                c.customerPhoneSituation.phoneSituation,
                c.didsendCustomerGSM
            });
            return new()
            {
                customer = customer,
            };
        }
    }
}
