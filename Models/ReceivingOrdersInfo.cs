using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoWMS.Server.Models
{
    public class ReceivingOrdersInfo
    {
        public string Package_ID { get; set; }
        public string Roll_ID { get; set; }
        public string Material_Code { get; set; }
        public string Material_Description { get; set; }
       public DateTime? Receiving_Date { get; set; }
        public decimal? GR_Quantity { get; set; }
        public string Unit { get; set; }
        public decimal? GR_Quantity_KG { get; set; }
        public string WH_Code { get; set; }
        public string Warehouse { get; set; }
        public string Location { get; set; }
        public string Document_Number { get; set; }
        public string Job { get; set; }
        public string Job_Code { get; set; }
        public string Pallet_Code { get; set; }
    }
}
