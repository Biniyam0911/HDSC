using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onana_Hospital_Management_System
{
    public class SalesOrderDM
    {
        public string ServiceCode { get; set; }
        public string ServiceName { get; set; }
        public float UnitPrice { get; set; }
        public int Qty { get; set; }
        public float TotalPrice { get; set; }
        public string Category { get; set; }
    }
}
