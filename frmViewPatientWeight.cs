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
using DevExpress.XtraEditors;

namespace Onana_Hospital_Management_System
{
    public partial class frmViewPatientWeight : XtraForm
    {
        string ConString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        clsSelect selectClass = new clsSelect();
        clsInsert varinsert = new clsInsert();
        public frmViewPatientWeight()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmViewPatientWeight_Load(object sender, EventArgs e)
        {
            selectClass.selectPatientname(comboBox1);
            selectClass.callPatientWeight(dataGridView1);         
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            selectClass.callPatientWeight(dataGridView1);           
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                //string dbPath = @"Data Source=SONY\MSSQLSERVER00V1;Initial Catalog=dbOHMS;Integrated Security=True";
                // BindingSource bindingSource1 = new BindingSource();
                SqlConnection con = new SqlConnection(ConString);
                con.Open();
                //string sql="";
                //string sql = " SELECT    patID  as [ID], patName as [Patient Name], bmi as [BMI], pressure as [Pressure], temperature as [Temperature], measuredOnDate as [Date], measuredOnTime as [Time], pulserate as [Pulse Rate], respiratoryrate as [Respiratory Rate] from PatientWeight where patName='" + comboBox1.SelectedItem.ToString() + "'";
                //SqlCommand cmd = new SqlCommand(sql, con);
                string patname = comboBox1.Text;
                SqlCommand cmd = new SqlCommand("sp_get_select_patient_vital_sign", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@patname", patname);
                cmd.Parameters.AddWithValue("@date1",DateTime.Parse(dtpFrom.Text));
                cmd.Parameters.AddWithValue("@date2", DateTime.Parse(dtpTo.Text));
                //SqlDataReader reader;
                //reader = cmd.ExecuteReader();
                //while (reader.Read())
                //{
                //    MessageBox.Show(reader["Time"].ToString());
                //}
                //MessageBox.Show(comboBox1.Text);
                DataSet dsd = new DataSet();
                DataTable data = new DataTable();

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                //SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data);
                dataGridView1.DataSource = data;
                //dataGridView1.DataMember = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
