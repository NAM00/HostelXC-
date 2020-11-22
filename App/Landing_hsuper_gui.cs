using Entity;
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
    public partial class Landing_hsuper_gui : Form
    {
        internal Login l;
        public Landing_hsuper_gui(Login l)
        {
            InitializeComponent();
            this.l = l;
        }

        private void Landing_hsuper_gui_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Btn_mngemp_Click(object sender, EventArgs e)
        {

            Employee_management em = new Employee_management(l);
            this.Visible = false;
            em.Visible = true;

        }

        private void Btn_mngten_Click(object sender, EventArgs e)
        {
            Tenant_management tm = new Tenant_management(l);
            this.Visible = false;
            tm.Visible = true;
        }

        private void Btn_mngapp_Click(object sender, EventArgs e)
        {
            Application_management am = new Application_management(l);
            this.Visible = false;
            am.Visible = true;
        }

        private void Btn_mngcom_Click(object sender, EventArgs e)
        {
            Complains_management cm = new Complains_management(l);
            this.Visible = false;
            cm.Visible = true;
        }

        private void Btn_mngpay_Click(object sender, EventArgs e)
        {
           
        }

        private void Btn_logout_Click(object sender, EventArgs e)
        {
            Flogin fl = new Flogin();
            this.Visible = false;
            fl.Visible = true;
        }
    }
}
