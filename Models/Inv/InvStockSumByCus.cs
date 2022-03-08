using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoWMS.Server.Models.Inv
{
    public class InvStockSumByCus
    {
        public string Itemcode { get; set; }
        public string Itemname { get; set; }
        public string Cuscode { get; set; }
        public string Cusname { get; set; }
        public string Palltego { get; set; }
        public string Pallteno { get; set; }
        public string Storagebin { get; set; }
        public decimal? Totalstock { get; set; }
        
       public Int32? StorageLane { get; set; }
        public Int16? StorageBank { get; set; }
        public Int32? StorageBay { get; set; }
        public Int16? StorageLevel { get; set; }

    }
}
