using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onana_Hospital_Management_System
{
    public class JournalEntryItem
    {
        public int AccountId { get; set; } // The ID of the account affected
        public decimal Debit { get; set; } // The debit amount
        public decimal Credit { get; set; } // The credit amount
    }
}
