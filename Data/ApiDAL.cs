using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using Npgsql;
using System.Linq;
using System.Threading.Tasks;
using GoWMS.Server.Controllers;
using GoWMS.Server.Models;
using GoWMS.Server.Models.Api;
using NpgsqlTypes;
using System.Text;

namespace GoWMS.Server.Data
{
    public class ApiDAL
    {
        readonly private string connectionString = ConnGlobals.GetConnLocalDBPG();

        public IEnumerable<Api_Cylinder_Go> GetAllApiCylinderGo()
        {
            List<Api_Cylinder_Go> lstobj = new List<Api_Cylinder_Go>();
            using (NpgsqlConnection con = new NpgsqlConnection(connectionString))
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("select * ");
                sql.AppendLine("from wms.api_cylinder_go");
                sql.AppendLine("order by efidx");
                NpgsqlCommand cmd = new NpgsqlCommand(sql.ToString(), con)
                {
                    CommandType = CommandType.Text
                };
                con.Open();
                NpgsqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Api_Cylinder_Go objrd = new Api_Cylinder_Go
                    {
                        Efidx = rdr["efidx"] == DBNull.Value ? null : (Int64?)rdr["efidx"],
                        Efstatus = rdr["efstatus"] == DBNull.Value ? null : (Int32?)rdr["efstatus"],
                        Created = rdr["created"] == DBNull.Value ? null : (DateTime?)rdr["created"],
                        Modified = rdr["modified"] == DBNull.Value ? null : (DateTime?)rdr["modified"],
                        Innovator = rdr["innovator"] == DBNull.Value ? null : (Int64?)rdr["innovator"],
                        Device = rdr["device"].ToString(),
                        Material_Code = rdr["material_code"].ToString(),
                        Material_Description = rdr["material_description"].ToString(),
                        Customer_Code = rdr["customer_code"].ToString(),
                        Customer_Description = rdr["customer_description"].ToString(),
                        Customer_Reference = rdr["customer_reference"].ToString(),
                        Color1 = rdr["color1"].ToString(),
                        Cylinder1 = rdr["cylinder1"].ToString(),
                        Color2 = rdr["color2"].ToString(),
                        Cylinder2 = rdr["cylinder2"].ToString(),
                        Color3 = rdr["color3"].ToString(),
                        Cylinder3 = rdr["cylinder3"].ToString(),
                        Color4 = rdr["color4"].ToString(),
                        Cylinder4 = rdr["cylinder4"].ToString(),
                        Color5 = rdr["color5"].ToString(),
                        Cylinder5 = rdr["cylinder5"].ToString(),
                        Color6 = rdr["color6"].ToString(),
                        Cylinder6 = rdr["cylinder6"].ToString(),
                        Color7 = rdr["color7"].ToString(),
                        Cylinder7 = rdr["cylinder7"].ToString(),
                        Color8 = rdr["color8"].ToString(),
                        Cylinder8 = rdr["cylinder8"].ToString(),
                        Color9 = rdr["color9"].ToString(),
                        Cylinder9 = rdr["cylinder9"].ToString(),
                        Color10 = rdr["color10"].ToString(),
                        Cylinder10 = rdr["cylinder10"].ToString()
                    };
                    lstobj.Add(objrd);
                }
                con.Close();
            }
            return lstobj;
        }


        public IEnumerable<Api_Itemmaster_Go> GetAllApiItemmasterGo()
        {
            List<Api_Itemmaster_Go> lstobj = new List<Api_Itemmaster_Go>();
            using (NpgsqlConnection con = new NpgsqlConnection(connectionString))
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("select * ");
                sql.AppendLine("from wms.api_itemmaster_go");
                sql.AppendLine("order by efidx");
                NpgsqlCommand cmd = new NpgsqlCommand(sql.ToString(), con)
                {
                    CommandType = CommandType.Text
                };

                con.Open();
                NpgsqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Api_Itemmaster_Go objrd = new Api_Itemmaster_Go
                    {
                        Efidx = rdr["efidx"] == DBNull.Value ? null : (Int64?)rdr["efidx"],
                        Efstatus = rdr["efstatus"] == DBNull.Value ? null : (Int32?)rdr["efstatus"],
                        Created = rdr["created"] == DBNull.Value ? null : (DateTime?)rdr["created"],
                        Modified = rdr["modified"] == DBNull.Value ? null : (DateTime?)rdr["modified"],
                        Innovator = rdr["innovator"] == DBNull.Value ? null : (Int64?)rdr["innovator"],
                        Device = rdr["device"].ToString(),
                        Itemcode = rdr["itemcode"].ToString()
                    };
                    lstobj.Add(objrd);
                }
                con.Close();
            }
            return lstobj;
        }

        public IEnumerable<Api_Listofmaterialsneeds_Go> GetAllApiListofNeedGo()
        {
            List<Api_Listofmaterialsneeds_Go> lstobj = new List<Api_Listofmaterialsneeds_Go>();
            using (NpgsqlConnection con = new NpgsqlConnection(connectionString))
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("select * ");
                sql.AppendLine("from wms.api_listofmaterialsneeds_go");
                sql.AppendLine("order by efidx");
                NpgsqlCommand cmd = new NpgsqlCommand(sql.ToString(), con)
                {
                    CommandType = CommandType.Text
                };

                con.Open();
                NpgsqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Api_Listofmaterialsneeds_Go objrd = new Api_Listofmaterialsneeds_Go
                    {
                        Efidx = rdr["efidx"] == DBNull.Value ? null : (Int64?)rdr["efidx"],
                        Efstatus = rdr["efstatus"] == DBNull.Value ? null : (Int32?)rdr["efstatus"],
                        Created = rdr["created"] == DBNull.Value ? null : (DateTime?)rdr["created"],
                        Modified = rdr["modified"] == DBNull.Value ? null : (DateTime?)rdr["modified"],
                        Innovator = rdr["innovator"] == DBNull.Value ? null : (Int64?)rdr["innovator"],
                        Device = rdr["device"].ToString(),
                        Customer_Code = rdr["customer_code"].ToString(),
                        Customer_Description = rdr["customer_description"].ToString(),
                        Finished_Product = rdr["finished_product"].ToString(),
                        Finished_Product_Description = rdr["finished_product_description"].ToString(),
                        Material_Code = rdr["material_code"].ToString(),
                        Material_Description = rdr["material_description"].ToString(),
                        Matelement = rdr["matelement"].ToString(),
                        Quantity = rdr["quantity"] == DBNull.Value ? null : (decimal?)rdr["quantity"],
                        Unit = rdr["unit"].ToString(),
                        Job = rdr["job"].ToString(),
                        Mo_Barcode = rdr["mo_Barcode"].ToString()
                    };
                    lstobj.Add(objrd);
                }
                con.Close();
            }
            return lstobj;
        }

        public IEnumerable<Api_Receivingorders_Go> GetAllApiRecevingorderGo()
        {
            List<Api_Receivingorders_Go> lstobj = new List<Api_Receivingorders_Go>();
            using (NpgsqlConnection con = new NpgsqlConnection(connectionString))
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("select * ");
                sql.AppendLine("from wms.api_receivingorders_go");
                sql.AppendLine("order by efidx");
                NpgsqlCommand cmd = new NpgsqlCommand(sql.ToString(), con)
                {
                    CommandType = CommandType.Text
                };

                con.Open();
                NpgsqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Api_Receivingorders_Go objrd = new Api_Receivingorders_Go
                    {
                        Efidx = rdr["efidx"] == DBNull.Value ? null : (Int64?)rdr["efidx"],
                        Efstatus = rdr["efstatus"] == DBNull.Value ? null : (Int32?)rdr["efstatus"],
                        Created = rdr["created"] == DBNull.Value ? null : (DateTime?)rdr["created"],
                        Modified = rdr["modified"] == DBNull.Value ? null : (DateTime?)rdr["modified"],
                        Innovator = rdr["innovator"] == DBNull.Value ? null : (Int64?)rdr["innovator"],
                        Device = rdr["device"].ToString(),
                        Package_Id = rdr["package_id"].ToString(),
                        Roll_Id = rdr["roll_id"].ToString(),
                        Material_Code = rdr["material_code"].ToString(),
                        Material_Description = rdr["material_description"].ToString(),
                        Receiving_Date = rdr["receiving_Date"] == DBNull.Value ? null : (DateTime?)rdr["receiving_Date"],
                        Gr_Quantity = rdr["gr_quantity"] == DBNull.Value ? null : (decimal?)rdr["gr_quantity"],
                        Unit = rdr["unit"].ToString(),
                        Gr_Quantity_Kg = rdr["gr_quantity_kg"] == DBNull.Value ? null : (decimal?)rdr["gr_quantity_kg"],
                        Wh_Code = rdr["wh_code"].ToString(),
                        Warehouse = rdr["warehouse"].ToString(),
                        Locationno = rdr["locationno"].ToString(),
                        Document_Number = rdr["document_number"].ToString(),
                        Job = rdr["job"].ToString(),
                        Job_Code = rdr["job_code"].ToString(),
                        Lpncode = rdr["Lpncode"].ToString()
                    };
                    lstobj.Add(objrd);
                }
                con.Close();
            }
            return lstobj;
        }


        public IEnumerable<Api_Receivingorders_Go> GetApiRecevingorderGoBypallet(string pallet)
        {
            List<Api_Receivingorders_Go> lstobj = new List<Api_Receivingorders_Go>();
            using (NpgsqlConnection con = new NpgsqlConnection(connectionString))
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("select * ");
                sql.AppendLine("from wms.api_receivingorders_go");
                sql.AppendLine("Where Lpncode = @pallet");
                sql.AppendLine("order by efidx");
                NpgsqlCommand cmd = new NpgsqlCommand(sql.ToString(), con)
                {
                    CommandType = CommandType.Text
                };

                con.Open();
               
                cmd.Parameters.AddWithValue("@pallet", NpgsqlDbType.Varchar, pallet);


                NpgsqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Api_Receivingorders_Go objrd = new Api_Receivingorders_Go
                    {
                        Efidx = rdr["efidx"] == DBNull.Value ? null : (Int64?)rdr["efidx"],
                        Efstatus = rdr["efstatus"] == DBNull.Value ? null : (Int32?)rdr["efstatus"],
                        Created = rdr["created"] == DBNull.Value ? null : (DateTime?)rdr["created"],
                        Modified = rdr["modified"] == DBNull.Value ? null : (DateTime?)rdr["modified"],
                        Innovator = rdr["innovator"] == DBNull.Value ? null : (Int64?)rdr["innovator"],
                        Device = rdr["device"].ToString(),
                        Package_Id = rdr["package_id"].ToString(),
                        Roll_Id = rdr["roll_id"].ToString(),
                        Material_Code = rdr["material_code"].ToString(),
                        Material_Description = rdr["material_description"].ToString(),
                        Receiving_Date = rdr["receiving_Date"] == DBNull.Value ? null : (DateTime?)rdr["receiving_Date"],
                        Gr_Quantity = rdr["gr_quantity"] == DBNull.Value ? null : (decimal?)rdr["gr_quantity"],
                        Unit = rdr["unit"].ToString(),
                        Gr_Quantity_Kg = rdr["gr_quantity_kg"] == DBNull.Value ? null : (decimal?)rdr["gr_quantity_kg"],
                        Wh_Code = rdr["wh_code"].ToString(),
                        Warehouse = rdr["warehouse"].ToString(),
                        Locationno = rdr["locationno"].ToString(),
                        Document_Number = rdr["document_number"].ToString(),
                        Job = rdr["job"].ToString(),
                        Job_Code = rdr["job_code"].ToString(),
                        Lpncode = rdr["Lpncode"].ToString()
                    };
                    lstobj.Add(objrd);
                }
                con.Close();
            }
            return lstobj;
        }

        public void CancelReceivingOrdersBypack(string pallet, string pack)
        {
            using NpgsqlConnection con = new NpgsqlConnection(connectionString);
            StringBuilder sql = new StringBuilder();
            sql.AppendLine("Update wms.api_receivingorders_go");
            sql.AppendLine("Set Lpncode = NULL");
            sql.AppendLine(", Lpncode = @Pallet");
            sql.AppendLine(", efstatus = @efstatus");
            sql.AppendLine("Where package_id = @Pack ");
            NpgsqlCommand cmd = new NpgsqlCommand(sql.ToString(), con)
            {
                CommandType = CommandType.Text
            };

            cmd.Parameters.AddWithValue("@Pallet", pallet);
            cmd.Parameters.AddWithValue("@Pack", pack);
            cmd.Parameters.AddWithValue("@efstatus", 0);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void UpdateReceivingOrdersBypallet(string pallet)
        {
            using NpgsqlConnection con = new NpgsqlConnection(connectionString);
            StringBuilder sql = new StringBuilder();
            sql.AppendLine("Update wms.api_receivingorders_go");
            sql.AppendLine("Set efstatus = @efstatus");
            sql.AppendLine("where lpncode = @Pallet");
            NpgsqlCommand cmd = new NpgsqlCommand(sql.ToString(), con)
            {
                CommandType = CommandType.Text
            };

            cmd.Parameters.AddWithValue("@efstatus", 2);
            cmd.Parameters.AddWithValue("@Pallet", pallet);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void UpdateReceivingOrdersBypack(string pallet, string pack)
        {
            using NpgsqlConnection con = new NpgsqlConnection(connectionString);
            StringBuilder sql = new StringBuilder();
            sql.AppendLine("Update wms.api_receivingorders_go");
            sql.AppendLine("Set efstatus = @efstatus");
            sql.AppendLine(", Lpncode = @Pallet");
            sql.AppendLine("Where package_id = @Pack ");
            NpgsqlCommand cmd = new NpgsqlCommand(sql.ToString(), con)
            {
                CommandType = CommandType.Text
            };

            cmd.Parameters.AddWithValue("@efstatus", 1);
            cmd.Parameters.AddWithValue("@Pallet", pallet);
            cmd.Parameters.AddWithValue("@Pack", pack);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void InsertReceivingOrdersBypack(List<Api_Receivingorders_Go> listOrder, string pallet)
        {
            using NpgsqlConnection con = new NpgsqlConnection(connectionString);
            StringBuilder sql = new StringBuilder();
            sql.AppendLine("Delete from wms.api_receivingorders_go Where package_id = @package_idchk ;");
            sql.AppendLine("Insert into wms.api_receivingorders_go");
            sql.AppendLine("(package_id, roll_id, material_code, material_description, receiving_Date, gr_quantity, unit, gr_quantity_kg, wh_code, warehouse, locationno,  document_number, job, job_code, lpncode)");
            sql.AppendLine("Values(@package_id, @roll_id, @material_code, @material_description, @receiving_date, @gr_quantity, @unit, @gr_quantity_kg, @wh_code, @warehouse, @locationno, @document_number, @job, @job_code, @lpncode) ;");
            NpgsqlCommand cmd = new NpgsqlCommand(sql.ToString(), con)
            {
                CommandType = CommandType.Text
            };

            foreach (var s in listOrder)
            {
                cmd.Parameters.AddWithValue("@package_id", s.Package_Id);
                cmd.Parameters.AddWithValue("@roll_id", s.Roll_Id);
                cmd.Parameters.AddWithValue("@material_code", s.Material_Code);
                cmd.Parameters.AddWithValue("@material_description", s.Material_Description);
                cmd.Parameters.AddWithValue("@receiving_date", s.Receiving_Date);
                cmd.Parameters.AddWithValue("@gr_quantity", s.Gr_Quantity);
                cmd.Parameters.AddWithValue("@unit", s.Unit);
                cmd.Parameters.AddWithValue("@gr_quantity_kg", s.Gr_Quantity_Kg);
                cmd.Parameters.AddWithValue("@wh_code", s.Wh_Code);
                cmd.Parameters.AddWithValue("@warehouse", s.Warehouse);
                cmd.Parameters.AddWithValue("@locationno", s.Locationno);
                cmd.Parameters.AddWithValue("@document_number", s.Document_Number);
                cmd.Parameters.AddWithValue("@job", s.Job);
                cmd.Parameters.AddWithValue("@job_code", s.Job_Code);
                cmd.Parameters.AddWithValue("@lpncode", pallet);
                cmd.Parameters.AddWithValue("@package_idchk", s.Package_Id);
            }
            con.Open();
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public IEnumerable<Api_Reservedmaterials_Go> GetAllApiReservedmaterialGo()
        {
            List<Api_Reservedmaterials_Go> lstobj = new List<Api_Reservedmaterials_Go>();
            using (NpgsqlConnection con = new NpgsqlConnection(connectionString))
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("Select * ");
                sql.AppendLine("From wms.api_listofmaterialsneeds_go");
                sql.AppendLine("Order by efidx");
                NpgsqlCommand cmd = new NpgsqlCommand(sql.ToString(), con)
                {
                    CommandType = CommandType.Text
                };

                con.Open();
                NpgsqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Api_Reservedmaterials_Go objrd = new Api_Reservedmaterials_Go
                    {
                        Efidx = rdr["efidx"] == DBNull.Value ? null : (Int64?)rdr["efidx"],
                        Efstatus = rdr["efstatus"] == DBNull.Value ? null : (Int32?)rdr["efstatus"],
                        Created = rdr["created"] == DBNull.Value ? null : (DateTime?)rdr["created"],
                        Modified = rdr["modified"] == DBNull.Value ? null : (DateTime?)rdr["modified"],
                        Innovator = rdr["innovator"] == DBNull.Value ? null : (Int64?)rdr["innovator"],
                        Device = rdr["device"].ToString(),
                        Package_Id = rdr["package_id"].ToString(),
                        Roll_Id = rdr["roll_id"].ToString(),
                        Material_Code = rdr["material_code"].ToString(),
                        Material_Description = rdr["material_description"].ToString(),
                        Quantity = rdr["quantity"] == DBNull.Value ? null : (decimal?)rdr["quantity"],
                        Unit = rdr["unit"].ToString(),
                        Wh_Code = rdr["wh_code"].ToString(),
                        Warehouse = rdr["warehouse"].ToString(),
                        Locationno = rdr["locationno"].ToString(),
                        Job = rdr["job"].ToString(),
                        Job_Code = rdr["job_code"].ToString(),
                        Mo_Barcode = rdr["mo_barcode"].ToString()
                    };
                    lstobj.Add(objrd);
                }
                con.Close();
            }
            return lstobj;
        }

        public void SetMappPallet(string pallet)
        {
            Int32? iRet = 0 ;
            string sRet = "Calling";
            NpgsqlConnection con = new NpgsqlConnection(connectionString);
            try
            {
                con.Open();
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("Call wms.poc_inb_mappallet(");
                sql.AppendLine("@spalletno,@retchk,@retmsg)");
                NpgsqlCommand cmd = new NpgsqlCommand(sql.ToString(), con)
                {
                        CommandType = CommandType.Text
                 };

                 cmd.Parameters.AddWithValue("@spalletno", pallet);
                 cmd.Parameters.AddWithValue("@retchk", iRet);
                 cmd.Parameters.AddWithValue("@retmsg", sRet);
                 NpgsqlDataReader rdr = cmd.ExecuteReader();
                 while (rdr.Read())
                 {
                    iRet = rdr["retchk"] == DBNull.Value ? null : (Int32?)rdr["retchk"];
                    sRet = rdr["retmsg"].ToString();
                 }
            }
            catch (NpgsqlException exp)
            {
                //Response.Write(exp.ToString());
            }
            finally
            {
                con.Close();
            }
        }
    }
}
