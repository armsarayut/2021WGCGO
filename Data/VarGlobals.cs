using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace GoWMS.Server.Data
{
    public class VarGlobals
    {
        public string MainMenu { get; set; }
        public string CurrentMunu { get; set; }
        public static string Imagelogoreport()
        {
            return $"{Directory.GetCurrentDirectory()}{@"\wwwroot\images\Logocus.jpg"}" ;
        }

        public static string Fontreport()
        {
            return $"{Directory.GetCurrentDirectory()}{@"\wwwroot\fonts\ARIALUNI.TTF"}";
        }

        public static string CurrentUserName { get; set; }

        public static class User
        {
            public static long UserID { get; set; }
            public static string UserCode { get; set; }
            public static string UserName { get; set; }
            public static long DeepID { get; set; }
            public static long GroupID { get; set; }
        }

        public static string FormatN0 { get; set; } = "{0:N0}";
        public static string FormatN2 { get; set; } = "{0:N2}";
        public static string FormatD2 { get; set; } = "{0:D2}";
        public static string FormatD3 { get; set; } = "{0:D3}";
        public static string FormatD4 { get; set; } = "{0:D4}";
        public static string FormatD5 { get; set; } = "{0:D5}";
        public static string FormatD6 { get; set; } = "{0:D6}";
        public static string FormatD7 { get; set; } = "{0:D7}";
        public static string FormatD8 { get; set; } = "{0:D8}";
        public static string FormatD9 { get; set; } = "{0:D9}";
        public static string FormatDT { get; set; } = "yyyy-MM-dd HH:mm:ss";
        public static string FormatDTHM { get; set; } = "yyyy-MM-dd HH:mm";
        public static string FormatT { get; set; } = "HH:mm:ss";
        public static string FormatTHM { get; set; } = "HH:mm";
        public static string FormatD { get; set; } = "yyyy-MM-dd";
        public static string TableHeight { get; set; } = "600px";

    }
}
