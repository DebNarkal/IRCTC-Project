using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace LastRecord
{
    public class Info
    {
        public string usrName { get; set; }
        public string pwd { get; set; }
        public string frmStn { get; set; }
        public string toStn { get; set; }
        public string trainInfo { get; set; }
        public string journeyClass { get; set; }
        public DataTable passengerInfo { get; set; }
    }
}
