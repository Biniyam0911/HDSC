using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Onana_Hospital_Management_System
{
    public partial class frmServiceSetting : XtraForm
    {
        readonly clsSelect selectClass = new clsSelect();
        readonly clsInsert varInsert = new clsInsert();
        readonly ClsUpdate varUpdate = new ClsUpdate();
        private static readonly HttpClient httpClient = new HttpClient();
        private readonly string _baseUrl = "http://196.188.64.222:8002";
        private readonly string _apiKey = "f4af4d4b5103c25";
        private readonly string _apiSecret = "0693376111c4d2c";
        public frmServiceSetting()
        {
            InitializeComponent();
        }
        public void ClearAll()
        {
            txtDServiceCode.ResetText();
            txtPrice.ResetText();
            txtServiceCode.ResetText();
            txtServiceName.ResetText();
        }
        private void frmServiceSetting_Load(object sender, EventArgs e)
        {
            dgServices.AutoGenerateColumns = false;
            selectClass.getProcedureServicesSetting(dgServices);
        }

        private void btnAddUpdate_Click(object sender, EventArgs e)
        {
            if(txtServiceCode.Text.Length >0 && txtPrice.Text.Length>0)
            {
                if(txtServiceName.Text.Length ==0)
                {
                    txtServiceName.Text = "";
                }
                varInsert.insertorUpdateService(txtServiceCode.Text, txtServiceName.Text, float.Parse(txtPrice.Text),cmbCategory.Text);
                selectClass.getProcedureServicesSetting(dgServices);
            }
            else
            {
                MessageBox.Show("Please type service code or price");
            }
            //varInsert.insertorUpdateService(txtServiceCode.Text, txtServiceName.Text, float.Parse(txtPrice.Text));
           
            ClearAll();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            varUpdate.DeleteService(txtDServiceCode.Text);
            selectClass.getProcedureServicesSetting(dgServices);
            ClearAll();
        }

        private void dgvServices_Clicked(object sender, DataGridViewCellEventArgs e)
        {
            txtServiceCode.Text = dgServices.CurrentRow.Cells[0].Value.ToString();
            txtDServiceCode.Text = dgServices.CurrentRow.Cells[0].Value.ToString();
            txtServiceName.Text = dgServices.CurrentRow.Cells[1].Value.ToString();
            txtPrice.Text = dgServices.CurrentRow.Cells[2].Value.ToString();
            cmbCategory.Text = dgServices.CurrentRow.Cells[3].Value.ToString();
        }

        private async void btnPostService_Click(object sender, EventArgs e)
        {
            btnPostService.Enabled = false;

            try
            {
                httpClient.DefaultRequestHeaders.Clear();
                httpClient.DefaultRequestHeaders.Add(
                    "Authorization",
                    $"token {_apiKey}:{_apiSecret}"
                );

                foreach (DataGridViewRow row in dgServices.Rows)
                {
                    if (row.IsNewRow) continue;

                    string itemCode = row.Cells["Code"].Value?.ToString();
                    string itemName = row.Cells["Description"].Value?.ToString();
                    string itemGroup = row.Cells["Category"].Value?.ToString();
                    string uom = "Nos";
                    bool isStockItem = true;

                    if (string.IsNullOrEmpty(itemCode) ||
                        string.IsNullOrEmpty(itemName) ||
                        string.IsNullOrEmpty(itemGroup))
                        continue;

                    try
                    {
                        if (await ItemExists(itemCode))
                        {
                            ErrorLogger.Log(
                            reference: itemCode,
                            message: "Item Code Exists",
                            requestText: $"ItemCode={itemCode}, ItemName={itemName}, ItemGroup={itemGroup}, UOM={uom}, IsStockItem={isStockItem}",
                            responseText: "Item Code Exists");
                            continue;
                        }
                            

                        var item = new ERPNextItem
                        {
                            item_code = itemCode,
                            item_name = itemName,
                            item_group = itemGroup,
                            stock_uom = string.IsNullOrEmpty(uom) ? "Nos" : uom,
                            is_stock_item = isStockItem ? 1 : 0
                        };

                        await CreateItem(item);

                        row.Cells["Posted"].Value = "Yes";
                    }
                    catch (Exception ex)
                    {
                        ErrorLogger.Log(
                        reference: itemCode,
                        message: "Item POST failed",
                        requestText: $"ItemCode={itemCode}, ItemName={itemName}, ItemGroup={itemGroup}, UOM={uom}, IsStockItem={isStockItem}",
                        responseText: ex.ToString()
);

                    }
                }

                MessageBox.Show(
                    "Item posting completed.\nCheck Logs for errors.",
                    "Done",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            finally
            {
                btnPostService.Enabled = true;
            }
        }
        private async Task CreateItem(ERPNextItem item)
        {
            var json = JsonSerializer.Serialize(item);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await httpClient.PostAsync(
                $"{_baseUrl}/api/resource/Item",
                content
            );

            var body = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
                throw new Exception(body);
        }

        private async Task<bool> ItemExists(string itemCode)
        {
            var response = await httpClient.GetAsync(
                $"{_baseUrl}/api/resource/Item/{itemCode}"
            );

            return response.IsSuccessStatusCode;
        }


    }

    public class ERPNextItem
    {
        public string item_code { get; set; }
        public string item_name { get; set; }
        public string item_group { get; set; }
        public string stock_uom { get; set; } = "Nos";
        public int is_stock_item { get; set; } = 1;
        public int disabled { get; set; } = 0;
    }

}


