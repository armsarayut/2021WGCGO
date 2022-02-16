using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoWMS.Server.Models.Wcs
{
    public class AsrsTaskSummary
    {
        public DateTime? W_date { get; set; }
        public long? W01 { get; set; }
        public long? W101 { get; set; }
        public long? Sumin { get; set; }
        public long? W05 { get; set; }
        public long? W102 { get; set; }
        public long? Sumout { get; set; }
        public long? Wtotal { get; set; }
    }
}
