using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onana_Hospital_Management_System
{
    public class JournalEntryRepository
    {
        private readonly DatabaseManager _dbManager;

        public JournalEntryRepository(DatabaseManager dbManager)
        {
            _dbManager = dbManager;
        }

        public void SaveJournalEntry(DateTime entryDate, string description, List<JournalEntryItem> items)
        {
            using (var connection = _dbManager.GetConnection())
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // Create DataTable for TVP
                        DataTable itemsTable = new DataTable();
                        itemsTable.Columns.Add("AccountId", typeof(int));
                        itemsTable.Columns.Add("Debit", typeof(decimal));
                        itemsTable.Columns.Add("Credit", typeof(decimal));
                        foreach (var item in items)
                        {
                            itemsTable.Rows.Add(item.AccountId, item.Debit, item.Credit);
                        }

                        // Execute stored procedure
                        using (var command = new SqlCommand("InsertJournalEntry", connection, transaction))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@EntryDate", entryDate);
                            command.Parameters.AddWithValue("@Description", description);
                            command.Parameters.AddWithValue("@Items", itemsTable);
                            command.ExecuteNonQuery();
                        }

                        transaction.Commit();
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }
    }
}
