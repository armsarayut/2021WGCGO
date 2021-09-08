using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using GoWMS.Server.Data;
using GoWMS.Server.Models;

namespace GoWMS.Server.Controllers
{
    public class CustomerService 
    {
        readonly CustomerDataAccessLayer objCustomerDAL = new CustomerDataAccessLayer();

        public List<CustomerInfo> GetCustomer()
        {
            List<CustomerInfo> customers = objCustomerDAL.GetAllCustomers().ToList();
            return customers;
        }
        public string Create(CustomerInfo objCustomer)
        {
            objCustomerDAL.AddCustomer(objCustomer);
            return "Added Successfully";
        }

        public CustomerInfo GetCustomerByID(int id)
        {
            CustomerInfo customer = objCustomerDAL.GetCustomerData(id);
            return customer;
        }

        public List<CustomerInfo> GetCustomerByName(string id)
        {

            List<CustomerInfo> customers = objCustomerDAL.GetCustomerDataName(id).ToList();
            return customers;
        }

        public string UpdateCustomer(CustomerInfo objcustomer)
        {
            objCustomerDAL.UpdateCustomer(objcustomer);
            return "Update Successfully";
        }

        public string UpdateCustomerbyName(string nm, string ct)
        {
            objCustomerDAL.UpdateCustomerByname(nm, ct);
            return "Update Successfully";
        }

        public string DeleteCustomer(CustomerInfo objcustomer)
        {
            objCustomerDAL.DeleteCustomer(objcustomer.CustomerId);
            return "Delete Successfully";
        }

        public List<ReceivingOrdersInfo> GetReceivivgOrder()
        {
            List<ReceivingOrdersInfo> receivingOrders = objCustomerDAL.GetAllReceivingOrderss().ToList();
            return receivingOrders;
        }

        public List<ReceivingOrdersInfo> GetReceivingOrdersbypallet(string pallet)
        {

            List<ReceivingOrdersInfo> receivingOrders = objCustomerDAL.GetReceivingOrdersbypallet(pallet).ToList();
            return receivingOrders;
        }

        public string UpdateReceivingOrderbypack(string pallet, string pack)
        {
            objCustomerDAL.UpdateReceivingOrdersBypack(pallet, pack);
            return "Update Successfully";
        }

        public string CancelReceivingOrderbypack(string pallet, string pack)
        {
            objCustomerDAL.CancelReceivingOrdersBypack(pallet, pack);
            return "Cancel Successfully";
        }

        public Boolean CheckReceivingOrdersbypack(string pack)
        {
            bool bret = false;
                if(objCustomerDAL.GetReceivingOrdersbypack(pack).ToList().Count>0)
                {
                    bret = true;
                }
            return bret;
        }

        public string UpdateReceivingOrderbypallet(string pallet)
        {
            objCustomerDAL.UpdateReceivingOrdersBypallet(pallet);
            return "Update Successfully";
        }

        public List<RecevingQueueInfo> GetAllReceivingQueue()
        {
            List<RecevingQueueInfo> receivingQueues = objCustomerDAL.GetAllReceivingQueue().ToList();
            return receivingQueues;
        }

        public List<WcsTasWork> GetAllQueueWCS()
        {
            List<WcsTasWork> wcsQueues = objCustomerDAL.GetAllQueueWCS().ToList();
            return wcsQueues;
        }


        public List<WcsTasWork> GetStorageQueueWCS()
        {
            List<WcsTasWork> wcsQueues = objCustomerDAL.GetStorageQueueWCS().ToList();
            return wcsQueues;
        }

        public List<WcsTasWork> GetRetrivalQueueWCS()
        {
            List<WcsTasWork> wcsQueues = objCustomerDAL.GetRetrivalQueueWCS().ToList();
            return wcsQueues;
        }

        public List<MasterPallet> GetMasterpallet()
        {

            List<MasterPallet> masterpallet = objCustomerDAL.GetAllMasterpallet().ToList();
            return masterpallet;
        }


    }
}
