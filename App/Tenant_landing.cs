﻿using Entity;
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
    public partial class Tenant_landing : Form
    {
        internal Login l;
        public Tenant_landing(Login l)
        {
            InitializeComponent();
            this.l = l;
        }

        private void Tenant_landing_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Btn_app_Click(object sender, EventArgs e)
        {
            tenant_applications ta = new tenant_applications(l);
            this.Visible = false;
            ta.Visible = true;
        }

        private void Btn_com_Click(object sender, EventArgs e)
        {
           tenant_complains tc = new tenant_complains(l);
            this.Visible = false;
            tc.Visible = true;
        }

        private void Btn_logout_Click(object sender, EventArgs e)
        {
            Flogin fl = new Flogin();
            this.Visible = false;
            fl.Visible = true;
        }
    }
}
