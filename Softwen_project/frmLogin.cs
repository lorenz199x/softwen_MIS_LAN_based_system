using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;
using System.Configuration;
using System.Web;


namespace Softwen_project
{
    public partial class frmLogin : Form
    {

        SqlDataAdapter da;
        SqlCommand cmd;
        SqlConnection con;
        SqlDataReader rdr;
        ConnectionString cs = new ConnectionString();
        DataTable dt;
        DataSet ds;

        public frmLogin()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            /*con = new SqlConnection(cs.DBConn);
            con.Open();
            cmd = new SqlCommand("Select * from DbLogin where UserName='" + this.txtUserName.Text + "' and Password = '" + txtPassword.Text + "'");
            cmd.Connection = con;
            rdr = cmd.ExecuteReader();

            int count = 0;

            while (rdr.Read())
            {
                count += 1;
            }

            if (count == 1)
            {
                MessageBox.Show("Succesfully Login", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                
            this.Hide();
            frmMain main = new frmMain();
            main.Show();
            main.label1.Text = txtUserName.Text;  
            }
            else if (txtUserName.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Please fill-up all the required field/s", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                MessageBox.Show("Invalid Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserName.Text = null;
                txtPassword.Text = null;
            }*/



            if (txtUserName.Text == "")
            {
                MessageBox.Show("Please enter UserName", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserName.Focus();
                return;
            }
            if (txtPassword.Text == "")
            {
                MessageBox.Show("Please enter Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
                return;
            }
            //try
            //{
                con = new SqlConnection(cs.DBConn);
                cmd = new SqlCommand("SELECT UserName,Password FROM DbLogin WHERE UserName = @UserName AND Password = @Password", con);
                SqlParameter UserName = new SqlParameter("@UserName", SqlDbType.VarChar);
                SqlParameter Password = new SqlParameter("@Password", SqlDbType.VarChar);
                UserName.Value = txtUserName.Text;
                Password.Value = txtPassword.Text;
                cmd.Parameters.Add(UserName);
                cmd.Parameters.Add(Password);
                cmd.Connection.Open();
                SqlDataReader myReader = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                if (myReader.Read() == true)
                {
                    con = new SqlConnection(cs.DBConn);
                    con.Open();
                    string ct = "select UserType from DbLogin where UserName='" + txtUserName.Text + "' and Password='" + txtPassword.Text + "'";
                    cmd = new SqlCommand(ct);
                    cmd.Connection = con;
                    rdr = cmd.ExecuteReader();
                    if (rdr.Read())
                    {
                        lblAdmin.Text = (rdr.GetString(0));
                        lblInventory.Text = (rdr.GetString(0));
                        lblSales.Text = (rdr.GetString(0));
                    }
                    if ((rdr != null))
                    {
                        rdr.Close();
                    }

                    if (lblAdmin.Text.Trim() == "Admin")
                    {
                        con = new SqlConnection(cs.DBConn);
                        con.Open();
                        string aa = "insert into DbUserLogs(UserName,UserType,DateTime,Activity) VALUES ('" + txtUserName.Text + "','" + lblAdmin.Text + "','" + lblDateTime.Text + "','" + label2.Text + "')";
                        cmd = new SqlCommand(aa);
                        cmd.Connection = con;
                        cmd.ExecuteNonQuery();


                        this.Hide();
                        frmMain main = new frmMain();
                        main.Show();
                        main.lblUserName.Text = txtUserName.Text;
                        main.lblUserType.Text = lblAdmin.Text;
                    }
                    if (lblInventory.Text.Trim() == "Inventory Manager")
                    {
                        con = new SqlConnection(cs.DBConn);
                        con.Open();
                        string aa = "insert into DbUserLogs(UserName,UserType,DateTime,Activity) VALUES ('" + txtUserName.Text + "','" + lblAdmin.Text + "','" + lblDateTime.Text + "','" + label2.Text + "')";
                        cmd = new SqlCommand(aa);
                        cmd.Connection = con;
                        cmd.ExecuteNonQuery();

                        this.Hide();
                        frmMain main = new frmMain();
                        
                        main.lblUserName.Text = txtUserName.Text;
                        main.lblUserType.Text = lblInventory.Text;

                        main.btnSales.Enabled = false;
                        main.btnPurchasing.Enabled = false;

                        frmInventory inventory = new frmInventory();
                        inventory.btnSales.Enabled = false;
                        inventory.btnPurchasing.Enabled = false;

                        frmSales sales = new frmSales();
                        sales.btnSales.Enabled = false;
                        sales.btnPurchasing.Enabled = false;
                        sales.lblCustomerList.Enabled = false;
                        sales.lblNewCustomer.Enabled = false;
                        sales.lblNewSalesOrder.Enabled = false;
                        sales.lblSalesOrderList.Enabled = false;
             

                        frmPurchase purchase = new frmPurchase();
                        purchase.btnSales.Enabled = false;
                        purchase.btnPurchasing.Enabled = false;
                        purchase.lblNewPurchaseOrder.Enabled = false;
                        purchase.lblNewSupplier.Enabled = false;
                        purchase.lblPurchaseOrderList.Enabled = false;
                        purchase.lblSupplierList.Enabled = false;

                        frmMonitoring monitoring = new frmMonitoring();
                        monitoring.btnSales.Enabled = false;
                        monitoring.btnPuchasing.Enabled = false;

                        frmReports reports = new frmReports();
                        reports.btnPurchasing.Enabled = false;
                        reports.btnSales.Enabled = false;

                        main.Show();
                    }
                    if (lblSales.Text.Trim() == "Sales Manager")
                    {
                        con = new SqlConnection(cs.DBConn);
                        con.Open();
                        string aa = "insert into DbUserLogs(UserName,UserType,DateTime,Activity) VALUES ('" + txtUserName.Text + "','" + lblAdmin.Text + "','" + lblDateTime.Text + "','" + label2.Text + "')";
                        cmd = new SqlCommand(aa);
                        cmd.Connection = con;
                        cmd.ExecuteNonQuery();

                        this.Hide();
                        frmMain main = new frmMain();
                        main.Show();
                        main.lblUserName.Text = txtUserName.Text;
                        main.lblUserType.Text = lblSales.Text;

                        main.btnInventory.Enabled = false;

                        frmInventory inventory = new frmInventory();
                        inventory.btnInventory.Enabled = false;
                        inventory.label5.Enabled = false;
                        inventory.label6.Enabled = false;

                        frmSales sales = new frmSales();
                        sales.btnInventory.Enabled = false;

                        frmPurchase purchase = new frmPurchase();
                        purchase.btnInventory.Enabled = false;

                        frmMonitoring monitoring = new frmMonitoring();
                        monitoring.btnInventory.Enabled = false;

                        frmReports reports = new frmReports();
                        reports.btnInventory.Enabled = false;

                    }

                }
                else
                {
                    MessageBox.Show("Login is Failed...Try again !", "Login Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txtUserName.Clear();
                    txtPassword.Clear();
                    txtUserName.Focus();
                }
                if (con.State == ConnectionState.Open)
                {
                    con.Dispose();
                }

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            frmChangePassword changepass = new frmChangePassword();
            this.Hide();
            changepass.ShowDialog();
        }

        private void btnPassRec_Click(object sender, EventArgs e)
        {
            frmPasswordRecovery passrec = new frmPasswordRecovery();
            this.Hide();
            passrec.ShowDialog();
          /*string UserName = string.Empty;
            string Password = string.Empty;

            using (con = new SqlConnection(cs.DBConn))
            {
                using (cmd = new SqlCommand("Select UserName,[Password] from DbLogin where Email = @Email"))
                {
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                    cmd.Connection = con;
                    con.Open();

                    using (rdr = cmd.ExecuteReader())
                    {
                        if (rdr.Read())
                        {
                            UserName = rdr["UserName"].ToString();
                            Password = rdr["Password"].ToString();
                        }
                        con.Close();
                    }

                    if (!string.IsNullOrEmpty(Password))
                    {
                        MailMessage mm = new MailMessage("sender@gmail.com", txtEmail.Text.Trim());
                        mm.Subject = "Password Recovery";
                        mm.Body = string.Format("Hi {0},<br /><br />Your password is {1}.<br /><br />Thank You.", UserName, Password);
                        mm.IsBodyHtml = true;
                        SmtpClient smtp = new SmtpClient();
                        smtp.Host = "smtp.gmail.com";
                        smtp.EnableSsl = true;
                        NetworkCredential networkcred = new NetworkCredential();
                        networkcred.UserName = "sender@gmail.com";
                        networkcred.Password = "<Password";
                        smtp.UseDefaultCredentials = true;
                        smtp.Credentials = networkcred;
                        smtp.Port = 587;
                        smtp.Send(mm);
                        lblMessage.ForeColor = Color.Green;
                        lblMessage.Text = "Password has been sent to your email address.";
                    }
                    else
                    {
                        lblMessage.ForeColor = Color.Red;
                        lblMessage.Text = "This email address does not match our records.";
                    }
                }
            }*/
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
        /////////////////////////////////////////////////////////////////GAWA ko :)))))
        //protected void SendEmail(object sender, EventArgs e)
        //{
        //    frmCreateAccount acc = new frmCreateAccount();
        //    string UserName = string.Empty;
        //    string Password = string.Empty;

        //    using (con = new SqlConnection(cs.DBConn))
        //    {
        //        using (cmd = new SqlCommand("Select UserName,[Password] from DbLogin where Email = @Email"))
        //        {
        //            cmd.Parameters.AddWithValue("@Email", acc.txtEmail.Text.Trim());
        //            cmd.Connection = con;
        //            con.Open();

        //            using (rdr = cmd.ExecuteReader())
        //            {
        //                if (rdr.Read())
        //                {
        //                    UserName = rdr["UserName"].ToString();
        //                    Password = rdr["Password"].ToString();
        //                }
        //                con.Close();
        //            }

        //            if (!string.IsNullOrEmpty(Password))
        //            {
        //                MailMessage mm = new MailMessage("sender@gmail.com", acc.txtEmail.Text.Trim());
        //                mm.Subject = "Password Recovery";
        //                mm.Body = string.Format("Hi {0},<br /><br />Your password is {1}.<br /><br />Thank You.", UserName, Password);
        //                mm.IsBodyHtml = true;
        //                SmtpClient smtp = new SmtpClient();
        //                smtp.Host = "smtp.gmail.com";
        //                smtp.EnableSsl = true;
        //                NetworkCredential networkcred = new NetworkCredential();
        //                networkcred.UserName = "sender@gmail.com";
        //                networkcred.Password = "<Password";
        //                smtp.UseDefaultCredentials = true;
        //                smtp.Credentials = networkcred;
        //                smtp.Port = 587;
        //                smtp.Send(mm);
        //                lblMessage.ForeColor = Color.Green;
        //                lblMessage.Text = "Password has been sent to your email address.";
        //            }
        //            else
        //            {
        //                lblMessage.ForeColor = Color.Red;
        //                lblMessage.Text = "This email address does not match our records.";
        //            }
        //        }
        //    }
        //}

    }
}

                                            //using System.Net;
                                            //using System.Net.Mail;
                                            //using System.Drawing;
                                            //using System.Configuration;
                                            //using System.Data.SqlClient;


                                        //protected void SendEmail(object sender, EventArgs e)
                                        //{
                                        //    string username = string.Empty;
                                        //    string password = string.Empty;
                                        //    string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
                                        //    using (SqlConnection con = new SqlConnection(constr))
                                        //    {
                                        //        using (SqlCommand cmd = new SqlCommand("SELECT Username, [Password] FROM Users WHERE Email = @Email"))
                                        //        {
                                        //           cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                                        //            cmd.Connection = con;
                                        //            con.Open();
                                        //            using (SqlDataReader sdr = cmd.ExecuteReader())
                                        //            {
                                        //                if (sdr.Read())
                                        //                {
                                        //                    username = sdr["Username"].ToString();
                                        //                    password = sdr["Password"].ToString();
                                        //                }
                                        //            }
                                        //            con.Close();
                                        //        }
                                        //    }
                                        //    if (!string.IsNullOrEmpty(password))
                                        //    {
                                        //        MailMessage mm = new MailMessage("sender@gmail.com", txtEmail.Text.Trim());
                                        //        mm.Subject = "Password Recovery";
                                        //        mm.Body = string.Format("Hi {0},<br /><br />Your password is {1}.<br /><br />Thank You.", username, password);
                                        //        mm.IsBodyHtml = true;
                                        //       SmtpClient smtp = new SmtpClient();
                                        //        smtp.Host = "smtp.gmail.com";
                                        //        smtp.EnableSsl = true;
                                        //        NetworkCredential NetworkCred = new NetworkCredential();
                                        //        NetworkCred.UserName = "sender@gmail.com";
                                        //        NetworkCred.Password = "<Password>";
                                        //        smtp.UseDefaultCredentials = true;
                                        //        smtp.Credentials = NetworkCred;
                                        //        smtp.Port = 587;
                                        //        smtp.Send(mm);
                                        //        lblMessage.ForeColor = Color.Green;
                                        //        lblMessage.Text = "Password has been sent to your email address.";
                                        //    }
                                        //    else
                                        //    {
                                        //        lblMessage.ForeColor = Color.Red;
                                        //        lblMessage.Text = "This email address does not match our records.";
                                        //    }