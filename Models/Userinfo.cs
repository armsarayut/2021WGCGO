using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoWMS.Server.Models
{
    public class Userinfo
    {
        public long? Usid { get; set; }
        public string Usname { get; set; }

        public string Uspass { get; set; }
        public long? Usgid { get; set; }
        public string Usgrp { get; set; }
        public DateTime? Dtlogon { get; set; }
        public string Usgridcolor { get; set; }
        public long? Depid { get; set; }
        public string Depname { get; set; }
    }
}
