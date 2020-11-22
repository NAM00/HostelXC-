using Entity;
using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HostelX
{
    public partial class tenant_applications : Form
    {
       
        internal Login l;
        ApplicationRepo ar;
        public tenant_applications(Login l)
        {
            InitializeComponent();
            this.l = l;
           this.ar = new ApplicationRepo();
        }

        private void Tenant_applications_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Tenant_landing tl = new Tenant_landing(l);
            this.Visible = false;
            tl.Visible = true;
        }

        private void InsertBtn_Click(object sender, EventArgs e)
        {
            Applications a = new Applications();


            int s = new Random().Next(999) + 1000;

            a.AppId = "A"+s.ToString();
            a.Appbody = appbodyTB.Text;
            a.Appsub = appsubTB.Text;
            a.AppuserId = l.Id;
            a.Astatus= "Applied";
          



            try
            {

                ar.InsertApplication(a);
                
                    MessageBox.Show("Application submitted");

                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Problem"+ex.StackTrace);
                
            }
                
           
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            appbodyTB.Text = "";
            appsubTB.Text = "";
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            Flogin fl = new Flogin();
            this.Visible = false;
            fl.Visible = true;
        }
    }
}
