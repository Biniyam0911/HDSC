using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MWLibraryForPT;
using DevExpress.XtraEditors;

namespace Onana_Hospital_Management_System
{
    public partial class frmChartofAccount : XtraForm
    {
        private Peachtree peach;
        clsSelect varSelect = new clsSelect();
        private readonly JournalEntryBusinessLogic _businessLogic;
        public frmChartofAccount()
        {
            InitializeComponent();
            var dbManager = new DatabaseManager();
            var repository = new JournalEntryRepository(dbManager);
            _businessLogic = new JournalEntryBusinessLogic(repository);
        }

        private void frmChartofAccount_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbOHMSDataSet3.tblOrder' table. You can move, or remove it, as needed.
            this.tblOrderTableAdapter.Fill(this.dbOHMSDataSet3.tblOrder);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var items = new List<JournalEntryItem>
            {
                new JournalEntryItem { AccountId = 1, Debit = 1000, Credit = 0 },  // Cash
                new JournalEntryItem { AccountId = 4, Debit = 0, Credit = 1000 }   // Revenue
            };


            try
            {
                _businessLogic.SaveJournalEntry(DateTime.Now, "Sample Sale", items);
                MessageBox.Show("Saved successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {


            try
            {
               // int noOfRecords = dgvSales.Rows.Count;
                // Create an instance of the SalesJournal object
                
                //oSalesJournal.CreateData();
                // Step 1: Prepare the sales data
                int numberOfRecords = dgvSales.Rows.Count;//1; // Assuming we're exporting one record
                short rowCount = 1; // Number of rows (lines of distribution) in the transaction
                int index = 1;
                
                foreach (DataGridViewRow row in dgvSales.Rows)
                {
                    SalesJournal oSalesJournal = new SalesJournal();
                    oSalesJournal.set_NumberOfRecords(ref numberOfRecords); // Set number of records
                    if (!row.IsNewRow) // Avoid the empty new row at the end
                    {
                        string customerID = row.Cells[0].Value?.ToString(); // Replace with actual customer ID
                        string itemID = row.Cells[1].Value?.ToString(); // Replace with actual item ID
                        double quantity = double.Parse(row.Cells[2].Value?.ToString()); // Replace with actual quantity
                        double unitPrice = double.Parse(row.Cells[3].Value?.ToString()); // Replace with actual unit price
                        DateTime trxDate = DateTime.Parse(row.Cells[5].Value?.ToString()); // Transaction date
                                                                                                     // Step 2: Create a new data stream for import
                        bool status = oSalesJournal.CreateData();
                        if (!status)
                        {
                            MessageBox.Show("Failed to create data stream.");
                            return;
                        }

                        // Step 3: Set the number of records              
                       
                        oSalesJournal.set_RowCount(1, rowCount);

                        // Step 4: Populate the sales journal fields for the first record
                        oSalesJournal.set_CustomerID(ref index, ref customerID);

                        oSalesJournal.set_ItemID(1, ref rowCount, ref itemID);
                        oSalesJournal.set_Quantity(1, ref rowCount, ref quantity);
                        oSalesJournal.set_UnitPrice(1, ref rowCount, ref unitPrice);
                        oSalesJournal.set_Amount(1, ref rowCount, double.Parse(row.Cells[4].Value?.ToString()));
                        oSalesJournal.set_TrxDate(1, trxDate);

                        // Optional: Set additional fields if needed
                        oSalesJournal.set_ARAccountID(1, row.Cells[6].Value?.ToString());
                        oSalesJournal.set_TaxType(1, ref rowCount, 4);
                        oSalesJournal.set_GLAccountID(1, ref rowCount, "1010"); // Example GL account ID
                        oSalesJournal.set_JobID(1, ref rowCount, row.Cells[7].Value?.ToString()); // Example Job ID (if applicable)
                        oSalesJournal.set_InvoiceNumber(1, row.Cells[8].Value?.ToString());
                        oSalesJournal.set_Description(1, ref rowCount, row.Cells[9].Value?.ToString());

                        // Step 5: Import the data into Peachtree
                        status = oSalesJournal.Import();
                        if (status)
                        {
                            MessageBox.Show("Sales data successfully exported to Peachtree.");
                        }
                        else
                        {
                            MessageBox.Show("Failed to export sales data to Peachtree.");
                        }
                        //numberOfRecords++;
                        rowCount++; // Number of rows (lines of distribution) in the transaction
                       // index++;
                        // Step 6: Clean up resources
                        oSalesJournal.CloseData();
                        oSalesJournal = null;
                    }
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
            //peach = new Peachtree();
            ////MessageBox.Show(peach.CompanyPath);
            //List<Sale> dailySales = GetSalesFromDatabase();
            //PeachtreeExporter exporter = new PeachtreeExporter();
            //exporter.ExportDailySales(dailySales);
            //exporter.Close();

        }

        public List<Sale> GetSalesFromDatabase()
        {
            List<Sale> sales = new List<Sale>();

            // Simulating a daily sale record
            Sale sale1 = new Sale
            {
                CustomerId = "CUST001",
                Date = DateTime.Today,
                InvoiceNM = "CM101",
                Items = new List<SaleItem>
                {
                    new SaleItem { ItemCode = "ITEM001", Quantity = 2, UnitPrice = 50.00,ARAccount="OP100",CoA="1010",NoDist="1",salestype=2,Total=120 },
                    new SaleItem { ItemCode = "ITEM002", Quantity = 1, UnitPrice = 100.00, ARAccount="OP100",CoA="1010",NoDist="1",salestype=2,Total=120}
                }
            };

            sales.Add(sale1);
            return sales;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            varSelect.getDailySales(dgvSales, DateTime.Parse(dtpFrom.Text), DateTime.Parse(dtpTo.Text));
        }
    }
}
