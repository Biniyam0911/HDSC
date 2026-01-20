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
    public partial class frmViewDept : XtraForm
    {
        clsSelect selectlass = new clsSelect();
        public frmViewDept()
        {
            InitializeComponent();
        }

        private void frmViewDept_Load(object sender, EventArgs e)
        {
            selectlass.viewDepartments(dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
