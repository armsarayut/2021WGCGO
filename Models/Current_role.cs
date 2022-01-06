using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoWMS.Server.Models
{
    public class Current_role
    {
        public Boolean? Role_acc { get; set; }
        public Boolean? Role_add { get; set; }
        public Boolean? Role_edit { get; set; }
        public Boolean? Role_del { get; set; }
        public Boolean? Role_rpt { get; set; }
        public Boolean? Role_apv { get; set; }

    }
}
