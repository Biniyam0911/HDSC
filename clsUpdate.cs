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

namespace Onana_Hospital_Management_System
{
    //INHERITS FROM CLSINSERT
    class ClsUpdate :clsInsert
    {
        
        //Delete Drug from Table By ID
       public void DeletingDrugByID(int ID)
        {
            string deleteDrug;
            SqlConnection con;

            // SqlCommand cmd;
            try
            {
                con = new SqlConnection(ConString);
                con.Open();
                deleteDrug = "delete  from  tblProduct where proCode =@proCode";
                SqlCommand cmd = new SqlCommand(deleteDrug, con);
                try
                {
                    cmd.Parameters.AddWithValue("@proCode", ID);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Product deleted successfully", "Delete Product - MediSphere", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Product Error - MediSphere", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void UpdateIntoConsultation(string patID, string DocCode, DateTimePicker consultDate, DateTimePicker consultTime, string chiefcompliant, string history, string pe, string diagnosis, string plan, string medication, PictureBox testImage)
        {
            try
            {
                SqlConnection con = new SqlConnection(ConString);

                // string ConString = @"Data Source=SONY\MSSQLSERVER00V1;Initial Catalog=dbOHMS;Integrated Security=True";
                //string sql = "insert into tblConsultation(patID,DocCode,consultDate,consultTime,chiefcompliant,Treatment,medication,testImage) values(@patID, @DocCode,@consultDate,@consurtTime,@diagnoseDetails,@Treatment,@medication,@testImage)";


                con.Open();
                SqlCommand cmd = new SqlCommand("sp_update_note_for_new_consultation", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                //SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@patID", patID.Trim());
                cmd.Parameters.AddWithValue("@DocCode", DocCode.Trim());
                cmd.Parameters.AddWithValue("@consultDate", consultDate.Value.Date);
                cmd.Parameters.AddWithValue("@consultTime", consultTime.Value.ToShortTimeString());
                cmd.Parameters.AddWithValue("@chiefcompliant", chiefcompliant.Trim());
                cmd.Parameters.AddWithValue("@history", history.Trim());
                cmd.Parameters.AddWithValue("@pe", pe.Trim());
                cmd.Parameters.AddWithValue("@diagnosis", diagnosis.Trim());
                cmd.Parameters.AddWithValue("@plan", plan.Trim());

                cmd.Parameters.AddWithValue("@medication", medication.Trim());


                //ADDING PHOTO AND SIGNATURE

                MemoryStream pp = new MemoryStream();
                testImage.Image.Save(pp, testImage.Image.RawFormat);
                Byte[] pdata = pp.GetBuffer();
                SqlParameter ppic = new SqlParameter("@testImage1", System.Data.SqlDbType.Image);
                ppic.Value = pdata;

                cmd.Parameters.Add(ppic);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Consultation record successfully updated", "Save Data - MediSphere", MessageBoxButtons.OK, MessageBoxIcon.Information);

                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error- MediSphere", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


            }

        }
        public void DeleteService(string servicecode)
        {
            try
            {
                SqlConnection con = new SqlConnection(ConString);

                // string ConString = @"Data Source=SONY\MSSQLSERVER00V1;Initial Catalog=dbOHMS;Integrated Security=True";
                //string sql = "insert into tblConsultation(patID,DocCode,consultDate,consultTime,chiefcompliant,Treatment,medication,testImage) values(@patID, @DocCode,@consultDate,@consurtTime,@diagnoseDetails,@Treatment,@medication,@testImage)";


                con.Open();
                SqlCommand cmd = new SqlCommand("sp_delete_service", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@servicecode", servicecode.Trim());
                //SqlCommand cmd = new SqlCommand(sql, con);
             

                cmd.ExecuteNonQuery();
                MessageBox.Show("Service deleted successfully", "Save Data - MediSphere", MessageBoxButtons.OK, MessageBoxIcon.Information);

                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error- MediSphere", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


            }

        }

        public void updateERPNextPostingStatus(string ERPInvoiceNo, string InvoiceNo, string remark)
        {
            try
            {
                SqlConnection con = new SqlConnection(ConString);       

                con.Open();
                SqlCommand cmd = new SqlCommand("sp_update_invoice_post_status", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ERPInvoiceNo", ERPInvoiceNo.Trim());
                cmd.Parameters.AddWithValue("@InvoiceNo", InvoiceNo.Trim());
                cmd.Parameters.AddWithValue("@remark", remark.Trim());


                //SqlCommand cmd = new SqlCommand(sql, con);


                cmd.ExecuteNonQuery();
                Console.WriteLine("Invoice " + InvoiceNo + " with ERPNext Invoice " + ERPInvoiceNo + " Posted successfully");

                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error- MediSphere", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


            }

        }
        public void updateIntoFollowupConsultation(string patID, string DocCode, DateTimePicker consultDate, DateTimePicker consultTime, string problem, string subjective, string objective, string assessement, string plan,string medication2, PictureBox testImage)
        {
            try
            {
                SqlConnection con = new SqlConnection(ConString);

                // string ConString = @"Data Source=SONY\MSSQLSERVER00V1;Initial Catalog=dbOHMS;Integrated Security=True";
                //string sql = "insert into tblConsultation(patID,DocCode,consultDate,consultTime,chiefcompliant,Treatment,medication,testImage) values(@patID, @DocCode,@consultDate,@consurtTime,@diagnoseDetails,@Treatment,@medication,@testImage)";


                con.Open();
                SqlCommand cmd = new SqlCommand("sp_update_note_for_followup_consultation", con);
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

                MemoryStream pp = new MemoryStream();
                testImage.Image.Save(pp, testImage.Image.RawFormat);
                Byte[] pdata = pp.GetBuffer();
                SqlParameter ppic = new SqlParameter("@testImage1", System.Data.SqlDbType.Image);
                ppic.Value = pdata;

                cmd.Parameters.Add(ppic);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Consultation record successfully updated", "Save Data - MediSphere", MessageBoxButtons.OK, MessageBoxIcon.Information);

                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error- MediSphere", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


            }

        }
        //SUPPLIERS
        public void BackUp()
        { 
        try{
           
          SqlConnection  con = new SqlConnection(ConString);
            con.Open(); //OPEN ACCESS TO DATABASE
           SqlCommand cmd =  new SqlCommand(ConString, con);

            //CREATE DIRECTORY IF NOT EXIST
           if (!Directory.Exists(@"C:\Temp_dbOHMS")) 
		{
                Directory.CreateDirectory(@"C:\Temp_dbOHMS");
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "BACKUP DATABASE dbOHMS TO DISK = 'C:\\Temp_dbOHMS\\dbOHMS.BAK'";
                cmd.Connection = con;
                cmd.ExecuteNonQuery();

                MessageBox.Show(@"database backup successfully to C:\Temp_dbOHMS\dbOHMS.BAK", "Backup Database - MediSphere", MessageBoxButtons.OK, MessageBoxIcon.Information);
                

               
		}
            else
		{
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "BACKUP DATABASE dbOHMS TO DISK = 'C:\\Temp_dbOHMS\\dbOHMS.BAK'";
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                MessageBox.Show(@"database backup successfully to C:\Temp_dbOHMS\dbOHMS.BAK", "Backup Database - MediSphere", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
          	 }
          }  
        catch (Exception ex )
        {
            MessageBox.Show(ex.Message + Environment.NewLine + "Please contact the developer", " Database Backup Error- MediSphere", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
        }
            

        
        
        }
        public void Updatepayment(int cartnumber, string cashier,string invoiceno)
        {
            try
            {
                SqlConnection con = new SqlConnection(ConString);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_update_payments", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                //string sql = "Update tblProduct set  proQty=@proQty where proName =@proName";
                //SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@cartnumber", cartnumber);
                cmd.Parameters.AddWithValue("@cashier", cashier);
                cmd.Parameters.AddWithValue("@invoiceno", invoiceno);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Removepayment(int cartnumber)
        {
            try
            {
                SqlConnection con = new SqlConnection(ConString);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_remove_payments", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                //string sql = "Update tblProduct set  proQty=@proQty where proName =@proName";
                //SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@cartnumber", cartnumber);
                

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void UpdateDoctor(string patname, string doctor)
        {
            try
            {
                SqlConnection con = new SqlConnection(ConString);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_update_assigned_doctor", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                //string sql = "Update tblProduct set  proQty=@proQty where proName =@proName";
                //SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@patname", patname);
                cmd.Parameters.AddWithValue("@doctor", doctor);
                

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void UpdateProductQty(string names, int qty)
       {
           try
           {
               SqlConnection con = new SqlConnection(ConString);
               con.Open();
               string sql = "Update tblProduct set  proQty=@proQty where proName =@proName";
               SqlCommand cmd = new SqlCommand(sql, con);
               cmd.Parameters.AddWithValue("@proName", names.Trim());
               cmd.Parameters.AddWithValue("@proQty", qty);
               cmd.ExecuteNonQuery();
           }
           catch (Exception ex)
           {
               MessageBox.Show(ex.Message);
           }
       }
     
    }
}
