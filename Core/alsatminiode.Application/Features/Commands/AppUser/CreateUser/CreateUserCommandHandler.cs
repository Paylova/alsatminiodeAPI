using alsatminiode.Application.Exceptions;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using F=alsatminiode.Domain.Entities.Identity;

namespace alsatminiode.Application.Features.Commands.AppUser.CreateUser
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommandRequest, CreateUserCommandResponse>
    {
        readonly UserManager<F::AppUser> _userManager;

        public CreateUserCommandHandler(UserManager<F.AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<CreateUserCommandResponse> Handle(CreateUserCommandRequest request, CancellationToken cancellationToken)
        {
            IdentityResult result =  await _userManager.CreateAsync(new()
            {
                Id = Guid.NewGuid().ToString(),
                UserName = request.adminUsername,
                Email = request.adminEmail,
                adminName = request.adminName,
                adminSurname = request.adminSurname,
                PhoneNumber = request.adminGSM


            }, request.adminPassword);
            CreateUserCommandResponse response = new()
            {
                Succeeded = result.Succeeded
            };
            if (result.Succeeded)
            {
                response.Message = "Kullanıcı başarıyla oluşturulmuştur.";
            }
            else
            {
                foreach (var error in result.Errors)
                {
                    response.Message += $"{error.Code} - {error.Description} <br>";
                }
                
            }
            return response;
            

                
           // throw new UserCreateFailedException();
        }
        
    }
}
