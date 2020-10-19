using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class UserDTO
    {
        public long id_user { get; set; }
        public string user_name { get; set; }
        public string user_passward { get; set; }
        public string user_email_address { get; set; }
    }
}
