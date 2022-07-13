using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanmemDesktop
{
    public partial class DashboardForm1 : DevExpress.XtraEditors.XtraForm
    {
       
        SqlConnection sqlcon;
       

        public DashboardForm1()
        {
            InitializeComponent();
        }

        private void DashboardForm1_Load(object sender, EventArgs e)
        {

            string strcon = @"Data Source=LAPTOP-ESFJ9H96\MSSQLSERVER01;Initial Catalog=phanmemdesktop;Integrated Security=True";
            sqlcon = new SqlConnection(strcon);
            hienthiDashboard();
        }

        private void hienthiDashboard()
        {
            string strSQL = "SELECT * FROM Dashboard ";
            SqlDataAdapter da = new SqlDataAdapter(strSQL, sqlcon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            listView1.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi =
               listView1.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());
                lvi.SubItems.Add(dt.Rows[i][5].ToString());
                lvi.SubItems.Add(dt.Rows[i][6].ToString());

            }
        }


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }
    }
}