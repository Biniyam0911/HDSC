using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Onana_Hospital_Management_System
{
    public delegate void AddItemHandler(object sender, SalesOrderDM itemToAdd);
    public partial class Services : XtraForm
    {
        clsSelect selectClass = new clsSelect();
        float total = 0;
        //public List<SalesOrderDM> serviceItems = new List<SalesOrderDM>();
        public event AddItemHandler AddItem;
        private frmProcedure procedureform;
        public Services(frmProcedure procedureform)
        {
            InitializeComponent();
            this.procedureform = procedureform;
        }

        private void Services_Load(object sender, EventArgs e)
        {
            selectClass.getProcedureServices(dgvServices);
        }

        private void btnAddItems_Click(object sender, EventArgs e)
        {
            if (txtQuantity.Text == null || txtQuantity.Text.Length == 0 || int.Parse(txtQuantity.Text) == 0)
            {
                MessageBox.Show("Please type Quanity");
            }
            else
            {

                if (dgvServices.SelectedRows.Count > 0)
                {
                    SalesOrderDM member = new SalesOrderDM();
                    SalesOrderDM itemToAdd = new SalesOrderDM();
                   

                    itemToAdd.ServiceCode = dgvServices.CurrentRow.Cells[3].Value.ToString();
                    itemToAdd.ServiceName = dgvServices.CurrentRow.Cells[0].Value.ToString(); ;
                    itemToAdd.Category = dgvServices.CurrentRow.Cells[1].Value.ToString(); ;
                    itemToAdd.UnitPrice =float.Parse( dgvServices.CurrentRow.Cells[2].Value.ToString());
                    //itemToAdd.Qty = member.Qty;
                    itemToAdd.Qty = int.Parse(txtQuantity.Text);
                    itemToAdd.UnitPrice = float.Parse(dgvServices.CurrentRow.Cells[2].Value.ToString());
                    itemToAdd.TotalPrice = int.Parse(txtQuantity.Text) * float.Parse(dgvServices.CurrentRow.Cells[2].Value.ToString());
                    total += int.Parse(txtQuantity.Text) * float.Parse(dgvServices.CurrentRow.Cells[2].Value.ToString());

                    procedureform.dgvOrders.Rows.Add(itemToAdd.ServiceCode, itemToAdd.ServiceName,itemToAdd.Category, itemToAdd.UnitPrice, itemToAdd.Qty, itemToAdd.TotalPrice);
                   
                    procedureform.SetTotalTextBoxValue(Math.Round((total), 2).ToString());
                   
                    txtQuantity.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Please select item");
                }
            }
        }

        //private readonly frmProcedure _mainWindow;

        //public Services(frmProcedure mainWindow)
        //{
        //    _mainWindow = mainWindow;
        //    InitializeComponent();
        //}
    }
}
