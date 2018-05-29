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
    public partial class frmPasswordRecovery : Form
    {
        SqlDataAdapter da;
        SqlCommand cmd;
        SqlConnection con;
        SqlDataReader rdr;
        ConnectionString cs = new ConnectionString();
        DataTable dt;
        DataSet ds;

        public frmPasswordRecovery()
        {
            InitializeComponent();
        }

        private void btnPassRec_Click(object sender, EventArgs e)
        {
            // frmCreateAccount acc = new frmCreateAccount();                   
            string UserName = string.Empty;
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
                        smtp.UseDefaultCredentials = false; ;
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
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            this.Hide();
            login.ShowDialog();
        }
    }
}
