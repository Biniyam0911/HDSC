using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Onana_Hospital_Management_System
{
    public partial class frmParent : XtraForm
    {

        //private frmLogin login;
        readonly clsSelect selectClass = new clsSelect();
        readonly ClsUpdate theUpdates = new ClsUpdate();
        public string empRole {  get; set; }
        public string empName { get; set; }
        public frmParent()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = new DateTime();
           dt = DateTime.Now;

           getDate.Text = dt.Date.ToLongDateString();
           toolStripStatusLabel4.Text = dt.ToLongTimeString();
        }

        private void frmParent_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbOHMSDataSet.tblEmployees' table. You can move, or remove it, as needed.
            //this.tblEmployeesTableAdapter.Fill(this.dbOHMSDataSet.tblEmployees);
            if (empRole == "Administrator")
            {
                
            }
            else if(empRole == "Doctor")
            {
                nurseYardToolStripMenuItem.Enabled = false;
                cashierToolStripMenuItem.Enabled = false;
                administratorsToolStripMenuItem.Enabled = false;
                salesReportToolStripMenuItem.Enabled = false;
                dashboardToolStripMenuItem.Enabled = false;
            }
            else if(empRole == "Finance")
            {
                proceduresToolStripMenuItem.Enabled = false;
                nurseYardToolStripMenuItem.Enabled = false;
                doctorToolStripMenuItem.Enabled = false;
                cashierToolStripMenuItem.Enabled = false;
                administratorsToolStripMenuItem.Enabled = false;
                dashboardToolStripMenuItem.Enabled = false;
            }
            else if(empRole == "Cashier")
            {
                proceduresToolStripMenuItem.Enabled = false;
                doctorToolStripMenuItem.Enabled = false;
                nurseYardToolStripMenuItem.Enabled = false;
                administratorsToolStripMenuItem.Enabled = false;
                dashboardToolStripMenuItem.Enabled = false;
            }
            else if(empRole == "Nurse")
            {
                doctorToolStripMenuItem.Enabled = false;
                cashierToolStripMenuItem.Enabled= false;
                administratorsToolStripMenuItem.Enabled = false;
                dashboardToolStripMenuItem.Enabled = false;
            }
            else if(empRole == "FDA")
            {
                procedureReportToolStripMenuItem.Visible = false;
                proceduresToolStripMenuItem1.Visible = false;
                dashboardToolStripMenuItem.Visible = false;
            }
            //clsSelect selectClass = new clsSelect();
            getEmpCodes.Text = empName;
            timer1.Start();

        }       

        //private void frmParent_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    Application.Exit();
        //}

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSupplier supplier = new frmSupplier();
            supplier.Show();
            supplier.MdiParent = this;
        }

        private void productSaleInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProduct product = new frmProduct();
            product.empName = this.getEmpCodes.Text;
            product.Show();
            product.MdiParent = this;
        }

        private void checkupsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNurseTest Nursetest = new frmNurseTest();
            Nursetest.Show();
            Nursetest.MdiParent = this; 
        }

        private void transactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPayments payment = new frmPayments();
            payment.cachierName = this.getEmpCodes.Text;
            payment.Show();
            payment.MdiParent = this;
        }

        private void appointmentToolStripMenuItem4_Click(object sender, EventArgs e)
        {
           
        }

        private void appointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void appointmentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void appointmentToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmAppointment appointment = new frmAppointment();
            appointment.Show();
            appointment.MdiParent = this;
        }

        private void appointmentToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmAppointment appointment = new frmAppointment();
            appointment.Show();
            appointment.MdiParent = this;
        }

        private void consultationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultation consult = new frmConsultation { docName = this.getEmpCodes.Text, FDARole=empRole };
            //consult.txtDocName.Text = this.getEmpCodes.Text;
            consult.Show();
            consult.MdiParent = this;
        }

        private void updatePasswordToolStripMenuItem4_Click(object sender, EventArgs e)
        {
           
        }

        private void updatePasswordToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmUpdatePassword uPassword = new frmUpdatePassword { username = empName };
            uPassword.Show();
            uPassword.MdiParent = this;
        }

        private void updatePasswordToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmUpdatePassword uPassword = new frmUpdatePassword { username = empName };
            uPassword.Show();
            uPassword.MdiParent = this;
        }

        private void updatePasswordToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmUpdatePassword uPassword = new frmUpdatePassword { username = empName };
            uPassword.Show();
            uPassword.MdiParent = this;
        }

        private void updatePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdatePassword uPassword = new frmUpdatePassword { username = empName };
            uPassword.Show();
            uPassword.MdiParent = this;
        }

        private void addAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAppointment appointment = new frmAppointment();
            appointment.Show();
            appointment.MdiParent = this;
        }

        private void viewAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmViewAppointment viewAppointment = new frmViewAppointment();
            viewAppointment.Show();
            viewAppointment.MdiParent = this;
        }

        private void addAppointmentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAppointment appointment = new frmAppointment();
            appointment.Show();
            appointment.MdiParent = this;
        }

        private void viewAppointmentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmViewAppointment viewAppointment = new frmViewAppointment();
            viewAppointment.Show();
            viewAppointment.MdiParent = this;
        }

        private void viewAppointmentToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmViewAppointment viewAppointment = new frmViewAppointment();
            viewAppointment.Show();
            viewAppointment.MdiParent = this;
        }

        private void addAppointmentToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmAppointment appointment = new frmAppointment();
            appointment.Show();
            appointment.MdiParent = this;
        }

        private void wardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
             * 
             * THIS FORM IS NOT YET WORKED ON
             * 
             * */


            //frmWard ward = new frmWard();
            //ward.Show();
        }

        private void addPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPatient patient = new frmPatient();
            patient.nurseName = this.getEmpCodes.Text;
            patient.Show();
            patient.MdiParent = this;
        }

        private void viewPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmViewPatient patientView = new frmViewPatient();
            patientView.Show();
            patientView.MdiParent = this;
        }

        private void viewPatientWeightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmViewPatientWeight viewWeight = new frmViewPatientWeight();
            viewWeight.Show();
            viewWeight.MdiParent = this;
        }

        private void updatePasswordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdatePassword uPassword = new frmUpdatePassword { username = empName };
            uPassword.Show();
            uPassword.MdiParent = this;
        }

        private void viewUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmViewUsers userView = new frmViewUsers();
            userView.Show();
            userView.MdiParent = this;
        }

        private void departmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void viewTransactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmviewDailyTrans viewTrans = new frmviewDailyTrans();
            viewTrans.Show();
            viewTrans.MdiParent = this;
        }

        private void viewDepartmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmViewDept viewDept = new frmViewDept();
            viewDept.Show();
            viewDept.MdiParent = this;
        }

        private void viewBillsToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void supportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHelp help = new frmHelp();
            help.Show();
            help.MdiParent = this;
        }

        private void updatePatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void updateEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmupdateEmployee upEmployee = new frmupdateEmployee();
            upEmployee.Show();
            upEmployee.MdiParent = this;
        }

        private void viewEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmViewEmployee viewEmp = new frmViewEmployee();
            viewEmp.Show();
            viewEmp.MdiParent = this;
        }

        private void nowToolStripMenuItem_Click(object sender, EventArgs e)
        {
          theUpdates.BackUp();
        }

      

        private void viewPatientToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           frmViewPatient viewPatient = new frmViewPatient();
            viewPatient.Show();
            viewPatient.MdiParent = this;
        }

        private void viewPatientWeightToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmViewPatientWeight viewWeight = new frmViewPatientWeight();
            viewWeight.Show();
            viewWeight.MdiParent = this;
        }

        private void viewAppointmentToolStripMenuItem3_Click(object sender, EventArgs e)
        {
           
        }

        private void viewItemBillingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmViewBills bills = new frmViewBills();
            bills.Show();
            bills.MdiParent = this;
        }

        private void viewAppointmentToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            frmViewAppointment viewAppoint = new frmViewAppointment();
            viewAppoint.Show();
            viewAppoint.MdiParent = this;
        }

        private void administratorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

       

        private void viewVitalSignToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmViewPatientWeight viewWeight = new frmViewPatientWeight();
            viewWeight.Show();
            viewWeight.MdiParent = this;
        }

        private void updatePatientToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmUpdatePatient patUpdate = new frmUpdatePatient();
            patUpdate.Show();
            patUpdate.MdiParent = this;
        }

        private void patientToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmPatientHistory patHistory = new frmPatientHistory { PatientMRN = "" };
            patHistory.Show();

            //frmDocPrescription prescrib = new frmDocPrescription();
            //prescrib.Show();
            //prescrib.MdiParent = this;
        }

        private void cashSalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPatientBills bills = new frmPatientBills { empName = empName };
            bills.Show();
            bills.MdiParent = this;
        }

        private void addNewEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmployee employee = new frmEmployee();
            employee.Show();
            employee.MdiParent = this;
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmViewAppointment vAppointment = new frmViewAppointment();
            vAppointment.Show();
            vAppointment.MdiParent = this;
        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsers users = new frmUsers();
            users.Show();
            users.MdiParent = this;
        }

        private void addNewDepartmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 department = new Form1();
            department.Show();
            department.MdiParent = this;
        }

        private void salesReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSalesReport salesrpt = new frmSalesReport();
            salesrpt.Show();
        }

        private void doctorReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDoctorReport docReport = new frmDoctorReport();
            docReport.Show();
        }

        private void serviceSettingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmServiceSetting servsett = new frmServiceSetting();
            servsett.Show();
            servsett.MdiParent = this;
        }

        private void backupToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void diagnosisReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDiagnosisReport diagreport = new frmDiagnosisReport();
            diagreport.Show();
        }

        private void procedureReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProcedureReport procreport =new frmProcedureReport();
            procreport.Show();
        }

        private void ageStratifiedReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgeReport agereport = new frmAgeReport();
            agereport.Show();
        }

        private void sexStratifiedReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSexReport sexreport = new frmSexReport();
            sexreport.Show();
        }

        private void proceduresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmViewProcedure proc = new frmViewProcedure();
            proc.Show();
            proc.MdiParent = this;
        }

        private void laboratoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmViewLaboratory viewlab = new frmViewLaboratory();
            viewlab.Show();
            viewlab.MdiParent = this;
        }

        private void prescriptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmViewPrescription viewPresc = new frmViewPrescription();
            viewPresc.Show();
            viewPresc.MdiParent = this;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            while (System.Windows.Forms.Application.OpenForms.Count > 2)
            {
                
                CloseForms();
            }
            foreach (XtraForm OpenForm in System.Windows.Forms.Application.OpenForms)
            {
                if (OpenForm.GetType() == typeof(frmLogin))
                {
                    OpenForm.Visible = true;
                }
            }
            Dispose();
        }

        private void CloseForms()
        {
            List<XtraForm> forms = new List<XtraForm>();
            foreach (XtraForm OpenForm in System.Windows.Forms.Application.OpenForms)
            {
                XtraMessageBox.Show(typeof(frmLogin).ToString());
                if (OpenForm.GetType() != typeof(frmLogin) && OpenForm.GetType() != typeof(frmParent))
                {
                    
                    forms.Add(OpenForm);
                }
                else
                {
                    OpenForm.Visible = true;
                }
            }
            foreach (XtraForm f in forms)
            {
                f.Dispose();
            }
        }

        private void doctorTransferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDocTransfer doctrans = new frmDocTransfer();
            doctrans.Show();
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDashboard dash = new frmDashboard();
            dash.Show();
            dash.MdiParent = this;
        }

        private void frmParent_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void eRPNextIntegrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ERPNextSettings eRPNextSettings = new ERPNextSettings();
            eRPNextSettings.Show();
            eRPNextSettings.MdiParent = this;
        }

        private void viewSalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void cOAToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmChartofAccount frmcoa = new frmChartofAccount();
            frmcoa.Show();
        }

        private void postRefundReverseSalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmViewBills bills = new frmViewBills();
            bills.Show();
            bills.MdiParent = this;
        }

        private void updatePasswordToolStripMenuItem3_Click_1(object sender, EventArgs e)
        {
            frmUpdatePassword uPassword = new frmUpdatePassword { username = empName };
            uPassword.Show();
            uPassword.MdiParent = this;
        }
    }
}
