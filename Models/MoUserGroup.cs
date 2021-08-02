using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoWMS.Server.Models
{
    public class MoUserGroup
    {
        public Int32 Efidx { get; set; }
        public int Efstatus { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public Int32 Innovator { get; set; }
        public string Device { get; set; }
        public string UgCode { get; set; }
        public string UsName { get; set; }
    }

}
