using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoWMS.Server.Models
{
    public class Helpdesk
    {
        public long? Idx { get; set; }
        public DateTime? Created { get; set; }
        public int? Entity_lock { get; set; }
        public DateTime? Modified { get; set; }
        public long? Client_id { get; set; }
        public string Client_ip { get; set; }
        public string Hlp_name { get; set; }
        public string Hlp_desc { get; set; }
        public string Hlp_tel { get; set; }
        public string Hlp_mail { get; set; }
    }
}
