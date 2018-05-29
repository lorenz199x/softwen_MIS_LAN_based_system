using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data.SqlClient;

namespace Softwen_project
{
    public partial class frmMain : Form
    {
        SqlDataAdapter da;
        SqlCommand cmd;
        SqlConnection con;
        SqlDataReader rdr;
        ConnectionString cs = new ConnectionString();
        DataTable dt;
        DataSet ds;
        SqlCommandBuilder scbuild;

        public frmMain()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmInventory inventory = new frmInventory();
            inventory.lblUserName.Text = lblUserName.Text;
            inventory.lblUserType.Text = lblUserType.Text;
            inventory.ShowDialog();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain main = new frmMain();
            main.lblUserName.Text = lblUserName.Text;
            main.lblUserType.Text = lblUserType.Text;
            main.ShowDialog();    
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString();
        }

        private void lblChangeUser_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            this.Hide();
            login.ShowDialog();
        }

        private void lblBackup_Click(object sender, EventArgs e)
        {
            frmBackup backup = new frmBackup();
            backup.ShowDialog();
            //con.Open();
            // string fullPath= "";
            // string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
            // fullPath= (System.IO.Path.GetDirectoryName(executable));
            // AppDomain.CurrentDomain.SetData("DataDirectory", fullPath);
            // fullPath=fullPath+"\\DBSoftwen.mdf";

             
            // cmd = new SqlCommand("backup [DBSoftwen.mdf] to disk ='D:\DATABackup\'" "'", con);
            // cmd.ExecuteNonQuery();
            //con.Close();

            //try
            //{
            //SaveFileDialog sd = new SaveFileDialog();
            //sd.Filter = "SQL Server database backup files|*.bak";
            //sd.Title = "Create Database Backup";

            //if (sd.ShowDialog() == DialogResult.OK)
            //{
            //    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["project_name.Properties.Settings.project‌​_nameConnectionString"].ConnectionString))
            //    {
            //        string sqlStmt = string.Format("backup database [" + System.Windows.Forms.Application.StartupPath + "\\dbname.mdf] to disk='{0}'", sd.FileName);
            //        using (SqlCommand bu2 = new SqlCommand(sqlStmt, conn))
            //        {
            //            conn.Open();
            //            bu2.ExecuteNonQuery();
            //            conn.Close();

            //            MessageBox.Show("Backup Created Sucessfully");
            //        }
            //    }
            //}
            ////}
            //catch (Exception)
            //{
            //    MessageBox.Show("Backup Not Created");
            //}
            //con = new SqlConnection(cs.DBConn);
            //con.Open();
            //string str = "USE DBSoftwen;";
            //string str1 = "BACKUP DATABASE DBSoftwen TO DISK = 'D:\\backupfile.Bak' WITH FORMAT,MEDIANAME = 'Z_SQLServerBackups',NAME = 'Full Backup of DBSoftwen';";
            //SqlCommand cmd1 = new SqlCommand(str, con);
            //SqlCommand cmd2 = new SqlCommand(str1, con);
            //cmd1.ExecuteNonQuery();
            //cmd2.ExecuteNonQuery();
            //MessageBox.Show("success");
            //con.Close();

            //try
            //{
            //con = new SqlConnection(cs.DBConn);
            //Cursor = Cursors.WaitCursor;
            //timer1.Enabled = true;
            //if ((!System.IO.Directory.Exists("D:\\DbBackup")))
            //{
            //    System.IO.Directory.CreateDirectory("D:\\DbBackup");
            //}
            //string destdir = "D:\\DbBackup\\DBSoftwen " + DateTime.Now.ToString("dd-MM-yyyy_HH-mm-ss") + ".bak";

            //con.Open();
            //string cb = "backup database [" + System.Windows.Forms.Application.StartupPath + "\\DBSoftwen] to disk='" + destdir + "'with init,stats=10";
            //cmd = new SqlCommand(cb);
            //cmd.Connection = con;
            //cmd.ExecuteReader();
            //con.Close();
            //MessageBox.Show("Successfully performed", "Database Backup", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void lblRecovery_Click(object sender, EventArgs e)
        {
            frmRecovery recovery = new frmRecovery();
            recovery.ShowDialog();
            //var _with1 = openFileDialog1;
            //_with1.Filter = ("DB Backup File|*.bak;");
            //_with1.FilterIndex = 4;
            ////Clear the file name
            //openFileDialog1.FileName = "";

            //if (openFileDialog1.ShowDialog() == DialogResult.OK)
            //{
            //    Cursor = Cursors.WaitCursor;
            //    timer1.Enabled = true;
            //    SqlConnection.ClearAllPools();
            //    con = new SqlConnection(cs.DBConn);
            //    con.Open();
            //    string cb = "USE Master ALTER DATABASE [" + System.Windows.Forms.Application.StartupPath + "\\SpireDatabase.mdf] SET Single_User WITH Rollback Immediate Restore database [" + System.Windows.Forms.Application.StartupPath + "\\DBSoftwen.mdf] FROM disk='" + openFileDialog1.FileName + "' WITH REPLACE ALTER DATABASE [" + System.Windows.Forms.Application.StartupPath + "\\DBSoftwen.mdf] SET Multi_User ";
            //    cmd = new SqlCommand(cb);
            //    cmd.Connection = con;
            //    cmd.ExecuteReader();
            //    MessageBox.Show("Successfully performed", "Database Restore", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    //GetData();
            //}
        }

        private void lblLogout_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(cs.DBConn);
            con.Open();
            string aa = "insert into DbUserLogs(UserName,UserType,DateTime,Activity) VALUES ('" + lblUserName.Text + "','" + lblUserType.Text + "','" + lblDateTime.Text + "','" + label1.Text + "')";
            cmd = new SqlCommand(aa);
            cmd.Connection = con;
            cmd.ExecuteNonQuery();

            this.Hide();
            frmLogin login = new frmLogin();
            login.ShowDialog();
        }

        //***** TOOLS *****//
        private void lblWord_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Winword.exe");
        }

        private void lblExcel_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("EXCEL.exe");
        }

        private void lblCalc_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }

        private void lblNotepad_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Notepad.exe");
        }

        private void lblCreateUser_Click(object sender, EventArgs e)
        {
            frmCreateAccount createacc = new frmCreateAccount();
            createacc.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(cs.DBConn);
            string inv = "select count(*) from DbNewSales";
            cmd = new SqlCommand(inv, con);

            con.Open();
            cmd.ExecuteNonQuery();

            rdr = cmd.ExecuteReader(0);

            while (rdr.Read())
            {
                int n = rdr.GetInt32(0);
                lblSonum.Text = "" + n.ToString();
            }
            con.Close();

            string qwe = "select count(*) from DbNewSupplier";
            cmd = new SqlCommand(qwe, con);

            con.Open();
            cmd.ExecuteNonQuery();

            rdr = cmd.ExecuteReader(0);

            while (rdr.Read())
            {
                int n = rdr.GetInt32(0);
                lblPonum.Text = "" + n.ToString();
            }
            con.Close();

            string zxc = "select count(*) from Dbinventory where (Quantity <= ReorderPoint)";
            cmd = new SqlCommand(zxc, con);

            con.Open();
            cmd.ExecuteNonQuery();

            rdr = cmd.ExecuteReader(0);

            while (rdr.Read())
            {
                int n = rdr.GetInt32(0);
                lblPrno.Text = "" + n.ToString();
            }
            con.Close();

            con = new SqlConnection(cs.DBConn);
            cmd = new SqlCommand();
            cmd.Connection = con;
            string query = "select ProductName,Quantity,ReorderPoint from Dbinventory where(Quantity <= ReorderPoint)";
            cmd.CommandText = query;
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            if(lblUserType.Text == "Inventory Manager")
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
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
