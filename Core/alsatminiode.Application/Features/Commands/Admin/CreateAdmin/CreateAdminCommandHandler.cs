using alsatminiode.Application.Repositories.AdminRepo;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Features.Commands.Admin.CreateAdmin
{
    public class CreateAdminCommandHandler : IRequestHandler<CreateAdminCommandRequest, CreateAdminCommandResponse>
    {
        readonly IAdminWriteRepository _adminWriteRepository;

        public CreateAdminCommandHandler(IAdminWriteRepository adminWriteRepository)
        {
            _adminWriteRepository = adminWriteRepository;
        }

        public async Task<CreateAdminCommandResponse> Handle(CreateAdminCommandRequest request, CancellationToken cancellationToken)
        {
            await _adminWriteRepository.AddAsync(new()
            {
                adminName = request.adminName,
                adminSurname = request.adminSurname,
                adminUsername=request.adminUsername,
                adminPassword=request.adminPassword,
                adminGSM = request.adminGSM,
                adminMail = request.adminMail,
            });
            await _adminWriteRepository.SaveAsync();
            return new();
        }
    }
}
