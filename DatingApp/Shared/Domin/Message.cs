using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingApp.Shared.Domin
{
    public class Message
    {
        public int Id { get; set; }
        public string Message_content { get; set; }
        public DateTime Message_timestamp { get; set; }
        public string Message_read { get; set; }
        public virtual Match Match_Id { get; set; }

       
    }
}
