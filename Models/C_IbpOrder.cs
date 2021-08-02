using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoWMS.Server.Models
{
    public class C_IbpOrder
    {
        public string Matcode { get; set; }
        public string Matname { get; set; }
        public string Packid { get; set; }
        public int Qty { get; set; }
        public string Matunit { get; set; }

    }
}
