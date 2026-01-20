using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using DevExpress.XtraEditors;

namespace Onana_Hospital_Management_System
{
    public partial class frmHelp : XtraForm
    {
        public frmHelp()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start("http//mailto:agbenuwisdom@gmail.com");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
