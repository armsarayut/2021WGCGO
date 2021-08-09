using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoWMS.Server.Models.Das
{
    public class DasLocation
    {
        public Int32 Lane { get; set; }
        public Int32 Total { get; set; }
        public Int32 Use { get; set; }
        public Int32 Empty { get; set; }
    }
}
