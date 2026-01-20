using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Onana_Hospital_Management_System
{
    public partial class ERPNextSettings : Form
    {
        clsSelect selectClass = new clsSelect();
        clsInsert varinsert = new clsInsert();
        public ERPNextSettings()
        {
            InitializeComponent();
        }

        private void ERPNextSettings_Load(object sender, EventArgs e)
        {
            selectClass.getERPNextSetings(dgvSettings);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            varinsert.InsertToERPNextSettings(txtKey.Text,txtSecret.Text,txtCompany.Text);
        }
    }
}
