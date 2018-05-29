namespace Softwen_project
{
    partial class frmMonitoring
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMonitoring));
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape2 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.btnMonitoring = new System.Windows.Forms.Button();
            this.btnPuchasing = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnSales = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.lblAudit = new System.Windows.Forms.Label();
            this.lblSupplst = new System.Windows.Forms.Label();
            this.lblCustlst = new System.Windows.Forms.Label();
            this.lblPurcorderlst = new System.Windows.Forms.Label();
            this.lblSalesorderlist = new System.Windows.Forms.Label();
            this.lblProdlist = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblUserType = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape2});
            this.shapeContainer1.Size = new System.Drawing.Size(1366, 768);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape2
            // 
            this.rectangleShape2.BackColor = System.Drawing.Color.LightGray;
            this.rectangleShape2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangleShape2.BorderColor = System.Drawing.Color.LightGray;
            this.rectangleShape2.FillColor = System.Drawing.Color.Transparent;
            this.rectangleShape2.Location = new System.Drawing.Point(0, 745);
            this.rectangleShape2.Name = "rectangleShape2";
            this.rectangleShape2.Size = new System.Drawing.Size(1365, 23);
            // 
            // btnMonitoring
            // 
            this.btnMonitoring.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMonitoring.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonitoring.Location = new System.Drawing.Point(42, 667);
            this.btnMonitoring.Name = "btnMonitoring";
            this.btnMonitoring.Size = new System.Drawing.Size(181, 23);
            this.btnMonitoring.TabIndex = 14;
            this.btnMonitoring.Text = "MONITORING";
            this.btnMonitoring.UseVisualStyleBackColor = true;
            this.btnMonitoring.Click += new System.EventHandler(this.btnMonitoring_Click);
            // 
            // btnPuchasing
            // 
            this.btnPuchasing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPuchasing.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPuchasing.Location = new System.Drawing.Point(44, 631);
            this.btnPuchasing.Name = "btnPuchasing";
            this.btnPuchasing.Size = new System.Drawing.Size(152, 24);
            this.btnPuchasing.TabIndex = 13;
            this.btnPuchasing.Text = "PURCHASING";
            this.btnPuchasing.UseVisualStyleBackColor = true;
            this.btnPuchasing.Click += new System.EventHandler(this.btnPuchasing_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventory.Location = new System.Drawing.Point(44, 549);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(165, 28);
            this.btnInventory.TabIndex = 12;
            this.btnInventory.Text = "INVENTORY";
            this.btnInventory.UseVisualStyleBackColor = true;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // btnReports
            // 
            this.btnReports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.Location = new System.Drawing.Point(42, 710);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(139, 23);
            this.btnReports.TabIndex = 11;
            this.btnReports.Text = "REPORTS";
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnSales
            // 
            this.btnSales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSales.Location = new System.Drawing.Point(44, 590);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(98, 25);
            this.btnSales.TabIndex = 10;
            this.btnSales.Text = "SALES";
            this.btnSales.UseVisualStyleBackColor = true;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // btnHome
            // 
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(44, 514);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(110, 24);
            this.btnHome.TabIndex = 9;
            this.btnHome.Text = "HOME";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // lblAudit
            // 
            this.lblAudit.AutoSize = true;
            this.lblAudit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(180)))), ((int)(((byte)(203)))));
            this.lblAudit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAudit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAudit.ForeColor = System.Drawing.Color.White;
            this.lblAudit.Location = new System.Drawing.Point(72, 329);
            this.lblAudit.Name = "lblAudit";
            this.lblAudit.Size = new System.Drawing.Size(94, 24);
            this.lblAudit.TabIndex = 51;
            this.lblAudit.Text = "Audit Trail";
            this.lblAudit.Click += new System.EventHandler(this.lblAudit_Click);
            // 
            // lblSupplst
            // 
            this.lblSupplst.AutoSize = true;
            this.lblSupplst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(180)))), ((int)(((byte)(203)))));
            this.lblSupplst.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSupplst.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplst.ForeColor = System.Drawing.Color.White;
            this.lblSupplst.Location = new System.Drawing.Point(69, 257);
            this.lblSupplst.Name = "lblSupplst";
            this.lblSupplst.Size = new System.Drawing.Size(112, 24);
            this.lblSupplst.TabIndex = 50;
            this.lblSupplst.Text = "Supplier List";
            this.lblSupplst.Click += new System.EventHandler(this.lblSupplst_Click);
            // 
            // lblCustlst
            // 
            this.lblCustlst.AutoSize = true;
            this.lblCustlst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(180)))), ((int)(((byte)(203)))));
            this.lblCustlst.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCustlst.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustlst.ForeColor = System.Drawing.Color.White;
            this.lblCustlst.Location = new System.Drawing.Point(62, 289);
            this.lblCustlst.Name = "lblCustlst";
            this.lblCustlst.Size = new System.Drawing.Size(123, 24);
            this.lblCustlst.TabIndex = 49;
            this.lblCustlst.Text = "Customer List";
            this.lblCustlst.Click += new System.EventHandler(this.lblCustlst_Click);
            // 
            // lblPurcorderlst
            // 
            this.lblPurcorderlst.AutoSize = true;
            this.lblPurcorderlst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(180)))), ((int)(((byte)(203)))));
            this.lblPurcorderlst.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPurcorderlst.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPurcorderlst.ForeColor = System.Drawing.Color.White;
            this.lblPurcorderlst.Location = new System.Drawing.Point(40, 226);
            this.lblPurcorderlst.Name = "lblPurcorderlst";
            this.lblPurcorderlst.Size = new System.Drawing.Size(176, 24);
            this.lblPurcorderlst.TabIndex = 48;
            this.lblPurcorderlst.Text = "Purchase Order List";
            this.lblPurcorderlst.Click += new System.EventHandler(this.lblPurcorderlst_Click);
            // 
            // lblSalesorderlist
            // 
            this.lblSalesorderlist.AutoSize = true;
            this.lblSalesorderlist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(180)))), ((int)(((byte)(203)))));
            this.lblSalesorderlist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSalesorderlist.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesorderlist.ForeColor = System.Drawing.Color.White;
            this.lblSalesorderlist.Location = new System.Drawing.Point(54, 190);
            this.lblSalesorderlist.Name = "lblSalesorderlist";
            this.lblSalesorderlist.Size = new System.Drawing.Size(142, 24);
            this.lblSalesorderlist.TabIndex = 47;
            this.lblSalesorderlist.Text = "Sales Order List";
            this.lblSalesorderlist.Click += new System.EventHandler(this.lblSalesorderlist_Click);
            // 
            // lblProdlist
            // 
            this.lblProdlist.AutoSize = true;
            this.lblProdlist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(180)))), ((int)(((byte)(203)))));
            this.lblProdlist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblProdlist.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdlist.ForeColor = System.Drawing.Color.White;
            this.lblProdlist.Location = new System.Drawing.Point(69, 157);
            this.lblProdlist.Name = "lblProdlist";
            this.lblProdlist.Size = new System.Drawing.Size(116, 24);
            this.lblProdlist.TabIndex = 46;
            this.lblProdlist.Text = "Products List";
            this.lblProdlist.Click += new System.EventHandler(this.lblProdlist_Click);
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.lblDateTime.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDateTime.Location = new System.Drawing.Point(1074, 748);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(45, 18);
            this.lblDateTime.TabIndex = 54;
            this.lblDateTime.Text = "time";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.lblUserName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUserName.Location = new System.Drawing.Point(117, 748);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(92, 18);
            this.lblUserName.TabIndex = 55;
            this.lblUserName.Text = "UserName";
            // 
            // lblUserType
            // 
            this.lblUserType.AutoSize = true;
            this.lblUserType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.lblUserType.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserType.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUserType.Location = new System.Drawing.Point(367, 748);
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.Size = new System.Drawing.Size(84, 18);
            this.lblUserType.TabIndex = 56;
            this.lblUserType.Text = "UserType";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1366, 768);
            this.pictureBox1.TabIndex = 53;
            this.pictureBox1.TabStop = false;
            // 
            // frmMonitoring
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.lblUserType);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblProdlist);
            this.Controls.Add(this.lblSalesorderlist);
            this.Controls.Add(this.lblPurcorderlst);
            this.Controls.Add(this.lblSupplst);
            this.Controls.Add(this.lblCustlst);
            this.Controls.Add(this.lblAudit);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnInventory);
            this.Controls.Add(this.btnSales);
            this.Controls.Add(this.btnPuchasing);
            this.Controls.Add(this.btnMonitoring);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMonitoring";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMonitoring";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMonitoring_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape2;
        public System.Windows.Forms.Label lblAudit;
        public System.Windows.Forms.Label lblSupplst;
        public System.Windows.Forms.Label lblCustlst;
        public System.Windows.Forms.Label lblPurcorderlst;
        public System.Windows.Forms.Label lblSalesorderlist;
        public System.Windows.Forms.Label lblProdlist;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Timer timer1;
        internal System.Windows.Forms.Label lblUserName;
        internal System.Windows.Forms.Label lblUserType;
        public System.Windows.Forms.Button btnMonitoring;
        public System.Windows.Forms.Button btnPuchasing;
        public System.Windows.Forms.Button btnInventory;
        public System.Windows.Forms.Button btnReports;
        public System.Windows.Forms.Button btnSales;
        public System.Windows.Forms.Button btnHome;
    }
}