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
    public partial class tenant_complains : Form
    {
        internal Login l;

        ComplainRepo cr;
        public tenant_complains(Login l)
        {
            InitializeComponent();
            this.l = l;
            this. cr = new ComplainRepo();
        }

        private void Tenant_complains_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void InsertBtn_Click(object sender, EventArgs e)
        {
            Complain c = new Complain();
            


            int r = new Random().Next(999);
            string s = r.ToString();


            c.CId =  s;
            c.Csub = csubTB.Text;
            c.Cbody = cbodytb.Text;
            c.CuserId = l.Id;



            try
            {

                cr.Insertcomplain(c);

                MessageBox.Show("complain submitted");


            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem");
            }

        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            Flogin fl = new Flogin();
            this.Visible = false;
            fl.Visible = true;
        }
    }
}
