using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.NetworkInformation;

namespace GoWMS.Server.Controllers
{
    public class UtilityServices
    {
        public async Task<bool> PingAsync(string hostUrl)
        {
            //var hostUrl = "www.code4it.dev";

            Ping ping = new Ping();

            PingReply result = await ping.SendPingAsync(hostUrl, 15);
            return result.Status == IPStatus.Success;
        }

    }
}
