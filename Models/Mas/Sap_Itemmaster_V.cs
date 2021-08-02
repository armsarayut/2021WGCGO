using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoWMS.Server.Models.Mas
{
    public class Sap_Itemmaster_V
    {
        private Int64? m_idx;
        public Int64? Idx { get => m_idx; set => m_idx = value; }

        private DateTime? m_created;
        public DateTime? Created { get => m_created; set => m_created = value; }

        private Int32? m_entity_lock;
        public Int32? Entity_Lock { get => m_entity_lock; set => m_entity_lock = value; }

        private DateTime? m_modified;
        public DateTime? Modified { get => m_modified; set => m_modified = value; }

        private Int64? m_client_id;
        public Int64? Client_Id { get => m_client_id; set => m_client_id = value; }

        private string m_client_ip;
        public string Client_Ip { get => m_client_ip; set => m_client_ip = value; }

        private string m_item_code;
        public string Item_Code { get => m_item_code; set => m_item_code = value; }

        private string m_article;
        public string Article { get => m_article; set => m_article = value; }

        private string m_item_name;
        public string Item_Name { get => m_item_name; set => m_item_name = value; }

        private string m_mc_code;
        public string Mc_Code { get => m_mc_code; set => m_mc_code = value; }

        private string m_uom;
        public string Uom { get => m_uom; set => m_uom = value; }

        private string m_brand;
        public string Brand { get => m_brand; set => m_brand = value; }

        private string m_tile_size;
        public string Tile_Size { get => m_tile_size; set => m_tile_size = value; }

        private string m_tem_flag;
        public string Tem_Flag { get => m_tem_flag; set => m_tem_flag = value; }

        private string m_vendor;
        public string Vendor { get => m_vendor; set => m_vendor = value; }

        private Double? m_gross_weight;
        public Double? Gross_Weight { get => m_gross_weight; set => m_gross_weight = value; }

        private string m_weight_unit;
        public string Weight_Unit { get => m_weight_unit; set => m_weight_unit = value; }

        private string m_pack_size_box;
        public string Pack_Size_Box { get => m_pack_size_box; set => m_pack_size_box = value; }

        private string m_pack_size_pal;
        public string Pack_Size_Pal { get => m_pack_size_pal; set => m_pack_size_pal = value; }

        private string m_batch_management;
        public string Batch_Management { get => m_batch_management; set => m_batch_management = value; }

        private string m_class_flag;
        public string Class_Flag { get => m_class_flag; set => m_class_flag = value; }

        private string m_consign_flag;
        public string Consign_Flag { get => m_consign_flag; set => m_consign_flag = value; }


    }
}
