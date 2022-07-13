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
    public partial class Formaccount : Form
    {
        SqlConnection sqlcon;
        public Formaccount()
        {
            InitializeComponent();
        }

        private void Formaccount_Load(object sender, EventArgs e)
        {
            string strcon = @"Data Source=LAPTOP-ESFJ9H96\MSSQLSERVER01;Initial Catalog=phanmemdesktop;Integrated Security=True";
            sqlcon = new SqlConnection(strcon);
            hiendsaccount();
        }
        private void hiendsaccount()
        {
            string sqlhienthi = " SELECT * FROM Account";
            SqlDataAdapter da = new SqlDataAdapter(sqlhienthi, sqlcon);
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
                lvi.SubItems.Add(dt.Rows[i][7].ToString());


            }
        }
    }
}
