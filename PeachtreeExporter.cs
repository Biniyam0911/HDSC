using MWLibraryForPT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onana_Hospital_Management_System
{
    public class PeachtreeExporter
    {
        private SalesJournal salesJournal;
        //private Peachtree peach;

        public PeachtreeExporter()
        {
            try
            {
                
                salesJournal = new SalesJournal();
                salesJournal.OpenData(); // Open connection to Peachtree
               
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error initializing Peachtree Sales Journal: " + ex.Message);
                throw;
            }
        }

        public void ExportDailySales(List<Sale> dailySales)
        {
            foreach (var sale in dailySales)
            {
                try
                {
                    salesJournal.CreateData();

                    int recordIndex = 1;
                    int numberOfRecords = 1;
                    salesJournal.set_NumberOfRecords(ref numberOfRecords); // Set number of records



                    // Assign Peachtree required fields
                    string CustomerId = sale.CustomerId;
                    salesJournal.set_CustomerID(ref recordIndex, ref CustomerId);

                    string dt = sale.Date.ToString("MM/dd/yyyy");
                    salesJournal.set_TrxDate(ref recordIndex, dt);
                    short rowind = 1;
                    // salesJournal.set_Description = "Sales-" + sale.Date.ToString("yyyyMMdd");  // ✅ Correct (if `Description` exists)
                    string desc = "Sales-" + sale.Date.ToString("yyyyMMdd");
                    salesJournal.set_Description(ref recordIndex, ref rowind, ref desc);

                    int rowIndex = 1;
                    int rowCount = sale.Items.Count;
                    salesJournal.set_RowCount(ref rowIndex, ref rowCount);  // Set row count explicitly

                    
                    int lineIndex = 1;
                    foreach (var item in sale.Items)
                    {
                        string ItemCode = item.ItemCode;
                        salesJournal.set_ItemID(ref lineIndex, ref rowind, ref ItemCode);


                        //salesJournal.set_ItemID(ref lineIndex, ref rowIndex, ref item.ItemCode);
                        //salesJournal.set_Quantity(ref lineIndex, ref item.Quantity);

                        double quantity = item.Quantity;
                        salesJournal.set_Quantity(ref lineIndex, ref rowind, ref quantity);

                        double UnitPrice = item.UnitPrice;
                        salesJournal.set_UnitPrice(ref lineIndex, ref rowind, ref UnitPrice);

                        //salesJournal.set_UnitPrice(ref lineIndex, ref item.UnitPrice);
                        lineIndex++;
                    }

                    bool success = salesJournal.Import();
                    if (success)
                    {
                        Console.WriteLine($"Sale for Customer {sale.CustomerId} exported successfully.");
                    }
                    else
                    {
                        Console.WriteLine($"Failed to export sale for {sale.CustomerId}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error exporting sale for {sale.CustomerId}: {ex.Message}");
                }
            }
        }


        public void Close()
        {
            salesJournal.CloseData();
        }
    }

    public class Sale
    {
        public string CustomerId { get; set; }  // Customer ID from Peachtree
        public DateTime Date { get; set; }  // Sale date
        public string InvoiceNM { get; set; }
        public List<SaleItem> Items { get; set; }  // List of sold items

        public Sale()
        {
            Items = new List<SaleItem>(); // Initialize the list to avoid null references
        }
    }

    public class SaleItem
    {
        
        public string ARAccount { get; set; }
        public string NoDist { get; set; }
        public string CoA { get; set; }
        public string ItemCode { get; set; }  // Item ID in Peachtree
        public double Quantity { get; set; } // Quantity sold
        public double UnitPrice { get; set; } // Selling price
        public int salestype { get; set; }
        public double Total { get; set; }
    }

}
