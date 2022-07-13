using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PhanmemDesktop
{
    public partial class trangChuForm : DevExpress.XtraEditors.XtraForm
    {
        public trangChuForm()
        {
            InitializeComponent();
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.KeyPreview = true;
            foreach (var f in this.MdiChildren)
            {
                //trong truong hop from dc mo 
                if (f.Name == "DashboardForm1")
                {
                    // hien thi len tren dau
                    f.Activate();
                   
                    return;
                }
                f.Close();  
            }
            //neu form chua dc mo thi tbuc hien
            DashboardForm1 sv1 = new DashboardForm1();
            sv1.MdiParent = this;
            sv1.Show();


          
        }

        private void accountToolStripMenuItem_Click(object sender, EventArgs e)
        {


            this.KeyPreview = true;
            foreach (var f in this.MdiChildren)
            {

             
                //trong truong hop from dc mo 
                if (f.Name == "Formaccount")
                {
                    // hien thi len tren dau
                    f.Activate();
                    return;
                }
                f.Close();
            }
            //neu form chua dc mo thi tbuc hien
            Formaccount sv = new Formaccount();
            sv.MdiParent = this;
            sv.Show();
            
      



        }
       

        private void trangChuForm_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
         
            
        }
    }
}
