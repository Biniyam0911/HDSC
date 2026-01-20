using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onana_Hospital_Management_System
{
    public class JournalEntryBusinessLogic
    {
        private readonly JournalEntryRepository _repository;

        public JournalEntryBusinessLogic(JournalEntryRepository repository)
        {
            _repository = repository;
        }

        public void SaveJournalEntry(DateTime entryDate, string description, List<JournalEntryItem> items)
        {
            // Validate double-entry
            decimal totalDebit = items.Sum(i => i.Debit);
            decimal totalCredit = items.Sum(i => i.Credit);
            if (totalDebit != totalCredit)
                throw new InvalidOperationException("Debits and credits must be equal.");

            // Apply IFRS revenue recognition rules (example)
            ApplyIFRSRevenueRecognition(items);

            _repository.SaveJournalEntry(entryDate, description, items);
        }

        private void ApplyIFRSRevenueRecognition(List<JournalEntryItem> items)
        {
            // Custom logic to defer revenue if needed
        }
    }
}
