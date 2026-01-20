using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DevExpress.XtraEditors;
using System.Net.Http;
using System.Text.Json;

namespace Onana_Hospital_Management_System
{
    public partial class frmViewBills : XtraForm
    {
        readonly clsInsert varintsert = new clsInsert();
        readonly clsSelect selectClass = new clsSelect();
        readonly ClsUpdate clsUpdate = new ClsUpdate();
        private static readonly HttpClient httpClient = new HttpClient();
        private readonly string _baseUrl = "http://196.188.64.222:8002";
        private readonly string _apiKey = "f4af4d4b5103c25";
        private readonly string _apiSecret = "0693376111c4d2c";
        private static readonly Dictionary<string, ItemGroupDefaults> _itemGroupCache    = new Dictionary<string, ItemGroupDefaults>();


        public frmViewBills()
        {
            InitializeComponent();
        }

        private void frmViewBills_Load(object sender, EventArgs e)
        {
           
        }

        private async Task CancelSalesInvoiceAsync(string erpInvoiceName)
        {
            httpClient.DefaultRequestHeaders.Clear();
            httpClient.DefaultRequestHeaders.Add(
                "Authorization",
                $"token {_apiKey}:{_apiSecret}"
            );

            var payload = new
            {
                doctype = "Sales Invoice",
                name = erpInvoiceName
            };

            var json = JsonSerializer.Serialize(payload);
            // Step 1: Cancel the document
            var response = await httpClient.PostAsync(
                $"{_baseUrl}/api/method/frappe.client.cancel",
                new StringContent(json, Encoding.UTF8, "application/json")
            );

            if (!response.IsSuccessStatusCode)
            {
                var body = await response.Content.ReadAsStringAsync();
                ErrorLogger.Log(
                                    reference: erpInvoiceName,
                                    message: "Invoice Cancel failed",
                                    requestText: json,
                                    responseText: body
                                );
                //throw new Exception($"Cancel failed: {body}");
            }
            else
                MessageBox.Show("Invoice " + erpInvoiceName + " canceled successfully");
        }

        //Filter Search

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if(chkShowPosted.Checked)
            {
                btnPost.Enabled = false;
                selectClass.viewPaidBills(dgvSales, false, dtpFrom, dtpTo, true);
            }
            else
            {
                btnPost.Enabled = true;
                selectClass.viewPaidBills(dgvSales, false, dtpFrom, dtpTo, false);
            }
        }

