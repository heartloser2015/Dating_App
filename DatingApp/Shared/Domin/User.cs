using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingApp.Shared.Domin
{
    public class User
    {
        public int Id { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string gender { get; set; }

        public string Birth { get; set; }
        public string Status { get; set; }
        public string GenderP { get; set; }
        public string Location { get; set; }
        public string Like { get; set; }
        public string Superlike { get; set; }
    }
}
