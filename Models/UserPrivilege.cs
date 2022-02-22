using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoWMS.Server.Models
{
    public class UserPrivilege
    {
        public long? Idx { get; set; }

        public DateTime? Created { get; set; }
        public Int32? Entity_lock { get; set; }
        public DateTime? Modified { get; set; }
        public long? Client_id { get; set; }
        public string Client_ip { get; set; }
        public long? Group_id { get; set; }
        public string Ugdesc { get; set; }
        public string Menu_id { get; set; }
        public string Menu_desc { get; set; }
        public bool? Role_acc { get; set; }
        public bool? Role_add { get; set; }
        public bool? Role_edit { get; set; }
        public bool? Role_del { get; set; }
        public bool? Role_rpt { get; set; }
        public bool? Role_apv { get; set; }

    }
}
