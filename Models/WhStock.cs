using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoWMS.Server.Models
{
    public class WhStock
    {
        public long Rn { get; set; }
        public string Brand { get; set; }
        public string Batchnumber { get; set; }
        public string Itemcode { get; set; }
        public string Itemname { get; set; }
        public decimal Totalstock { get; set; }
        public decimal Countpallet { get; set; }
    }
}
