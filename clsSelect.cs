using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Drawing;
using System.Data;
using System.ComponentModel;
using System.Configuration;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Windows.Shapes;
using Telerik.WinControls.UI;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraBars.Navigation;

namespace Onana_Hospital_Management_System
{
    class clsSelect:clsInsert
    {

        //string ConString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;

        double BMI;

        int getNum;
        float price;
        int getEmpNum;
        int getSuppNUm;
        int getReceiptNum;
        SqlDataReader reader;

       
        public int drugQty;
        public double PatBill;
        public string myUser;
        public string fullName;
        public string deptart;
        public string cont;
        public string designate;
        public double patientBills;
        public string Medication;
        public string Treatment;
       // public  string DrugName;
        public double DrugPrice;
       public  double myBillTotal;

        //==================================
        //   PRODUCT                        |
        //                                  |
        //=================================
        public string prosName;
        public string prosSuppliedBy;
        public string prosPrice;
        public string prosQty;
        public string prosDetails;
        public string prosManDate;
        public string prosLocation;
        public string prosExpiryDate;

        //=========================

        // CALL GEN Receipt NO
        public int GenReceiptNo()
        {


            try
            {
                //string ConString = @"Data Source=SONY\MSSQLSERVER00V1;Initial Catalog=dbOHMS;Integrated Security=True";
               // string sql = "select genReceiptNo from GenReceipt where genReceiptNo = (select max(genReceiptNo) from GenReceipt)";

                SqlConnection con = new SqlConnection(ConString);
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_get_max_invoice_no", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

               // SqlCommand cmd = new SqlCommand(sql, con);

                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    getReceiptNum = int.Parse(reader["id"].ToString());
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return getReceiptNum + 1;

        }


        public void LoadPatientHistory(string patientId, AccordionControl accordionControl1)
        {
            accordionControl1.Elements.Clear(); // Clear previous items

            using (SqlConnection conn = new SqlConnection(ConString))
            {
                conn.Open();
                //using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    //string query = "SELECT VisitDate, Diagnosis, Treatment FROM PatientHistory WHERE PatientID = @PatientID ORDER BY VisitDate DESC";
                    SqlCommand cmd = new SqlCommand("sp_get_patient_history", conn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@patid", patientId);


                    //cmd.Parameters.AddWithValue("@PatientID", patientId);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string visitDate = reader["consultDate"].ToString();
                            string DocCode = reader["DocCode"].ToString();

                            string assessment = reader["assessment"].ToString();
                            string chiefcompliant = reader["chiefcompliant"].ToString();
                            string diagnosis = reader["diagnosis"].ToString();                            
                            string history = reader["history"].ToString();
                            string medication = reader["medication"].ToString();
                            string objective = reader["objective"].ToString();
                            string pe = reader["pe"].ToString();
                            string plan = reader["plan"].ToString();
                            string problem = reader["problem"].ToString();
                            string subjective = reader["subjective"].ToString();                            
                            string Treatment = reader["Treatment"].ToString();

                            // Create a new Accordion element
                            AccordionControlElement visitElement = new AccordionControlElement
                            {
                                Text = $"Visit Date: {visitDate}   :   Doctor: { DocCode }",
                                Style = ElementStyle.Group
                            };
                            AccordionControlElement chiefcompliantElement = new AccordionControlElement
                            {
                                Text = "Chief Compliant: " + chiefcompliant,
                                Style = ElementStyle.Item
                            };
                            // Add Diagnosis
                            AccordionControlElement historyElement = new AccordionControlElement
                            {
                                Text = "History:         " + history,
                                Style = ElementStyle.Item
                            };
                            AccordionControlElement peElement = new AccordionControlElement
                            {
                                Text = "P/E:             " + pe,
                                Style = ElementStyle.Item
                            };
                            AccordionControlElement diagnosisElement = new AccordionControlElement
                            {
                                Text = "Diagnosis:       " + diagnosis,
                                Style = ElementStyle.Item
                            };
                            AccordionControlElement planElement = new AccordionControlElement
                            {
                                Text = "Plan:            " + plan,
                                Style = ElementStyle.Item
                            };
                            AccordionControlElement medicationElement = new AccordionControlElement
                            {
                                Text = "Medication:      " + medication,
                                Style = ElementStyle.Item
                            };

                          
                            // Add sub-items
                            
                            visitElement.Elements.Add(chiefcompliantElement);
                            visitElement.Elements.Add(historyElement);
                            visitElement.Elements.Add(peElement);
                            visitElement.Elements.Add(diagnosisElement);
                            visitElement.Elements.Add(planElement);
                            visitElement.Elements.Add(medicationElement);


                            // Add visit element to AccordionControl
                            accordionControl1.Elements.Add(visitElement);
                        }
                    }
                }
            }
        }

