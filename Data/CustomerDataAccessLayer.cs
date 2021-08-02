using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using GoWMS.Server.Controllers;
using GoWMS.Server.Models;



namespace GoWMS.Server.Data
{
    public class CustomerDataAccessLayer
    {
        // string connectionString = "Put Your Connection string here";
        readonly private string connectionString = ConnGlobals.GetConnLocalDB();
        //To View all Customers details    
        public IEnumerable<CustomerInfo> GetAllCustomers()
        {
            
            List<CustomerInfo> lstCustomer = new List<CustomerInfo>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("usp_GetAllCustomers", con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    CustomerInfo Customer = new CustomerInfo
                    {
                        CustomerId = Convert.ToInt32(rdr["CustomerID"]),
                        Name = rdr["Name"].ToString(),
                        Gender = rdr["Gender"].ToString(),
                        Country = rdr["Country"].ToString(),
                        City = rdr["City"].ToString()
                    };
                    lstCustomer.Add(Customer);
                }
                con.Close();
            }
            return lstCustomer;
        }
        //To Add new Customer record    
        public void AddCustomer(CustomerInfo Customer)
        {
            using SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("usp_AddCustomer", con)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@Name", Customer.Name);
            cmd.Parameters.AddWithValue("@Gender", Customer.Gender);
            cmd.Parameters.AddWithValue("@Country", Customer.Country);
            cmd.Parameters.AddWithValue("@City", Customer.City);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        //To Update the records of a particluar Customer  
        public void UpdateCustomer(CustomerInfo Customer)
        {
            using SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("usp_UpdateCustomer", con)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@CustomerId", Customer.CustomerId);
            cmd.Parameters.AddWithValue("@Name", Customer.Name);
            cmd.Parameters.AddWithValue("@Gender", Customer.Gender);
            cmd.Parameters.AddWithValue("@Country", Customer.Country);
            cmd.Parameters.AddWithValue("@City", Customer.City);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }


        public void UpdateCustomerByname(string nm, string ct)
        {
            using SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("usp_UpdateCustomerByName", con)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@Name", nm);
            cmd.Parameters.AddWithValue("@Country", ct);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        //Get the details of a particular Customer  
        public CustomerInfo GetCustomerData(int? id)
        {
            CustomerInfo Customer = new CustomerInfo();

            using (SqlConnection con = new SqlConnection(connectionString))
            {

                SqlCommand cmd = new SqlCommand("usp_GetCustomerByID", con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@CustomerId", id);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Customer.CustomerId = Convert.ToInt32(rdr["CustomerID"]);
                    Customer.Name = rdr["Name"].ToString();
                    Customer.Gender = rdr["Gender"].ToString();
                    Customer.Country = rdr["Country"].ToString();
                    Customer.City = rdr["City"].ToString();
                }
            }
            return Customer;
        }

        public IEnumerable<CustomerInfo> GetCustomerDataName(string nm)
        {
            List<CustomerInfo> lstCustomer = new List<CustomerInfo>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("usp_GetCustomerByName", con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@CustomerName", nm);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    CustomerInfo Customer = new CustomerInfo
                    {
                        CustomerId = Convert.ToInt32(rdr["CustomerID"]),
                        Name = rdr["Name"].ToString(),
                        Gender = rdr["Gender"].ToString(),
                        Country = rdr["Country"].ToString(),
                        City = rdr["City"].ToString()
                    };
                    lstCustomer.Add(Customer);
                }
                con.Close();
            }
            return lstCustomer;
        }

        public IEnumerable<MasterPallet> GetAllMasterpallet()
        {
            List<MasterPallet> lstQurey = new List<MasterPallet>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("Select set_code, cat_no From wcs.set_lpn", con)
                {
                    CommandType = CommandType.Text
                };

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    MasterPallet listRead = new MasterPallet
                    {
                        Lpncode = rdr["set_code"].ToString(),
                        LpnType = Convert.ToInt32(rdr["cat_no"])
                    };
                    lstQurey.Add(listRead);
                }
                con.Close();
            }
            return lstQurey;
        }



        //To Delete the record on a particular Customer  
        public void DeleteCustomer(int? id)
        {
            using SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("usp_DeleteCustomer", con)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@CustomerId", id);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public IEnumerable<ReceivingOrdersInfo> GetAllReceivingOrderss()
        {
            List<ReceivingOrdersInfo> lstReceivingOrders = new List<ReceivingOrdersInfo>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("usp_Get_AllReceiving_Orders", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    ReceivingOrdersInfo GR = new ReceivingOrdersInfo
                    {
                        Package_ID = rdr["Package_ID"].ToString(),
                        Roll_ID = rdr["Roll_ID"].ToString(),
                        Material_Code = rdr["Material_Code"].ToString(),
                        Material_Description = rdr["Material_Description"].ToString(),

                        Receiving_Date = rdr["Receiving_Date"] == DBNull.Value ? null : (DateTime?)rdr["Receiving_Date"],

                        //GR.Receiving_Date = Convert.ToDateTime(rdr["Receiving_Date"]);
                        //GR.GR_Quantity = (decimal)rdr["GR_Quantity"];
                        GR_Quantity = rdr["GR_Quantity"] == DBNull.Value ? null : (decimal?)rdr["GR_Quantity"],

                        Unit = rdr["Unit"].ToString(),
                        //GR.GR_Quantity_KG = (decimal)rdr["GR_Quantity_KG"];
                        GR_Quantity_KG = rdr["GR_Quantity_KG"] == DBNull.Value ? null : (decimal?)rdr["GR_Quantity_KG"],

                        WH_Code = rdr["WH_Code"].ToString(),
                        Warehouse = rdr["Warehouse"].ToString(),
                        Location = rdr["Location"].ToString(),
                        Document_Number = rdr["Document_Number"].ToString(),
                        Job = rdr["Job"].ToString(),
                        Job_Code = rdr["Job_Code"].ToString(),
                        Pallet_Code = rdr["Pallet_Code"].ToString()
                    };
                    lstReceivingOrders.Add(GR);
                }
                con.Close();
            }
            return lstReceivingOrders;
        }


        public void UpdateReceivingOrdersBypack(string pallet, string pack)
        {
            using SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("usp_UpdateReceiving_OrdersBypack", con)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@Pallet", pallet);
            cmd.Parameters.AddWithValue("@Pack", pack);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void CancelReceivingOrdersBypack(string pallet, string pack)
        {
            using SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("usp_CancleReceiving_OrdersBypack", con)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@Pallet", pallet);
            cmd.Parameters.AddWithValue("@Pack", pack);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }


        public IEnumerable<ReceivingOrdersInfo> GetReceivingOrdersbypack(string pack)
        {
            List<ReceivingOrdersInfo> lstReceivingOrders = new List<ReceivingOrdersInfo>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("usp_Get_Receiving_OrdersBypack", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@Id", pack);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    ReceivingOrdersInfo GR = new ReceivingOrdersInfo
                    {
                        Package_ID = rdr["Package_ID"].ToString(),
                        Roll_ID = rdr["Roll_ID"].ToString(),
                        Material_Code = rdr["Material_Code"].ToString(),
                        Material_Description = rdr["Material_Description"].ToString(),
                        Receiving_Date = (DateTime)rdr["Receiving_Date"],
                        GR_Quantity = (decimal)rdr["GR_Quantity"],
                        Unit = rdr["Unit"].ToString(),
                        GR_Quantity_KG = (decimal)rdr["GR_Quantity_KG"],
                        WH_Code = rdr["WH_Code"].ToString(),
                        Warehouse = rdr["Warehouse"].ToString(),
                        Location = rdr["Location"].ToString(),
                        Document_Number = rdr["Document_Number"].ToString(),
                        Job = rdr["Job"].ToString(),
                        Job_Code = rdr["Job_Code"].ToString(),
                        Pallet_Code = rdr["Pallet_Code"].ToString()
                    };
                    lstReceivingOrders.Add(GR);
                }
                con.Close();
            }
            return lstReceivingOrders;
        }

        public IEnumerable<ReceivingOrdersInfo> GetReceivingOrdersbypallet(string pallet)
        {
            List<ReceivingOrdersInfo> lstReceivingOrders = new List<ReceivingOrdersInfo>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("usp_Get_Receiving_OrdersBypallet", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@Id", pallet);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    ReceivingOrdersInfo GR = new ReceivingOrdersInfo
                    {
                        Package_ID = rdr["Package_ID"].ToString(),
                        Roll_ID = rdr["Roll_ID"].ToString(),
                        Material_Code = rdr["Material_Code"].ToString(),
                        Material_Description = rdr["Material_Description"].ToString(),
                        Receiving_Date = (DateTime)rdr["Receiving_Date"],
                        GR_Quantity = (decimal)rdr["GR_Quantity"],
                        Unit = rdr["Unit"].ToString(),
                        GR_Quantity_KG = (decimal)rdr["GR_Quantity_KG"],
                        WH_Code = rdr["WH_Code"].ToString(),
                        Warehouse = rdr["Warehouse"].ToString(),
                        Location = rdr["Location"].ToString(),
                        Document_Number = rdr["Document_Number"].ToString(),
                        Job = rdr["Job"].ToString(),
                        Job_Code = rdr["Job_Code"].ToString(),
                        Pallet_Code = rdr["Pallet_Code"].ToString()
                    };
                    lstReceivingOrders.Add(GR);
                }
                con.Close();
            }
            return lstReceivingOrders;
        }

        public void UpdateReceivingOrdersBypallet(string pallet)
        {
            using SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("usp_UpdateReceiving_OrdersBypallet", con)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@Pallet", pallet);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        //----------------------
        public IEnumerable<RecevingQueueInfo> GetAllReceivingQueue()
        {
            List<RecevingQueueInfo> lstReceivingQueue = new List<RecevingQueueInfo>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.v_wms_tans", con)
                {
                    CommandType = CommandType.Text
                };
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    RecevingQueueInfo GR = new RecevingQueueInfo
                    {
                        Site = rdr["site"].ToString(),
                        Doc_num = rdr["doc_num"].ToString(),
                        Trans_num = rdr["trans_num"] == DBNull.Value ? null : (decimal?)rdr["trans_num"],
                        Ref_type = rdr["ref_type"].ToString(),
                        Trans_type = rdr["ref_type"].ToString(),
                        Trans_date = rdr["trans_date"] == DBNull.Value ? null : (DateTime?)rdr["trans_date"],
                        Unit_key = rdr["unit_key"].ToString(),
                        Item_bc = rdr["item_bc"].ToString(),
                        Prodcode = rdr["prodcode"].ToString(),
                        Proddesc = rdr["proddesc"].ToString(),
                        Item = rdr["item"].ToString(),
                        Itemdesc = rdr["itemdesc"].ToString(),
                        Qty = rdr["qty"] == DBNull.Value ? null : (decimal?)rdr["qty"],
                        Uom = rdr["uom"].ToString(),
                        Prod_date = rdr["prod_date"] == DBNull.Value ? null : (DateTime?)rdr["prod_date"],
                        Stat = rdr["stat"] == DBNull.Value ? null : (Int32?)rdr["stat"],
                        Pallet_bc = rdr["pallet_bc"].ToString(),
                        Reason = rdr["reason"].ToString()
                    };
                    lstReceivingQueue.Add(GR);
                }
                con.Close();
            }
            return lstReceivingQueue;
        }
        //---------------------

        //----------------------
        public IEnumerable<WcsTasWork> GetAllQueueWCS()
        {
            List<WcsTasWork> lstWcsQueue = new List<WcsTasWork>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM wcs.tas_works order by ctime ASC", con)
                {
                    CommandType = CommandType.Text
                };
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    WcsTasWork GR = new WcsTasWork
                    {
                        Idx = rdr["idx"] == DBNull.Value ? null : (Int64?)rdr["idx"],
                        Su_no = rdr["su_no"].ToString(),
                        Lpncode = rdr["lpncode"].ToString(),
                        Work_code = rdr["work_code"].ToString(),
                        Work_status = rdr["work_status"].ToString(),
                        Work_srm = rdr["work_srm"].ToString(),
                        Work_location = rdr["work_location"].ToString(),
                        Work_weight = rdr["work_weight"] == DBNull.Value ? null : (decimal?)rdr["work_weight"],
                        Actual_weight = rdr["actual_weight"] == DBNull.Value ? null : (decimal?)rdr["actual_weight"],
                        Work_size = rdr["work_size"] == DBNull.Value ? null : (Int32?)rdr["work_size"],
                        Actual_size = rdr["actual_size"] == DBNull.Value ? null : (Int32?)rdr["actual_size"],
                        Work_gate = rdr["work_gate"].ToString(),
                        Work_ref = rdr["work_ref"].ToString(),
                        Ctime = rdr["ctime"] == DBNull.Value ? null : (DateTime?)rdr["ctime"],
                        Stime = rdr["stime"] == DBNull.Value ? null : (DateTime?)rdr["stime"],
                        Etime = rdr["etime"] == DBNull.Value ? null : (DateTime?)rdr["etime"],
                        Work_priority = rdr["work_priority"] == DBNull.Value ? null : (Int32?)rdr["work_priority"]
                    };
                    lstWcsQueue.Add(GR);
                }
                con.Close();
            }
            return lstWcsQueue;
        }

        public IEnumerable<WcsTasWork> GetStorageQueueWCS()
        {
            List<WcsTasWork> lstWcsQueue = new List<WcsTasWork>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM wcs.tas_works Where work_code='01' order by ctime ASC", con)
                {
                    CommandType = CommandType.Text
                };
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    WcsTasWork GR = new WcsTasWork
                    {
                        Idx = rdr["idx"] == DBNull.Value ? null : (Int64?)rdr["idx"],
                        Su_no = rdr["su_no"].ToString(),
                        Lpncode = rdr["lpncode"].ToString(),
                        Work_code = rdr["work_code"].ToString(),
                        Work_status = rdr["work_status"].ToString(),
                        Work_srm = rdr["work_srm"].ToString(),
                        Work_location = rdr["work_location"].ToString(),
                        Work_weight = rdr["work_weight"] == DBNull.Value ? null : (decimal?)rdr["work_weight"],
                        Actual_weight = rdr["actual_weight"] == DBNull.Value ? null : (decimal?)rdr["actual_weight"],
                        Work_size = rdr["work_size"] == DBNull.Value ? null : (Int32?)rdr["work_size"],
                        Actual_size = rdr["actual_size"] == DBNull.Value ? null : (Int32?)rdr["actual_size"],
                        Work_gate = rdr["work_gate"].ToString(),
                        Work_ref = rdr["work_ref"].ToString(),
                        Ctime = rdr["ctime"] == DBNull.Value ? null : (DateTime?)rdr["ctime"],
                        Stime = rdr["stime"] == DBNull.Value ? null : (DateTime?)rdr["stime"],
                        Etime = rdr["etime"] == DBNull.Value ? null : (DateTime?)rdr["etime"],
                        Work_priority = rdr["work_priority"] == DBNull.Value ? null : (Int32?)rdr["work_priority"]
                    };
                    lstWcsQueue.Add(GR);
                }
                con.Close();
            }
            return lstWcsQueue;
        }

        public IEnumerable<WcsTasWork> GetRetrivalQueueWCS()
        {
            List<WcsTasWork> lstWcsQueue = new List<WcsTasWork>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM wcs.tas_works Where work_code='05' order by ctime ASC", con)
                {
                    CommandType = CommandType.Text
                };
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    WcsTasWork GR = new WcsTasWork
                    {
                        Idx = rdr["idx"] == DBNull.Value ? null : (Int64?)rdr["idx"],
                        Su_no = rdr["su_no"].ToString(),
                        Lpncode = rdr["lpncode"].ToString(),
                        Work_code = rdr["work_code"].ToString(),
                        Work_status = rdr["work_status"].ToString(),
                        Work_srm = rdr["work_srm"].ToString(),
                        Work_location = rdr["work_location"].ToString(),
                        Work_weight = rdr["work_weight"] == DBNull.Value ? null : (decimal?)rdr["work_weight"],
                        Actual_weight = rdr["actual_weight"] == DBNull.Value ? null : (decimal?)rdr["actual_weight"],
                        Work_size = rdr["work_size"] == DBNull.Value ? null : (Int32?)rdr["work_size"],
                        Actual_size = rdr["actual_size"] == DBNull.Value ? null : (Int32?)rdr["actual_size"],
                        Work_gate = rdr["work_gate"].ToString(),
                        Work_ref = rdr["work_ref"].ToString(),
                        Ctime = rdr["ctime"] == DBNull.Value ? null : (DateTime?)rdr["ctime"],
                        Stime = rdr["stime"] == DBNull.Value ? null : (DateTime?)rdr["stime"],
                        Etime = rdr["etime"] == DBNull.Value ? null : (DateTime?)rdr["etime"],
                        Work_priority = rdr["work_priority"] == DBNull.Value ? null : (Int32?)rdr["work_priority"]
                    };
                    lstWcsQueue.Add(GR);
                }
                con.Close();
            }
            return lstWcsQueue;
        }

        //---------------------




    }
}
