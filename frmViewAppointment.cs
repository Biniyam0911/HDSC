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
    public partial class frmViewAppointment : XtraForm
    {

        clsSelect selectClass = new clsSelect();
        public frmViewAppointment()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmViewAppointment_Load(object sender, EventArgs e)
        {
            
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            selectClass.callSchedule(dataGridView1, dtpFrom,dtpTo);
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
