using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Softwen_project
{
    public partial class frmReports : Form
    {
        public frmReports()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain main = new frmMain();
            main.lblUserName.Text = lblUserName.Text;
            main.lblUserType.Text = lblUserType.Text;
            main.ShowDialog();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmInventory inventory = new frmInventory();
            inventory.lblUserName.Text = lblUserName.Text;
            inventory.lblUserType.Text = lblUserType.Text;
            inventory.ShowDialog();
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSales sales = new frmSales();
            sales.lblUserName.Text = lblUserName.Text;
            sales.lblUserType.Text = lblUserType.Text;
            sales.ShowDialog();
        }

        private void btnPurchasing_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPurchase purchase = new frmPurchase();
            purchase.lblUserName.Text = lblUserName.Text;
            purchase.lblUserType.Text = lblUserType.Text;
            purchase.ShowDialog();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmReports reports = new frmReports();
            reports.lblUserName.Text = lblUserName.Text;
            reports.lblUserType.Text = lblUserType.Text;
            reports.ShowDialog();
        }

        private void btnMonitoring_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMonitoring monitoring = new frmMonitoring();
            monitoring.lblUserName.Text = lblUserName.Text;
            monitoring.lblUserType.Text = lblUserType.Text;
            monitoring.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString();
        }

        private void lblProductPriceList_Click(object sender, EventArgs e)
        {
            frmProductPriceListReport pplr = new frmProductPriceListReport();
            pplr.ShowDialog();
        }

        private void lblInventoryReorderReport_Click(object sender, EventArgs e)
        {
            frmInventoryReorderReport irr = new frmInventoryReorderReport();
            irr.ShowDialog();
        }

        private void lblInventoryDescriptionListing_Click(object sender, EventArgs e)
        {
            frmInventoryReport sr = new frmInventoryReport();
            sr.ShowDialog();
        }

        private void lblSalesReport_Click(object sender, EventArgs e)
        {
            frmSalesDetailsReport sdr = new frmSalesDetailsReport();
            sdr.ShowDialog();
            
        }

        private void lblPdl_Click(object sender, EventArgs e)
        {

        }

        private void lblSor_Click(object sender, EventArgs e)
        {
            frmSalesOrderReport sol = new frmSalesOrderReport();
            sol.ShowDialog();
        }

       
    }
}
