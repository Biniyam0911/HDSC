using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Text.Json;

namespace Onana_Hospital_Management_System
{
    public class ERPNextService
    {
        //clsSelect selectClass = new clsSelect();
        
        private readonly string _baseUrl = "http://196.188.64.222:8002";
        private readonly string _apiKey = "f4af4d4b5103c25";
        private readonly string _apiSecret = "0693376111c4d2c";

        public async Task PostSalesInvoice()
        {
            var invoice = new SalesInvoice
            {
                customer = "Test Customer",
                posting_date = DateTime.Today.ToString("yyyy-MM-dd"),
                due_date = DateTime.Today.ToString("yyyy-MM-dd"),
                items = new List<SalesInvoiceItem>
            {
                new SalesInvoiceItem
                {
                    item_code = "ITEM-001",
                    qty = 2,
                    rate = 150
                }
            }
            };

            var json = JsonSerializer.Serialize(invoice);

            var client = new HttpClient();
            client.DefaultRequestHeaders.Add(
                "Authorization",
                $"token {_apiKey}:{_apiSecret}"
            );

            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await client.PostAsync(
                $"{_baseUrl}/api/resource/Sales Invoice",
                content
            );

            var responseBody = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception($"ERPNext Error: {responseBody}");
            }

            Console.WriteLine("Sales Invoice Posted Successfully");
            Console.WriteLine(responseBody);
        }
    }
}
