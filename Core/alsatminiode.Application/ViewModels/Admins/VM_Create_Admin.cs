using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.ViewModels.Admins
{
    public class VM_Create_Admin
    {
        public string adminName { get; set; }
        public string adminSurname { get; set; }
        public string adminUsername { get; set; }
        public string adminPassword { get; set; }
        public string adminGSM { get; set; }
        public string adminMail { get; set; }
        public bool isAdmin { get; set; }
    }
}
