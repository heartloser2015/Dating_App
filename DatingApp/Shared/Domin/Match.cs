using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingApp.Shared.Domin
{
    public class Match
    {
        public int Id { get; set; }

        public virtual User User_Id { get; set; }
        public int unmatch_ID { get; set; }
        public virtual Location location { get; set; }
        public DateTime match_timestamp { get; set; }





    }
}
