using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GoWMS.Server.Data;
using GoWMS.Server.Models;


namespace GoWMS.Server.Controllers
{
    public class UserServices
    {
        readonly UserDAL objDAL = new UserDAL();

         public List<Userinfo> GetUser(string uusname, string uspass)
        {
            List<Userinfo> retlist = objDAL.GetUser(uusname, uspass).ToList();
            return retlist;
        }

        public List<Userroleinfo> GetUserRole(string menu_desc, long group_id)
        {
            List<Userroleinfo> retlist = objDAL.GetUserRole(menu_desc, group_id).ToList();
            return retlist;
        }


    }
}
