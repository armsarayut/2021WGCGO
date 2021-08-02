using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoWMS.Server.Models.Erp
{
    public class V_Reserved_MaterialsInfo
    {
        public string Package_ID { get; set; }
        public string Roll_ID { get; set; }
        public string Material_Code { get; set; }
        public string Description { get; set; }
        public string WH_Code { get; set; }
        public string Warehouse { get; set; }
        public string Location { get; set; }
        public double? Quantity { get; set; }
        public string Unit { get; set; }
        public string Job { get; set; }
        public string Job_Code { get; set; }
        public string MO_Barcode { get; set; }
    }
}