        private async void btnPost_Click(object sender, EventArgs e)
        {
            btnPost.Enabled = false;

            try
            {
                httpClient.DefaultRequestHeaders.Clear();
                httpClient.DefaultRequestHeaders.Add(
                    "Authorization",
                    $"token {_apiKey}:{_apiSecret}"
                );

                var invoices = await BuildInvoicesFromGridAsync();

                foreach (var kvp in invoices)
                {
                    string localInvoiceNo = kvp.Key;
                    SalesInvoice invoice = kvp.Value;

                    try
                    {
                        // Ensure customer exists
                        bool exists = await CustomerExists(invoice.customerID);
                        if (!exists)
                        {
                            await CreateCustomer(
                                invoice.customerID,
                                invoice.customer
                            );
                        }
                        //var status = await GetInvoiceStatusAsync(invoice.custom_invoice_number);

                        //bool Invoiceexists = await InvoiceExists(invoice.custom_invoice_number);
                        //if (!status.Exists)
                       // {
                            // Serialize
                            var json = JsonSerializer.Serialize(invoice);
                            var content = new StringContent(
                                json,
                                Encoding.UTF8,
                                "application/json"
                            );
                            Console.WriteLine($"=== Sending invoice {localInvoiceNo} ===");
                            Console.WriteLine(json);
                            Console.WriteLine("=======================");
                            // POST Sales Invoice
                            var response = await httpClient.PostAsync(
                                $"{_baseUrl}/api/resource/Sales Invoice",
                                content
                            );

                            var responseBody = await response.Content.ReadAsStringAsync();

                            if (!response.IsSuccessStatusCode)
                            {
                                ErrorLogger.Log(
                                    reference: localInvoiceNo,
                                    message: "Invoice POST failed",
                                    requestText: json,
                                    responseText: responseBody
                                );
                                continue;
                            }

                            // Read ERPNext invoice number
                            var erpResponse =
                                JsonSerializer.Deserialize<ERPNextResponse>(responseBody);

                            string erpInvoiceNo = erpResponse?.data?.name;

                            // Update UI / DB
                            MarkInvoiceAsPosted(localInvoiceNo, erpInvoiceNo, "Posted");
                            UpdateGrid(localInvoiceNo, erpInvoiceNo);
                       // }
                        //else
                       //     Console.WriteLine("Invoice " + invoice.custom_invoice_number + " Exists");
                        
                    }
                    catch (Exception ex)
                    {
                        ErrorLogger.Log(
                            reference: localInvoiceNo,
                            message: ex.ToString()
                        );
                    }
                }

                MessageBox.Show(
                    "Posting completed.\nCheck Logs folder for any errors.",
                    "Done",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            finally
            {
                //btnPost.Enabled = true;
            }
        }

        private async Task<Dictionary<string, SalesInvoice>> BuildInvoicesFromGridAsync()
        {
            var invoices = new Dictionary<string, SalesInvoice>();

            foreach (DataGridViewRow row in dgvSales.Rows)
            {
                if (row.IsNewRow) continue;

                string invoiceNo = row.Cells["InvoiceNumber"].Value?.ToString();
                string customer = row.Cells["Customer"].Value?.ToString();
                string customerID = row.Cells["CustomerID"].Value?.ToString();
                string itemCode = row.Cells["ItemCode"].Value?.ToString();
                string cashier = row.Cells["Cashier"].Value?.ToString();
                string billid = row.Cells["BillID"].Value?.ToString();
                
                if (string.IsNullOrWhiteSpace(invoiceNo) ||
                    string.IsNullOrWhiteSpace(customer) ||
                    string.IsNullOrWhiteSpace(itemCode))
                    continue;

                // -------------------------------
                // Create invoice header once
                // -------------------------------
                if (!invoices.ContainsKey(invoiceNo))
                {
                    invoices[invoiceNo] = new SalesInvoice
                    {
                        customer = customer,
                        customerID = customerID,
                        set_posting_time = true,
                        posting_date = Convert.ToDateTime(
                            row.Cells["PostingDate"].Value
                        ).ToString("yyyy-MM-dd"),

                        due_date = DateTime.Today.ToString("yyyy-MM-dd"),
                        custom_bilid = billid,
                        items = new List<SalesInvoiceItem>(),
                        cashier = cashier,
                        custom_patient_id = customerID,
                        // 🔥 POS MODE (CRITICAL)
                        is_pos = 1,
                        pos_profile = "POS Main",           // EXACT ERPNext POS Profile
                        company = "MediNexus",

                        docstatus = 1,
                        custom_invoice_number = invoiceNo
                    };
                }

                // -------------------------------
                // Resolve accounts from ERPNext
                // Item → Item Group → Defaults
                // -------------------------------
                var (incomeAccount, expenseAccount, costCenter) =
                    await ResolveAccountsAsync(itemCode);

                // -------------------------------
                // Add item row
                // -------------------------------
                invoices[invoiceNo].items.Add(new SalesInvoiceItem
                {
                    item_code = itemCode,
                    qty = Convert.ToDecimal(row.Cells["Quantity"].Value),
                    rate = Convert.ToDecimal(row.Cells["UnitPrice"].Value),
                    uom = "Nos",
                    income_account = incomeAccount,
                    expense_account = expenseAccount,
                    cost_center = costCenter
                });
            }
            //string paymentAccount = await GetModeOfPaymentAccount(cashier);
            // -------------------------------
            // Calculate totals (POS requires this)
            // -------------------------------
            foreach (var invoice in invoices.Values)
            {
                decimal total = invoice.items.Sum(i => i.qty * i.rate);

                invoice.paid_amount = total;
                invoice.outstanding_amount = 0;

                // Required for POS invoice
                invoice.payments = new List<POSPayment>
                {
                    new POSPayment
                    {
                        mode_of_payment = invoice.cashier,//"Cash",//invoice.cashier, // ERPNext mode of payment
                        amount = total,
                        account = await GetModeOfPaymentAccount(invoice.cashier)
                    }
                };
            }


            return invoices;
        }
        private async Task<string> GetModeOfPaymentAccount(string modeOfPaymentName)
        {
            try
            {
                var response = await httpClient.GetAsync(
                    $"{_baseUrl}/api/resource/Mode of Payment/{Uri.EscapeDataString(modeOfPaymentName)}"
                );

                if (!response.IsSuccessStatusCode)
                {

                    ErrorLogger.Log(
                                reference: modeOfPaymentName,
                                message: "Mode of Payment has no account",
                                requestText: response.ToString(),
                                responseText: null
                            );
                    // Fallback to default cash account
                    return null;
                }

                var json = await response.Content.ReadAsStringAsync();
                var doc = JsonDocument.Parse(json);
                var data = doc.RootElement.GetProperty("data");

                // Get the account from mode of payment
                if (data.TryGetProperty("accounts", out var accountsArray) &&
                    accountsArray.ValueKind == JsonValueKind.Array &&
                    accountsArray.GetArrayLength() > 0)
                {
                    var firstAccount = accountsArray[0];
                    if (firstAccount.TryGetProperty("default_account", out var account))
                    {
                        return account.GetString();
                    }
                }
                ErrorLogger.Log(
                                reference: modeOfPaymentName,
                                message: "Mode of Payment has no account",
                                requestText: response.ToString(),
                                responseText: null);
                // Fallback
                return null;
            }
            catch(Exception ex)
            {
                ErrorLogger.Log(
                                reference: modeOfPaymentName,
                                message: "Mode of Payment has no account",
                                requestText: ex.Message,
                                responseText: null);
                return null;
            }
        }

        private async Task<ItemGroupDefaults> GetItemGroupDefaultsAsync(string itemGroup)
        {
            try
            {

                var response = await httpClient.GetAsync(
                    $"{_baseUrl}/api/resource/Item Group/{itemGroup}"
                );
                Console.WriteLine($"Response status: {response.StatusCode}");
                //var url = $"{_baseUrl}/api/resource/Item Group/{Uri.EscapeDataString(itemGroup)}";
                //var response = await httpClient.GetAsync(url);

                if (!response.IsSuccessStatusCode)
                {
                    Console.WriteLine($"Item Group '{itemGroup}' not found!");
                    return new ItemGroupDefaults();
                }

                var json = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"Raw JSON: {json}");  // Add this to see what's actually returned

                var doc = JsonDocument.Parse(json);
                var data = doc.RootElement.GetProperty("data");
                // Check ALL possible account field names
                Console.WriteLine("Available properties in item group:");

                foreach (var prop in data.EnumerateObject())
                {
                    Console.WriteLine($"  {prop.Name}: {prop.Value}");
                }

                return ParseItemGroupDefaults(data);                
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error getting item group: {ex.Message}");
                return new ItemGroupDefaults();
            }
        }
        private ItemGroupDefaults ParseItemGroupDefaults(JsonElement data)
        {
            // Check if item_group_defaults array exists and has at least one element
            if (data.TryGetProperty("item_group_defaults", out var defaultsArray) &&
                defaultsArray.ValueKind == JsonValueKind.Array &&
                defaultsArray.GetArrayLength() > 0)
            {
                var defaults = defaultsArray[0]; // Take the first company/default
                return new ItemGroupDefaults
                {
                    income_account = GetOptionalString(defaults, "income_account"),
                    expense_account = GetOptionalString(defaults, "expense_account"),
                    cost_center = GetOptionalString(defaults, "selling_cost_center")
                };
            }

            // fallback if no defaults exist
            return new ItemGroupDefaults
            {
                income_account = null,
                expense_account = null,
                cost_center = null
            };
        }

        private string GetOptionalString(JsonElement element, string propertyName)
        {
            if (element.TryGetProperty(propertyName, out var prop) &&
                prop.ValueKind != JsonValueKind.Null &&
                prop.ValueKind != JsonValueKind.Undefined)
            {
                return prop.GetString();
            }

            return null;
        }


        private async Task<(string income, string expense, string costCenter)> ResolveAccountsAsync(string itemCode)
        {
            Console.WriteLine($"=== DEBUG: Resolving accounts for {itemCode} ===");
            try
            {

                var item = await GetItemAsync(itemCode);

                Console.WriteLine($"Item: {itemCode}");
                Console.WriteLine($"Income Account: {item.income_account}");
                Console.WriteLine($"Expense Account: {item.expense_account}");
                Console.WriteLine($"Cost Center: {item.cost_center}");
                Console.WriteLine($"Is null/empty income: {string.IsNullOrEmpty(item.income_account)}");
                Console.WriteLine($"Is null/empty expense: {string.IsNullOrEmpty(item.expense_account)}");
                // 1️⃣ Item-level
                if (!string.IsNullOrEmpty(item.income_account))
                {
                    Console.WriteLine($"RETURNING item accounts");
                    return (item.income_account, item.expense_account, item.cost_center);
                }
                else
                {
                    Console.WriteLine($"Item has no accounts, getting company defaults");
                    var companyDefaults = await GetCompanyDefaultsAsync();
                    Console.WriteLine($"Company income: '{companyDefaults.default_income_account}'");
                    Console.WriteLine($"Company expense: '{companyDefaults.default_expense_account}'");

                    if (string.IsNullOrEmpty(companyDefaults.default_income_account))
                    {
                        throw new Exception("Company has no default income account configured!");
                    }

                    return (
                        companyDefaults.default_income_account,
                        companyDefaults.default_expense_account,
                        companyDefaults.cost_center
                    );
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR: {ex.Message}");
                throw;
            }

            //// 2️⃣ Item Group-level
            //var groupDefaults = await GetItemGroupDefaultsAsync(item.item_group);
            //if (!string.IsNullOrEmpty(groupDefaults.income_account))
            //    return (
            //        groupDefaults.income_account,
            //        groupDefaults.expense_account,
            //        groupDefaults.cost_center
            //    );

            // 3️⃣ Company defaults (SAFE fallback)
            // var companyDefaults = await GetCompanyDefaultsAsync();
            //return (
            //    companyDefaults.default_income_account,
            //    companyDefaults.default_expense_account,
            //    companyDefaults.cost_center
            //);
        }
        private async Task<ItemDto> GetItemAsync(string itemCode)
        {
            // 1. Get the item
            var response = await httpClient.GetAsync($"{_baseUrl}/api/resource/Item/{itemCode}");
            if (!response.IsSuccessStatusCode)
                throw new Exception($"Item {itemCode} not found in ERPNext");

            var json = await response.Content.ReadAsStringAsync();
            var doc = JsonDocument.Parse(json);
            var data = doc.RootElement.GetProperty("data");

            string itemGroup = data.GetProperty("item_group").GetString();

            // 2. Get the item group defaults
            var groupDefaults = await GetItemGroupDefaultsAsync(itemGroup);

            // 3. Return ItemDto with proper accounts
            return new ItemDto
            {
                item_code = data.GetProperty("item_code").GetString(),
                item_group = itemGroup,
                income_account =  groupDefaults.income_account,
                expense_account =  groupDefaults.expense_account,
                cost_center =  groupDefaults.cost_center,
                is_stock_item = data.GetProperty("is_stock_item").GetInt32() == 0
            };

        }

        private async Task<string> GetItemGroupAsync(string itemCode)
        {
            var response = await httpClient.GetAsync(
                $"{_baseUrl}/api/resource/Item/{itemCode}"
            );

            if (!response.IsSuccessStatusCode)
                throw new Exception($"Failed to fetch Item {itemCode}");

            var json = await response.Content.ReadAsStringAsync();
            var doc = JsonDocument.Parse(json);

            return doc.RootElement
                      .GetProperty("data")
                      .GetProperty("item_group")
                      .GetString();
        }

        private async Task<CompanyDefaults> GetCompanyDefaultsAsync()
        {
            var response = await httpClient.GetAsync(
                $"{_baseUrl}/api/resource/Company/{"MediNexus"}"
            );

            if (!response.IsSuccessStatusCode)
                throw new Exception("Company defaults not configured in ERPNext");

            var json = await response.Content.ReadAsStringAsync();
            var doc = JsonDocument.Parse(json);

            var data = doc.RootElement.GetProperty("data");

            return new CompanyDefaults
            {
                default_income_account = GetOptionalString(data, "default_income_account"),
                default_expense_account = GetOptionalString(data, "default_expense_account"),
                cost_center = GetOptionalString(data, "cost_center")
            };
        } 

        private void MarkInvoiceAsPosted(string invoiceNo, string ERPNextInvoiceNo, string remark)
        {
            clsUpdate.updateERPNextPostingStatus(ERPNextInvoiceNo, invoiceNo, remark);
        }

        private void UpdateGrid(string invoiceNo, string erpInvoiceNo)
        {
            foreach (DataGridViewRow row in dgvSales.Rows)
            {
                if (row.IsNewRow) continue;
                
                if (row.Cells["InvoiceNumber"].Value?.ToString() == invoiceNo)
                {
                    //dgvSales.Columns["ERPNextInvoiceNo"].ValueType = typeof(string);
                    row.Cells["ERPNextInvoiceNo"].Value = erpInvoiceNo.ToString();
                    row.Cells["Posted"].Value = "Yes";
                }
            }
        }
        private async Task CreateSalesReturnAsync(string originalInvoice)
        {            

            var status = await GetInvoiceStatusAsync(originalInvoice);

            if (status.HasReturn)
            {
                MessageBox.Show(
                    $"Invoice already refunded.\nReturns:\n{string.Join(", ", status.ReturnInvoices)}"
                );
                return;
            }

            // ✅ Safe to refund
            string creditNote = await ProcessRefund(originalInvoice);

            MessageBox.Show($"Refund successful\nCredit Note: {creditNote}");

        }


        private async Task<string> ProcessRefund(string originalInvoiceName)
        {
            httpClient.DefaultRequestHeaders.Clear();
            httpClient.DefaultRequestHeaders.Add(
                "Authorization",
                $"token {_apiKey}:{_apiSecret}"
            );
            // 1️⃣ Fetch original invoice (MUST get customer + items)
            var sourceResp = await httpClient.GetAsync(
                $"{_baseUrl}/api/resource/Sales Invoice/{originalInvoiceName}"
            );

            if (!sourceResp.IsSuccessStatusCode)
                ErrorLogger.Log(
                    reference: originalInvoiceName,
                    message: "Failed to fetch original Sales Invoice",
                    requestText: "",
                    responseText: sourceResp.ToString()
                );
            //throw new Exception("Failed to fetch original Sales Invoice");

            var sourceJson = await sourceResp.Content.ReadAsStringAsync();
            var sourceDoc = JsonDocument.Parse(sourceJson);
            var source = sourceDoc.RootElement.GetProperty("data");

            //var data = sourceDoc.RootElement.GetProperty("data");

            //var source = data[0]; // <-- FIRST OBJECT in array

            string customer = source.GetProperty("customer").GetString();
            string company = source.GetProperty("company").GetString();
            //bool isPos = source.TryGetProperty("is_pos", out var pos) && pos.GetBoolean();

            // ERPNext can store is_pos as number (0/1) or boolean
            bool isPos = false;
            if (source.TryGetProperty("is_pos", out var pos))
            {
                if (pos.ValueKind == JsonValueKind.Number)
                    isPos = pos.GetInt32() != 0; // 1 -> true, 0 -> false
                else if (pos.ValueKind == JsonValueKind.True || pos.ValueKind == JsonValueKind.False)
                    isPos = pos.GetBoolean();
            }
            // 2️⃣ Build return items (NEGATIVE qty & amount)
            var items = new List<object>();

            foreach (var item in source.GetProperty("items").EnumerateArray())
            {
                items.Add(new
                {
                    item_code = item.GetProperty("item_code").GetString(),
                    qty = -item.GetProperty("qty").GetDecimal(),
                    rate = item.GetProperty("rate").GetDecimal(),
                    income_account = item.GetProperty("income_account").GetString(),
                    expense_account = item.TryGetProperty("expense_account", out var ea)
                                        ? ea.GetString()
                                        : null,
                    cost_center = item.GetProperty("cost_center").GetString()
                });
            }

            // 3️⃣ Build credit note payload
            var refundInvoice = new
            {
                customer = customer,                 // ✅ MUST match original
                company = company,
                is_return = 1,
                return_against = originalInvoiceName,
                update_stock = 0,
                items = items,
                docstatus = 1                         // submit immediately
            };

            var json = JsonSerializer.Serialize(refundInvoice);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            // 4️⃣ Post Credit Note
            var refundResp = await httpClient.PostAsync(
                $"{_baseUrl}/api/resource/Sales Invoice",
                content
            );

            var refundBody = await refundResp.Content.ReadAsStringAsync();

            if (!refundResp.IsSuccessStatusCode)
            {
                ErrorLogger.Log(
                    reference: originalInvoiceName,
                    message: "Invoice Return failed",
                    requestText: json,
                    responseText: refundBody
                );

                throw new Exception("Refund failed");
            }

            var refundDoc = JsonDocument.Parse(refundBody);
            return refundDoc.RootElement.GetProperty("data").GetProperty("name").GetString();
        }


        private async Task<bool> CustomerExists(string customerCode)
        {

            //$"?fields=[\"name\"]" +
            var response = await httpClient.GetAsync(
                    $"{_baseUrl}/api/resource/Customer" +
                    $"?filters=[[\"custom_patient_id\",\"=\",\"{customerCode}\"]]" +
                    $"&limit_page_length=1"
            );

            if (!response.IsSuccessStatusCode)
                return false;

            var json = await response.Content.ReadAsStringAsync();
            var doc = JsonDocument.Parse(json);

            var data = doc.RootElement.GetProperty("data");

            return data.GetArrayLength() > 0;

            //var response = await httpClient.GetAsync(
            //    $"{_baseUrl}/api/resource/Customer/{customerCode}"
            //);

            //return response.IsSuccessStatusCode;
        }
        private async Task<InvoiceLookupResult> GetInvoiceStatusAsync(string customInvoiceNumber)
        {
            httpClient.DefaultRequestHeaders.Clear();
            httpClient.DefaultRequestHeaders.Add(
                "Authorization",
                $"token {_apiKey}:{_apiSecret}"
            );

            var result = new InvoiceLookupResult();            

            // 2️⃣ Check for returns (credit notes)
            var returnResponse = await httpClient.GetAsync(
                $"{_baseUrl}/api/resource/Sales Invoice" +
                $"?fields=[\"name\"]" +
                $"&filters=[[\"is_return\",\"=\",1],[\"return_against\",\"=\",\"{customInvoiceNumber}\"]]"
            );
            result.SalesInvoiceName = customInvoiceNumber;
            if (!returnResponse.IsSuccessStatusCode)
                return result;

            var returnJson = await returnResponse.Content.ReadAsStringAsync();
            var returnDoc = JsonDocument.Parse(returnJson);

            var returnData = returnDoc.RootElement.GetProperty("data");

            if (returnData.GetArrayLength() > 0)
            {
                result.HasReturn = true;

                foreach (var r in returnData.EnumerateArray())
                {
                    result.ReturnInvoices.Add(
                        r.GetProperty("name").GetString()
                    );
                }
            }

            return result;
        }

        
        private async Task CreateCustomer(string customerCode, string customerName)
        {
            var customer = new
            {
                name = customerCode,                 // 🔥 FORCE CUSTOMER CODE
                customer_name = customerName,
                customer_group = "All Customer Groups",
                territory = "All Territories",
                customer_type = "Individual",
                custom_patient_id = customerCode
            };

            var json = JsonSerializer.Serialize(customer);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await httpClient.PostAsync(
                $"{_baseUrl}/api/resource/Customer",
                content
            );

            var body = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
                throw new Exception(body);
        }

        private async void btnReversePost_Click(object sender, EventArgs e)
        {
            await CancelSalesInvoiceAsync(txtInvoiceToCancel.Text);
            MarkInvoiceAsPosted(txtInvoiceToCancel.Text, txtInvoiceToCancel.Text, "Canceled");
        }

        private async void btnRefundInvoice_Click(object sender, EventArgs e)
        {
            await CreateSalesReturnAsync(txtRefundInvoice.Text);
            MarkInvoiceAsPosted(txtRefundInvoice.Text, txtRefundInvoice.Text, "Refund");
        }
    }
    public class POSPayment
    {
        public string mode_of_payment { get; set; }
        public decimal amount { get; set; }
        public string account { get; set; }
    }

    public class ERPNextResponse
    {
        public ERPNextData data { get; set; }
    }

    public class ERPNextData
    {
        public string name { get; set; }
    }

    public class SalesInvoice
    {
        public string customer { get; set; }
        public string customerID { get; set; }
        public string posting_date { get; set; }
        public string custom_patient_id { get; set; }
        public string due_date { get; set; }
        public bool set_posting_time { get; set; } = true;
        public List<SalesInvoiceItem> items { get; set; }

        // 🔥 POS fields
        public int is_pos { get; set; }
        public string pos_profile { get; set; }
        public string company { get; set; }

        // Accounting
        public decimal paid_amount { get; set; }
        public decimal outstanding_amount { get; set; }

        // ❌ MUST NOT BE SENT FOR POS
        public List<POSPayment> payments { get; set; }

        public int docstatus { get; set; }
        public string custom_invoice_number { get; set; }
        public string cashier { get; set; }
        public string custom_bilid { get; set; }
    }

    public class SalesInvoiceItem
    {
        public string item_code { get; set; }
        public decimal qty { get; set; }
        public decimal rate { get; set; }
        public string uom { get; set; } = "Nos";
        public string income_account { get; set; }     // Revenue account
        public string expense_account { get; set; }    // COGS, only for stock items
        public string cost_center { get; set; }        // Optional, department/ward
    }

    public class ERPNextCustomer
    {
        public string customer_name { get; set; }
        public string customer_group { get; set; } = "All Customer Groups";
        public string territory { get; set; } = "All Territories";
        public string customer_type { get; set; } = "Individual";
        public int disabled { get; set; } = 0;
    }

    public class SalesInvoicePayment
    {
        public string mode_of_payment { get; set; }
        public decimal amount { get; set; }
    }

    public class ItemGroupDefaults
    {
        public string income_account { get; set; }
        public string expense_account { get; set; }
        public string cost_center { get; set; }
    }
    public class ItemDto
    {
        public string item_code { get; set; }
        public string item_group { get; set; }
        public string income_account { get; set; }
        public string expense_account { get; set; }
        public string cost_center { get; set; }
        public bool is_stock_item { get; set; }
    }

    public class CompanyDefaults
    {
        public string default_income_account { get; set; }
        public string default_expense_account { get; set; }
        public string cost_center { get; set; }
    }
    public class InvoiceLookupResult
    {
        public bool Exists { get; set; }
        public string SalesInvoiceName { get; set; }
        public bool HasReturn { get; set; }
        public List<string> ReturnInvoices { get; set; } = new List<string>();
    }

}
