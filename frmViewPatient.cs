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
    public partial class frmViewPatient : XtraForm
    {
        clsSelect selectClass = new clsSelect();
        public frmViewPatient()
        {
            InitializeComponent();
        }

        private void frmViewPatient_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //label1.Text = dataGridView1.CurrentCell.Value.ToString();
            //selectClass.selectImage(label1.Text, pictureBox1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string fname, sname, oname;



            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                //assigning data gride field to control 
                //using their index/ numeric position starting from zero
                label1.Visible=true;
                label1.Text = row.Cells[0].Value.ToString();
                selectClass.selectImage(label1.Text, pictureBox1);

                fname = row.Cells[1].Value.ToString();
                sname = row.Cells[2].Value.ToString();
                oname = row.Cells[3].Value.ToString();
                txtEmpname.Text = fname + " " + sname + " " + oname;
                
                txtresidence.Text = row.Cells[6].Value.ToString();
                
                txtAge.Text = row.Cells[5].Value.ToString();
                txtEmpPhone.Text = row.Cells[7].Value.ToString();

            }

           
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            selectClass.viewPatient(dataGridView1, dtpFrom,dtpTo);
        }
    }
}
