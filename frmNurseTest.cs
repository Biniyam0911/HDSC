using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Media3D;
using DevExpress.XtraEditors;

namespace Onana_Hospital_Management_System
{
    public partial class frmNurseTest : XtraForm
    {
        clsSelect selectClass = new clsSelect();
        clsInsert varinsert = new clsInsert();
        DateTimePicker sysdate = new DateTimePicker();

        public frmNurseTest()
        {
            InitializeComponent();
        }

        private void txtPatID_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           selectClass.selectImage(txtPatID.Text.Trim(), pictImage);
            txtPatName.Text = selectClass.selectname(txtPatID.Text.Trim());
            
            //txtPatName.Text = selectClass.fullName;
        }

        private void frmDiagnose_Load(object sender, EventArgs e)
        {
            relay();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPatName_TextChanged(object sender, EventArgs e)
        {
            relay();
        }
              

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtPatID.Text.Trim() == string.Empty || txtPatName.Text.Trim() == string.Empty || txtPatHeight.Text.Trim() == string.Empty || txtPatWeight.Text.Trim() == string.Empty || txtpatPressure.Text.Trim() == string.Empty || txtPatTemperature.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please fill all fields", "Error - MediSphere", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            varinsert.insertIntoPatientWeight(float.Parse(txtPatHeight.Text), float.Parse(txtPatWeight.Text), txtPatID.Text, txtPatName.Text, double.Parse(txtpatBMI.Text), txtpatPressure.Text, double.Parse(txtPatTemperature.Text), sysdate, sysdate, txtPatPulseRate.Text,txtPatRespiratoryRate.Text);
            relay();
            txtPatName.Text = "";
            txtpatBMI.Text = "";
            //checkBox1.Checked = false;
            txtPatID.Text = "";
            txtPatRespiratoryRate.Text = "";
            txtPatPulseRate.Text = "";

            pictImage.Image = Properties.Resources.index;
        }

        //INITIATE
        void relay()
        {
            txtPatHeight.Text = "";
            txtPatWeight.Text = "";
            txtpatPressure.Text = "";
            txtPatTemperature.Text = "";
            txtPatPulseRate.Text = "";
            txtPatRespiratoryRate.Text = "";

            if (txtPatName.Text.Length > 0)
            {
                txtPatHeight.ReadOnly = false;
                txtPatWeight.ReadOnly = false;
                txtpatPressure.ReadOnly = false;
                txtPatTemperature.ReadOnly = false;
                txtPatPulseRate.ReadOnly = false;
                txtPatRespiratoryRate.ReadOnly = false;
            }
            else
            {
                txtPatHeight.ReadOnly = true;
                txtPatWeight.ReadOnly = true;
                txtpatPressure.ReadOnly = true;
                txtPatTemperature.ReadOnly = true;
                txtPatPulseRate.ReadOnly = true;
                txtPatRespiratoryRate.ReadOnly = true;
            }
        
        }
        
        private void txtPatWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 8)
            {
                //MessageBox.Show("Back");
            }
            else
            {
                int isnumber;
                e.Handled = !int.TryParse(e.KeyChar.ToString(), out isnumber);
            }
            
            
        }
        private void txtWeight_TextChanged(object sender, EventArgs e)
        {
            
            double Height, Weight;

            if (double.TryParse(txtPatHeight.Text, out Height) == true && double.TryParse(txtPatWeight.Text, out Weight) == true)
            {
                txtpatBMI.Text = selectClass.calBMI(Convert.ToDouble(txtPatHeight.Text), Convert.ToDouble(txtPatWeight.Text)).ToString("n2");

            }
            else
            {
                txtpatBMI.Text = "";
                //checkBox1.CheckState = 0;
               // MessageBox.Show("Either Height or Weight value is not numeric" + Environment.NewLine + "Please check the values", "Error - MediSphere", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }
    }
}
