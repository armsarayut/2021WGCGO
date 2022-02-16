using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoWMS.Server.Models.Rpt
{
    public class RptAudittrial
    {
        public long Idx { get; set; }
        public DateTime Created { get; set; }
        public Int32 Entity_lock { get; set; }
        public DateTime Modified { get; set; }
        public long Client_id { get; set; }
        public string Menu_name { get; set; }
        public string Action_desc { get; set; }
        public string Usid { get; set; }
        public string Client_ip { get; set; }
    }
}
