using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoWMS.Server.Data
{
    public static class ConnGlobals
    {
        public static string GetConnLocalDB()
        {
            return "server=DESKTOP-NQ62BHU\\MSSQL; database=GoSQL;Trusted_Connection=True;";
        }

        private static readonly string NpgServer = "localhost";
        //private static readonly string NpgServer = "192.188.180.38";
        private static readonly string NpgPort = "5432";
        private static readonly string NpgDB = "GoDemo";
        //private static readonly string NpgDB = "GoPG";
        private static readonly string NpgUser = "postgres";
        private static readonly string NpgPass = "@ei0u2020";
        //private static readonly string NpgPass = "@ei0u";
        private static readonly string NpgContime = "60";

        public static string GetConnLocalDBPG()
        {
            return "Server=" + NpgServer + " ;Port=" + NpgPort + ";Database=" + NpgDB + ";User Id=" + NpgUser + ";Password=" + NpgPass + ";Timeout=" + NpgContime + ";";
        }

        public static string GetConnApiDB()
        {
            return "Server=" + NpgServer + " ;Port=" + NpgPort + ";Database=" + NpgDB + ";User Id=" + NpgUser + ";Password=" + NpgPass + ";Timeout=" + NpgContime + ";";
        }

        private static readonly string ErpServer = "192.188.180.38";
        private static readonly string ErpDB = "Staging";
        private static readonly string ErpUser = "ASRS_WMS";
        private static readonly string ErpPass = "ASRS_WMS";
        private static readonly string ErpContime = "60";

        public static string GetConnErpDB()
        {
            //return "Data Source=" + ErpServer + ";Initial Catalog=" + ErpDB + ";Persist Security Info=True;User ID=" + ErpUser + ";Password=" + ErpPass + ";Connect Timeout=" + ErpContime + ";";
            return "server=DESKTOP-NQ62BHU\\MSSQL; database=GoSQL;Trusted_Connection=True;";

        }
        
    }
}
