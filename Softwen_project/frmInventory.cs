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
    public partial class frmInventory : Form
    {
        SqlDataAdapter da;
        SqlCommand cmd;
        SqlConnection con;
        SqlDataReader rdr;
        ConnectionString cs = new ConnectionString();
        DataTable dt;
        DataSet ds;
        SqlCommandBuilder scbuild;

        public frmInventory()
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
            frmReports report = new frmReports();
            report.lblUserName.Text = lblUserName.Text;
            report.lblUserType.Text = lblUserType.Text;
            report.ShowDialog();
        }

        private void btnMonitoring_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMonitoring monitoring = new frmMonitoring();
            monitoring.lblUserName.Text = lblUserName.Text;
            monitoring.lblUserType.Text = lblUserType.Text;
            monitoring.ShowDialog();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            frmNewProduct newproduct = new frmNewProduct();
            newproduct.lblUserName.Text = lblUserName.Text;
            newproduct.lblUserType.Text = lblUserType.Text;
            newproduct.ShowDialog();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            frmProductList productlist = new frmProductList();
            productlist.lblUserName.Text = lblUserName.Text;
            productlist.lblUserType.Text = lblUserType.Text;
            productlist.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmInventory_Load(object sender, EventArgs e)
        {
            if (lblUserType.Text == "Inventory Manager")
            {
                frmMain main = new frmMain();
                frmInventory inventory = new frmInventory();
                frmSales sales = new frmSales();
                frmPurchase purchase = new frmPurchase();
                frmMonitoring monitoring = new frmMonitoring();
                frmReports reports = new frmReports();

                main.btnSales.Enabled = false;
                main.btnPurchasing.Enabled = false;

                inventory.btnSales.Enabled = false;
                inventory.btnPurchasing.Enabled = false;

                sales.btnSales.Enabled = false;
                sales.btnPurchasing.Enabled = false;
                sales.lblCustomerList.Enabled = false;
                sales.lblNewCustomer.Enabled = false;
                sales.lblNewSalesOrder.Enabled = false;
                sales.lblSalesOrderList.Enabled = false;

                purchase.btnSales.Enabled = false;
                purchase.btnPurchasing.Enabled = false;
                purchase.lblNewPurchaseOrder.Enabled = false;
                purchase.lblNewSupplier.Enabled = false;
                purchase.lblPurchaseOrderList.Enabled = false;
                purchase.lblSupplierList.Enabled = false;

                monitoring.btnSales.Enabled = false;
                monitoring.btnPuchasing.Enabled = false;

                reports.btnPurchasing.Enabled = false;
                reports.btnSales.Enabled = false;


            }
            else if (lblUserType.Text == "Sales Manager")
            {
                frmMain main = new frmMain();
                frmInventory inventory = new frmInventory();
                frmSales sales = new frmSales();
                frmPurchase purchase = new frmPurchase();
                frmMonitoring monitoring = new frmMonitoring();
                frmReports reports = new frmReports();

                main.btnInventory.Enabled = false;

                inventory.btnInventory.Enabled = false;
                inventory.label5.Enabled = false;
                inventory.label6.Enabled = false;

                sales.btnInventory.Enabled = false;

                purchase.btnInventory.Enabled = false;

                monitoring.btnInventory.Enabled = false;

                reports.btnInventory.Enabled = false;
            }

            con = new SqlConnection(cs.DBConn);
            cmd = new SqlCommand();
            cmd.Connection = con;
            string cb = "select top 5 ProductName, sum(Quantity) as QuantitySold from DbNewSales group by ProductName order by QuantitySold desc";
            cmd.CommandText = cb;
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            cmd = new SqlCommand();
            cmd.Connection = con;
            string query = "Select ProductCode,ProductName,BrandName,Category,Datetime from DbInventory Order by DateTime DESC";
            cmd.CommandText = query;
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;

            cmd = new SqlCommand("select top(5) * from Dbinventory order by Quantity Desc", con);
            con.Open();
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                //this.chart1.Series["AvailableQty"].Points.AddXY(rdr.GetString("ProductName"), rdr.GetInt32("AvailableQty"));

                chart1.DataSource = rdr;

                this.chart1.Series[0].XValueMember = "ProductName";
                this.chart1.Series[0].YValueMembers = "Quantity";

                chart1.DataBind();
            }


        }
    }
}
