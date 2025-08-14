using alsatminiode.Application.Repositories.AdminRepo;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Features.Queries.Admin.GetAllAdmin
{
    public class GetAllAdminQueryHandler : IRequestHandler<GetAllAdminQueryRequest, GetAllAdminQueryResponse>
    {
        readonly IAdminReadRepository _adminReadRepository;

        public GetAllAdminQueryHandler(IAdminReadRepository adminReadRepository)
        {
            _adminReadRepository = adminReadRepository;
        }

        public async Task<GetAllAdminQueryResponse> Handle(GetAllAdminQueryRequest request, CancellationToken cancellationToken)
        {
            var totalCount = _adminReadRepository.GetAll(false).Count();
            var admin = _adminReadRepository.GetAll(false).Skip(request.Page * request.Size).Take(request.Size).Select(a => new
            {
                a.Id,
                a.adminName,
                a.adminSurname,
                a.adminUsername,
                a.adminPassword,
                a.adminGSM,
                a.adminMail,
                a.CreatedDate,
                a.UpdatedDate
                
            });

            return new()
            {
                admin = admin,
                totalCount = totalCount,
            };
        }
    }
}
