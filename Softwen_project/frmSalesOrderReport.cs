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
    public partial class frmSalesOrderReport : Form
    {
        public frmSalesOrderReport()
        {
            InitializeComponent();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            SqlConnection con;
            ConnectionString cs = new ConnectionString();
            SqlCommand cmd;
            SOReport rpt = new SOReport();
            SqlDataAdapter myDA = new SqlDataAdapter();
            softwenDS myDS = new softwenDS();

            //The report you created.
            cmd = new SqlCommand();
            //The DataSet you created.
            con = new SqlConnection(cs.DBConn);
            cmd.Connection = con;
            cmd.CommandText = "SELECT * from DbNewSales where Orderno='" + txtOrderNo.Text + "'";
            cmd.CommandType = CommandType.Text;
            myDA.SelectCommand = cmd;
            myDA.Fill(myDS, "DbNewSales");
            // myDA.Fill(myDS, "ProductCode");
            rpt.SetDataSource(myDS);
            crystalReportViewer1.ReportSource = rpt;
            //sr.Show();
        }
    }
}
