using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoWMS.Server.Models.Oub
{
    public class Oub_CustomerReturn
    {
        public string Package_id { get; set; }
        public string Material_code { get; set; }
        public string Material_description { get; set; }
        public string Unit { get; set; }
        public string Customer_code { get; set; }
        public Int32? Quantity { get; set; }
        public string Dnno { get; set; }
        public string Lotno { get; set; }
        public string Batchno { get; set; }

        public string Sono { get; set; }
        public string Palletno { get; set; }
        public DateTime? Sodate { get; set; }

    }
}
