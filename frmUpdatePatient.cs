using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using DevExpress.XtraEditors;

namespace Onana_Hospital_Management_System
{
    public partial class frmUpdatePatient : XtraForm
    {
        clsInsert varinsert = new clsInsert();
        clsSelect selectClass = new clsSelect();
        ErrorProvider err = new ErrorProvider();
        public frmUpdatePatient()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            validateLastName((Control)sender);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
             validateLastName(txtLastName);
            validateFirstName(txtFirstName);
            validateContact(txtContact) ;
            
            validateResAddress(txtResAddress);
           


            if (err.GetError(txtLastName).Length !=0)  {
                err.SetError(txtLastName, "Please enter a value");
               }
            else if (err.GetError(txtFirstName).Length !=0) {
                err.SetError(txtLastName, "Please enter a value");
             }
            else if (err.GetError(txtContact).Length !=0) {
                err.SetError(txtContact, "Please enter a numeric value of 10 digits long");
                 }
           
          else if(err.GetError(txtResAddress).Length !=0) 
                 {

                err.SetError(txtResAddress, "Please enter a value");
              }
           
            else
            {

                if (txtPatCode.Text.Length > 0)
                {
                    updatePatient(txtFirstName.Text.Trim(), txtLastName.Text.Trim(), txtOname.Text.Trim(), cboGender,  txtResAddress.Text,  txtContact.Text,  pictureBox1, int.Parse(txtAge.Text));
                    ClearErrorProvider();
                    ClearAll();
                }
                else
                {
                    MessageBox.Show("Please enter enter patient id");
                }

            }
        }

        private void ClearAll()
        {
            txtPatCode.Clear();
            txtLastName.Clear();
            txtOname.Clear();
            txtAge.Clear();
            txtResAddress.Clear();
            txtContact.Clear();
            txtFirstName.Clear();
            cboGender.SelectedIndex = -1;
        }

