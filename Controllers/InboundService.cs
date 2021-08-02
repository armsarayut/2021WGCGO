using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GoWMS.Server.Data;
using GoWMS.Server.Models;
using GoWMS.Server.Models.Inb;
using Microsoft.AspNetCore.Mvc;

namespace GoWMS.Server.Controllers
{
    public class InboundService
    {
        readonly InbDAL objDAL = new InbDAL();

        public List<Inb_Goodreceipt_Go> GetAllInbGoodreceiptGos()
        {
            List<Inb_Goodreceipt_Go> retlist = objDAL.GetAllInbGoodreceiptGo().ToList();
            return retlist;
        }

        public List<Inb_Goodreceive_Go> GetAllInbGoodreceiveGos()
        {
            List<Inb_Goodreceive_Go> retlist = objDAL.GetAllInbGoodreceiveGo().ToList();
            return retlist;
        }

        public List<Inb_Putaway_Go> GetAllInbPutawayGos()
        {
            List<Inb_Putaway_Go> retlist = objDAL.GetAllInbPutawayGo().ToList();
            return retlist;
        }

        public List<Inb_Putaway_Go> GetAllInbPutawayGosByPallet(string pallet)
        {
            List<Inb_Putaway_Go> retlist = objDAL.GetAllInbPutawayGoBypallet(pallet).ToList();
            return retlist;
        }

        public string SetStorageComplete(string pallet, string bin)
        {
            objDAL.SetStorageComplete(pallet, bin);
            return "Map Successfully";
        }
        


    }
}
