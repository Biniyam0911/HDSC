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
    public partial class frmPicture : XtraForm
    {
        public Image pic { get; set; }
        public frmPicture()
        {
            InitializeComponent();
        }

        private void frmPicture_Load(object sender, EventArgs e)
        {
            pcbImage.Image = pic;
        }
    }
}
