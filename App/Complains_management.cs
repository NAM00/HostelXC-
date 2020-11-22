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
    public partial class Complains_management : Form
    {
        internal Login l;
        ComplainRepo cr;
        public Complains_management(Login l)
        {
            InitializeComponent();
            this.l = l;
           this.cr = new ComplainRepo();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            if (l.Role == 1)
            {
                Landing_admin_gui lag = new Landing_admin_gui(l);
                this.Visible = false;
                lag.Visible = true;
            }
            else if (l.Role == 2)
            {
                Landing_hsuper_gui lhg = new Landing_hsuper_gui(l);
                this.Visible = false;
                lhg.Visible = true;
            }
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            string s = this.cidTB.Text;
            Complain c = cr.Getcomplain(s);
            if (c == null)
            {
                MessageBox.Show("Invalid ID");
            }
            else
            {
                cbodyTB.Text = c.Cbody;
            }
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            Flogin fl = new Flogin();
            this.Visible = false;
            fl.Visible = true;
        }

        private void ViewAllBtn_Click(object sender, EventArgs e)
        {
            List<Complain> listOfComplains = cr.GetAllComplains();

            ComplainsTable.DataSource = listOfComplains;
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            List<Complain> listOfApplications = cr.GetAllComplains();
            String keyword = this.SearchBox.Text;
            List<Complain> searchedComplain = listOfApplications.FindAll(x => (x.CId.ToLower()).Contains(keyword.ToLower()) || (x.Csub.ToLower()).Contains(keyword.ToLower()) );
            ComplainsTable.DataSource = searchedComplain;
        }

        private void Complains_management_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
