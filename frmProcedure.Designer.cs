namespace Onana_Hospital_Management_System
{
    partial class frmProcedure
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProcedure));
            this.label1 = new System.Windows.Forms.Label();
            this.txtCardno = new System.Windows.Forms.TextBox();
            this.txtFullname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grpOrders = new System.Windows.Forms.GroupBox();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.servicecode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servicename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSelectService = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.grpOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Card No.";
            // 
            // txtCardno
            // 
            this.txtCardno.Location = new System.Drawing.Point(147, 46);
            this.txtCardno.Name = "txtCardno";
            this.txtCardno.ReadOnly = true;
            this.txtCardno.Size = new System.Drawing.Size(162, 21);
            this.txtCardno.TabIndex = 1;
            // 
            // txtFullname
            // 
            this.txtFullname.Location = new System.Drawing.Point(413, 46);
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.ReadOnly = true;
            this.txtFullname.Size = new System.Drawing.Size(162, 21);
            this.txtFullname.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(342, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fullname";
            // 
            // grpOrders
            // 
            this.grpOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpOrders.Controls.Add(this.dgvOrders);
            this.grpOrders.Location = new System.Drawing.Point(12, 98);
            this.grpOrders.Name = "grpOrders";
            this.grpOrders.Size = new System.Drawing.Size(986, 347);
            this.grpOrders.TabIndex = 4;
            this.grpOrders.TabStop = false;
            this.grpOrders.Text = "Orders";
            // 
            // dgvOrders
            // 
            this.dgvOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.servicecode,
            this.servicename,
            this.Category,
            this.unitprice,
            this.qty,
            this.totalprice});
            this.dgvOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrders.Location = new System.Drawing.Point(3, 17);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.ReadOnly = true;
            this.dgvOrders.Size = new System.Drawing.Size(980, 327);
            this.dgvOrders.TabIndex = 0;
            // 
            // servicecode
            // 
            this.servicecode.HeaderText = "Service Code";
            this.servicecode.Name = "servicecode";
            this.servicecode.ReadOnly = true;
            // 
            // servicename
            // 
            this.servicename.HeaderText = "Service Name";
            this.servicename.Name = "servicename";
            this.servicename.ReadOnly = true;
            // 
            // Category
            // 
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            // 
            // unitprice
            // 
            this.unitprice.HeaderText = "Unit Price";
            this.unitprice.Name = "unitprice";
            this.unitprice.ReadOnly = true;
            // 
            // qty
            // 
            this.qty.HeaderText = "Qty";
            this.qty.Name = "qty";
            this.qty.ReadOnly = true;
            // 
            // totalprice
            // 
            this.totalprice.HeaderText = "Total Price";
            this.totalprice.Name = "totalprice";
            this.totalprice.ReadOnly = true;
            // 
            // btnSelectService
            // 
            this.btnSelectService.Location = new System.Drawing.Point(603, 44);
            this.btnSelectService.Name = "btnSelectService";
            this.btnSelectService.Size = new System.Drawing.Size(114, 23);
            this.btnSelectService.TabIndex = 5;
            this.btnSelectService.Text = "Select Service";
            this.btnSelectService.UseVisualStyleBackColor = true;
            this.btnSelectService.Click += new System.EventHandler(this.btnSelectService_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(866, 43);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(129, 23);
            this.btnOrder.TabIndex = 6;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(69, 472);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(57, 13);
            this.lblTotalPrice.TabIndex = 7;
            this.lblTotalPrice.Text = "Total Price";
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Location = new System.Drawing.Point(147, 472);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(130, 21);
            this.txtTotalPrice.TabIndex = 8;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(733, 43);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(114, 23);
            this.btnRemove.TabIndex = 9;
            this.btnRemove.Text = "Remove Service";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // frmProcedure
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(200)))), ((int)(((byte)(206)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 497);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.txtTotalPrice);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnSelectService);
            this.Controls.Add(this.grpOrders);
            this.Controls.Add(this.txtFullname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCardno);
            this.Controls.Add(this.label1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("frmProcedure.IconOptions.Icon")));
            this.Name = "frmProcedure";
            this.Text = "Procedure";
            this.Load += new System.EventHandler(this.frmProcedure_Load);
            this.grpOrders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCardno;
        private System.Windows.Forms.TextBox txtFullname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpOrders;
        private System.Windows.Forms.Button btnSelectService;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.TextBox txtTotalPrice;
        public System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn servicename;
        private System.Windows.Forms.DataGridViewTextBoxColumn servicecode;
    }
}