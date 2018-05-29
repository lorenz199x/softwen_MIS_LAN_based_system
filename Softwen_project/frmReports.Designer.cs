namespace Softwen_project
{
    partial class frmReports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReports));
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape2 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.btnMonitoring = new System.Windows.Forms.Button();
            this.btnPurchasing = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnSales = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.lblSalesReport = new System.Windows.Forms.Label();
            this.lblProductPriceList = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblDateTime = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblUserType = new System.Windows.Forms.Label();
            this.lblInventoryReorderReport = new System.Windows.Forms.Label();
            this.lblInventoryDescriptionListing = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblPdl = new System.Windows.Forms.Label();
            this.lblSor = new System.Windows.Forms.Label();
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
            this.rectangleShape2.Location = new System.Drawing.Point(0, 744);
            this.rectangleShape2.Name = "rectangleShape2";
            this.rectangleShape2.Size = new System.Drawing.Size(1365, 23);
            // 
            // btnMonitoring
            // 
            this.btnMonitoring.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMonitoring.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonitoring.Location = new System.Drawing.Point(41, 671);
            this.btnMonitoring.Name = "btnMonitoring";
            this.btnMonitoring.Size = new System.Drawing.Size(187, 25);
            this.btnMonitoring.TabIndex = 14;
            this.btnMonitoring.Text = "MONITORING";
            this.btnMonitoring.UseVisualStyleBackColor = true;
            this.btnMonitoring.Click += new System.EventHandler(this.btnMonitoring_Click);
            // 
            // btnPurchasing
            // 
            this.btnPurchasing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPurchasing.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPurchasing.Location = new System.Drawing.Point(43, 627);
            this.btnPurchasing.Name = "btnPurchasing";
            this.btnPurchasing.Size = new System.Drawing.Size(160, 24);
            this.btnPurchasing.TabIndex = 13;
            this.btnPurchasing.Text = "PURCHASING";
            this.btnPurchasing.UseVisualStyleBackColor = true;
            this.btnPurchasing.Click += new System.EventHandler(this.btnPurchasing_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventory.Location = new System.Drawing.Point(43, 551);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(163, 24);
            this.btnInventory.TabIndex = 12;
            this.btnInventory.Text = "INVENTORY";
            this.btnInventory.UseVisualStyleBackColor = true;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // btnReports
            // 
            this.btnReports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.Location = new System.Drawing.Point(45, 707);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(134, 25);
            this.btnReports.TabIndex = 11;
            this.btnReports.Text = "REPORTS";
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnSales
            // 
            this.btnSales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSales.Location = new System.Drawing.Point(43, 593);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(102, 20);
            this.btnSales.TabIndex = 10;
            this.btnSales.Text = "SALES";
            this.btnSales.UseVisualStyleBackColor = true;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // btnHome
            // 
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(43, 519);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(114, 22);
            this.btnHome.TabIndex = 9;
            this.btnHome.Text = "HOME";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // lblSalesReport
            // 
            this.lblSalesReport.AutoSize = true;
            this.lblSalesReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(180)))), ((int)(((byte)(203)))));
            this.lblSalesReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSalesReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesReport.ForeColor = System.Drawing.Color.White;
            this.lblSalesReport.Location = new System.Drawing.Point(39, 353);
            this.lblSalesReport.Name = "lblSalesReport";
            this.lblSalesReport.Size = new System.Drawing.Size(177, 24);
            this.lblSalesReport.TabIndex = 25;
            this.lblSalesReport.Text = "Sales Details Report";
            this.lblSalesReport.Click += new System.EventHandler(this.lblSalesReport_Click);
            // 
            // lblProductPriceList
            // 
            this.lblProductPriceList.AutoSize = true;
            this.lblProductPriceList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(180)))), ((int)(((byte)(203)))));
            this.lblProductPriceList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblProductPriceList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductPriceList.ForeColor = System.Drawing.Color.White;
            this.lblProductPriceList.Location = new System.Drawing.Point(48, 147);
            this.lblProductPriceList.Name = "lblProductPriceList";
            this.lblProductPriceList.Size = new System.Drawing.Size(155, 24);
            this.lblProductPriceList.TabIndex = 21;
            this.lblProductPriceList.Text = "Product Price List";
            this.lblProductPriceList.Click += new System.EventHandler(this.lblProductPriceList_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.lblDateTime.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDateTime.Location = new System.Drawing.Point(1069, 750);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(45, 18);
            this.lblDateTime.TabIndex = 55;
            this.lblDateTime.Text = "time";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.lblUserName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUserName.Location = new System.Drawing.Point(124, 750);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(92, 18);
            this.lblUserName.TabIndex = 56;
            this.lblUserName.Text = "UserName";
            // 
            // lblUserType
            // 
            this.lblUserType.AutoSize = true;
            this.lblUserType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.lblUserType.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserType.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUserType.Location = new System.Drawing.Point(367, 750);
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.Size = new System.Drawing.Size(84, 18);
            this.lblUserType.TabIndex = 60;
            this.lblUserType.Text = "UserType";
            // 
            // lblInventoryReorderReport
            // 
            this.lblInventoryReorderReport.AutoSize = true;
            this.lblInventoryReorderReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(180)))), ((int)(((byte)(203)))));
            this.lblInventoryReorderReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblInventoryReorderReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventoryReorderReport.ForeColor = System.Drawing.Color.White;
            this.lblInventoryReorderReport.Location = new System.Drawing.Point(17, 246);
            this.lblInventoryReorderReport.Name = "lblInventoryReorderReport";
            this.lblInventoryReorderReport.Size = new System.Drawing.Size(211, 24);
            this.lblInventoryReorderReport.TabIndex = 61;
            this.lblInventoryReorderReport.Text = "InventoryReorderReport";
            this.lblInventoryReorderReport.Click += new System.EventHandler(this.lblInventoryReorderReport_Click);
            // 
            // lblInventoryDescriptionListing
            // 
            this.lblInventoryDescriptionListing.AutoSize = true;
            this.lblInventoryDescriptionListing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(180)))), ((int)(((byte)(203)))));
            this.lblInventoryDescriptionListing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblInventoryDescriptionListing.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventoryDescriptionListing.ForeColor = System.Drawing.Color.White;
            this.lblInventoryDescriptionListing.Location = new System.Drawing.Point(39, 294);
            this.lblInventoryDescriptionListing.Name = "lblInventoryDescriptionListing";
            this.lblInventoryDescriptionListing.Size = new System.Drawing.Size(167, 48);
            this.lblInventoryDescriptionListing.TabIndex = 62;
            this.lblInventoryDescriptionListing.Text = "Inventory\r\n Description Listing";
            this.lblInventoryDescriptionListing.Click += new System.EventHandler(this.lblInventoryDescriptionListing_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1366, 768);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // lblPdl
            // 
            this.lblPdl.AutoSize = true;
            this.lblPdl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(180)))), ((int)(((byte)(203)))));
            this.lblPdl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPdl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPdl.ForeColor = System.Drawing.Color.White;
            this.lblPdl.Location = new System.Drawing.Point(48, 184);
            this.lblPdl.Name = "lblPdl";
            this.lblPdl.Size = new System.Drawing.Size(158, 24);
            this.lblPdl.TabIndex = 63;
            this.lblPdl.Text = "Product Detail List";
            this.lblPdl.Click += new System.EventHandler(this.lblPdl_Click);
            // 
            // lblSor
            // 
            this.lblSor.AutoSize = true;
            this.lblSor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(180)))), ((int)(((byte)(203)))));
            this.lblSor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSor.ForeColor = System.Drawing.Color.White;
            this.lblSor.Location = new System.Drawing.Point(39, 389);
            this.lblSor.Name = "lblSor";
            this.lblSor.Size = new System.Drawing.Size(171, 24);
            this.lblSor.TabIndex = 64;
            this.lblSor.Text = "Sales Order Report";
            this.lblSor.Click += new System.EventHandler(this.lblSor_Click);
            // 
            // frmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.lblUserType);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnInventory);
            this.Controls.Add(this.btnSales);
            this.Controls.Add(this.btnPurchasing);
            this.Controls.Add(this.btnMonitoring);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.lblSor);
            this.Controls.Add(this.lblSalesReport);
            this.Controls.Add(this.lblInventoryDescriptionListing);
            this.Controls.Add(this.lblInventoryReorderReport);
            this.Controls.Add(this.lblPdl);
            this.Controls.Add(this.lblProductPriceList);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReports";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape2;
        private System.Windows.Forms.Label lblSalesReport;
        private System.Windows.Forms.Label lblProductPriceList;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblDateTime;
        internal System.Windows.Forms.Label lblUserName;
        internal System.Windows.Forms.Label lblUserType;
        private System.Windows.Forms.Label lblInventoryReorderReport;
        private System.Windows.Forms.Label lblInventoryDescriptionListing;
        private System.Windows.Forms.Label lblPdl;
        private System.Windows.Forms.Label lblSor;
        public System.Windows.Forms.Button btnMonitoring;
        public System.Windows.Forms.Button btnPurchasing;
        public System.Windows.Forms.Button btnInventory;
        public System.Windows.Forms.Button btnReports;
        public System.Windows.Forms.Button btnSales;
        public System.Windows.Forms.Button btnHome;
    }
}