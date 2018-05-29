using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Softwen_project
{
    public partial class frmPurchase : Form
    {

        public frmPurchase()
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

        private void lblNewPurchaseOrder_Click(object sender, EventArgs e)
        {
            frmNewPurchase newpur = new frmNewPurchase();
            newpur.lblUserName.Text = lblUserName.Text;
            newpur.lblUserType.Text = lblUserType.Text;
            newpur.ShowDialog();
        }

        private void lblNewSupplier_Click(object sender, EventArgs e)
        {
            frmNewSupplier newsup = new frmNewSupplier();
            newsup.lblUserName.Text = lblUserName.Text;
            newsup.lblUserType.Text = lblUserType.Text;
            newsup.ShowDialog();
        }

        private void lblPurchaseOrderList_Click(object sender, EventArgs e)
        {
            frmPurchaseOrderList pol = new frmPurchaseOrderList();
            pol.lblUserName.Text = lblUserName.Text;
            pol.lblUserType.Text = lblUserType.Text;
            pol.ShowDialog();
        }

        private void lblSupplierList_Click(object sender, EventArgs e)
        {
            frmSupplierList sl = new frmSupplierList();
            sl.lblUserName.Text = lblUserName.Text;
            sl.lblUserType.Text = lblUserType.Text;
            sl.ShowDialog();
        }

      
    }
}
