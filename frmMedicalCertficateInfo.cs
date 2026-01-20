using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DevExpress.XtraEditors;

namespace Onana_Hospital_Management_System
{
    public partial class frmMedicalCertficateInfo : XtraForm
    {
        clsInsert varInsert = new clsInsert();
        clsSelect selectClass = new clsSelect();
        public string patid { get; set; }
        public string patname { get; set; }
        public string age { get; set; }
        public string doctor { get; set; }
        public Image digitalsignature { get; set; }
        public string address { get; set; }
        public string diagnosis { get; set; }
        private long serialNum = 0L;
        //private MemoryStream ds;
        
        public frmMedicalCertficateInfo()
        {
            InitializeComponent();
        }

        private void frmMedicalCertficateInfo_Load(object sender, EventArgs e)
        {
           // dtpExaminedon.CustomFormat = "ddd dd MMM yyyy";
            string docname = selectClass.getEmpName(selectClass.getEmpCode(doctor));
            string speciality = selectClass.getEmpQalification(selectClass.getEmpCode(doctor));
            
            //selectClass.selectImageFromEmployee(selectClass.getEmpCode(doctor), picImage);
            txtAge.Text = age;
            txtCardno.Text = patid;
            txtFullname.Text = patname;
            txtAddress.Text = address;
            txtDiagnosis.Text = diagnosis;
            //pcbSignature.Image = digitalsignature;
            lblDoctor.Text = "Dr. " + docname;
            lblSpecialty.Text = speciality;
            
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            
            varInsert.insertToMC(txtCardno.Text, txtFullname.Text, int.Parse(txtAge.Text), txtAddress.Text, dtpExaminedon, txtDiagnosis.Text, txtRecommendation.Text, txtRest.Text, lblDoctor.Text, lblSpecialty.Text, picImage);
            serialNum = varInsert.serialNum1;
            new MedicalCertificate().ShowDialog();
            this.Close();
            //MedicalCertificate mc = new MedicalCertificate();
            //mc.Show();

        }
    }
}
