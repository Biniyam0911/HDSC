using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.IO;
using System.Data;
using System.Configuration;
using System.Security.AccessControl;
using DevExpress.XtraEditors.Controls;
using System.Drawing;

namespace Onana_Hospital_Management_System
{
    class clsInsert
    {
       //public string ConString = @"Data Source=IT-PC;Initial Catalog=dbOHMS;password=say@123;Integrated Security=True";
        public string ConString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        public long serialNum1 = 0L;

        public void InsertToDept(string name)
        {
            try
            {
                //string ConString = @"Data Source=SONY\MSSQLSERVER00V1;Initial Catalog=dbOHMS;Integrated Security=True";
                string sql = "Insert into tblDepartment (deptName) VALUES (@deptName)";
                SqlConnection con = new SqlConnection(ConString);
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@deptName", name.Trim());
                cmd.ExecuteNonQuery();
                System.Windows.Forms.MessageBox.Show("Data successfully saved", "SAVE-OHMS", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                con.Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
        public void InsertToERPNextSettings(string key, string secret, string company)
        {
            try
            {
                //string ConString = @"Data Source=SONY\MSSQLSERVER00V1;Initial Catalog=dbOHMS;Integrated Security=True";
                SqlConnection con = new SqlConnection(ConString);
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_insert_ERPNext Settings", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("key", key.Trim());
                cmd.Parameters.AddWithValue("secret", secret.Trim());
                cmd.Parameters.AddWithValue("company", company);
                cmd.ExecuteNonQuery();
                System.Windows.Forms.MessageBox.Show("Setting successfully saved", "SAVE MediSphere", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                con.Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
        //INSERT TO PATIENT
        public void insertToPatient(string patID, string pSname, string pFname, string pOname, ComboBox pGender, string pResidenAddres,  string pContact,  PictureBox pPhoto,int age)
       
        {
            try
            {
               // string ConString = @"Data Source=SONY\MSSQLSERVER00V1;Initial Catalog=dbOHMS;Integrated Security=True";
                //string sql = "Insert into tblPatient (patID,pSname,pFname,pOname,pGender,pOccupation,pDOB,pResidenAddres,pNationality,pContact,pEmail,pDateRegistered,pTimeRegistered,pGuardianName,pGuardianPhone,pGuardianRelateAs,pPhoto) VALUES (@patID,@pSname,@pFname,@pOname,@pGender,@pOccupation,@pDOB,@pResidenAddres,@pNationality,@pContact,@pEmail,@pDateRegistered,@pTimeRegistered,@pGuardianName,@pGuardianPhone,@pGuardianRelateAs,@pPhoto)";
                SqlConnection con = new SqlConnection(ConString);
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_insert_new_patient", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                //SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@patID", patID.Trim());
                cmd.Parameters.AddWithValue("@pSname", pSname.Trim());
                cmd.Parameters.AddWithValue("@pFname", pFname.Trim());
                cmd.Parameters.AddWithValue("@pOname", pOname.Trim());
                cmd.Parameters.AddWithValue("@pGender", pGender.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@pResidenAddres", pResidenAddres.Trim());
                cmd.Parameters.AddWithValue("@pContact", pContact.Trim());
               
                cmd.Parameters.AddWithValue("@age", age);
                //ADDING PHOTO AND SIGNATURE

                MemoryStream pp = new MemoryStream();
                pPhoto.Image.Save(pp, pPhoto.Image.RawFormat);
                Byte[] pdata = pp.GetBuffer();
                SqlParameter ppic = new SqlParameter("@pPhoto", System.Data.SqlDbType.Image);
                ppic.Value = pdata;

                cmd.Parameters.Add(ppic);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Patient successfully added", "Save Data - MediSphere", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                con.Close();

                con.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(), "Error - MediSphere", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

        }

        public void insertToPrescription(string medname, string frequency, string length, string dosage,  string patid, string patname, string docname,string diagnosis,string age, string sex, int prescID)
        {
            try
            {
                // string ConString = @"Data Source=SONY\MSSQLSERVER00V1;Initial Catalog=dbOHMS;Integrated Security=True";
                //string sql = "Insert into tblPatient (patID,pSname,pFname,pOname,pGender,pOccupation,pDOB,pResidenAddres,pNationality,pContact,pEmail,pDateRegistered,pTimeRegistered,pGuardianName,pGuardianPhone,pGuardianRelateAs,pPhoto) VALUES (@patID,@pSname,@pFname,@pOname,@pGender,@pOccupation,@pDOB,@pResidenAddres,@pNationality,@pContact,@pEmail,@pDateRegistered,@pTimeRegistered,@pGuardianName,@pGuardianPhone,@pGuardianRelateAs,@pPhoto)";
                SqlConnection con = new SqlConnection(ConString);
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_insert_new_prescription", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                //SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@medname", medname.Trim());
                cmd.Parameters.AddWithValue("@frequency", frequency.Trim());
                cmd.Parameters.AddWithValue("@length", length.Trim());
                cmd.Parameters.AddWithValue("@dosage", dosage.Trim());
                cmd.Parameters.AddWithValue("@patid", patid.Trim());
                cmd.Parameters.AddWithValue("@patname", patname.Trim());
                cmd.Parameters.AddWithValue("@docname", docname.Trim());
                cmd.Parameters.AddWithValue("@diagnosis", diagnosis.Trim());
                cmd.Parameters.AddWithValue("@age", int.Parse(age));
                cmd.Parameters.AddWithValue("@sex", sex.Trim());
                cmd.Parameters.AddWithValue("@prescID", prescID);

                cmd.ExecuteNonQuery();

                con.Close();

                con.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(), "Error - MediSphere", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

        }

        public void insertToLaboratory(string patid, string patname, string sex, bool urgent, bool routine, string clinicaldata, string testcode, string testname)
        {
            try
            {
                // string ConString = @"Data Source=SONY\MSSQLSERVER00V1;Initial Catalog=dbOHMS;Integrated Security=True";
                //string sql = "Insert into tblPatient (patID,pSname,pFname,pOname,pGender,pOccupation,pDOB,pResidenAddres,pNationality,pContact,pEmail,pDateRegistered,pTimeRegistered,pGuardianName,pGuardianPhone,pGuardianRelateAs,pPhoto) VALUES (@patID,@pSname,@pFname,@pOname,@pGender,@pOccupation,@pDOB,@pResidenAddres,@pNationality,@pContact,@pEmail,@pDateRegistered,@pTimeRegistered,@pGuardianName,@pGuardianPhone,@pGuardianRelateAs,@pPhoto)";
                SqlConnection con = new SqlConnection(ConString);
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_insert_laboratory", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                //SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@patid", patid.Trim());
                cmd.Parameters.AddWithValue("@patname", patname.Trim());
                cmd.Parameters.AddWithValue("@sex", sex.Trim());
                cmd.Parameters.AddWithValue("@urgent", urgent);
                cmd.Parameters.AddWithValue("@routine", routine);
                cmd.Parameters.AddWithValue("@clinicaldata", clinicaldata.Trim());
                cmd.Parameters.AddWithValue("@testcode", testcode.Trim());
                cmd.Parameters.AddWithValue("@testname", testname.Trim());

                cmd.ExecuteNonQuery();

                con.Close();

                con.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(), "Error - MediSphere", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

        }
        public void insertToMC(string patid, string fullname, int age, string address, DateTimePicker examinedon, string diagnosis, string recommendation, string rest, string doctor, string specialty, PictureBox pPhoto)

        {
            try
            {
                // string ConString = @"Data Source=SONY\MSSQLSERVER00V1;Initial Catalog=dbOHMS;Integrated Security=True";
                //string sql = "Insert into tblPatient (patID,pSname,pFname,pOname,pGender,pOccupation,pDOB,pResidenAddres,pNationality,pContact,pEmail,pDateRegistered,pTimeRegistered,pGuardianName,pGuardianPhone,pGuardianRelateAs,pPhoto) VALUES (@patID,@pSname,@pFname,@pOname,@pGender,@pOccupation,@pDOB,@pResidenAddres,@pNationality,@pContact,@pEmail,@pDateRegistered,@pTimeRegistered,@pGuardianName,@pGuardianPhone,@pGuardianRelateAs,@pPhoto)";
                SqlConnection con = new SqlConnection(ConString);
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_insert_medical_certificate", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                //SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@patid", patid.Trim());
                cmd.Parameters.AddWithValue("@fullname", fullname.Trim());
                cmd.Parameters.AddWithValue("@age", age);
                cmd.Parameters.AddWithValue("@address", address.Trim());
                cmd.Parameters.AddWithValue("@examinedon", examinedon.Value.Date);
                cmd.Parameters.AddWithValue("@diagnosis", diagnosis.Trim());
                cmd.Parameters.AddWithValue("@recommendation", recommendation.Trim());
                cmd.Parameters.AddWithValue("@rest", rest.Trim());
                cmd.Parameters.AddWithValue("@doctor", doctor.Trim());
                cmd.Parameters.AddWithValue("@specialty", specialty.Trim());

                //ADDING PHOTO AND SIGNATURE
                SqlParameter returnParameter = cmd.Parameters.Add("@ReturnVal", SqlDbType.BigInt);
                returnParameter.Direction = ParameterDirection.ReturnValue;
                //MemoryStream pp = new MemoryStream();
                //pPhoto.Image.Save(pp, pPhoto.Image.RawFormat);
                //Byte[] pdata = pp.GetBuffer();
                //SqlParameter ppic = new SqlParameter("@signature", System.Data.SqlDbType.Image);
                //ppic.Value = pdata;

                //cmd.Parameters.Add(ppic);
                cmd.ExecuteNonQuery();
                //MessageBox.Show("Patient successfully added", "Save Data - MediSphere", MessageBoxButtons.OK, MessageBoxIcon.Information);
                serialNum1 = long.Parse(returnParameter.Value.ToString());
                con.Close();

                con.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(), "Error -  MediSphere", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

        }
        //INSERT TO EMPLOYEE TABLE
        public void insertToEmployee(string empCode, string empSname, string empFname, string empOname,  string age, string empGender, string empContact, string empEmail,  DateTimePicker empDateJoined, string empDepartment, string empDesignation, string empQualification, string empResidenceAddress, PictureBox epmPhoto)
        {

            try
            {
                //string ConString = @"Data Source=SONY\MSSQLSERVER00V1;Initial Catalog=dbOHMS;Integrated Security=True";
                SqlConnection con = new SqlConnection(ConString);
                string sql = "insert into tblEmployees(empCode, empFname, empSname,  empOname, age,  empGender,  empContact,  empEmail, empDateJoined,  empDepartment,  empDesignation,  empQualification, empResidenceAddress,  epmPhoto) values(@empCode, @empSname, @empFname, @empOname, @age, @empGender, @empContact, @empEmail, @empDateJoined, @empDepartment, @empDesignation, @empQualification, @empResidenceAddress, @epmPhoto)";
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@empCode", empCode.Trim());
                cmd.Parameters.AddWithValue("@empSname", empSname.Trim());
                cmd.Parameters.AddWithValue("@empFname", empFname.Trim());
                cmd.Parameters.AddWithValue("@empOname", empOname.Trim());
               
                cmd.Parameters.AddWithValue("@empGender", empGender.Trim());
                cmd.Parameters.AddWithValue("@empContact", empContact.Trim());
                cmd.Parameters.AddWithValue("@empEmail", empEmail.Trim());
               
                cmd.Parameters.AddWithValue("@empDateJoined", empDateJoined.Value.Date);

                cmd.Parameters.AddWithValue("@empDepartment", empDepartment.Trim());
                cmd.Parameters.AddWithValue("@empDesignation", empDesignation.Trim());

                cmd.Parameters.AddWithValue("@empQualification", empQualification.Trim());
                cmd.Parameters.AddWithValue("@empResidenceAddress", empResidenceAddress.Trim());
                cmd.Parameters.AddWithValue("@age", age.Trim());

                //ADDING PHOTO AND SIGNATURE

                MemoryStream pp = new MemoryStream();
                epmPhoto.Image.Save(pp, epmPhoto.Image.RawFormat);
                Byte[] pdata = pp.GetBuffer();
                SqlParameter ppic = new SqlParameter("@epmPhoto", System.Data.SqlDbType.Image);
                ppic.Value = pdata;
                cmd.Parameters.Add(ppic);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Employee successfully added", "Save Data - MediSphere", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error - MediSphere", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        //INSERT TO GEN ID TABLE  EmployeeNo
        public void insertIntoGenEmployeeNo(string num)
        {
            try
            {

               // string ConString = @"Data Source=SONY\MSSQLSERVER00V1;Initial Catalog=dbOHMS;Integrated Security=True";
                string sql = "Insert into GenEmployeeNo (numNo) values(@numNo)";
                SqlConnection con = new SqlConnection(ConString);
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@numNo", num);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error - MediSphere", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


            }

        }

        //INSERT IN GEN ID  TABLE SUPPLIER
        public void insertIntoGenSupplierNo(string num)
        {
            try
            {

                string sql = "Insert into GenSupNo (genNum) values(@genNum)";
                SqlConnection con = new SqlConnection(ConString);
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@genNum", num);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error - MediSphere", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

        }

        //INSERT IN GEN ID  TABLE RECEIPT
        public void insertIntoGenReceiptNo()
        {
            try
            {

                //string sql = "Insert into Genreceipt (genReceiptNo) values(@genReceiptNo)";
                SqlConnection con = new SqlConnection(ConString);
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_insert_invoice_number", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                
                //SqlCommand cmd = new SqlCommand(sql, con);
                //cmd.Parameters.AddWithValue("@genReceiptNo", num);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error - MediSphere", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

        }

        //INSERT TO GEN ID TABLE GenPatientNo
        public void insertIntoGenPatientNo(string num)
        {
            try
            {

               // string ConString = @"Data Source=SONY\MSSQLSERVER00V1;Initial Catalog=dbOHMS;Integrated Security=True";
                //string sql = "Insert into GenPatientNo (num) values(@num)";
                SqlConnection con = new SqlConnection(ConString);              

                con.Open();
                SqlCommand cmd = new SqlCommand("sp_insert_patientno", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                //SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@num", num);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error - MediSphere", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }


        //INSERT TO USER TABLE 
        public void insertIntoUsers(ComboBox empCode, string Uname, string Pwd, ComboBox Levels)
        {
            try
            {

               // string ConString = @"Data Source=SONY\MSSQLSERVER00V1;Initial Catalog=dbOHMS;Integrated Security=True";
                string sql = "Insert into Users (empCode, Uname, Pwd, Levels) values(@empCode, @Uname, @Pwd, @Levels)";
                SqlConnection con = new SqlConnection(ConString);
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@empCode", empCode.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@Uname", Uname.Trim());
                cmd.Parameters.AddWithValue("@Pwd", Pwd.Trim());
                cmd.Parameters.AddWithValue("@Levels", Levels.SelectedItem.ToString());

                cmd.ExecuteNonQuery();
                MessageBox.Show("User account successfully added", "Save Data - MediSphere", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Save Data - MediSphere", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

        }

        //INSERT TO PRODUCT TABLE 
        public void insertIntoProduct(string proName, string proSupplier, string proLocation, double proPrice, int proQty , DateTimePicker proManuDate, DateTimePicker proExpiry, string proDescription)
        {

            try
            {

               // string ConString = @"Data Source=SONY\MSSQLSERVER00V1;Initial Catalog=dbOHMS;Integrated Security=True";
                string sql = "Insert into tblProduct (proName, proSupplier,proLocation, proPrice, proQty , proManuDate, proExpiry, proDescription) values(@proName, @proSupplier,@proLocation, @proPrice, @proQty , @proManuDate, @proExpiry, @proDescription)";
                SqlConnection con = new SqlConnection(ConString);
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@proName", proName.Trim());
               cmd.Parameters.AddWithValue("@proSupplier", proSupplier.Trim());
               cmd.Parameters.AddWithValue("@proLocation", proLocation.Trim());
                cmd.Parameters.AddWithValue("@proPrice", proPrice);
                cmd.Parameters.AddWithValue("@proQty ", proQty);
                cmd.Parameters.AddWithValue("@proManuDate", proManuDate.Value.Date);
                cmd.Parameters.AddWithValue("@proExpiry", proExpiry.Value.Date);
                cmd.Parameters.AddWithValue("proDescription", proDescription.Trim());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product successfully added", "Save Data - MediSphere", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
                con.Close();
            }
            catch (Exception ex)
            {
               
                MessageBox.Show(ex.ToString(), "Error - MediSphere", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
            
            }
        }
   
        //EMPLOYEE DAILY SCHEDULES
        public void insertIntoSchedule(DateTime createOndate, string note, string patname, string patid, string doctor, string visittype, string diagnosistype,int cartnumber, bool ispaid)
        { 
              try
            {

              //  string ConString = @"Data Source=SONY\MSSQLSERVER00V1;Initial Catalog=dbOHMS;Integrated Security=True";
                //string sql = "insert into tblSchedule (empCode,subj,categ,createOndate,createOnTime,EndOndate, EndOnTime,appNote) values(@empCode,@subj,@categ,@createOndate,@createOnTime,@EndOndate,@EndOnTime,@appNote)";

                SqlConnection con = new SqlConnection(ConString);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_insert_patient_assignement", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

               // SqlCommand cmd = new SqlCommand(sql, con);
                  cmd.Parameters.AddWithValue("@createOndate", createOndate.Date);
                  cmd.Parameters.AddWithValue("@note", note);
                  cmd.Parameters.AddWithValue("@patname", patname);
                  cmd.Parameters.AddWithValue("@patid", patid);
                  cmd.Parameters.AddWithValue("@doctor", doctor);
                  cmd.Parameters.AddWithValue("@visittype", visittype);
                  cmd.Parameters.AddWithValue("@diagnossistype", diagnosistype);
                  cmd.Parameters.AddWithValue("@cartnumber", cartnumber);
                    cmd.Parameters.AddWithValue("@ispaid", ispaid);

                cmd.ExecuteNonQuery();
                  MessageBox.Show("Assignment successfull", "Save Data - MediSphere", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  con.Close();
        }
            catch(Exception ex)
              {
                MessageBox.Show(ex.Message);
            }
        }
        public void insertIntocartNumbere()
        {
            try
            {

                //  string ConString = @"Data Source=SONY\MSSQLSERVER00V1;Initial Catalog=dbOHMS;Integrated Security=True";
                //string sql = "insert into tblSchedule (empCode,subj,categ,createOndate,createOnTime,EndOndate, EndOnTime,appNote) values(@empCode,@subj,@categ,@createOndate,@createOnTime,@EndOndate,@EndOnTime,@appNote)";

                SqlConnection con = new SqlConnection(ConString);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_insert_cart_number", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                // SqlCommand cmd = new SqlCommand(sql, con);
              
                cmd.ExecuteNonQuery();
                //MessageBox.Show("Assignment successfull", "Save Data - MediSphere", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void insertIntoPrescNumbere()
        {
            try
            {

                //  string ConString = @"Data Source=SONY\MSSQLSERVER00V1;Initial Catalog=dbOHMS;Integrated Security=True";
                //string sql = "insert into tblSchedule (empCode,subj,categ,createOndate,createOnTime,EndOndate, EndOnTime,appNote) values(@empCode,@subj,@categ,@createOndate,@createOnTime,@EndOndate,@EndOnTime,@appNote)";

                SqlConnection con = new SqlConnection(ConString);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_insert_prescription_number", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                // SqlCommand cmd = new SqlCommand(sql, con);

                cmd.ExecuteNonQuery();
                //MessageBox.Show("Assignment successfull", "Save Data - MediSphere", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //CONSULTATION
        public void insertIntoConsultation(string patID ,string DocCode, DateTimePicker consultDate, DateTimePicker consultTime, string chiefcompliant,string history, string pe,string diagnosis,string plan, string medication, ImageSlider slider) {
            try
            {
                SqlConnection con = new SqlConnection(ConString);

                // string ConString = @"Data Source=SONY\MSSQLSERVER00V1;Initial Catalog=dbOHMS;Integrated Security=True";
                //string sql = "insert into tblConsultation(patID,DocCode,consultDate,consultTime,chiefcompliant,Treatment,medication,testImage) values(@patID, @DocCode,@consultDate,@consurtTime,@diagnoseDetails,@Treatment,@medication,@testImage)";
               

                con.Open();
                SqlCommand cmd = new SqlCommand("sp_insert_note_for_new_consultation", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                //SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@patID", patID.Trim());
                cmd.Parameters.AddWithValue("@DocCode", DocCode.Trim());
                cmd.Parameters.AddWithValue("@consultDate", consultDate.Value.Date);
                cmd.Parameters.AddWithValue("@consultTime",consultTime.Value.ToShortTimeString());
                cmd.Parameters.AddWithValue("@chiefcompliant", chiefcompliant.Trim());
                cmd.Parameters.AddWithValue("@history", history.Trim());
                cmd.Parameters.AddWithValue("@pe", pe.Trim());
                cmd.Parameters.AddWithValue("@diagnosis", diagnosis.Trim());
                cmd.Parameters.AddWithValue("@plan", plan.Trim());

                cmd.Parameters.AddWithValue("@medication", medication.Trim());
                

                //ADDING PHOTO AND SIGNATURE

                //MemoryStream pp1 = new MemoryStream();
                //pcbCapture1.Image.Save(pp1, pcbCapture1.Image.RawFormat);
                //Byte[] pdata1 = pp1.GetBuffer();
                //SqlParameter ppic1 = new SqlParameter("@testImage1", System.Data.SqlDbType.Image);
                //ppic1.Value = pdata1;

                //cmd.Parameters.Add(ppic1);
                if(slider != null)
                {
                    foreach (Image img in slider.Images)
                    {
                        byte[] imageBytes = ImageToByteArray(img); // Convert image to byte array
                        using (SqlCommand cmd1 = new SqlCommand("INSERT INTO tblImage (patid,imagedata) VALUES (@patID, @ImageData)", con))
                        {
                            cmd1.Parameters.AddWithValue("@ImageData", imageBytes);
                            cmd1.Parameters.AddWithValue("@patID", patID.Trim());
                            cmd1.ExecuteNonQuery();
                        }
                    }
                }
               

                cmd.ExecuteNonQuery();
                MessageBox.Show("Consultation record successfully added", "Save Data - MediSphere", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error- MediSphere", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);               
            
            }
        
        }
        private byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }
        public void insertorUpdateService(string servicecode, string servicename, float price, string category)
        {
            try
            {
                SqlConnection con = new SqlConnection(ConString);

                // string ConString = @"Data Source=SONY\MSSQLSERVER00V1;Initial Catalog=dbOHMS;Integrated Security=True";
                //string sql = "insert into tblConsultation(patID,DocCode,consultDate,consultTime,chiefcompliant,Treatment,medication,testImage) values(@patID, @DocCode,@consultDate,@consurtTime,@diagnoseDetails,@Treatment,@medication,@testImage)";

                //MessageBox.Show(servicecode);
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_insert_or_update_new_service_if_not_exist", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                //SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@servicecode", servicecode.Trim());
                cmd.Parameters.AddWithValue("@servicename", servicename.Trim());
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@category", category);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Srvice Inserted/Updated successfully", "Save Data - MediSphere", MessageBoxButtons.OK, MessageBoxIcon.Information);

                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error- MediSphere", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


            }

        }
        public void insertIntoFollowupConsultation(string patID, string DocCode, DateTimePicker consultDate, DateTimePicker consultTime, string problem, string subjective, string objective, string assessement, string plan,string medication2, PictureBox pcbFCapture1, PictureBox pcbFCapture2, PictureBox pcbFCapture3, PictureBox pcbFCapture4, PictureBox pcbFCapture5, PictureBox pcbFCapture6)
        {
            try
            {
                SqlConnection con = new SqlConnection(ConString);

                // string ConString = @"Data Source=SONY\MSSQLSERVER00V1;Initial Catalog=dbOHMS;Integrated Security=True";
                //string sql = "insert into tblConsultation(patID,DocCode,consultDate,consultTime,chiefcompliant,Treatment,medication,testImage) values(@patID, @DocCode,@consultDate,@consurtTime,@diagnoseDetails,@Treatment,@medication,@testImage)";


                con.Open();
                SqlCommand cmd = new SqlCommand("sp_insert_note_for_followup_consultation", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                //SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@patID", patID.Trim());
                cmd.Parameters.AddWithValue("@DocCode", DocCode.Trim());
                cmd.Parameters.AddWithValue("@consultDate", consultDate.Value.Date);
                cmd.Parameters.AddWithValue("@consultTime", consultTime.Value.ToShortTimeString());
                cmd.Parameters.AddWithValue("@problem", problem.Trim());
                cmd.Parameters.AddWithValue("@subjective", subjective.Trim());
                cmd.Parameters.AddWithValue("@objective", objective.Trim());
                cmd.Parameters.AddWithValue("@assessement", assessement.Trim());
                cmd.Parameters.AddWithValue("@plan2", plan.Trim());
                cmd.Parameters.AddWithValue("@medication2", medication2.Trim());

                //ADDING PHOTO AND SIGNATURE

                MemoryStream pp1 = new MemoryStream();
                pcbFCapture1.Image.Save(pp1, pcbFCapture1.Image.RawFormat);
                Byte[] pdata1 = pp1.GetBuffer();
                SqlParameter ppic1 = new SqlParameter("@testImage1", System.Data.SqlDbType.Image);
                ppic1.Value = pdata1;
                cmd.Parameters.Add(ppic1);

                MemoryStream pp2 = new MemoryStream();
                pcbFCapture2.Image.Save(pp2, pcbFCapture2.Image.RawFormat);
                Byte[] pdata2 = pp2.GetBuffer();
                SqlParameter ppic2 = new SqlParameter("@testImage2", System.Data.SqlDbType.Image);
                ppic2.Value = pdata2;
                cmd.Parameters.Add(ppic2);

                MemoryStream pp3 = new MemoryStream();
                pcbFCapture3.Image.Save(pp3, pcbFCapture3.Image.RawFormat);
                Byte[] pdata3 = pp3.GetBuffer();
                SqlParameter ppic3 = new SqlParameter("@testImage3", System.Data.SqlDbType.Image);
                ppic3.Value = pdata3;
                cmd.Parameters.Add(ppic3);

                MemoryStream pp4 = new MemoryStream();
                pcbFCapture4.Image.Save(pp4, pcbFCapture4.Image.RawFormat);
                Byte[] pdata4 = pp4.GetBuffer();
                SqlParameter ppic4 = new SqlParameter("@testImage4", System.Data.SqlDbType.Image);
                ppic4.Value = pdata4;
                cmd.Parameters.Add(ppic4);

                MemoryStream pp5 = new MemoryStream();
                pcbFCapture5.Image.Save(pp5, pcbFCapture5.Image.RawFormat);
                Byte[] pdata5 = pp5.GetBuffer();
                SqlParameter ppic5 = new SqlParameter("@testImage5", System.Data.SqlDbType.Image);
                ppic5.Value = pdata5;
                cmd.Parameters.Add(ppic5);

                MemoryStream pp6 = new MemoryStream();
                pcbFCapture6.Image.Save(pp6, pcbFCapture6.Image.RawFormat);
                Byte[] pdata6 = pp6.GetBuffer();
                SqlParameter ppic6 = new SqlParameter("@testImage6", System.Data.SqlDbType.Image);
                ppic6.Value = pdata6;
                cmd.Parameters.Add(ppic6);


                cmd.ExecuteNonQuery();
                MessageBox.Show("Consultation record successfully added", "Save Data - MediSphere", MessageBoxButtons.OK, MessageBoxIcon.Information);

                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error- MediSphere", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


            }

        }
        //SUPPLIERS
        public void insertIntoSupplier(string supCode, string supName, string supContact, ComboBox supType, string supPersonInCharge, string supContactPersonInCharge, ComboBox supCountry, string supEmail, string supAddress, DateTimePicker supAgreementDate)
         {
             try
             {

                // string ConString = @"Data Source=SONY\MSSQLSERVER00V1;Initial Catalog=dbOHMS;Integrated Security=True";
                 string sql = "insert into tblSupplier(supCode, supName, supContact,supType,supPersonInCharge,supContactPersonInCharge,supCountry, supEmail, supAddress, supAgreementDate) values(@supCode, @supName, @supContact,@supType,@supPersonInCharge,@supContactPersonInCharge,@supCountry, @supEmail, @supAddress, @supAgreementDate)";
                 SqlConnection con = new SqlConnection(ConString);
                 con.Open();
                 SqlCommand cmd = new SqlCommand(sql, con);
                 cmd.Parameters.AddWithValue("@supCode", supCode.Trim());
                 cmd.Parameters.AddWithValue("@supName", supName.Trim());
                 cmd.Parameters.AddWithValue("@supContact", supContact.Trim());
                 cmd.Parameters.AddWithValue("@supType", supType.SelectedItem.ToString());
                 cmd.Parameters.AddWithValue("@supPersonInCharge", supPersonInCharge.Trim());
                 cmd.Parameters.AddWithValue("@supContactPersonInCharge", supContactPersonInCharge.Trim());
                 cmd.Parameters.AddWithValue("@supCountry", supCountry.SelectedItem.ToString());
                 cmd.Parameters.AddWithValue("@supEmail", supEmail.Trim());
                 cmd.Parameters.AddWithValue("@supAddress", supAddress.Trim());
                 cmd.Parameters.AddWithValue("@supAgreementDate", supAgreementDate.Value.Date);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Supplier record successfully added", "Save Data - MediSphere", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
                con.Close();

             }
             catch(Exception ex)
             {
                 MessageBox.Show(ex.Message, "Save Data - MediSphere", MessageBoxButtons.OK, MessageBoxIcon.Information);

             }
         
         }
    
        //PATIENT WEIGHT AND HEIGHT
         public void insertIntoPatientWeight(float height, float weight, string patID, string patName, double bmi, string pressure, double temperature, DateTimePicker measuredOnDate, DateTimePicker measuredOnTime,string pulserate, string respiratoryrate)
         {

             try
             {
                SqlConnection con = new SqlConnection(ConString);

                SqlCommand cmd = new SqlCommand("sp_insert_vital", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                con.Open();

                cmd.Parameters.AddWithValue("@height", height);
                cmd.Parameters.AddWithValue("@weight", weight);
                cmd.Parameters.AddWithValue("@patID", patID.Trim());
                 cmd.Parameters.AddWithValue("@patName", patName.Trim());
                 cmd.Parameters.AddWithValue("@bmi", bmi);
                 cmd.Parameters.AddWithValue("@pressure", pressure.Trim());
                 cmd.Parameters.AddWithValue("@temperature", temperature);
                 cmd.Parameters.AddWithValue("@pulserate", pulserate);
                 cmd.Parameters.AddWithValue("@respiratoryrate", respiratoryrate); 
                 cmd.Parameters.AddWithValue("@measuredOnDate", measuredOnDate.Value.Date);
                 cmd.Parameters.AddWithValue("@measuredOnTime", measuredOnTime.Value.ToShortTimeString());
                 cmd.ExecuteNonQuery();
                 MessageBox.Show("Vital Sign Recorded Successfully", "Save Data - MediSphere", MessageBoxButtons.OK, MessageBoxIcon.Information);

                 con.Close();
             
             
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message, "Error - MediSphere", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

             }
         
         }

        //INSERT INTO RECEIPT
         public void insertIntoPatientWeight(int genReceiptNo)
         {

             try
             {
                 string sql = "insert into PatientWeight (genReceiptNo) values(@genReceiptNo)";
                 SqlConnection con = new SqlConnection(ConString);
                 con.Open();
                 SqlCommand cmd = new SqlCommand(sql, con);
                 cmd.Parameters.AddWithValue("@genReceiptNo", genReceiptNo);
                 cmd.ExecuteNonQuery();
                 con.Close();

             }
             catch (Exception ex)
             {
                MessageBox.Show(ex.Message);
            }

         }


        //INSERT INTO DAILY TRANSACTION
         public void insertIntoDailyTransaction(string ReceiptNo, string patID, string PatientName, DateTimePicker TransDate, DateTimePicker TransTime, double Amts, double AmtBalance, string TransBy)
         {
             try
             {
                 SqlConnection con = new SqlConnection(ConString);
                 string sql = "Insert into DailyTransaction (ReceiptNo,patID,PatientName,TransDate,TransTime,Amts,AmtBalance,TransBy) values(@ReceiptNo,@patID,@PatientName,@TransDate,@TransTime,@Amts,@AmtBalance,@TransBy)";
                 con.Open();
                 SqlCommand cmd = new SqlCommand(sql, con);
                 cmd.Parameters.AddWithValue("@ReceiptNo", ReceiptNo.Trim());
                 cmd.Parameters.AddWithValue("@patID", patID.Trim());
                 cmd.Parameters.AddWithValue("@PatientName", PatientName.Trim());
                 cmd.Parameters.AddWithValue("@TransDate", TransDate.Value.Date);
                 cmd.Parameters.AddWithValue("@TransTime", TransTime.Value.ToShortTimeString());
                 cmd.Parameters.AddWithValue("@Amts", Amts);
                 cmd.Parameters.AddWithValue("@AmtBalance", AmtBalance);
                 cmd.Parameters.AddWithValue("@TransBy", TransBy.Trim());
                 cmd.ExecuteNonQuery();
                 MessageBox.Show("Daily successfully added", "Save Data - MediSphere", MessageBoxButtons.OK, MessageBoxIcon.Information);

                 con.Close();

             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message, "Error- MediSphere", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

             }

         
         }

        //INSERT INTO ITEM BILL
        public void ItemsBills( string patID, string PatientName, DateTimePicker TransDate, DateTimePicker  TransTime,string Item,double Amts,string TransBy )
        {
            try { 
            SqlConnection con = new SqlConnection(ConString);
            string sql = "insert into ItemsBills (patID,PatientName,TransDate,TransTime,Item,Amts,TransBy) values (@patID,@PatientName,@TransDate,@TransTime,@Item,@Amts,@TransBy)";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@patID", patID.Trim());
            cmd.Parameters.AddWithValue("@PatientName",PatientName.Trim());
            cmd.Parameters.AddWithValue("@TransDate", TransDate.Value.Date);
            cmd.Parameters.AddWithValue("@TransTime", TransTime.Value.ToShortTimeString());
            cmd.Parameters.AddWithValue("@Item", Item);
            cmd.Parameters.AddWithValue("@Amts", Amts);
            cmd.Parameters.AddWithValue("@TransBy", TransBy.Trim());
            cmd.ExecuteNonQuery();
            MessageBox.Show("Bill successfully taken", "Save Data - MediSphere", MessageBoxButtons.OK, MessageBoxIcon.Information);

            con.Close();

            }
            catch(Exception ex)
            {
            MessageBox.Show(ex.ToString());
            }
        }


        public void InsertIntoOrder(string patid, string patname, string doctor, string item, float unitprice, int quantity,int cartnumber, string category, bool ispaid)
        {
            try
            {
                SqlConnection con = new SqlConnection(ConString);
                //string sql = "insert into ItemsBills (patID,PatientName,TransDate,TransTime,Item,Amts,TransBy) values (@patID,@PatientName,@TransDate,@TransTime,@Item,@Amts,@TransBy)";
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_insert_in_to_order", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                //SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@patid", patid.Trim());
                cmd.Parameters.AddWithValue("@patname", patname.Trim());
                cmd.Parameters.AddWithValue("@doctor", doctor.Trim());
                cmd.Parameters.AddWithValue("@item", item.Trim());
                cmd.Parameters.AddWithValue("@unitprice", unitprice);
                cmd.Parameters.AddWithValue("@quantity", quantity);
                cmd.Parameters.AddWithValue("@cartnumber", cartnumber);
                cmd.Parameters.AddWithValue("@category", category);
                cmd.Parameters.AddWithValue("@ispaid", ispaid);
                cmd.ExecuteNonQuery();
                //MessageBox.Show("Bill successfully taken", "Save Data - MediSphere", MessageBoxButtons.OK, MessageBoxIcon.Information);

                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        //INSERT INTO  TBL PATIENTBILL
        public void tblpatientBill(string patID, string patName, double Amts)
        {

            try
            {
                SqlConnection con = new SqlConnection(ConString);
                string sql = "insert into tblPatientBill (patID,patName,Amts) values (@patID,@patName,@Amts)";
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@patID", patID.Trim());
                cmd.Parameters.AddWithValue("@patName", patName.Trim());
                cmd.Parameters.AddWithValue("@Amts", Amts);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Bill record successfully taken", "Save Data - MediSphere", MessageBoxButtons.OK, MessageBoxIcon.Information);

                con.Close();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message) ; }
        }

        
    
    }
}
