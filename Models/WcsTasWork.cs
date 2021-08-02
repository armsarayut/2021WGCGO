using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoWMS.Server.Models
{
    public class WcsTasWork
    {
        public Int64? Idx { get; set; }
        public string Su_no { get; set; }
        public string Lpncode { get; set; }
        public string Work_code { get; set; }
        public string Work_status { get; set; }
        public string Work_srm { get; set; }
        public string Work_location { get; set; }
        public decimal? Work_weight { get; set; }
        public decimal? Actual_weight { get; set; }
        public Int32? Work_size { get; set; }
        public Int32? Actual_size { get; set; }
        public string Work_gate { get; set; }
        public string Work_ref { get; set; }
        public DateTime? Ctime { get; set; }
        public DateTime? Stime { get; set; }
        public DateTime? Etime { get; set; }
        public Int32? Work_priority { get; set; }
    }
}
