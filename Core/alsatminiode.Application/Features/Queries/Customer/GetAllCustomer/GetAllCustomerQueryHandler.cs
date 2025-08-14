using alsatminiode.Application.Repositories.CustomerRepo;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Features.Queries.Customer.GetAllCustomer
{
    public class GetAllCustomerQueryHandler : IRequestHandler<GetAllCustomerQueryRequest, GetAllCustomerQueryResponse>
    {
        readonly ICustomerReadRepository _customerReadRepository;

        public GetAllCustomerQueryHandler(ICustomerReadRepository customerReadRepository)
        {
            _customerReadRepository = customerReadRepository;
        }

        public async Task<GetAllCustomerQueryResponse> Handle(GetAllCustomerQueryRequest request, CancellationToken cancellationToken)
        {
            DateTime CreatedDate = new();
            DateTime UpdatedDate = new();
            var totalCount = _customerReadRepository.GetAll(false).Count();
            var customer = _customerReadRepository.GetAll(false).Skip(request.Page * request.Size).Take(request.Size)
                .OrderByDescending(x => x.CreatedDate)
                .Select(c => new
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
                CreatedDate = c.CreatedDate.ToShortDateString(),
                UpdatedDate = c.UpdatedDate.ToShortDateString()
            });
            return new()
            {
                customer = customer,
                totalCount = totalCount
            };
        }
    }
}
