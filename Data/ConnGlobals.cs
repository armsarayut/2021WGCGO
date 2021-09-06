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
            return "Data Source=" + ErpServer + ";Initial Catalog=" + ErpDB + ";Persist Security Info=True;User ID=" + ErpUser + ";Password=" + ErpPass + ";Connect Timeout=" + ErpContime + ";";
            //return "server=DESKTOP-NQ62BHU\\MSSQL; database=GoSQL;Trusted_Connection=True;";

        }

        private static readonly string oraServer = "192.168.1.143";
        private static readonly string oraPort = "1521";
        //private static readonly string oraSource = "ASRS_WMS";
        private static readonly string oraUser = "WGRB";
        private static readonly string oraPass = "WGRB2021LINK";
        private static readonly string oraDB = "orcl";


        public static string GetConnErpDBWCG()
        {
            //Using ODP.NET without tnsnames.ora
             return "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=" + oraServer + ")(PORT=" + oraPort + ")))(CONNECT_DATA=(SERVER=DEDICATED)(SID = " + oraDB + ")));User Id=" + oraUser + ";Password=" + oraPass + ";";

            // return "Data Source = (DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = 192.168.1.143)(PORT = 1521)) (CONNECT_DATA=(SID=ORCL)));User Id=AWGRB;Password=WGRB2021LINK;";
            //return "Data Source = (DESCRIPTION = (ADDRESS_LIST = (ADDRESS =(PROTOCOL = TCP)(HOST = 192.168.1.143)(PORT = 1521)))(CONNECT_DATA = ORCL))); User Id = AWGRB; password = WGRB2021LINK:";
            //return "Data Source = 192.168.1.143:1521/ORCL; User Id = AWGRB; Password = WGRB2021LINK; Validate Connection = true; ";

            // return "User Id = AWGRB; Password = WGRB2021LINK; Data Source = 192.168.1.143:1521/ORCL";
            // return "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=192.168.1.143)(PORT=1521)))(CONNECT_DATA=(SID=ORCL)));User ID=AWGRB;Password=WGRB2021LINK;";
            //return "User Id=AWGRB;Password=WGRB2021LINK;Data Source=orcl;";
            // return "Data Source = (DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = 192.168.1.143)(PORT = 1521)))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = ORCL))); User Id = AWGRB; Password = WGRB2021LINK;";
            //return "Data Source = 192.168.1.143:1521/orcl;User Id = AWGRB;Password = WGRB2021LINK;";
            //"(DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (COMMUNITY = TCP) (PROTOCOL = TCP) (HOST = hun) (PORT = 1521)))(CONNECT_DATA = (SID = kraus)))"

            //return "Data Source = (DESCRIPTION = (ADDRESS_LIST = (ADDRESS = " +
            //"(PROTOCOL = TCP)(HOST ={ url of your database})(PORT ={ port})))(CONNECT_DATA = " +
            //"{ name of your database for ex: SID}))); User Id = { user id }; password = " +
            //"{ password};";
            //"User Id=WGRB;Password=WGRB2021LINK;Data Source=192.168.1.143:1521/{database}:{schema};"

            //return "Data Source=//192.168.1.143:1521/orcl:;User ID=WGRB;Password=WGRB2021LINK;";

        }


    }
}
