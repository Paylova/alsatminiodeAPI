using alsatminiode.Application.Repositories.AdminRepo;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Features.Commands.Admin.UpdateAdmin
{
    public class UpdateAdminCommandHandler : IRequestHandler<UpdateAdminCommandRequest, UpdateAdminCommandResponse>
    {
        readonly IAdminReadRepository _adminReadRepository;
        readonly IAdminWriteRepository _adminWriteRepository;

        public UpdateAdminCommandHandler(IAdminReadRepository adminReadRepository, IAdminWriteRepository adminWriteRepository)
        {
            _adminReadRepository = adminReadRepository;
            _adminWriteRepository = adminWriteRepository;
        }

        public async Task<UpdateAdminCommandResponse> Handle(UpdateAdminCommandRequest request, CancellationToken cancellationToken)
        {
            alsatminiode.Domain.Entities.Admin admin = await _adminReadRepository.GetByIdAsync(request.id);
            admin.adminName = request.adminName;
            admin.adminSurname = request.adminSurname;
            admin.adminUsername = request.adminUsername;
            admin.adminPassword = request.adminPassword;
            admin.adminGSM = request.adminGSM;
            admin.adminMail = request.adminMail;
            await _adminWriteRepository.SaveAsync();

            return new();
        }
    }
}
