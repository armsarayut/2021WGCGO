using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoWMS.Server.Models.Erp
{
    public class V_List_OF_Materials_NeedsInfo
    {
        public string Customer { get; set; }
        public string Customer_Name {get; set;}
        public string Finished_Product { get; set; }
        public string Finished_Product_Description { get; set; }
        public string Material_Code { get; set; }
        public string Description { get; set; }
        public string Element { get; set; }
        public double? Quantity { get; set; }
        public string Unit { get; set; }
        public string Job { get; set; }
        public string Job_Code { get; set; }
        public string MO_Barcode { get; set; }
    }
}
