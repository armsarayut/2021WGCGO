using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoWMS.Server.Models
{
    public class RecevingQueueInfo
    {
        public string Site { get; set; }
        public string Doc_num { get; set; }
        public decimal? Trans_num { get; set; }
        public string Ref_type { get; set; }
        public string Trans_type { get; set; }
        public DateTime? Trans_date { get; set; }
        public string Unit_key { get; set; }
        public string Item_bc { get; set; }
        public string Prodcode { get; set; }
        public string Proddesc { get; set; }
        public string Item { get; set; }
        public string Itemdesc { get; set; }
        public decimal? Qty { get; set; }
        public string Uom { get; set; }
        public DateTime? Prod_date { get; set; }
        public Int32? Stat { get; set; }
        public string Pallet_bc  { get; set; }
        public string Reason { get; set; }

    }
}
