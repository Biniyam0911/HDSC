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
    public partial class frmLaboratory : XtraForm
    {
        clsSelect selectClass = new clsSelect();
        clsInsert varInsert = new clsInsert();
        public string patid { get; set; }
        public string fullname { get; set; }
        public frmLaboratory()
        {
            InitializeComponent();
            
        }

        private void frmLaboratory_Load(object sender, EventArgs e)
        {
            
            txtCardno.Text = patid;
            txtFullname.Text = fullname;

            var dsd = selectClass.getLaboratoryServices();
            //for (int j = 0; j < dsd.Tables[0].Rows.Count; j++)
            //{
            //    trvTests.Nodes.Add(dsd.Tables[0].Rows[j]["servicecode"].ToString().Trim() + "|" + dsd.Tables[0].Rows[j]["servicename"].ToString().Trim());

            //}

            // Clear existing nodes before adding new ones
            trvTests.Nodes.Clear();

            // Dictionary to track parent nodes (service codes)
            Dictionary<string, TreeNode> serviceNodes = new Dictionary<string, TreeNode>();

            for (int j = 0; j < dsd.Tables[0].Rows.Count; j++)
            {
                string serviceCode = dsd.Tables[0].Rows[j]["servicecode"].ToString().Trim();
                string serviceName = dsd.Tables[0].Rows[j]["servicename"].ToString().Trim();

                // Check if the service code node already exists
                if (!serviceNodes.ContainsKey(serviceCode))
                {
                    // Create a parent node for the service code
                    TreeNode parentNode = new TreeNode(serviceCode);
                    trvTests.Nodes.Add(parentNode);
                    serviceNodes[serviceCode] = parentNode; // Store reference to parent node
                }

                // Add the service name as a child node under the correct service code
                serviceNodes[serviceCode].Nodes.Add(new TreeNode(serviceName));
            }


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //for (int g = 0; g < trvTests.Nodes.Count; g++)
            //{
            //    if (!trvTests.Nodes[g].Checked)
            //    {
            //        continue;
            //    }
            //    //MessageBox.Show(trvTests.Nodes[g].Text);
            //    dgvTests.Rows.Add(DateTime.Now, trvTests.Nodes[g].Text.ToString().Split('|')[0].Trim(), trvTests.Nodes[g].Text.ToString().Split('|')[1].Trim());
            //    trvTests.Nodes[g].Checked = false;
            //}
            //for (int g = 0; g < trvTests.Nodes.Count; g++) // Loop through parent nodes (service codes)
            //{
            //    TreeNode parentNode = trvTests.Nodes[g];

            //    // Loop through child nodes (service names)
            //    foreach (TreeNode childNode in parentNode.Nodes)
            //    {
            //        if (!childNode.Checked)
            //        {
            //            continue;
            //        }

            //        // Add only child nodes (service names) to the DataGridView
            //        dgvTests1.Rows.Add(
            //            DateTime.Now,
            //            parentNode.Text,  // Service Code (parent node)
            //            childNode.Text    // Service Name (child node)
            //        );

            //        // Uncheck child node after adding
            //        childNode.Checked = false;
            //    }
            //}

            // Get the GridView from the GridControl
           // GridView gridView = gridControlTests.MainView as GridView;

            // Get the current DataTable bound to the GridControl
            DataTable dt = gridControlTests.DataSource as DataTable;

            // If there's no existing DataTable, create a new one
            if (dt == null)
            {
                dt = new DataTable();
                dt.Columns.Add("Request Date", typeof(DateTime));
                dt.Columns.Add("Test Name", typeof(string));
                dt.Columns.Add("Test Category", typeof(string));

                gridControlTests.DataSource = dt; // Bind to GridControl
            }

            // Loop through parent nodes (service codes)
            foreach (TreeNode parentNode in trvTests.Nodes)
            {
                // Loop through child nodes (service names)
                foreach (TreeNode childNode in parentNode.Nodes)
                {
                    if (!childNode.Checked)
                    {
                        continue;
                    }

                    // Add only child nodes (service names) to the DataTable
                    dt.Rows.Add(DateTime.Now, childNode.Text, parentNode.Text );

                    // Uncheck child node after adding
                    childNode.Checked = false;
                }
            }

            // Refresh the GridControl to reflect changes
            gridControlTests.RefreshDataSource();


        }

        private void btnOAdd_Click(object sender, EventArgs e)
        {
            //if(txtOther.Text.Length>0)
            //{
            //    dgvTests1.Rows.Add(DateTime.Now, "", txtOther.Text);
            //    txtOther.ResetText();
            //}
            if (txtOther.Text.Length > 0)
            {
                // Get the GridView from the GridControl
                //GridView gridView = gridControlTests.MainView as GridView;

                // Get the current DataTable bound to the GridControl
                DataTable dt = gridControlTests.DataSource as DataTable;

                // If there's no existing DataTable, create a new one
                if (dt == null)
                {
                    dt = new DataTable();
                    dt.Columns.Add("Request Date", typeof(DateTime));
                    dt.Columns.Add("Test Name", typeof(string));
                    dt.Columns.Add("Test Category", typeof(string));

                    gridControlTests.DataSource = dt; // Bind to GridControl
                }

                // Add the custom test with an empty Service Code
                dt.Rows.Add(DateTime.Now, txtOther.Text,"");

                // Clear the text field
                txtOther.ResetText();

                // Refresh the GridControl to reflect changes
                gridControlTests.RefreshDataSource();
            }

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // if(dgvTests1.RowCount>0)
            // {
            //     for (int i = 0; i < dgvTests1.RowCount; i++)
            //     {
            //         varInsert.insertToLaboratory(txtCardno.Text, txtFullname.Text, txtSex.Text, chkUrgent.Checked, chkRoutine.Checked, txtClinicalData.Text, dgvTests1.Rows[i].Cells[1].Value.ToString(), dgvTests1.Rows[i].Cells[2].Value.ToString());
            //     }
            //     frmLaboratoryPrint labprint = new frmLaboratoryPrint { patname = txtFullname.Text, requestDate= DateTime.Today };
            //     labprint.Show();
            //     //MessageBox.Show("Laboratory Ordered");
            //     this.Close();
            // }
            //else
            // {
            //     MessageBox.Show("Please select tests");
            // }
            // Get the GridView from the GridControl
            //GridView gridView = gridControlTests.MainView as GridView;

            // Check if there are rows in the GridView
            if (gridView1.RowCount > 0)
            {
                for (int i = 0; i < gridView1.RowCount; i++)
                {
                    string serviceCode = gridView1.GetRowCellValue(i, "Test Name")?.ToString() ?? "";
                    string serviceName = gridView1.GetRowCellValue(i, "Test Category")?.ToString() ?? "";

                    varInsert.insertToLaboratory(
                        txtCardno.Text,
                        txtFullname.Text,
                        txtSex.Text,
                        chkUrgent.Checked,
                        chkRoutine.Checked,
                        txtClinicalData.Text,
                        serviceName,
                        serviceCode                        
                    );
                }

                // Open the laboratory print form
                frmLaboratoryPrint labprint = new frmLaboratoryPrint
                {
                    patname = txtFullname.Text,
                    requestDate = DateTime.Today
                };
                labprint.Show();

                // Close the current form
                this.Close();
            }
            else
            {
                MessageBox.Show("Please select tests");
            }

        }
    }
}
