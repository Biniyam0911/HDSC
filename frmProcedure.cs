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
    public partial class frmProcedure : XtraForm
    {
        public List<SalesOrderDM> salesOrderDM { get; set; } = new List<SalesOrderDM>();
        clsInsert varInsert = new clsInsert();
        clsSelect selectClass = new clsSelect();
        public string patid { get; set; }
        public string patname { get; set; }
        public string doctor { get; set; }

        public frmProcedure()
        {
            InitializeComponent();
            //dgvOrders.DataSource = salesOrderDM;
        }

        private void btnSelectService_Click(object sender, EventArgs e)
        {
            Services microStore = new Services(this);
            microStore.AddItem += new AddItemHandler(winAdd_AddItem);

            //microStore.TextBoxValueChanged += OtherWindowOnTextBoxValueChanged;
            microStore.Show();
        }

        void winAdd_AddItem(object sender, SalesOrderDM itemToAdd)
        {
            salesOrderDM.Add(itemToAdd);
        }

        public void SetTotalTextBoxValue(string value)
        {
            txtTotalPrice.Text = value;
        }

        private void frmProcedure_Load(object sender, EventArgs e)
        {
            txtCardno.Text = patid;
            txtFullname.Text = patname;
            
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if(dgvOrders.RowCount>1)
            {
                int cartnumber = selectClass.callCartNumber();
                for (int i = 0; i < dgvOrders.RowCount - 1; i++)
                {
                    varInsert.InsertIntoOrder(txtCardno.Text, txtFullname.Text, doctor, dgvOrders.Rows[i].Cells[1].Value.ToString(), float.Parse(dgvOrders.Rows[i].Cells[3].Value.ToString()), int.Parse(dgvOrders.Rows[i].Cells[4].Value.ToString()), cartnumber, dgvOrders.Rows[i].Cells[2].Value.ToString(), false);
                }
                varInsert.insertIntocartNumbere();

                MessageBox.Show("Procedure Ordered");
                this.Close();
            }
            else
            {
                MessageBox.Show("Please select Procedures");
            }
          
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            dgvOrders.Rows.Remove(dgvOrders.CurrentRow);
        }
    }
}
