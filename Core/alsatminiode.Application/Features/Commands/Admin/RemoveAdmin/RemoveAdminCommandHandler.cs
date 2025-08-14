using alsatminiode.Application.Repositories.AdminRepo;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Features.Commands.Admin.RemoveAdmin
{
    public class RemoveAdminCommandHandler : IRequestHandler<RemoveAdminCommandRequest, RemoveAdminCommandResponse>
    {
        readonly IAdminWriteRepository _adminWriteRepository;

        public RemoveAdminCommandHandler(IAdminWriteRepository adminWriteRepository)
        {
            _adminWriteRepository = adminWriteRepository;
        }

        public async Task<RemoveAdminCommandResponse> Handle(RemoveAdminCommandRequest request, CancellationToken cancellationToken)
        {
            await _adminWriteRepository.RemoveAsync(request.id);
            await _adminWriteRepository.SaveAsync();
            return new();
        }
    }
}
