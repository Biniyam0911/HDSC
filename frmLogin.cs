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
using System.Configuration;
using System.Windows.Input;
using DevExpress.XtraEditors;

namespace Onana_Hospital_Management_System
{
    public partial class frmLogin : XtraForm
    {
        clsSelect varSelect = new clsSelect();
        //clsInsert varinsert = new clsInsert();
        string ConString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        public string LogsUser { get; set; }

        public string myName;
        
        public frmLogin()
        {
            InitializeComponent();
        }       
        private void frmLogin_Load(object sender, EventArgs e)
        {
            //comboBox1.SelectedIndex = 0;
            notifyIcon1.Visible = true;
            notifyIcon1.ShowBalloonTip(5000, "Acknowledgement", "A product from MediSphere", ToolTipIcon.Info);
        
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            btnCancel_Click(sender, e);
        }

        //LOGIN
        void Logins(string Usernames, string Password)
         {
            try
            {
                if (Usernames == string.Empty || Password == string.Empty)
                {
                    MessageBox.Show("Wrong Username or Password");
                    txtPassword.Clear();

                }
                else
                {
                    string role ="";
                    DataSet ds = varSelect.checkCredential(Usernames, Password);
                    int count = ds.Tables[0].Rows.Count;
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                      role = row["Levels"].ToString(); // Replace with actual column name
                    }
                    //If count is equal to 1, than show frmMain form
                    if (count == 1)
                    {

                        frmParent fm = new frmParent { empRole = role, empName = Usernames };
                        this.Hide();
                        fm.Show();

                    }
                    else
                    {
                        MessageBox.Show("Invalid Username or Password", "Error -  MediSphere", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtPassword.Clear();
                    }
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Logins(txtUsername.Text, txtPassword.Text);
            
            varSelect.myUser = txtUsername.Text;
            LogsUser = txtUsername.Text.Trim();            
        }        

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Logins(txtUsername.Text, txtPassword.Text);
               
                varSelect.myUser = txtUsername.Text;
                LogsUser = txtUsername.Text.Trim();
            }
        }
    }
}
