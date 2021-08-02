using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoWMS.Server.Models
{
    public class MoUser
    {
        public Int32 Efidx { get; set; }
        public int Efstatus { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public Int32 Innovator { get; set; }
        public string Device { get; set; }
        public Int32 UgId { get; set; }
        public string UsId { get; set; }
        public string UsPass { get; set; }
        public string UsMail { get; set; }
        public string UsAddress { get; set; }
        public string UsFirstname { get; set; }
        public string UsLastname { get; set; }
        public string UsTel { get; set; }
    }


}
