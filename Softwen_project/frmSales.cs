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
    public partial class frmSales : Form
    {
        public frmSales()
        {
            InitializeComponent();
            timer1.Start();
        }
        
        private void lblNewSalesOrder_Click(object sender, EventArgs e)
        {
            frmNewSales newsales = new frmNewSales();
            newsales.lblUserName.Text = lblUserName.Text;
            newsales.lblUserType.Text = lblUserType.Text;
            newsales.ShowDialog();
        }

        private void lblNewCustomer_Click(object sender, EventArgs e)
        {
            frmNewCustomer newcus = new frmNewCustomer();
            newcus.lblUserName.Text = lblUserName.Text;
            newcus.lblUserType.Text = lblUserType.Text;
            newcus.ShowDialog();
        }

        private void lblSalesOrderList_Click(object sender, EventArgs e)
        {
            frmSalesOrderList sol = new frmSalesOrderList();
            sol.lblUserName.Text = lblUserName.Text;
            sol.lblUserType.Text = lblUserType.Text;
            sol.ShowDialog();
        }

        private void lblCustomerList_Click(object sender, EventArgs e)
        {
            frmCustomerList cl = new frmCustomerList();
            cl.lblUserName.Text = lblUserName.Text;
            cl.lblUserType.Text = lblUserType.Text;
            cl.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString();
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

       
    }
}
