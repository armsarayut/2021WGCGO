using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GoWMS.Server.Data;
using GoWMS.Server.Models;
using GoWMS.Server.Models.Wgc;
using Microsoft.AspNetCore.Mvc;

namespace GoWMS.Server.Controllers
{
    public class WgcService
    {
        readonly WgcDAL objDAL = new WgcDAL();

        public  Task<IEnumerable<BOOKING_NOTE_ITEMS>> GetAllApiBookingnoteWgc()
        {
           
            return objDAL.GetAllApiNewBooking_note();
        }

        public Task<IEnumerable<DELIVERY_NOTE_ITEMS>> GetAllApiDeliverynoteWgc()
        {

            return objDAL.GetAllApiNewDelivery_note();
        }

        public Task<IEnumerable<CUSTOMERS>> GetAllApiCustomerWgc()
        {

            return objDAL.GetAllApiAllCustomer();
        }

        public Task<IEnumerable<ITEMS>> GetAllApiItemWgc()
        {

            return objDAL.GetAllApiAllItem();
        }

        public Task<IEnumerable<PACKETINGS>> GetAllApiPackeingWgc()
        {

            return objDAL.GetAllApiAllPackeing();
        }


    }
}
