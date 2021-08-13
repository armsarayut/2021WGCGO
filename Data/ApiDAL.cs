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

        public async Task InsertReceivingOrdersBypack(List<Api_Receivingorders_Go> listOrder, string pallet)
        {
            using NpgsqlConnection con = new NpgsqlConnection(connectionString);
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("Delete from wms.api_receivingorders_go Where package_id = @package_idchk ;");
                sql.AppendLine("Insert into wms.api_receivingorders_go");
                sql.AppendLine("(package_id, roll_id, material_code, material_description, receiving_Date, gr_quantity, unit, gr_quantity_kg, wh_code, warehouse, locationno,  document_number, job, job_code, lpncode, matcategory)");
                sql.AppendLine("Values");

                //sql.AppendLine("Values(@package_id, @roll_id, @material_code, @material_description, @receiving_date, @gr_quantity, @unit, @gr_quantity_kg, @wh_code, @warehouse, @locationno, @document_number, @job, @job_code, @lpncode, @matcategory) ;");
                /*
                NpgsqlCommand cmd = new NpgsqlCommand(sql.ToString(), con)
                {
                    CommandType = CommandType.Text
                };
                */
                using var cmd = new NpgsqlCommand(connection: con, cmdText: null);

                var i = 0;
                foreach (var s in listOrder)
                {
                    if (i != 0) sql.AppendLine(",");
                    var package_id = "package_id" + i.ToString();
                    var roll_id = "roll_id" + i.ToString();
                    var material_code = "material_code" + i.ToString();
                    var material_description = "material_description" + i.ToString();
                    var receiving_date = "receiving_date" + i.ToString();
                    var gr_quantity = "gr_quantity" + i.ToString();
                    var unit = "unit" + i.ToString();
                    var gr_quantity_kg = "gr_quantity_kg" + i.ToString();
                    var wh_code = "wh_code" + i.ToString();
                    var warehouse = "warehouse" + i.ToString();
                    var locationno = "locationno" + i.ToString();
                    var document_number = "document_number" + i.ToString();
                    var job = "job" + i.ToString();
                    var job_code = "job_code" + i.ToString();
                    var lpncode = "lpncode" + i.ToString();
                    var package_idchk = "package_idchk" + i.ToString();
                    var matcategory = "matcategory" + i.ToString();

                    sql.Append("(@").Append(package_id)
                   .Append(", @").Append(roll_id)
                   .Append(", @").Append(material_code)
                   .Append(", @").Append(material_description)
                   .Append(", @").Append(receiving_date)
                   .Append(", @").Append(gr_quantity)
                   .Append(", @").Append(gr_quantity_kg)
                   .Append(", @").Append(wh_code)
                   .Append(", @").Append(warehouse)
                   .Append(", @").Append(locationno)
                   .Append(", @").Append(document_number)
                   .Append(", @").Append(job)
                   .Append(", @").Append(job_code)
                   .Append(", @").Append(lpncode)
                   .Append(", @").Append(package_idchk)
                   .Append(", @").Append(matcategory)
                   .Append(')');

                    cmd.Parameters.Add(new NpgsqlParameter<string>(package_id, s.Package_Id));
                    cmd.Parameters.Add(new NpgsqlParameter<string>(roll_id, s.Roll_Id));
                    cmd.Parameters.Add(new NpgsqlParameter<string>(material_code, s.Material_Code));
                    cmd.Parameters.Add(new NpgsqlParameter<string>(material_description, s.Material_Description));
                    cmd.Parameters.Add(new NpgsqlParameter<DateTime>(receiving_date, (DateTime)s.Receiving_Date));
                    cmd.Parameters.Add(new NpgsqlParameter<decimal>(gr_quantity, (decimal)s.Gr_Quantity));
                    cmd.Parameters.Add(new NpgsqlParameter<string>(unit, s.Unit));
                    cmd.Parameters.Add(new NpgsqlParameter<decimal>(gr_quantity_kg, (decimal)s.Gr_Quantity_Kg));
                    cmd.Parameters.Add(new NpgsqlParameter<string>(wh_code, s.Wh_Code));
                    cmd.Parameters.Add(new NpgsqlParameter<string>(warehouse, s.Warehouse));
                    cmd.Parameters.Add(new NpgsqlParameter<string>(locationno, s.Locationno));
                    cmd.Parameters.Add(new NpgsqlParameter<string>(document_number, s.Document_Number));
                    cmd.Parameters.Add(new NpgsqlParameter<string>(job, s.Job));
                    cmd.Parameters.Add(new NpgsqlParameter<string>(job_code, s.Job_Code));
                    cmd.Parameters.Add(new NpgsqlParameter<string>(lpncode, pallet));
                    cmd.Parameters.Add(new NpgsqlParameter<string>(package_idchk, s.Package_Id));
                    cmd.Parameters.Add(new NpgsqlParameter<string>(matcategory, s.Matcategory));
                }
                con.Open();
                //cmd.Prepare();
                //cmd.ExecuteNonQuery();
                cmd.CommandText = sql.ToString();
                await cmd.ExecuteNonQueryAsync();
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



        public async Task InsertDeliveryOrder(List<Api_Deliveryorder_Go> listOrder)
        {
            using NpgsqlConnection con = new NpgsqlConnection(connectionString);
            try
            {
            StringBuilder sql = new StringBuilder();
            sql.AppendLine("Insert into wms.api_deliveryorder_go");
            sql.AppendLine("(package_id, roll_id, material_code, material_description, matelement");
            sql.AppendLine(", quantity, picked, unit, wh_code, warehouse, locationno");
            sql.AppendLine(", job, job_code, customer_code, customer_description, finished_product");
            sql.AppendLine(", finished_product_description, mo_barcode, dotype)");
            sql.AppendLine("Values");

            /*
            sql.AppendLine("Values ( @package_id, @roll_id, @material_code, @material_description, @matelement");
            sql.AppendLine(", @quantity, @picked, @unit, @wh_code, @warehouse, @locationno");
            sql.AppendLine(", @job, @job_code, @customer_code, @customer_description, @finished_product");
            sql.AppendLine(", @finished_product_description, @mo_barcode, @dotype);");
            */

            using var cmd = new NpgsqlCommand(connection: con, cmdText: null);

            var i = 0;
            foreach (var s in listOrder)
            {

                if (i != 0) sql.AppendLine(",");
                var package_id = "package_id" + i.ToString();
                var roll_id = "roll_id" + i.ToString();
                var material_code = "material_code" + i.ToString();
                var material_description = "material_description" + i.ToString();
                var matelement = "matelement" + i.ToString();
                var quantity = "quantity" + i.ToString();
                var picked = "picked" + i.ToString();
                var unit = "unit" + i.ToString();
                var wh_code = "wh_code" + i.ToString();
                var warehouse = "warehouse" + i.ToString();
                var locationno = "locationno" + i.ToString();
                var job = "job" + i.ToString();
                var job_code = "job_code" + i.ToString();
                var customer_code = "customer_code" + i.ToString();
                var customer_description = "customer_description" + i.ToString();
                var finished_product = "finished_product" + i.ToString();
                var finished_product_description = "finished_product_description" + i.ToString();
                var mo_barcode = "mo_barcode" + i.ToString();
                var dotype = "dotype" + i.ToString();

                sql.Append("(@").Append(package_id)
                    .Append(", @").Append(roll_id)
                    .Append(", @").Append(material_code)
                    .Append(", @").Append(material_description)
                    .Append(", @").Append(matelement)
                    .Append(", @").Append(quantity)
                    .Append(", @").Append(picked)
                    .Append(", @").Append(unit)
                    .Append(", @").Append(wh_code)
                    .Append(", @").Append(warehouse)
                    .Append(", @").Append(locationno)
                    .Append(", @").Append(job)
                    .Append(", @").Append(job_code)
                    .Append(", @").Append(customer_code)
                    .Append(", @").Append(customer_description)
                    .Append(", @").Append(finished_product)
                    .Append(", @").Append(finished_product_description)
                    .Append(", @").Append(mo_barcode)
                    .Append(", @").Append(dotype)
                    .Append(')');

                cmd.Parameters.Add(new NpgsqlParameter<string>(package_id, s.Package_Id));
                cmd.Parameters.Add(new NpgsqlParameter<string>(roll_id, s.Roll_Id));
                cmd.Parameters.Add(new NpgsqlParameter<string>(material_code, s.Material_Code));
                cmd.Parameters.Add(new NpgsqlParameter<string>(material_description, s.Material_Description));
                cmd.Parameters.Add(new NpgsqlParameter<string>(matelement, s.Matelement));
                cmd.Parameters.Add(new NpgsqlParameter<decimal>(quantity, (decimal)s.Quantity));
                cmd.Parameters.Add(new NpgsqlParameter<decimal>(picked, (decimal)s.Picked));
                cmd.Parameters.Add(new NpgsqlParameter<string>(unit, s.Unit));
                cmd.Parameters.Add(new NpgsqlParameter<string>(wh_code, s.Wh_Code));
                cmd.Parameters.Add(new NpgsqlParameter<string>(warehouse, s.Warehouse));
                cmd.Parameters.Add(new NpgsqlParameter<string>(locationno, s.Locationno));
                cmd.Parameters.Add(new NpgsqlParameter<string>(job, s.Job));
                cmd.Parameters.Add(new NpgsqlParameter<string>(job_code, s.Job_Code));
                cmd.Parameters.Add(new NpgsqlParameter<string>(customer_code, s.Customer_Code));
                cmd.Parameters.Add(new NpgsqlParameter<string>(customer_description, s.Customer_Description));
                cmd.Parameters.Add(new NpgsqlParameter<string>(finished_product, s.Finished_Product));
                cmd.Parameters.Add(new NpgsqlParameter<string>(finished_product_description, s.Finished_Product_Description));
                cmd.Parameters.Add(new NpgsqlParameter<string>(mo_barcode, s.Mo_Barcode));
                cmd.Parameters.Add(new NpgsqlParameter<string>(dotype, s.Dotype));

                i++;


            }
            con.Open();
            //cmd.Prepare();
            //cmd.ExecuteNonQuery();

            cmd.CommandText = sql.ToString();
            await cmd.ExecuteNonQueryAsync();
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

        public IEnumerable<Api_Reservedmaterials_Go> GetAllApiReservedmaterialGo()
        {
            List<Api_Reservedmaterials_Go> lstobj = new List<Api_Reservedmaterials_Go>();
            using (NpgsqlConnection con = new NpgsqlConnection(connectionString))
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("Select * ");
                sql.AppendLine("From wms.api_reservedmaterials_go");
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


        public IEnumerable<Api_Deliveryorder_Go> GetAllDeliveryorderGo()
        {
            List<Api_Deliveryorder_Go> lstobj = new List<Api_Deliveryorder_Go>();
            using (NpgsqlConnection con = new NpgsqlConnection(connectionString))
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("select * ");
                sql.AppendLine("from wms.api_deliveryorder_go");
                sql.AppendLine("order by efidx");
                NpgsqlCommand cmd = new NpgsqlCommand(sql.ToString(), con)
                {
                    CommandType = CommandType.Text
                };

                con.Open();
                NpgsqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Api_Deliveryorder_Go objrd = new Api_Deliveryorder_Go
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
                        Picked = rdr["picked"] == DBNull.Value ? null : (decimal?)rdr["picked"],
                        Unit = rdr["unit"].ToString(),
                        Wh_Code = rdr["wh_code"].ToString(),
                        Warehouse = rdr["warehouse"].ToString(),
                        Locationno = rdr["locationno"].ToString(),
                        Job = rdr["job"].ToString(),
                        Job_Code = rdr["job_code"].ToString(),
                        Mo_Barcode = rdr["mo_barcode"].ToString(),
                        Customer_Code = rdr["customer_code"].ToString(),
                        Customer_Description = rdr["customer_description"].ToString(),
                        Finished_Product = rdr["finished_product"].ToString(),
                        Finished_Product_Description = rdr["finished_product_description"].ToString(),
                        Matelement = rdr["matelement"].ToString(),
                        Dotype = rdr["dotype"].ToString(),
                    };
                    lstobj.Add(objrd);
                }
                con.Close();
            }
            return lstobj;
        }

        public IEnumerable<Api_Deliveryorder_Go> GetAllDeliveryorderGoByMo(string mocode)
        {
            List<Api_Deliveryorder_Go> lstobj = new List<Api_Deliveryorder_Go>();
            using (NpgsqlConnection con = new NpgsqlConnection(connectionString))
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("select * ");
                sql.AppendLine("from wms.api_deliveryorder_go");
                sql.AppendLine("where mo_barcode = @mo_barcode");
                sql.AppendLine("order by efidx");
                NpgsqlCommand cmd = new NpgsqlCommand(sql.ToString(), con)
                {
                    CommandType = CommandType.Text
                };
                

                cmd.Parameters.AddWithValue("@mo_barcode", mocode);
                
                con.Open();
                NpgsqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Api_Deliveryorder_Go objrd = new Api_Deliveryorder_Go
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
                        Picked = rdr["picked"] == DBNull.Value ? null : (decimal?)rdr["picked"],
                        Unit = rdr["unit"].ToString(),
                        Wh_Code = rdr["wh_code"].ToString(),
                        Warehouse = rdr["warehouse"].ToString(),
                        Locationno = rdr["locationno"].ToString(),
                        Job = rdr["job"].ToString(),
                        Job_Code = rdr["job_code"].ToString(),
                        Mo_Barcode = rdr["mo_barcode"].ToString(),
                        Customer_Code = rdr["customer_code"].ToString(),
                        Customer_Description = rdr["customer_description"].ToString(),
                        Finished_Product = rdr["finished_product"].ToString(),
                        Finished_Product_Description = rdr["finished_product_description"].ToString(),
                        Matelement = rdr["matelement"].ToString(),
                        Dotype = rdr["dotype"].ToString(),
                    };
                    lstobj.Add(objrd);
                }
                con.Close();
            }
            return lstobj;
        }

    }
}
