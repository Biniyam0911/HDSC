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
    public partial class frmMedication : XtraForm
    {
        clsSelect selectClass = new clsSelect();
        frmProduct prod = new frmProduct();
        public frmMedication()
        {
            InitializeComponent();
        }

        private void frmMedication_Load(object sender, EventArgs e)
        {
            
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
