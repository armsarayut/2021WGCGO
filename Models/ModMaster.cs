using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoWMS.Server.Models
{
    public class ModMaster
    {
        private long Lvefidx;
        public long Efidx
        {
            get { return Lvefidx; }
            set { Lvefidx = value; }
        }
        private int Lvefstatus;
        public int Efstatus
        {
            get { return Lvefstatus; }
            set { Lvefstatus = value; }
        }
        private DateTime Lvcreated;
        public DateTime Created
        {
            get { return Lvcreated; }
            set { Lvcreated = value; }
        }
        private DateTime Lvmodified;
        public DateTime Modified
        {
            get { return Lvmodified; }
            set { Lvmodified = value; }
        }
        private long Lvinnovator;
        public long Innovator
        {
            get { return Lvinnovator; }
            set { Lvinnovator = value; }
        }
        private string Lvdevice;
        public string Device
        {
            get { return Lvdevice; }
            set { Lvdevice = value; }
        }
        private long Lvugid;
        public long Ugid
        {
            get { return Lvugid; }
            set { Lvugid = value; }
        }
        private string Lvusid;
        public string Usid
        {
            get { return Lvusid; }
            set { Lvusid = value; }
        }
        private string Lvuspass;
        public string Uspass
        {
            get { return Lvuspass; }
            set { Lvuspass = value; }
        }
        private string Lvusfirstname;
        public string Usfirstname
        {
            get { return Lvusfirstname; }
            set { Lvusfirstname = value; }
        }
        private string Lvuslastname;
        public string Uslastname
        {
            get { return Lvuslastname; }
            set { Lvuslastname = value; }
        }
        private string Lvusmail;
        public string Usmail
        {
            get { return Lvusmail; }
            set { Lvusmail = value; }
        }
        private string Lvustel;
        public string Ustel
        {
            get { return Lvustel; }
            set { Lvustel = value; }
        }
        private string Lvusgridcolor;
        public string Usgridcolor
        {
            get { return Lvusgridcolor; }
            set { Lvusgridcolor = value; }
        }

    }
}
