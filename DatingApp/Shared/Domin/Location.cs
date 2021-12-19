using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingApp.Shared.Domin
{
    public class Location
    {
        public int Id { get; set; }

        public virtual User User_Id { get; set; }
        public string Location_Gps { get; set; }
    }
}
