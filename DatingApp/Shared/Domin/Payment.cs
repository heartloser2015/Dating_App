using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingApp.Shared.Domin
{
    public class Payment
    {
        public int Id { get; set; }
        public int Payment_total { get; set; }
       
        public virtual User User_Id { get; set; }
    }
}
