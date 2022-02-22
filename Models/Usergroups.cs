using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoWMS.Server.Models
{
    public class Usergroups
    {
        //idx, created, entity_lock, modified, client_id, client_ip, ugdesc
        public long? Idx { get; set; }
        public DateTime? Created { get; set; }
        public Int32? Entity_lock { get; set; }
        public DateTime? Modified { get; set; }
        public long? Client_id { get; set; }
        public string Client_ip { get; set; }
        public string Ugdesc { get; set; }
    }
}
