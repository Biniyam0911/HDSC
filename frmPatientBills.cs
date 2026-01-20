using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Onana_Hospital_Management_System
{
    public partial class frmPatientBills : XtraForm
    {
        private readonly JournalEntryBusinessLogic _businessLogic;
        clsSelect selectClass = new clsSelect();
        ClsUpdate varUpdate = new ClsUpdate();
        clsInsert varInsert = new clsInsert();
        public string empName { get; set; }
        string recipt, fullpname, cardno, totalamnt;
        public frmPatientBills()
        {
            InitializeComponent();
            var dbManager = new DatabaseManager();
            var repository = new JournalEntryRepository(dbManager);
            _businessLogic = new JournalEntryBusinessLogic(repository);
        }

        private void frmPatientBills_Load(object sender, EventArgs e)
        {
            chkisPaid.CheckState = CheckState.Unchecked;
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            try
            {
                if (float.Parse(dataGridView1.CurrentRow.Cells[4].Value.ToString()) == 0.00)
                {
                    MessageBox.Show("Total price is 0");
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Are you sure", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        if(chkisPaid.Checked)
                        {
                            varUpdate.Removepayment(int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                            selectClass.viewBills(dataGridView1, false, dtpFrom, dtpTo);
                            chkisPaid.CheckState = CheckState.Unchecked;
                            MessageBox.Show("Payment Successfully Reimbursed");
                        }
                        else
                        {
                            var invoice = selectClass.GenReceiptNo();
                            recipt = "CSI-" + invoice.ToString();
                            fullpname = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                            cardno = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                            totalamnt = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                            varUpdate.Updatepayment(int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()), empName, "CSI-" + invoice.ToString());
                            varInsert.insertIntoGenReceiptNo();
                            selectClass.viewBills(dataGridView1, false, dtpFrom, dtpTo);
                            chkisPaid.CheckState = CheckState.Unchecked;

                           
                            //MessageBox.Show(totalamnt);
                            //printDocument1.Print();
                            MessageBox.Show("Payment Successful");
                        }
                        
                    }
                }
            }
            catch
            {
                MessageBox.Show("Please select unpaid bills");
            }
            
        }

        

        private void chkisPaid_CheckedChanged(object sender, EventArgs e)
        {
            if(chkisPaid.Checked)
            {
                btnPay.Text = "Reimburse";
                selectClass.viewBills(dataGridView1, true, dtpFrom, dtpTo);
            }
            else
            {
                selectClass.viewBills(dataGridView1, false, dtpFrom, dtpTo);
                btnPay.Text = "Pay";
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            selectClass.viewBills(dataGridView1, false, dtpFrom, dtpTo);
            
            //selectClass.calcBilling(label1);
        }

       

        private void salesDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                label1.Text = "Total Price: " + dataGridView1.CurrentRow.Cells[4].Value.ToString() + " ETB";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if(chkisPaid.Checked)
            {
                selectClass.viewBills(dataGridView1, true, dtpFrom, dtpTo);
            }
            else
            {
                selectClass.viewBills(dataGridView1, false, dtpFrom, dtpTo);
            }
        }
        //private void btnShow_Click(object sender, EventArgs e)
        //{
        //    if (chkisPaid.Checked)
        //    {
        //        selectClass.viewBills(dataGridView1, true);
        //    }
        //    else
        //    {
        //        selectClass.viewBills(dataGridView1, false);
        //    }
        //}
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {


            Font pfont;
            DateTime Mydate = new DateTime();
            int StartXpos = 0;
            int StartYpos = 0;
            int offset = 40;
            Mydate = DateTime.Now;

            pfont = new Font("Comic Sans MS", 9);
            e.Graphics.DrawString("Huderma Dermatology Specialty Clinic" + Environment.NewLine, pfont, Brushes.Black, StartXpos, StartYpos);
            e.Graphics.DrawString("Bole infront of Dembel City Center, Tel: +251 949 74 44 44/+251 949 54 44 44" + Environment.NewLine, new Font("Comic Sans MS", 9), Brushes.Black, 0, 30);
            e.Graphics.DrawString(Mydate.ToString("F") + Environment.NewLine, new Font("Comic Sans MS", 9), Brushes.Black, 0, 50);

            e.Graphics.DrawString("Reciept No.: " + recipt.PadRight(30) + Environment.NewLine, new Font("Comic Sans MS", 9), new SolidBrush(Color.Black), 0, 70 + offset);

            e.Graphics.DrawString("Patient Name  : " + fullpname.PadRight(30) + Environment.NewLine, new Font("Comic Sans MS", 9), new SolidBrush(Color.Black), 0, 90 + offset);

            e.Graphics.DrawString("Patient ID : " + cardno.PadRight(30) + Environment.NewLine, new Font("Comic Sans MS", 9), new SolidBrush(Color.Black), 0, 110 + offset);

            e.Graphics.DrawString("Total Amount (ETB)  : " + totalamnt, new Font("Comic Sans MS", 9), new SolidBrush(Color.Black), 0, 130 + offset);

            e.Graphics.DrawString("Thank you for your visit. Wish you good health, you were served by " + empName + Environment.NewLine, new Font("Comic Sans MS", 9), new SolidBrush(Color.Black), 0, 210 + offset);


            recipt = "";
            fullpname = "";
            cardno = "";
            totalamnt = "";
        }
    }    

}
