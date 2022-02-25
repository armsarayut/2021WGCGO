using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoWMS.Server.Controllers
{
    public class BlazorAppContext
    {
        /// <summary>
        /// The IP for the current session
        /// </summary>
        public string CurrentUserIP { get; set; }

        /// <summary>
        /// The IP for the current session
        /// </summary>
        public long CurrentUserNo { get; set; }

        public long CurrentGroupNo { get; set; }

        public string CurrentUserID { get; set; }
    }
}
