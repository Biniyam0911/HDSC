namespace Onana_Hospital_Management_System
{
    partial class frmPrescription
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrescription));
            this.grpOrders = new System.Windows.Forms.GroupBox();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.servicename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frequency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dosage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFullname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCardno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnSelectService = new System.Windows.Forms.Button();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.txtDiagnosis = new System.Windows.Forms.TextBox();
            this.lblDiagnosis = new System.Windows.Forms.Label();
            this.grpOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // grpOrders
            // 
            this.grpOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpOrders.Controls.Add(this.dgvOrders);
            this.grpOrders.Location = new System.Drawing.Point(12, 162);
            this.grpOrders.Name = "grpOrders";
            this.grpOrders.Size = new System.Drawing.Size(1133, 347);
            this.grpOrders.TabIndex = 13;
            this.grpOrders.TabStop = false;
            this.grpOrders.Text = "Orders";
            // 
            // dgvOrders
            // 
            this.dgvOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.servicename,
            this.frequency,
            this.qty,
            this.dosage});
            this.dgvOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrders.Location = new System.Drawing.Point(3, 17);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.ReadOnly = true;
            this.dgvOrders.Size = new System.Drawing.Size(1127, 327);
            this.dgvOrders.TabIndex = 0;
            // 
            // servicename
            // 
            this.servicename.HeaderText = "Description";
            this.servicename.Name = "servicename";
            this.servicename.ReadOnly = true;
            // 
            // frequency
            // 
            this.frequency.HeaderText = "Frequency";
            this.frequency.Name = "frequency";
            this.frequency.ReadOnly = true;
            // 
            // qty
            // 
            this.qty.HeaderText = "Qty";
            this.qty.Name = "qty";
            this.qty.ReadOnly = true;
            // 
            // dosage
            // 
            this.dosage.HeaderText = "Dosage";
            this.dosage.Name = "dosage";
            this.dosage.ReadOnly = true;
            // 
            // txtFullname
            // 
            this.txtFullname.Location = new System.Drawing.Point(417, 63);
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.ReadOnly = true;
            this.txtFullname.Size = new System.Drawing.Size(162, 21);
            this.txtFullname.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(346, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Fullname";
            // 
            // txtCardno
            // 
            this.txtCardno.Location = new System.Drawing.Point(151, 63);
            this.txtCardno.Name = "txtCardno";
            this.txtCardno.ReadOnly = true;
            this.txtCardno.Size = new System.Drawing.Size(162, 21);
            this.txtCardno.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Card No.";
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Location = new System.Drawing.Point(151, 535);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(130, 21);
            this.txtTotalPrice.TabIndex = 17;
            this.txtTotalPrice.Visible = false;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(73, 535);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(57, 13);
            this.lblTotalPrice.TabIndex = 16;
            this.lblTotalPrice.Text = "Total Price";
            this.lblTotalPrice.Visible = false;
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(1013, 60);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(129, 23);
            this.btnOrder.TabIndex = 15;
            this.btnOrder.Text = "Save and Print";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnSelectService
            // 
            this.btnSelectService.Location = new System.Drawing.Point(636, 60);
            this.btnSelectService.Name = "btnSelectService";
            this.btnSelectService.Size = new System.Drawing.Size(136, 23);
            this.btnSelectService.TabIndex = 14;
            this.btnSelectService.Text = "Add New Item";
            this.btnSelectService.UseVisualStyleBackColor = true;
            this.btnSelectService.Click += new System.EventHandler(this.btnSelectService_Click);
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Location = new System.Drawing.Point(829, 60);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(136, 23);
            this.btnRemoveItem.TabIndex = 18;
            this.btnRemoveItem.Text = "Remove Item";
            this.btnRemoveItem.UseVisualStyleBackColor = true;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // txtDiagnosis
            // 
            this.txtDiagnosis.Location = new System.Drawing.Point(151, 97);
            this.txtDiagnosis.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDiagnosis.Multiline = true;
            this.txtDiagnosis.Name = "txtDiagnosis";
            this.txtDiagnosis.Size = new System.Drawing.Size(428, 53);
            this.txtDiagnosis.TabIndex = 19;
            // 
            // lblDiagnosis
            // 
            this.lblDiagnosis.AutoSize = true;
            this.lblDiagnosis.Location = new System.Drawing.Point(82, 115);
            this.lblDiagnosis.Name = "lblDiagnosis";
            this.lblDiagnosis.Size = new System.Drawing.Size(52, 13);
            this.lblDiagnosis.TabIndex = 20;
            this.lblDiagnosis.Text = "Diagnosis";
            // 
            // frmPrescription
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(200)))), ((int)(((byte)(206)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 564);
            this.Controls.Add(this.lblDiagnosis);
            this.Controls.Add(this.txtDiagnosis);
            this.Controls.Add(this.btnRemoveItem);
            this.Controls.Add(this.grpOrders);
            this.Controls.Add(this.txtFullname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCardno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTotalPrice);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnSelectService);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("frmPrescription.IconOptions.Icon")));
            this.Name = "frmPrescription";
            this.Text = "Prescription";
            this.Load += new System.EventHandler(this.frmPrescription_Load);
            this.grpOrders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpOrders;
        public System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.TextBox txtFullname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCardno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnSelectService;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn frequency;
        private System.Windows.Forms.DataGridViewTextBoxColumn dosage;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn servicename;
        private System.Windows.Forms.TextBox txtDiagnosis;
        private System.Windows.Forms.Label lblDiagnosis;
    }
}