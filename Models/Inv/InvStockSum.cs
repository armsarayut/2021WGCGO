﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoWMS.Server.Models.Inv
{
    public class InvStockSum
    {
        public Int64? Rn { get; set; }
        public string Item_code { get; set; }
        public string Item_name { get; set; }
        public Decimal? Totalstock { get; set; }
        public Int64? Countpallet { get; set; }
    }
}
