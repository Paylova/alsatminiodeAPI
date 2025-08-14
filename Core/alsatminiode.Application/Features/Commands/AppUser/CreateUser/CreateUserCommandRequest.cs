using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Features.Commands.AppUser.CreateUser
{
    public class CreateUserCommandRequest : IRequest<CreateUserCommandResponse>
    {
        public string adminName { get; set; }
        public string adminSurname { get; set; }
        public string adminUsername { get; set; }
        public string adminPassword { get; set; }
        public string adminGSM { get; set; }
        public string adminEmail { get; set; }
    }
}
