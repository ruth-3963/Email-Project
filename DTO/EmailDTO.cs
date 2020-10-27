using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DTO
{
    public class EmailDTO
    {
        public int id_mail { get; set; }
        public string senter { get; set; }
        public string reciever { get; set; }
        public string subject { get; set; }
        public string context { get; set; }
        public DateTime sent_date { get; set; }
        public bool is_read { get; set; }

        public UserDTO user { get; set; }


    }
}
