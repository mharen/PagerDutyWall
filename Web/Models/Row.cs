using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Models
{
    public class Row
    {
        public string sDate { get; set; }
        public string sTime { get; set; }
        public string sDeparture { get; set; }
        public int nStatus { get; set; }
        public string nTrack { get; set; }
        public bool bLight { get; set; }
    }
}