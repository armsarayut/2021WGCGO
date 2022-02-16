using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoWMS.Server.Models.Wcs
{
    public class AsrsPerformance
    {
        public string Mccode { get; set; }
        public Int32? Inbound { get; set; }
        public Int32? Outbound { get; set; }
        public Int32? Total { get; set; }
    }
}