        void updatePatient(string pSname, string pFname, string pOname, System.Windows.Forms.ComboBox pGender, string pResidenAddres , string pContact, PictureBox pPhoto, int age)        
        {

            string updateBillString;
            SqlConnection con;
            // SqlCommand cmd;
            try
            {
                con = new SqlConnection(varinsert.ConString);
                con.Open();

                updateBillString = "update tblPatient set pSname =@pSname,pFname =@pFname, pOname =@pOname,pGender=@pGender ,pResidenAddres =@pResidenAddres , pContact=@pContact, pPhoto=@pPhoto, age=@age  where patID = '" + txtPatCode.Text.Trim() + "'";

                SqlCommand cmd = new SqlCommand(updateBillString, con);
                try
                {
                    cmd.Parameters.AddWithValue("@pSname", pSname.Trim());
                    cmd.Parameters.AddWithValue("@pFname", pFname.Trim());
                    cmd.Parameters.AddWithValue("@pOname",pOname.Trim());
                    cmd.Parameters.AddWithValue("@pGender", pGender.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@age", age);                    
                    cmd.Parameters.AddWithValue("@pResidenAddres", pResidenAddres.Trim());                   
                    cmd.Parameters.AddWithValue("@pContact", pContact.Trim());
                   

                    MemoryStream pp = new MemoryStream();
                    pPhoto.Image.Save(pp, pPhoto.Image.RawFormat);
                    Byte[] pdata = pp.GetBuffer();
                    SqlParameter ppic = new SqlParameter("pPhoto", System.Data.SqlDbType.Image);
                    ppic.Value = pdata;
                    cmd.Parameters.Add(ppic);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Updated successfully", "Save Data - MediSphere", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    con.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

      

    //GET PATIENT NAME
        public void selectPatDetails()
        {

            try
            {

                // string dbPath = @"Data Source=SONY\MSSQLSERVER00V1;Initial Catalog=dbOHMS;Integrated Security=True";


                SqlConnection con = new SqlConnection(varinsert.ConString);
                con.Open();

                SqlCommand cmd = new SqlCommand("select pSname,pFname,pOname,pGender,age,pResidenAddres,pContact,pPhoto from tblPatient where patID = '" + txtPatCode.Text.Trim() + "'", con);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtLastName.Text = reader["pFname"].ToString();
                    txtFirstName.Text = reader["pSname"].ToString();
                    txtOname.Text = reader["pOname"].ToString();
                    cboGender.SelectedItem = reader["pGender"].ToString();
                   
                    txtResAddress.Text = reader["pResidenAddres"].ToString();
                   
                   txtContact.Text =  reader["pContact"].ToString();
                  txtAge.Text = reader["age"].ToString();

                    MemoryStream ms = new MemoryStream((byte[])reader["pPhoto"]);
                    pictureBox1.Image = new Bitmap(ms);
                }
                else
                {
                    
                    txtLastName.Text = "";
                    txtFirstName.Text = "";
                    txtOname.Text ="";
                    cboGender.SelectedIndex = 0;
                    
                    txtResAddress.Text ="";
                    
                    txtContact.Text = "";
                   
                    pictureBox1.Image = Properties.Resources.index;

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }
        public void selectPatDetailsPhone()
        {

            try
            {

                // string dbPath = @"Data Source=SONY\MSSQLSERVER00V1;Initial Catalog=dbOHMS;Integrated Security=True";


                SqlConnection con = new SqlConnection(varinsert.ConString);
                con.Open();

                SqlCommand cmd = new SqlCommand("select patID,pSname,pFname,pOname,pGender,age,pResidenAddres,pContact,pPhoto from tblPatient where pContact = '" + txtPhoneNo.Text.Trim() + "'", con);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtPatCode.Text = reader["patID"].ToString();
                    txtLastName.Text = reader["pFname"].ToString();
                    txtFirstName.Text = reader["pSname"].ToString();
                    txtOname.Text = reader["pOname"].ToString();
                    cboGender.SelectedItem = reader["pGender"].ToString();

                    txtResAddress.Text = reader["pResidenAddres"].ToString();

                    txtContact.Text = reader["pContact"].ToString();
                    txtAge.Text = reader["age"].ToString();

                    MemoryStream ms = new MemoryStream((byte[])reader["pPhoto"]);
                    pictureBox1.Image = new Bitmap(ms);
                }
                else
                {

                    txtLastName.Text = "";
                    txtFirstName.Text = "";
                    txtOname.Text = "";
                    cboGender.SelectedIndex = 0;

                    txtResAddress.Text = "";

                    txtContact.Text = "";

                    pictureBox1.Image = Properties.Resources.index;

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void frmUpdatePatient_Load(object sender, EventArgs e)
        {
            cboGender.SelectedIndex = -1;
            
        }

        private void txtPatCode_TextChanged(object sender, EventArgs e)
        {
            if (txtPatCode.Text.Trim().Length > 0)
            {
                selectPatDetails();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            selectClass.ImageUpload(pictureBox1);
        }


        //VALIDATEION OF THE TEXT BOXES
        void validateLastName(Control ctrl)
        {
            if (string.IsNullOrEmpty(txtLastName.Text))
            {
                err.SetError(txtLastName, "Please enter a value");
                return;
            }
            else if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                err.SetError(txtLastName, "Please enter a value");
                return;
            }
            else
            {
                err.SetError(txtLastName, string.Empty);
            }
        }

        void validateFirstName(Control ctrl)
        {
            if (string.IsNullOrEmpty(txtFirstName.Text))
            {
                err.SetError(txtFirstName, "Please enter a value");
                return;
            }
            else if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                err.SetError(txtFirstName, "Please enter a value");
                return;
            }
            else
            {
                err.SetError(txtFirstName, string.Empty);
            }
        }

        void validateContact(Control ctrl)
        {

            if (txtContact.Text.Trim().Length != 10)
            {
                err.SetError(txtContact, "Please enter a numeric value of 10 digits long");
                return;
            }
            else
            {
                err.SetError(txtContact, string.Empty);
            }
        }

     

        void validateResAddress(Control ctrl)
        {
            if (string.IsNullOrEmpty(txtResAddress.Text))
            {
                err.SetError(txtResAddress, "Please enter a value");
                return;
            }
            else if (string.IsNullOrWhiteSpace(txtResAddress.Text))
            {
                err.SetError(txtResAddress, "Please enter a value");
                return;
            }
            else
            {
                err.SetError(txtResAddress, string.Empty);
            }

        }

      


        private void txtLastName_Leave(object sender, EventArgs e)
        {
            validateLastName((Control)sender);
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            validateFirstName((Control)sender);
        }

        private void txtFirstName_Leave(object sender, EventArgs e)
        {
            validateFirstName((Control)sender);
        }

      

        private void txtContact_TextChanged(object sender, EventArgs e)
        {
            validateContact((Control)sender);
        }

        private void txtContact_Leave(object sender, EventArgs e)
        {
            validateContact((Control)sender);
        }

        private void txtResAddress_TextChanged(object sender, EventArgs e)
        {
            validateResAddress((Control)sender);
        }

        private void txtResAddress_Leave(object sender, EventArgs e)
        {
            validateResAddress((Control)sender);
        }

      

        private void txtGContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            int isNumber;
            e.Handled = !int.TryParse(e.KeyChar.ToString(),out isNumber);
        }

        private void txtContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            int isNumber;
            e.Handled = !int.TryParse(e.KeyChar.ToString(), out isNumber);
        }


        //DESTROY ERROR PROVIDER ICONS AFTER SAVING
        void ClearErrorProvider()
        {
            err.SetError(txtFirstName, string.Empty);
            err.SetError(txtLastName, string.Empty);
           
            err.SetError(txtContact, string.Empty);
            err.SetError(txtResAddress, string.Empty);
           
        }

        private void txtPhoneNo_TextChanged(object sender, EventArgs e)
        {
            if (txtPhoneNo.Text.Trim().Length > 0)
            {
                selectPatDetailsPhone();
            }
        }
    }
}

