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
    public partial class Application_management : Form
    {
        ApplicationRepo ar = new ApplicationRepo();
        internal Login l;
        public Application_management(Login l)
        {
            InitializeComponent();
            this.l = l;
        }

        private void Application_management_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            if(l.Role==1)
            {
                Landing_admin_gui lag = new Landing_admin_gui(l);
                this.Visible = false;
                lag.Visible = true;
            }
            else if(l.Role == 2)
            {
                Landing_hsuper_gui lhg = new Landing_hsuper_gui(l);
                this.Visible = false;
                lhg.Visible = true;
            }
        }

        private void InsertBtn_Click(object sender, EventArgs e)
        {
            
            string s = this.apid_tb.Text;
            Applications a = ar.GetApplication(s);
            if (a == null)
            {
                MessageBox.Show("Invalid ID");
            }
            else
            {
                appbodytb.Text = a.Appbody;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
          
            Applications a = new Applications();
            a.Astatus =this.statusTB.Text;
            string s = apid_tb.Text;
            if (ar.UpdateappStatus(a,s))
            {
                MessageBox.Show("Updated");
                this.ViewAllBtn_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Can NOT Update");
            }


        }

        private void ViewAllBtn_Click(object sender, EventArgs e)
        {
            
            List<Applications> listOfApplications = ar.GetAllApplictaions();
           
            AppTable.DataSource = listOfApplications;
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            List<Applications> listOfApplications = ar.GetAllApplictaions();
            String keyword = this.SearchBox.Text;
            List<Applications> searchedApplication = listOfApplications.FindAll(x => (x.AppId.ToLower()).Contains(keyword.ToLower()) || (x.Appsub.ToLower()).Contains(keyword.ToLower()) || (x.AppuserId.ToLower()).Contains(keyword.ToLower()) || (x.Astatus.ToLower()).Contains(keyword.ToLower()));
            AppTable.DataSource = searchedApplication;
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            Flogin fl = new Flogin();
            this.Visible = false;
            fl.Visible = true;
        }
    }
}
