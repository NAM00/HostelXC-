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
    public partial class Flogin : Form
    {
        public Flogin()
        {
            InitializeComponent();
        }

        private void on_form_closing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Btn_login_Click(object sender, EventArgs e)
        {
            LoginRepo lr = new LoginRepo();
            string id = tb_uname.Text;
            string password = tb_pass.Text;

            Login l = lr.GetUser(id, password);

            if (l != null)
            {
                if(l.Role==1)
                {
                    Landing_admin_gui lg = new Landing_admin_gui(l);
                    this.Visible = false;
                    lg.Visible = true;
                }
                else if(l.Role == 2)
                {
                    Landing_hsuper_gui lhg = new Landing_hsuper_gui(l);
                    this.Visible = false;
                    lhg.Visible = true;

                }
                else if(l.Role == 3)
                {
                    Tenant_landing tl = new Tenant_landing(l);
                    this.Visible = false;
                    tl.Visible = true;
                }
              
            }
            else
            {
                MessageBox.Show("Invalid User");
            }
        }

        private void Flogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
