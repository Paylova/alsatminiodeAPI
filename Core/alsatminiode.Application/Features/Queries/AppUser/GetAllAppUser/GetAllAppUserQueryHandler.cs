using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using F = alsatminiode.Domain.Entities.Identity;

namespace alsatminiode.Application.Features.Queries.AppUser.GetAllAppUser
{
    public class GetAllAppUserQueryHandler : IRequestHandler<GetAllAppUserQueryRequest, GetAllAppUserQueryResponse>
    {
        readonly UserManager<F::AppUser> _userManager;

        public GetAllAppUserQueryHandler(UserManager<F.AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<GetAllAppUserQueryResponse> Handle(GetAllAppUserQueryRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
