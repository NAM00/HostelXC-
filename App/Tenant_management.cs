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
    public partial class Tenant_management : Form
    {
        internal Login l;
        TenantRepo tr;
        LoginRepo lr;
        public Tenant_management(Login l)
        {
            InitializeComponent();
            this.tr = new TenantRepo();
            this.l = l;
            this.lr = new LoginRepo();
        }

        private void on_form_closed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            string tenid = this.tenid_tb.Text;
            Tenant t = tr.GetTenant(tenid);

            if (t == null)
            {
                MessageBox.Show("Invalid ID");
            }
            else
            {
                this.tenname_tb.Text = t.Tname;
                this.tenphnnmbrtb2.Text = t.TphnNumber.Substring(4);
                this.tenisnt_tb.Text = t.Institution + "";
                this.trent_tb.Text = t.Rent.ToString();

                this.RefreshBtn.Enabled = true;
                this.LoadBtn.Enabled = false;
                this.InsertBtn.Enabled = false;
                this.UpdateBtn.Enabled = true;
                this.DeleteBtn.Enabled = true;

                this.tenid_tb.Enabled = false;
            }
        }

        private void InsertBtn_Click(object sender, EventArgs e)
        {

            Login user = new Login();
            Tenant t = new Tenant();

            int p = new Random().Next(99999999) + 10000000;
            user.Id = this.tenid_tb.Text;
            user.Password = p + "";

            t.TId = this.tenid_tb.Text;
            t.Tname = this.tenname_tb.Text;
            t.Institution = this.tenisnt_tb.Text;
            user.Role = 3;
            try
            {
                int i = Convert.ToInt32(this.tenphnnmbrtb2.Text);
                t.TphnNumber = this.tenphnnmbrtb1.Text + this.tenphnnmbrtb2.Text;
                double r = Convert.ToDouble(this.trent_tb.Text);
                t.Rent = r;


                if (lr.InsertUser(user))
                {

                    if (tr.InsertTenant(t))
                    {

                        MessageBox.Show("Tenant Added with Id: " + user.Id + " & Password: " + user.Password);
                        this.RefreshBtn_Click(sender, e);
                        this.ViewAllBtn_Click(sender, e);


                    }
                }

                else
                {
                    MessageBox.Show("Can Not Add" + user.Id);
                }
                
            }
            catch (Exception exp)
            {
                MessageBox.Show("Invalid Data" + exp.StackTrace);

            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            Tenant t = new Tenant();
            int i = Convert.ToInt32(this.tenphnnmbrtb2.Text);
            t.TphnNumber = this.tenphnnmbrtb1.Text + this.tenphnnmbrtb2.Text;
            double r = Convert.ToDouble(this.trent_tb.Text);
            t.Rent = r;
            t.Institution = this.tenisnt_tb.Text;

            if (tr.UpdateTenant(t))
            {
                MessageBox.Show("Updated");
                this.ViewAllBtn_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Can NOT Update");
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            Login user = new Login();
            Tenant t = new Tenant();

            user.Id = this.tenid_tb.Text;

           
            t.TId = this.tenid_tb.Text;

            if (lr.DeleteUser(user))
            {
                if (tr.DeleteTenant(t))
                {
                    MessageBox.Show("Tenant Removed");
                    this.RefreshBtn_Click(sender, e);
                    this.ViewAllBtn_Click(sender, e);
                }
            }
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            this.tenid_tb.Text = "";
            this.tenname_tb.Text = "";
            this.tenphnnmbrtb2.Text = "";
            this.tenisnt_tb.Text = "";
            this.trent_tb.Text = "";


            this.RefreshBtn.Enabled = false;
            this.LoadBtn.Enabled = true;
            this.InsertBtn.Enabled = true;
            this.UpdateBtn.Enabled = false;
            this.DeleteBtn.Enabled = false;

            this.tenid_tb.Enabled = true;

        }

        private void ViewAllBtn_Click(object sender, EventArgs e)
        {
            List<Tenant> listofTenant = tr.GetAllTenant();
            TenantTable.DataSource = listofTenant;
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            List<Tenant> listOfTenant = tr.GetAllTenant();
            String keyword = this.SearchBox.Text;
            List<Tenant> searchedTenant = listOfTenant.FindAll(x => (x.TId.ToLower()).Contains(keyword.ToLower()) || (x.Tname.ToLower()).Contains(keyword.ToLower()) || (x.Institution.ToLower()).Contains(keyword.ToLower()) || (x.TphnNumber.ToLower()).Contains(keyword.ToLower()));
            TenantTable.DataSource = searchedTenant;
        }

        private void TenantTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.tenid_tb.Text = TenantTable.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.tenname_tb.Text = TenantTable.Rows[e.RowIndex].Cells[1].Value.ToString();
            this.tenphnnmbrtb2.Text = (TenantTable.Rows[e.RowIndex].Cells[2].Value.ToString()).Substring(4);
            this.trent_tb.Text = TenantTable.Rows[e.RowIndex].Cells[3].Value.ToString();
            this.tenisnt_tb.Text = TenantTable.Rows[e.RowIndex].Cells[4].Value.ToString();

          
            this.RefreshBtn.Enabled = true;
            this.LoadBtn.Enabled = false;
            this.InsertBtn.Enabled = false;
            this.UpdateBtn.Enabled = true;
            this.DeleteBtn.Enabled = true;

            this.tenid_tb.Enabled = false;
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

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            Flogin fl = new Flogin();
            this.Visible = false;
            fl.Visible = true;
        }
    }
}
