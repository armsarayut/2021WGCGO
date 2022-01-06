using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GoWMS.Server.Data;
using GoWMS.Server.Models;
using GoWMS.Server.Models.Wgc;
using Microsoft.AspNetCore.Mvc;
using GoWMS.Server.Models.Api;

namespace GoWMS.Server.Controllers
{
    public class WgcService
    {
        readonly WgcDAL objDAL = new WgcDAL();

        public  Task<IEnumerable<BOOKING_NOTE_ITEMS>> GetAllApiBookingnoteWgc()
        {
           
            return objDAL.GetAllApiBooking_note();
        }

        public Task<IEnumerable<BOOKING_NOTE_ITEMS>> GetAllApiNewBookingnoteWgc()
        {

            return objDAL.GetAllApiNewBooking_note();
        }

        public Task<IEnumerable<BOOKING_NOTE_ITEMS>> GetPalletApiNewBookingnoteWgc(string pallet)
        {

            return objDAL.GetPalletApiNewBooking_note(pallet);
        }

        public Task<IEnumerable<DELIVERY_NOTE_ITEMS>> GetAllApiDeliverynoteWgc()
        {

            return objDAL.GetAllApiDelivery_note();
        }

        public Task<IEnumerable<DELIVERY_NOTE_ITEMS>> GetAllApiNewDeliverynoteWgc()
        {

            return objDAL.GetAllApiNewDelivery_note();
        }

        public Task<IEnumerable<DELIVERY_NOTE_ITEMS>> GetPalletApiNewDeliverynoteWgc(string pallet)
        {

            return objDAL.GetPalletApiNewDelivery_note(pallet);
        }

        public List<Api_Receivingorders_Go> GetMapPalletApiNewDelivery_note(string pallet)
        {

            return objDAL.GetMapPalletApiNewDelivery_note(pallet).ToList();
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

        public string UpdatePalletNewDelivery_note(string pallet)
        {
            objDAL.UpdateNewDelivery_note(pallet);
            return "Update Successfully";
        }

        public Task<Int64> GetSumOrderAllApiNewDelivery_note()
        {
            return objDAL.GetSumOrderAllApiNewDelivery_note();
        }
        public Task<Int64> GetSumPalletAllApiNewDelivery_note()
        {
            return objDAL.GetSumPalletAllApiNewDelivery_note();
        }


        public async Task<string> UpdateNewBooking_notebylist(List<BOOKING_NOTE_ITEMS> listOrder)
        {
            await objDAL.UpdateNewBooking_notebylist(listOrder);
            return "Update Successfully";
        }

    }
}
