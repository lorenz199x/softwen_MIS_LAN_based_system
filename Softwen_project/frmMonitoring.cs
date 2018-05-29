using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;
using System.Windows.Forms.DataVisualization.Charting;

namespace Softwen_project
{
    public partial class frmMonitoring : Form
    {
        public frmMonitoring()
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

        private void btnPuchasing_Click(object sender, EventArgs e)
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

        private void lblProdlist_Click(object sender, EventArgs e)
        {
            frmProductList pl = new frmProductList();
            pl.lblUserName.Text = lblUserName.Text;
            pl.lblUserType.Text = lblUserType.Text;
            pl.ShowDialog();
        }

        private void lblSalesorderlist_Click(object sender, EventArgs e)
        {
            frmSalesOrderList sol = new frmSalesOrderList();
            sol.lblUserName.Text = lblUserName.Text;
            sol.lblUserType.Text = lblUserType.Text;
            sol.ShowDialog();
        }

        private void lblPurcorderlst_Click(object sender, EventArgs e)
        {
            frmPurchaseOrderList pol = new frmPurchaseOrderList();
            pol.lblUserName.Text = lblUserName.Text;
            pol.lblUserType.Text = lblUserType.Text;
            pol.ShowDialog();
        }

        private void lblAudit_Click(object sender, EventArgs e)
        {
            frmUserLogs userlogs = new frmUserLogs();
            userlogs.lblUserName.Text = lblUserName.Text;
            userlogs.lblUserType.Text = lblUserType.Text;
            userlogs.ShowDialog();
        }

        private void lblCustlst_Click(object sender, EventArgs e)
        {
            frmCustomerList cl = new frmCustomerList();
            cl.lblUserName.Text = lblUserName.Text;
            cl.lblUserType.Text = lblUserType.Text;
            cl.ShowDialog();
        }

        private void lblSupplst_Click(object sender, EventArgs e)
        {
            frmSupplierList sl = new frmSupplierList();
            sl.lblUserName.Text = lblUserName.Text;
            sl.lblUserType.Text = lblUserType.Text;
            sl.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString();
        }

        private void frmMonitoring_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmBackupRecovery br = new frmBackupRecovery();
            br.ShowDialog();
        }
    }
}