        public void getERPNextSetings(DataGridView dataGridView)
        {
            // string patname = "";
            try
            {

                SqlConnection con = new SqlConnection(ConString);

                SqlCommand cmd = new SqlCommand("sp_get_ErpNextSettings", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
           

                con.Open();
                DataSet dsd = new DataSet();
                DataTable data = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                adapter.Fill(data);
                dataGridView.DataSource = data;
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            // return patname;
        }

        public void getDailySales(DataGridView dataGridView, DateTime date1, DateTime date2)
        {
            // string patname = "";
            try
            {

                SqlConnection con = new SqlConnection(ConString);

                SqlCommand cmd = new SqlCommand("sp_get_sales_from_to", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@date1", date1);
                cmd.Parameters.AddWithValue("@date2", date2);

                con.Open();
                DataSet dsd = new DataSet();
                DataTable data = new DataTable();

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                //SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data);
                dataGridView.DataSource = data;
                //SqlCommand cmd = new SqlCommand("select pSname + ' ' + pFname + ' ' +  pOname as fullname from tblPatient where patID = '" + id + "'", con);
                //SqlDataReader reader = cmd.ExecuteReader();
                //if (reader.Read())
                //{
                //    patname = reader["fullname"].ToString();

                //}    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            // return patname;
        }
        public SqlDataReader getVitalSignsListforConsultation(string id)
        {
            SqlDataReader reader =null;
            try
            {
                //string ConString = @"Data Source=SONY\MSSQLSERVER00V1;Initial Catalog=dbOHMS;Integrated Security=True";
                SqlConnection con = new SqlConnection(ConString);
                con.Open();

                //SqlCommand cmd = new SqlCommand("select patID from tblPatient", con);
                SqlCommand cmd = new SqlCommand("sp_get_select_patient_vital_sign_for_consultation", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id", int.Parse(id));
                
                //SqlDataReader reader = cmd.ExecuteReader();
                //DataSet dsd = new DataSet();
                //DataTable data = new DataTable();
                reader = cmd.ExecuteReader();

                //SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                //adapter.Fill(data);
                //rgv.DataSource = data;
                //dgv.DataMember = sql;



                //while (reader.Read())
                //{

                //    id.Items.Add(reader["patID"].ToString());
                //   // lv.Items.Add(reader["patID"].ToString());
                //}

                //if (reader.Read())
                //{
                //    fullName = reader["fullname"].ToString();
                //      }
                //else
                //{
                //    fullName = "";

                //}

                //con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
            return reader;
        }
        public DataSet checkCredential(string Usernames, string Password)
        {
            SqlConnection con = new SqlConnection(ConString);

            SqlCommand cmd = new SqlCommand("sp_get_login_info", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            con.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            cmd.Parameters.AddWithValue("@Uname", Usernames.Trim());
            cmd.Parameters.AddWithValue("@Pwd", Password.Trim());
            //cmd.Parameters.AddWithValue("@Levels", comLevel.SelectedItem.ToString());

            adapt.Fill(ds);
            con.Close();
            return ds;        
        }
        //public string getRole(string username)
        //{
        //    string role = "";
        //    using (SqlConnection con = new SqlConnection(ConString))
        //    {
        //        con.Open();
        //        SqlCommand cmd = new SqlCommand("sp_get_role", con);
        //        cmd.CommandType = System.Data.CommandType.StoredProcedure;
        //        cmd.Parameters.AddWithValue("@username", username);

        //        SqlDataReader reader = cmd.ExecuteReader();
        //        while (reader.Read())
        //        {
        //            role = reader["Levels"].ToString();
        //        }


        //        //cmd.ExecuteNonQuery();

        //        con.Close();
        //    }
        //    return role;
        //}
        public string getEmpCode(string username)
        {
            string role = "";
            using (SqlConnection con = new SqlConnection(ConString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_get_emp_code", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@username", username);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    role = reader["empCode"].ToString();
                }


                //cmd.ExecuteNonQuery();

                con.Close();
            }
            return role;
        }
        public string getEmpName(string empCode)
        {
            string role = "";
            using (SqlConnection con = new SqlConnection(ConString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_get_emp_name", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@empcode", empCode);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    role = reader["fullname"].ToString();
                }


                //cmd.ExecuteNonQuery();

                con.Close();
            }
            return role;
        }
        public string getEmpQalification(string empCode)
        {
            string role = "";
            using (SqlConnection con = new SqlConnection(ConString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_get_emp_qualification", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@empcode", empCode);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    role = reader["qualification"].ToString();
                }


                //cmd.ExecuteNonQuery();

                con.Close();
            }
            return role;
        }
        public string getAge(string patid)
        {
            string age = "";
            using (SqlConnection con = new SqlConnection(ConString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_get_age", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@patid", patid);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    age = reader["age"].ToString();
                }


                //cmd.ExecuteNonQuery();

                con.Close();
            }
            return age;
        }
        public string getSex(string patid)
        {
            string age = "";
            using (SqlConnection con = new SqlConnection(ConString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_get_sex", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@patid", patid);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    age = reader["pGender"].ToString();
                }


                //cmd.ExecuteNonQuery();

                con.Close();
            }
            return age;
        }
        public string getAddress(string patid)
        {
            string address = "";
            using (SqlConnection con = new SqlConnection(ConString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_get_address", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@patid", patid);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    address = reader["address"].ToString();
                }


                //cmd.ExecuteNonQuery();

                con.Close();
            }
            return address;
        }
        //UPLOADING PICTURE
        public void ImageUpload(PictureBox pic)
        {
            try
            {

                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Title = "Choose Pic...";
                ofd.InitialDirectory = @"C:\Picture";
                if (ofd.ShowDialog() != DialogResult.Cancel)
                {
                    pic.Image = System.Drawing.Image.FromFile(ofd.FileName);
                }
            }
            catch
            { 
            
            
            }

        }

        // CALL GENPatID
        public int callGenPatientNo()
        {
            try
            {
                
                string sql = "select num from GenPatientNo where num = (select max(num) from GenPatientNo)";

                SqlConnection con = new SqlConnection(ConString);
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);

                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    getNum = int.Parse(reader["num"].ToString());
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return getNum + 1;

        }
        public int callCartNumber()
        {
            try
            {

                //string sql = "select num from GenPatientNo where num = (select max(num) from GenPatientNo)";

                SqlConnection con = new SqlConnection(ConString);
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_get_max_cart_number", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                //SqlCommand cmd = new SqlCommand(sql, con);

                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    getNum = int.Parse(reader["id"].ToString());
                }
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return getNum + 1;

        }
        public int callPrescNumber()
        {
            try
            {

                //string sql = "select num from GenPatientNo where num = (select max(num) from GenPatientNo)";

                SqlConnection con = new SqlConnection(ConString);
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_get_max_prescription_number", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                //SqlCommand cmd = new SqlCommand(sql, con);

                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    getNum = int.Parse(reader["id"].ToString());
                }
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return getNum + 1;

        }
        public float getServicePrice(string servicename)
        {
            try
            {

                //string sql = "select num from GenPatientNo where num = (select max(num) from GenPatientNo)";

                SqlConnection con = new SqlConnection(ConString);
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_get_service_price", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@servicename", servicename.Trim());
                //SqlCommand cmd = new SqlCommand(sql, con);

                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    price = float.Parse(reader["price"].ToString());
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return price;

        }
        // CALL GEN EMPLOYEE ID
        public int GenEmployeeNo()
        {


            try
            {
              //  string ConString = @"Data Source=SONY\MSSQLSERVER00V1;Initial Catalog=dbOHMS;Integrated Security=True";
                string sql = "select numNo from GenEmployeeNo where numNo = (select max(numNo) from GenEmployeeNo)";

                SqlConnection con = new SqlConnection(ConString);
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);

                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    getEmpNum = int.Parse(reader["numNo"].ToString());
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return getEmpNum + 1;

        }


        //GEN SUPPLIER ID
        public int GenSupplierNo()
        {

            try
            {
                //string ConString = @"Data Source=SONY\MSSQLSERVER00V1;Initial Catalog=dbOHMS;Integrated Security=True";
                string sql = "select genNum from GenSupNo where genNum = (select max(genNum) from GenSupNo)";

                SqlConnection con = new SqlConnection(ConString);
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);

                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    getSuppNUm = int.Parse(reader["genNum"].ToString());
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return getSuppNUm + 1;

        }

        //CALL DEPARTMENT
        public void getDepart(ComboBox comDept)
        {
            try
            {
               // string ConString = @"Data Source=SONY\MSSQLSERVER00V1;Initial Catalog=dbOHMS;Integrated Security=True";
                string sql = "select deptName from tblDepartment";

                SqlConnection con = new SqlConnection(ConString);
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);

                reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    comDept.Items.Add(reader["deptName"]);

                }
                comDept.SelectedIndex = 0;
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }





        }

        //CALL EMPLOYEE CODE
        public void getEmpCode(ComboBox comEmpcode)
        {
            try
            {
               // string ConString = @"Data Source=SONY\MSSQLSERVER00V1;Initial Catalog=dbOHMS;Integrated Security=True";
                string sql = "select empCode from tblEmployees";

                SqlConnection con = new SqlConnection(ConString);
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);

                reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    comEmpcode.Items.Add(reader["empCode"]);

                }
                comEmpcode.SelectedIndex = 0;
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //CALL EMPLOYEE Details

        public void getDetails(ComboBox comEmpcode)
        {
            try
            {
               // string ConString = @"Data Source=SONY\MSSQLSERVER00V1;Initial Catalog=dbOHMS;Integrated Security=True";
                SqlConnection con = new SqlConnection(ConString);
                con.Open();

                string sql = "select empSname + ' ' + empFname + ' ' + empOname as fullname, empContact, empDepartment,empDesignation from tblEmployees where empCode = '" + comEmpcode.Text + "'";


                SqlCommand cmd = new SqlCommand(sql, con);

                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    fullName = reader[0].ToString();
                    cont = reader[1].ToString();
                    deptart = reader[2].ToString();
                    designate = reader[3].ToString();

                }
                else
                {
                    fullName = "";
                    cont = "";
                    deptart = "";
                    designate = "";
                    MessageBox.Show("Employee not found", "Search Result - MediSphere", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


                }

                reader.Close();
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }





        }


        //SELECT PRODUCT BY ID
        public void getProductDetails(int id)
        {



            try
            {
               // string ConString = @"Data Source=SONY\MSSQLSERVER00V1;Initial Catalog=dbOHMS;Integrated Security=True";
                SqlConnection con = new SqlConnection(ConString);
                con.Open();
                string sql = "select proName, proSupplier, proLocation, proPrice, proQty, proManuDate, proExpiry, proDescription from tblProduct where proCode = '" + id + "'";

                SqlCommand cmd = new SqlCommand(sql, con);

                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    prosName = reader[0].ToString();
                    prosSuppliedBy = reader[1].ToString();
                    prosLocation = reader[2].ToString();
                    prosPrice = reader[3].ToString();
                    prosQty = reader[4].ToString();
                    prosManDate = reader[5].ToString();
                    prosExpiryDate = reader[6].ToString();
                    prosDetails = reader[7].ToString();


                }
                else
                {
                    prosName = "";
                    prosSuppliedBy = "";
                    prosPrice = "";
                    prosQty = "";
                    prosDetails = "";
                    prosManDate = "";
                    prosLocation = "";
                    prosExpiryDate = "";


                }
                reader.Close();
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }


        public void viewDrugs()
        {
           // string ConString = @"Data Source=SONY\MSSQLSERVER00V1;Initial Catalog=dbOHMS;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConString);
            con.Open();

            //SqlCommand cmd= new SqlCommand(sql, con);
            // dataAdapter  da = SqlDataAdapter(cmd);

        }

        public void selectImage(string id, PictureBox pics)
        {

            try
            {
               // string ConString = @"Data Source=SONY\MSSQLSERVER00V1;Initial Catalog=dbOHMS;Integrated Security=True";
                SqlConnection con = new SqlConnection(ConString);


                SqlCommand cmd = new SqlCommand("sp_get_select_image", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);

                con.Open();

                //SqlCommand cmd = new SqlCommand("select pPhoto from tblPatient where patID = '" + id + "'", con);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataSet ds = new DataSet();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {

                    MemoryStream ms = new MemoryStream((byte[])reader["pPhoto"]);
                    pics.Image = new Bitmap(ms);
                }
                else
                {
                    pics.Image = Properties.Resources.index;

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }


        //GET PATIENT NAME
        public string selectname(string id)
        {

            try
            {
                               
                SqlConnection con = new SqlConnection(ConString);

                SqlCommand cmd = new SqlCommand("sp_get_select_patient_name", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);

                con.Open();

                //SqlCommand cmd = new SqlCommand("select pSname + ' ' + pFname + ' ' +  pOname as fullname from tblPatient where patID = '" + id + "'", con);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    fullName = reader["fullname"].ToString();

                }
                else
                {
                    fullName = "";

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            return fullName;

        }
        public string selectAge(string id)
        {
            string age = "";
            try
            {

                SqlConnection con = new SqlConnection(ConString);

                SqlCommand cmd = new SqlCommand("sp_get_select_patient_age", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);

                con.Open();

                //SqlCommand cmd = new SqlCommand("select pSname + ' ' + pFname + ' ' +  pOname as fullname from tblPatient where patID = '" + id + "'", con);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    age = reader["age"].ToString();

                }
                else
                {
                    age = "";

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            return age;
        }
        public void searchPatientbyFullname(string fullname, DataGridView dataGridView)
        {
            // string patname = "";
            try
            {

                SqlConnection con = new SqlConnection(ConString);

                SqlCommand cmd = new SqlCommand("sp_get_select_procedures_patid", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@fullname", fullname);

                con.Open();
                DataSet dsd = new DataSet();
                DataTable data = new DataTable();

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                
                adapter.Fill(data);
                dataGridView.DataSource = data;
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
        public void searchLaboratorybyFullname(string fullname, DateTime date, DataGridView dataGridView)
        {
            // string patname = "";
            try
            {

                SqlConnection con = new SqlConnection(ConString);

                SqlCommand cmd = new SqlCommand("sp_get_select_Laboratory_patname", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@fullname", fullname);
                cmd.Parameters.AddWithValue("@date", date);

                con.Open();
                DataSet dsd = new DataSet();
                DataTable data = new DataTable();

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                adapter.Fill(data);
                dataGridView.DataSource = data;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void searchPrescriptionbyFullname(string fullname, DateTime precdate, DataGridView dataGridView)
        {
            // string patname = "";
            try
            {

                SqlConnection con = new SqlConnection(ConString);

                SqlCommand cmd = new SqlCommand("sp_get_select_prescription_patname", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@fullname", fullname);
                cmd.Parameters.AddWithValue("@date", precdate);

                con.Open();
                DataSet dsd = new DataSet();
                DataTable data = new DataTable();

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                adapter.Fill(data);
                dataGridView.DataSource = data;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void searchPatient(string searchterm, string str, DataGridView dataGridView)
        {
           // string patname = "";
            try
            {
                               
                SqlConnection con = new SqlConnection(ConString);

                SqlCommand cmd = new SqlCommand(str, con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", searchterm);

                con.Open();
                DataSet dsd = new DataSet();
                DataTable data = new DataTable();

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                //SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data);
                dataGridView.DataSource = data;
                //SqlCommand cmd = new SqlCommand("select pSname + ' ' + pFname + ' ' +  pOname as fullname from tblPatient where patID = '" + id + "'", con);
                //SqlDataReader reader = cmd.ExecuteReader();
                //if (reader.Read())
                //{
                //    patname = reader["fullname"].ToString();

                //}    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           // return patname;
        }
        public void getPatientVisits(string patid, DataGridView dataGridView)
        {
            // string patname = "";
            try
            {

                SqlConnection con = new SqlConnection(ConString);
                SqlCommand cmd = new SqlCommand("sp_get_view_paid_visits", con);

                //SqlCommand cmd = new SqlCommand(str, con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@patid", patid);

                con.Open();
                DataSet dsd = new DataSet();
                DataTable data = new DataTable();

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                //SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data);
                dataGridView.DataSource = data;
                //SqlCommand cmd = new SqlCommand("select pSname + ' ' + pFname + ' ' +  pOname as fullname from tblPatient where patID = '" + id + "'", con);
                //SqlDataReader reader = cmd.ExecuteReader();
                //if (reader.Read())
                //{
                //    patname = reader["fullname"].ToString();

                //}    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            // return patname;
        }
        public void getProcedureServicesSetting(DataGridView dataGridView)
        {
            // string patname = "";
            try
            {

                SqlConnection con = new SqlConnection(ConString);

                SqlCommand cmd = new SqlCommand("sp_get_procedure_services_for_setting", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@id", searchterm);

                con.Open();
                DataSet dsd = new DataSet();
                DataTable data = new DataTable();

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                //SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data);
                dataGridView.DataSource = data;
                //SqlCommand cmd = new SqlCommand("select pSname + ' ' + pFname + ' ' +  pOname as fullname from tblPatient where patID = '" + id + "'", con);
                //SqlDataReader reader = cmd.ExecuteReader();
                //if (reader.Read())
                //{
                //    patname = reader["fullname"].ToString();

                //}    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            // return patname;
        }
        public DataTable getServices()
        {
            DataTable data = null;
            try
            {

                SqlConnection con = new SqlConnection(ConString);

                SqlCommand cmd = new SqlCommand("sp_get_services", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@id", searchterm);

                con.Open();
                DataSet dsd = new DataSet();
                data = new DataTable();

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                //SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data);
                //dataGridView.DataSource = data;
                //SqlCommand cmd = new SqlCommand("select pSname + ' ' + pFname + ' ' +  pOname as fullname from tblPatient where patID = '" + id + "'", con);
                //SqlDataReader reader = cmd.ExecuteReader();
                //if (reader.Read())
                //{
                //    patname = reader["fullname"].ToString();

                //}    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
             return data;
        }
        public void getProcedureServices(DataGridView dataGridView)
        {
            // string patname = "";
            try
            {

                SqlConnection con = new SqlConnection(ConString);

                SqlCommand cmd = new SqlCommand("sp_get_procedure_services", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@id", searchterm);

                con.Open();
                DataSet dsd = new DataSet();
                DataTable data = new DataTable();

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                //SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data);
                dataGridView.DataSource = data;
                //SqlCommand cmd = new SqlCommand("select pSname + ' ' + pFname + ' ' +  pOname as fullname from tblPatient where patID = '" + id + "'", con);
                //SqlDataReader reader = cmd.ExecuteReader();
                //if (reader.Read())
                //{
                //    patname = reader["fullname"].ToString();

                //}    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            // return patname;
        }

        public DataSet getLaboratoryServices()
        {
            DataSet dsd = new DataSet();
            try
            {

                SqlConnection con = new SqlConnection(ConString);

                SqlCommand cmd = new SqlCommand("sp_get_laboratory_services", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                
                con.Open();
                
                DataTable data = new DataTable();

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                //SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dsd);
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dsd;
        }
        public void getMedications(DataGridView dataGridView)
        {
            // string patname = "";
            try
            {

                SqlConnection con = new SqlConnection(ConString);

                SqlCommand cmd = new SqlCommand("sp_get_medications", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@id", searchterm);

                con.Open();
                DataSet dsd = new DataSet();
                DataTable data = new DataTable();

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                //SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data);
                dataGridView.DataSource = data;
                //SqlCommand cmd = new SqlCommand("select pSname + ' ' + pFname + ' ' +  pOname as fullname from tblPatient where patID = '" + id + "'", con);
                //SqlDataReader reader = cmd.ExecuteReader();
                //if (reader.Read())
                //{
                //    patname = reader["fullname"].ToString();

                //}    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            // return patname;
        }
        //GET PATIENT NAME
        public void selectIdForname(RadGridView rgv, DateTimePicker date1, string doctor)
        {

            try
            {
                //string ConString = @"Data Source=SONY\MSSQLSERVER00V1;Initial Catalog=dbOHMS;Integrated Security=True";
                SqlConnection con = new SqlConnection(ConString);
                con.Open();

                //SqlCommand cmd = new SqlCommand("select patID from tblPatient", con);
                SqlCommand cmd = new SqlCommand("sp_get_assigned_patient_list_by_date", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@date1", DateTime.Parse(date1.Text));
                cmd.Parameters.AddWithValue("@doctor", doctor);
                //SqlDataReader reader = cmd.ExecuteReader();
                DataSet dsd = new DataSet();
                DataTable data = new DataTable();
                // SqlDataReader reader = cmd.ExecuteReader();

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data);
                rgv.DataSource = data;
                //dgv.DataMember = sql;



                //while (reader.Read())
                //{

                //    id.Items.Add(reader["patID"].ToString());
                //   // lv.Items.Add(reader["patID"].ToString());
                //}
                con.Close();
                //if (reader.Read())
                //{
                //    fullName = reader["fullname"].ToString();
                //      }
                //else
                //{
                //    fullName = "";

                //}


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }

        }
      
        public void FollowupList(RadGridView rgv, DateTimePicker date1, string doctor)
        {

            try
            {
                //string ConString = @"Data Source=SONY\MSSQLSERVER00V1;Initial Catalog=dbOHMS;Integrated Security=True";
                SqlConnection con = new SqlConnection(ConString);
                con.Open();

                //SqlCommand cmd = new SqlCommand("select patID from tblPatient", con);
                SqlCommand cmd = new SqlCommand("sp_get_assigned_patient_list_by_date_followup", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@date1", DateTime.Parse(date1.Text));
                cmd.Parameters.AddWithValue("@doctor", doctor);
                //SqlDataReader reader = cmd.ExecuteReader();
                DataSet dsd = new DataSet();
                DataTable data = new DataTable();
                // SqlDataReader reader = cmd.ExecuteReader();

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data);
                rgv.DataSource = data;
                //dgv.DataMember = sql;



                //while (reader.Read())
                //{

                //    id.Items.Add(reader["patID"].ToString());
                //   // lv.Items.Add(reader["patID"].ToString());
                //}
                con.Close();
                //if (reader.Read())
                //{
                //    fullName = reader["fullname"].ToString();
                //      }
                //else
                //{
                //    fullName = "";

                //}


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }

        }
        public void getVitalSignsList(RadGridView rgv,  string patid)
        {

            try
            {
                //string ConString = @"Data Source=SONY\MSSQLSERVER00V1;Initial Catalog=dbOHMS;Integrated Security=True";
                SqlConnection con = new SqlConnection(ConString);
                con.Open();

                //SqlCommand cmd = new SqlCommand("select patID from tblPatient", con);
                SqlCommand cmd = new SqlCommand("sp_get_vital_signs_for_consultation", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                
                cmd.Parameters.AddWithValue("@patid", patid);
                //SqlDataReader reader = cmd.ExecuteReader();
                DataSet dsd = new DataSet();
                DataTable data = new DataTable();
                // SqlDataReader reader = cmd.ExecuteReader();

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data);
                rgv.DataSource = data;
                //dgv.DataMember = sql;



                //while (reader.Read())
                //{

                //    id.Items.Add(reader["patID"].ToString());
                //   // lv.Items.Add(reader["patID"].ToString());
                //}
                con.Close();
                //if (reader.Read())
                //{
                //    fullName = reader["fullname"].ToString();
                //      }
                //else
                //{
                //    fullName = "";

                //}


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }

        }
        //CALCULATE BMI
        public double calBMI(double heightInMeters, double weightInKG)
        {
            //height in meter
            BMI = ((weightInKG) / (System.Math.Pow(heightInMeters, 2)));

            return BMI;
        }

        //VIEW PRODUCT
        public void callProductData(DataGridView dgv)
        {

            try
            {
              //  string ConString = @"Data Source=SONY\MSSQLSERVER00V1;Initial Catalog=dbOHMS;Integrated Security=True";
                SqlConnection con = new SqlConnection(ConString);
                con.Open();
                string sql = "select proCode as [Product No], proName as [Product Name], proSupplier as [Supplier], proLocation as [Product Location], proPrice as [Price], proQty as [Quantity], proManuDate as [Manufacturing Date], proExpiry as [Expiry Date], proDescription as [Description] from tblProduct";
                SqlCommand cmd = new SqlCommand(sql, con);
                DataSet dsd = new DataSet();
                DataTable data = new DataTable();
                // SqlDataReader reader = cmd.ExecuteReader();

                SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
                adapter.Fill(dsd, sql);
                dgv.DataSource = dsd;
                dgv.DataMember = sql;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //VIEW PATIENT
        public void callPatientData(DataGridView dgv)
        {

            try
            {
               // string ConString = @"Data Source=SONY\MSSQLSERVER00V1;Initial Catalog=dbOHMS;Integrated Security=True";
                SqlConnection con = new SqlConnection(ConString);
                con.Open();
                string sql = "select* from tblPatient";
                SqlCommand cmd = new SqlCommand(sql, con);
                DataSet dsd = new DataSet();
                DataTable data = new DataTable();
                // SqlDataReader reader = cmd.ExecuteReader();

                SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
                adapter.Fill(dsd, sql);
                dgv.DataSource = dsd;
                dgv.DataMember = sql;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //VIEW SUPPLIER
        public void callSupplierData(DataGridView dgv)
        {

            try
            {
              //  string ConString = @"Data Source=SONY\MSSQLSERVER00V1;Initial Catalog=dbOHMS;Integrated Security=True";
                SqlConnection con = new SqlConnection(ConString);
                con.Open();
                string sql = "select supCode as [Supplier ID], supName as [Name], supContact as [Contact], suptype as [Items], supPersonInCharge as [Sales Person], supContactPersonInCharge as [Phone Sale Person], supCountry as [Country], supEmail as [supplier Email], supAddress as [Location], supAgreementDate as [Contract On] from tblSupplier";
                SqlCommand cmd = new SqlCommand(sql, con);
                DataSet dsd = new DataSet();
                DataTable data = new DataTable();
                // SqlDataReader reader = cmd.ExecuteReader();

                SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
                adapter.Fill(dsd, sql);
                dgv.DataSource = dsd;
                dgv.DataMember = sql;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        //SELECT LEVELS
        public void GetLevels(ComboBox comLevels)
        {
            try
            {
                //string ConString = @"Data Source=SONY\MSSQLSERVER00V1;Initial Catalog=dbOHMS;Integrated Security=True";
                SqlConnection con = new SqlConnection(ConString);

                string sql = "select Levels from Users";
                SqlCommand cmd = new SqlCommand(sql, con);
                con.Open();
                SqlDataReader reader;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    comLevels.Items.Add(reader["Levels"]);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void GetConsultationServices(ComboBox comLevels)
        {
            try
            {
                //string ConString = @"Data Source=SONY\MSSQLSERVER00V1;Initial Catalog=dbOHMS;Integrated Security=True";
                SqlConnection con = new SqlConnection(ConString);

                

                //string sql = "select Levels from Users";
                //SqlCommand cmd = new SqlCommand(sql, con);
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_get_consultation_services", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader reader;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    comLevels.Items.Add(reader["servicename"]);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #region This login not valid

        //LOGIN
        //public void Logins(string Usernames, string Password, ComboBox comLevel)
        //{
        //    try
        //    {
        //        //string ConString = @"Data Source=SONY\MSSQLSERVER00V1;Initial Catalog=dbOHMS;Integrated Security=True";
        //        SqlConnection con = new SqlConnection(ConString);

        //        string sql = "select empCode, Uname,Pwd, Levels from Users where Uname = @Uname and Pwd = @Pwd and Levels = @Levels";
        //        SqlCommand cmd = new SqlCommand(sql, con);
        //        con.Open();
        //        DataSet ds = new DataSet();
        //        SqlDataAdapter adapt = new SqlDataAdapter(cmd);
        //        cmd.Parameters.AddWithValue("@Uname", Usernames.Trim());
        //        cmd.Parameters.AddWithValue("@Pwd", Password.Trim());
        //        cmd.Parameters.AddWithValue("@Levels", comLevel.SelectedItem.ToString());

        //        adapt.Fill(ds);
        //        con.Close();
        //        int count = ds.Tables[0].Rows.Count;

        //        //If count is equal to 1, than show frmMain form
        //        if (count == 1)
        //        {
        //            myUser = Usernames;
        //            frmParent fm = new frmParent();
        //            frmLogin log = new frmLogin();
        //            log.Hide();

        //            fm.getEmpCodes.Text = Usernames;
        //            fm.Show();
        //        }
        //        else
        //        {
        //            MessageBox.Show("Invalid Username or Password or Privilege", "Error - MediSphere", MessageBoxButtons.OK, MessageBoxIcon.Error);

        //        }

        //    }

        //    catch (Exception ex)
        //    {

        //    }

        //}


        //GET PATIENT NAME

        #endregion


        public void selectPatDetailsFromBill(string id)
        {

            try
            {
                // string ConString = @"Data Source=SONY\MSSQLSERVER00V1;Initial Catalog=dbOHMS;Integrated Security=True";


                SqlConnection con = new SqlConnection(ConString);
                con.Open();

                SqlCommand cmd = new SqlCommand("select patName,Amts from tblPatientBill where patID = '" + id + "'", con);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    fullName = reader["patName"].ToString();
                    PatBill = double.Parse(reader["Amts"].ToString());
                }
                else
                {
                    fullName = "";
                    PatBill = 0;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        //VIEW APPOINTMENT OR SCHEDULE
        public void callSchedule(DataGridView dgv, DateTimePicker dtpFrom, DateTimePicker dtpTo)
        {

            try
            {
                //string ConString = @"Data Source=SONY\MSSQLSERVER00V1;Initial Catalog=dbOHMS;Integrated Security=True";
               
                SqlConnection con = new SqlConnection(ConString);
                con.Open();
                //string sql = " select empCode as [Employee], subj as [Subject],categ as [Category],createOndate as [Date Created On] , createOnTime as [ Time Created On],EndOndate as [Date End On], EndOnTime as [Time End On],appNote as [Description] from tblSchedule";
                //SqlCommand cmd = new SqlCommand(sql, con);
                SqlCommand cmd = new SqlCommand("sp_get_view_assignment", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@date1", DateTime.Parse(dtpFrom.Text));
                cmd.Parameters.AddWithValue("@date2", DateTime.Parse(dtpTo.Text));

                DataSet dsd = new DataSet();
                DataTable data = new DataTable();
                // SqlDataReader reader = cmd.ExecuteReader();

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data);
                dgv.DataSource = data;
                //dgv.DataMember = sql;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public DataTable callmc()
        {
            DataTable data = null;
            try
            {
                //string ConString = @"Data Source=SONY\MSSQLSERVER00V1;Initial Catalog=dbOHMS;Integrated Security=True";

                SqlConnection con = new SqlConnection(ConString);
                con.Open();
                //string sql = " select empCode as [Employee], subj as [Subject],categ as [Category],createOndate as [Date Created On] , createOnTime as [ Time Created On],EndOndate as [Date End On], EndOnTime as [Time End On],appNote as [Description] from tblSchedule";
                //SqlCommand cmd = new SqlCommand(sql, con);
                SqlCommand cmd = new SqlCommand("sp_get_search_mc", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                

                DataSet dsd = new DataSet();
                 data = new DataTable();
                // SqlDataReader reader = cmd.ExecuteReader();

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data);
               
                //dgv.DataMember = sql;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return data;
        }
        public DataTable callConsultaionHistory(string doctor, string patid, ImageSlider slider)
        {
            DataTable data = null;
            try
            {
                //string ConString = @"Data Source=SONY\MSSQLSERVER00V1;Initial Catalog=dbOHMS;Integrated Security=True";

                SqlConnection con = new SqlConnection(ConString);
                con.Open();
                //string sql = " select empCode as [Employee], subj as [Subject],categ as [Category],createOndate as [Date Created On] , createOnTime as [ Time Created On],EndOndate as [Date End On], EndOnTime as [Time End On],appNote as [Description] from tblSchedule";
                //SqlCommand cmd = new SqlCommand(sql, con);
                SqlCommand cmd = new SqlCommand("sp_get_patient_daily_notes", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@doctor", doctor);
                cmd.Parameters.AddWithValue("@patid", patid);


                DataSet dsd = new DataSet();
                data = new DataTable();
                // SqlDataReader reader = cmd.ExecuteReader();

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data);

               // using (SqlConnection conn = new SqlConnection(connectionString))
                //{
                    //conn.Open();
                    using (SqlCommand cmd1 = new SqlCommand("SELECT imagedata FROM tblImage where patid=@patid and uploaddate=@date", con))
                    {
                    cmd1.Parameters.AddWithValue("@patid", patid);
                    cmd1.Parameters.AddWithValue("@date", DateTime.Today);
                    using (SqlDataReader reader = cmd1.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                byte[] imageBytes = (byte[])reader["imagedata"];
                                Image img = ByteArrayToImage(imageBytes);
                                slider.Images.Add(img);
                            }
                        }
                    }
               // }

                //dgv.DataMember = sql;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return data;
        }
        private Image ByteArrayToImage(byte[] byteArray)
        {
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }
        public DataTable callPatientHistory(string patid)
        {
            DataTable data = null;
            try
            {
                //string ConString = @"Data Source=SONY\MSSQLSERVER00V1;Initial Catalog=dbOHMS;Integrated Security=True";

                SqlConnection con = new SqlConnection(ConString);
                con.Open();
                //string sql = " select empCode as [Employee], subj as [Subject],categ as [Category],createOndate as [Date Created On] , createOnTime as [ Time Created On],EndOndate as [Date End On], EndOnTime as [Time End On],appNote as [Description] from tblSchedule";
                //SqlCommand cmd = new SqlCommand(sql, con);
                SqlCommand cmd = new SqlCommand("sp_get_patient_history", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@patid", patid.Trim());


                DataSet dsd = new DataSet();
                data = new DataTable();
                // SqlDataReader reader = cmd.ExecuteReader();

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data);

                //dgv.DataMember = sql;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return data;
        }
        //VIEW PATIENT WEIGHT
        public void callPatientWeight(DataGridView dgv)
        {

            try
            {
                //string ConString = @"Data Source=SONY\MSSQLSERVER00V1;Initial Catalog=dbOHMS;Integrated Security=True";
                SqlConnection con = new SqlConnection(ConString);
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_get_select_patient_all_vital_sign", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@id", id);



                //SqlConnection con = new SqlConnection(ConString);
                //con.Open();
                //string sql = "SELECT    patID  as [ID], patName as [Patient Name], bmi as [BMI], pressure as [Pressure], temperature as [Temperature], measuredOnDate as [Date], measuredOnTime as [Time] from PatientWeight";
                //SqlCommand cmd = new SqlCommand(sql, con);
                DataSet dsd = new DataSet();
                DataTable data = new DataTable();
                // SqlDataReader reader = cmd.ExecuteReader();
                //SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data);
                dgv.DataSource = data;
                //dgv.DataMember = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        //GET PATIENT BILL AND UPDATE
        public void selectname(ComboBox id)
        {

            try
            {
                // string ConString = @"Data Source=SONY\MSSQLSERVER00V1;Initial Catalog=dbOHMS;Integrated Security=True";


                SqlConnection con = new SqlConnection(ConString);
                con.Open();

                SqlCommand cmd = new SqlCommand("select Amts from tblPatientBill where patID = '" + id.SelectedItem.ToString() + "'", con);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    patientBills = double.Parse(reader["Amts"].ToString());

                }
                else
                {
                    patientBills = 0;

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        //SELECT LEVELS
        public void GetSuppliers(ComboBox comLevels)
        {
            try
            {
                //string ConString = @"Data Source=SONY\MSSQLSERVER00V1;Initial Catalog=dbOHMS;Integrated Security=True";
                SqlConnection con = new SqlConnection(ConString);

                string sql = "select supName from tblSupplier";
                SqlCommand cmd = new SqlCommand(sql, con);
                con.Open();
                SqlDataReader reader;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    comLevels.Items.Add(reader["supName"]);
                }
                comLevels.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //GET PATIENT NAME
        public void selectEmployeesname(ComboBox EmpFullname)
        {

            try
            {
                

                SqlConnection con = new SqlConnection(ConString);
                con.Open();

                //SqlCommand cmd = new SqlCommand("select empSname + ' '  + empFname +' ' + empOname as [fullname] from tblEmployees ", con);


                SqlCommand cmd = new SqlCommand("sp_get_select_doctors", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;


                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    EmpFullname.Items.Add(reader["fullname"].ToString());

                }
                EmpFullname.SelectedIndex = -1;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        //GET PATIENT NAME

      //  public void selectPatMedication(string id, DateTimePicker dt)


        //get employee image by id
        public void selectImageFromEmployee(string id, PictureBox pics)
        {

            try
            {
                // string ConString = @"Data Source=SONY\MSSQLSERVER00V1;Initial Catalog=dbOHMS;Integrated Security=True";
                SqlConnection con = new SqlConnection(ConString);
                con.Open();

                SqlCommand cmd = new SqlCommand("select epmPhoto from tblEmployees where empCode = '" + id + "'", con);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataSet ds = new DataSet();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {

                    MemoryStream ms = new MemoryStream((byte[])reader["epmPhoto"]);
                    pics.Image = new Bitmap(ms);
                }
                else
                {
                    pics.Image = null;

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        public void selectPatMedication(string id)
        {

            try
            {
                SqlConnection con = new SqlConnection(ConString);
                con.Open();
                SqlCommand cmd = new SqlCommand("select Treatment,medication from tblConsultation where patID = '" + id + "' and id = (select max(id) from tblConsultation)", con);
                

               // SqlCommand cmd = new SqlCommand("select Treatment,medication from tblConsultation where patID = '" + id + "'and consultDate = '" + dt.Value.Date +"'", con);
                
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    Treatment = reader["Treatment"].ToString();
                    Medication = reader["medication"].ToString();
                }
                else
                {
                    Treatment = "";
                    Medication = "";
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }


        //Views Tables
        public void viewUsers(DataGridView dgv)
        {
            try
            {
               
                SqlConnection con = new SqlConnection(ConString);

                string sql = "select empCode as [Employee ID], Uname as [Username], Levels as [Levels] from Users";
                SqlCommand cmd = new SqlCommand(sql, con);
                DataSet dsd = new DataSet();
                DataTable data = new DataTable();
                // SqlDataReader reader = cmd.ExecuteReader();

                SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
                adapter.Fill(dsd, sql);
                dgv.DataSource = dsd;
                dgv.DataMember = sql;

            }

            catch (Exception ex)
            {
                MessageBox.Show (ex.Message);   
            }

        }

        public void viewPatient(DataGridView dgv, DateTimePicker dtpFrom, DateTimePicker dtpTo)
        {
            try
            {

                SqlConnection con = new SqlConnection(ConString);

                //string sql = "select  patID as [Patient ID], pFname as [Firstname], pSname as [Lastname],  pOname as [G Father Name], pGender as [Gender],   age  as [Age], pResidenAddres as [Address], pContact as [Phone], pDateRegistered as [Registered Date] from tblPatient where regdate between";
                //SqlCommand cmd = new SqlCommand(sql, con);
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_get_view_patient_by_date", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                
                cmd.Parameters.AddWithValue("@date1", DateTime.Parse(dtpFrom.Text));
                cmd.Parameters.AddWithValue("@date2", DateTime.Parse(dtpTo.Text));


                DataSet dsd = new DataSet();
                DataTable data = new DataTable();
                // SqlDataReader reader = cmd.ExecuteReader();

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data);
                dgv.DataSource = data;
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void viewDailTransact(DataGridView dgv)
        {
            try
            {

                SqlConnection con = new SqlConnection(ConString);

                string sql = "select ReceiptNo as [Receipt Number], PatientName as [Patient Name],TransDate as [Transaction Date], TransTime as [Transaction Time],Amts as [Amount Paid],AmtBalance as [Balance], TransBy as [Transaction By] from DailyTransaction";
                SqlCommand cmd = new SqlCommand(sql, con);
                DataSet dsd = new DataSet();
                DataTable data = new DataTable();
                // SqlDataReader reader = cmd.ExecuteReader();

                SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
                adapter.Fill(dsd, sql);
                dgv.DataSource = dsd;
                dgv.DataMember = sql;

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void viewDepartments(DataGridView dgv)
        {
            try
            {

                SqlConnection con = new SqlConnection(ConString);

                string sql = "select id as [No], deptName as [Department] from tblDepartment";
                SqlCommand cmd = new SqlCommand(sql, con);
                DataSet dsd = new DataSet();
                DataTable data = new DataTable();
                // SqlDataReader reader = cmd.ExecuteReader();

                SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
                adapter.Fill(dsd, sql);
                dgv.DataSource = dsd;
                dgv.DataMember = sql;
               

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void viewBills(DataGridView dgv, bool isPaid, DateTimePicker dtpFrom, DateTimePicker dtpTo)
        {
            try
            {

                SqlConnection con = new SqlConnection(ConString);

                //string sql = "select patID as [Patience ID],patName as [Patient Name],Amts as [Balance GH₵] from tblPatientBill";
                //SqlCommand cmd = new SqlCommand(sql, con);
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_get_unpaid_bills", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@isPaid", isPaid);
                cmd.Parameters.AddWithValue("@dtpFrom", DateTime.Parse(dtpFrom.Text));
                cmd.Parameters.AddWithValue("@dtpTo", DateTime.Parse(dtpTo.Text));

                DataSet dsd = new DataSet();
                DataTable data = new DataTable();
                // SqlDataReader reader = cmd.ExecuteReader();

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data);
                dgv.DataSource = data;
               // dgv.DataMember = sql;


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void viewPaidBills(DataGridView dgv, bool isPaid, DateTimePicker dtpFrom, DateTimePicker dtpTo, bool posted)
        {
            try
            {

                SqlConnection con = new SqlConnection(ConString);

                //string sql = "select patID as [Patience ID],patName as [Patient Name],Amts as [Balance GH₵] from tblPatientBill";
                //SqlCommand cmd = new SqlCommand(sql, con);
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_get_paid_bills", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@dtpFrom", DateTime.Parse(dtpFrom.Text));
                cmd.Parameters.AddWithValue("@dtpTo", DateTime.Parse(dtpTo.Text));
                cmd.Parameters.AddWithValue("@posted", posted);

                DataSet dsd = new DataSet();
                DataTable data = new DataTable();
                // SqlDataReader reader = cmd.ExecuteReader();

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data);
                dgv.DataSource = data;
                // dgv.DataMember = sql;


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void viewEmployee(DataGridView dgv)
        {
            try
            {

                SqlConnection con = new SqlConnection(ConString);

                string sql = "select  empCode as [Employee ID], empSname as [Lastname], empFname as [Firstname], empOname as [Othername],age, empGender as [Gender], empContact  as [Phone], empEmail as [Email], empNationality as [Country],empDateJoined as [Employed On],empDepartment as [Department],empDesignation as [Designation], empQualification as [Qualification], empResidenceAddress as [Residence], empReferenceName as [Reference Name],empReferenceContact as [Reference Contact] from tblEmployees";
                SqlCommand cmd = new SqlCommand(sql, con);
                DataSet dsd = new DataSet();
                DataTable data = new DataTable();
                // SqlDataReader reader = cmd.ExecuteReader();

                SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
                adapter.Fill(dsd, sql);
                dgv.DataSource = dsd;
                dgv.DataMember = sql;

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //GET PATIENT BILL AND UPDATE
        public void selectDocName(ComboBox Levels)
        {


            try
            {
                //string ConString = @"Data Source=SONY\MSSQLSERVER00V1;Initial Catalog=dbOHMS;Integrated Security=True";
                SqlConnection con = new SqlConnection(ConString);

                string sql = "select Uname from Users where Levels ='" + "Doctor" + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                con.Open();
                SqlDataReader reader;
                reader = cmd.ExecuteReader();
               
                 while (reader.Read())
                {

                    Levels.Items.Add(reader["Uname"].ToString());
                }
                 Levels.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

       public void SelectDrug(string Drug)
        {
            try 
            {
                
            
                SqlConnection con = new SqlConnection(ConString);
                con.Open();

                string sql = "select proPrice from tblProduct where proName ='" + Drug.Trim() + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                
                 //SqlDataReader reader = cmd.ExecuteReader();

                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                   // DrugName = reader["proName"].ToString();
                    DrugPrice =double.Parse( reader["proPrice"].ToString());
                }
                else
                        {
                   // DrugName = "";
                    DrugPrice = 0;
                     }
                con.Close();
            }
                catch(Exception ex)
            {
                MessageBox.Show(ex.Message);    
            }
            }

       public void SelectDrugName(ComboBox Drug)
       {
           try
           {


               SqlConnection con = new SqlConnection(ConString);
               con.Open();

               string sql = "select proName from tblProduct";
               SqlCommand cmd = new SqlCommand(sql, con);

               reader = cmd.ExecuteReader();

              while (reader.Read())
               {
                   
                   Drug.Items.Add(reader["proName"].ToString());
               }
               Drug.SelectedIndex = 0;
               con.Close();
           }
           catch (Exception ex)
           {
               MessageBox.Show(ex.Message);
           }
       }

       public void selectConsultation(DataGridView dgv)
       {

           try
           {

               SqlConnection con = new SqlConnection(ConString);

               string sql = "select patID as [Patient ID], DocCode as [Doctor], consultDate as [Date], consultTime as [Time], diagnosis  as [Diagnose],  Treatment as [Treatment], medication as [Medication] from tblConsultation";
               SqlCommand cmd = new SqlCommand(sql, con);
               DataSet dsd = new DataSet();
               DataTable data = new DataTable();
               // SqlDataReader reader = cmd.ExecuteReader();

               SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
               adapter.Fill(dsd, sql);
               dgv.DataSource = dsd;
               dgv.DataMember = sql;


           }

           catch (Exception ex)
           {
               MessageBox.Show(ex.Message);
           }
       }

       public void selectConImage(string id, PictureBox pics)
       {

           try
           {
               // string ConString = @"Data Source=SONY\MSSQLSERVER00V1;Initial Catalog=dbOHMS;Integrated Security=True";
               SqlConnection con = new SqlConnection(ConString);
               con.Open();

               SqlCommand cmd = new SqlCommand("select testImage1 from tblConsultation where patID = '" + id + "'", con);

               SqlDataAdapter da = new SqlDataAdapter(cmd);

               DataSet ds = new DataSet();
               SqlDataReader reader = cmd.ExecuteReader();
               if (reader.Read())
               {

                   MemoryStream ms = new MemoryStream((byte[])reader["testImage"]);
                   pics.Image = new Bitmap(ms);
               }
               else
               {
                   pics.Image = null;

               }


           }
           catch (Exception ex)
           {
               MessageBox.Show(ex.Message);

           }

       }
        public void selectSignature(string empcode, PictureBox pics)
        {

            try
            {
                // string ConString = @"Data Source=SONY\MSSQLSERVER00V1;Initial Catalog=dbOHMS;Integrated Security=True";
                SqlConnection con = new SqlConnection(ConString);
                con.Open();

                SqlCommand cmd = new SqlCommand("select epmPhoto from tblEmployees where empCode = '" + empcode + "'", con);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataSet ds = new DataSet();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {

                    MemoryStream ms = new MemoryStream((byte[])reader["epmPhoto"]);
                    pics.Image = new Bitmap(ms);
                }
                else
                {
                    pics.Image = null;

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        public void viewItemBills(DataGridView dgv)
       {
           try
           {

               SqlConnection con = new SqlConnection(ConString);

               string sql = "select patID as [Patient ID], PatientName as [Patient Name], TransDate as [Transaction Date], TransTime as [Transaction Time], Item , Amts as [Price GH₵], TransBy[Server] from ItemsBills";
               SqlCommand cmd = new SqlCommand(sql, con);
               DataSet dsd = new DataSet();
               DataTable data = new DataTable();
               // SqlDataReader reader = cmd.ExecuteReader();

               SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
               adapter.Fill(dsd, sql);
               dgv.DataSource = dsd;
               dgv.DataMember = sql;

           }

           catch (Exception ex)
           {
                MessageBox.Show(ex.Message);
            }

       }
        public void selectPatientnameTransfer(ComboBox names)
        {

            try
            {
                SqlConnection con = new SqlConnection(ConString);
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_get_select_patient_names_for_transfer", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@id", id);


                //SqlCommand cmd = new SqlCommand("select pSname + ' ' + pFname + ' ' +  pOname as [fullname] from tblPatient", con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    names.Items.Add(reader["patname"].ToString());

                }
                names.SelectedIndex = -1;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }
        public string getPatDoctor(string patname)
        {
            string originalDoctor = "";
            try
            {
                SqlConnection con = new SqlConnection(ConString);
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_get_select_patient_names_doctor", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@patname", patname);


                //SqlCommand cmd = new SqlCommand("select pSname + ' ' + pFname + ' ' +  pOname as [fullname] from tblPatient", con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    originalDoctor =  reader["doctor"].ToString();

                }
               // names.SelectedIndex = -1;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            return originalDoctor;
        }

        //GET PATIENT NAME
        public void selectPatientname(ComboBox names)
       {

           try
           {
                SqlConnection con = new SqlConnection(ConString);
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_get_select_patient_names", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@id", id);
                

               //SqlCommand cmd = new SqlCommand("select pSname + ' ' + pFname + ' ' +  pOname as [fullname] from tblPatient", con);
               SqlDataReader reader = cmd.ExecuteReader();
              while (reader.Read())
               {
                  names.Items.Add( reader["fullname"].ToString());

               }
              names.SelectedIndex = -1;

           }
           catch (Exception ex)
           {
               MessageBox.Show(ex.Message);

           }

       }

        public DataTable selectPrescriptionPatientname(DateTime PrescriptionDate)
        {
            DataTable prescnamedt = null;
            try
            {
                SqlConnection con = new SqlConnection(ConString);
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_get_select_patient_names_from_prescription", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@prescriptindate", PrescriptionDate);

                prescnamedt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(prescnamedt);
                //SqlCommand cmd = new SqlCommand("select pSname + ' ' + pFname + ' ' +  pOname as [fullname] from tblPatient", con);
                //SqlDataReader reader = cmd.ExecuteReader();
                //while (reader.Read())
                //{
                //    names.Items.Add(reader["fullname"].ToString());

                //}
                //names.SelectedIndex = -1;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            return prescnamedt;
        }
        public DataTable selectLabOrderPatientname(DateTime laborderdate)
        {
            DataTable labordernamedt = null;
            try
            {
                SqlConnection con = new SqlConnection(ConString);
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_get_select_patient_names_from_laboratory", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@laborderdate", laborderdate);

                labordernamedt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(labordernamedt);
                //SqlCommand cmd = new SqlCommand("select pSname + ' ' + pFname + ' ' +  pOname as [fullname] from tblPatient", con);
                //SqlDataReader reader = cmd.ExecuteReader();
                //while (reader.Read())
                //{
                //    names.Items.Add(reader["fullname"].ToString());

                //}
                //names.SelectedIndex = -1;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            return labordernamedt;
        }
        //Select Product Qty
        public void selectDrugQty(string proName)
       {

           try
           {
               // string ConString = @"Data Source=SONY\MSSQLSERVER00V1;Initial Catalog=dbOHMS;Integrated Security=True";


               SqlConnection con = new SqlConnection(ConString);
               con.Open();

               SqlCommand cmd = new SqlCommand("select proQty from tblProduct where proName = '" + proName + "'", con);
               SqlDataReader reader = cmd.ExecuteReader();
               if (reader.Read())
               {

                   drugQty = int.Parse(reader["proQty"].ToString());
               }
               else
               {
                   drugQty = 0;
               }


           }
           catch (Exception ex)
           {
               MessageBox.Show(ex.Message);

           }

       }


        //SUM UP TOTAL BILL
       public void calcBilling(Label lab)
       {

           try
           {
               SqlConnection con = new SqlConnection(ConString);
               con.Open();

               SqlCommand cmd = new SqlCommand("select SUM(Amts) as total from tblPatientBill", con);
               SqlDataReader reader = cmd.ExecuteReader();
              while (reader.Read())
               {
                   myBillTotal = double.Parse(reader["total"].ToString());

               }


              lab.Text = "Total Amount : GH₵ " + myBillTotal.ToString();
           }
           catch (Exception ex)
           {
               MessageBox.Show(ex.Message);

           }

       }


        }


    }