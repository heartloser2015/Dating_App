using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingApp.Shared.Domin
{
    public class Notify
    {
        public int Id { get; set; }

        public DateTime Notify_timestamp { get; set; }
        public string Notify_box { get; set; }
        public virtual User User_Id { get; set; }
    }
}
