namespace HostelX
{
    partial class Tenant_management
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tenant_management));
            this.tenphnnmbrtb2 = new System.Windows.Forms.TextBox();
            this.TenantTable = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.ViewAllBtn = new System.Windows.Forms.Button();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.InsertBtn = new System.Windows.Forms.Button();
            this.LoadBtn = new System.Windows.Forms.Button();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.trent_tb = new System.Windows.Forms.TextBox();
            this.tenisnt_tb = new System.Windows.Forms.TextBox();
            this.tenphnnmbrtb1 = new System.Windows.Forms.TextBox();
            this.tenname_tb = new System.Windows.Forms.TextBox();
            this.tenid_tb = new System.Windows.Forms.TextBox();
            this.rent_lbl = new System.Windows.Forms.Label();
            this.EmpSalaryLabel = new System.Windows.Forms.Label();
            this.EmpPhnLabel = new System.Windows.Forms.Label();
            this.EmpNameLabel = new System.Windows.Forms.Label();
            this.EmpIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TenantTable)).BeginInit();
            this.SuspendLayout();
            // 
            // tenphnnmbrtb2
            // 
            this.tenphnnmbrtb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenphnnmbrtb2.Location = new System.Drawing.Point(214, 232);
            this.tenphnnmbrtb2.Name = "tenphnnmbrtb2";
            this.tenphnnmbrtb2.Size = new System.Drawing.Size(158, 22);
            this.tenphnnmbrtb2.TabIndex = 65;
            // 
            // TenantTable
            // 
            this.TenantTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TenantTable.Location = new System.Drawing.Point(420, 109);
            this.TenantTable.Name = "TenantTable";
            this.TenantTable.ReadOnly = true;
            this.TenantTable.Size = new System.Drawing.Size(559, 299);
            this.TenantTable.TabIndex = 64;
            this.TenantTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TenantTable_CellClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(408, 445);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 15);
            this.label6.TabIndex = 63;
            this.label6.Text = "Search Here :";
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutBtn.Location = new System.Drawing.Point(885, 12);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(86, 32);
            this.LogoutBtn.TabIndex = 62;
            this.LogoutBtn.Text = "Logout";
            this.LogoutBtn.UseVisualStyleBackColor = true;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBtn.Location = new System.Drawing.Point(12, 12);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(83, 34);
            this.BackBtn.TabIndex = 61;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // ViewAllBtn
            // 
            this.ViewAllBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewAllBtn.Location = new System.Drawing.Point(420, 71);
            this.ViewAllBtn.Name = "ViewAllBtn";
            this.ViewAllBtn.Size = new System.Drawing.Size(559, 23);
            this.ViewAllBtn.TabIndex = 60;
            this.ViewAllBtn.Text = "View All Tenants";
            this.ViewAllBtn.UseVisualStyleBackColor = true;
            this.ViewAllBtn.Click += new System.EventHandler(this.ViewAllBtn_Click);
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Enabled = false;
            this.RefreshBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshBtn.Location = new System.Drawing.Point(28, 71);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(323, 23);
            this.RefreshBtn.TabIndex = 59;
            this.RefreshBtn.Text = "Refresh";
            this.RefreshBtn.UseVisualStyleBackColor = true;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Enabled = false;
            this.DeleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.Location = new System.Drawing.Point(297, 429);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.DeleteBtn.TabIndex = 58;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Enabled = false;
            this.UpdateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBtn.Location = new System.Drawing.Point(193, 429);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(75, 23);
            this.UpdateBtn.TabIndex = 57;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // InsertBtn
            // 
            this.InsertBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertBtn.Location = new System.Drawing.Point(104, 429);
            this.InsertBtn.Name = "InsertBtn";
            this.InsertBtn.Size = new System.Drawing.Size(75, 23);
            this.InsertBtn.TabIndex = 56;
            this.InsertBtn.Text = "Insert";
            this.InsertBtn.UseVisualStyleBackColor = true;
            this.InsertBtn.Click += new System.EventHandler(this.InsertBtn_Click);
            // 
            // LoadBtn
            // 
            this.LoadBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadBtn.Location = new System.Drawing.Point(12, 429);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(75, 23);
            this.LoadBtn.TabIndex = 55;
            this.LoadBtn.Text = "Load";
            this.LoadBtn.UseVisualStyleBackColor = true;
            this.LoadBtn.Click += new System.EventHandler(this.LoadBtn_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBox.Location = new System.Drawing.Point(507, 441);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(472, 22);
            this.SearchBox.TabIndex = 54;
            this.SearchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            // 
            // trent_tb
            // 
            this.trent_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trent_tb.Location = new System.Drawing.Point(174, 333);
            this.trent_tb.Name = "trent_tb";
            this.trent_tb.Size = new System.Drawing.Size(198, 22);
            this.trent_tb.TabIndex = 53;
            // 
            // tenisnt_tb
            // 
            this.tenisnt_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenisnt_tb.Location = new System.Drawing.Point(176, 282);
            this.tenisnt_tb.Name = "tenisnt_tb";
            this.tenisnt_tb.Size = new System.Drawing.Size(198, 22);
            this.tenisnt_tb.TabIndex = 52;
            // 
            // tenphnnmbrtb1
            // 
            this.tenphnnmbrtb1.Enabled = false;
            this.tenphnnmbrtb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenphnnmbrtb1.Location = new System.Drawing.Point(174, 232);
            this.tenphnnmbrtb1.Name = "tenphnnmbrtb1";
            this.tenphnnmbrtb1.Size = new System.Drawing.Size(36, 22);
            this.tenphnnmbrtb1.TabIndex = 51;
            this.tenphnnmbrtb1.Text = "+880";
            // 
            // tenname_tb
            // 
            this.tenname_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenname_tb.Location = new System.Drawing.Point(174, 185);
            this.tenname_tb.Name = "tenname_tb";
            this.tenname_tb.Size = new System.Drawing.Size(198, 22);
            this.tenname_tb.TabIndex = 50;
            // 
            // tenid_tb
            // 
            this.tenid_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenid_tb.Location = new System.Drawing.Point(174, 136);
            this.tenid_tb.Name = "tenid_tb";
            this.tenid_tb.Size = new System.Drawing.Size(198, 22);
            this.tenid_tb.TabIndex = 49;
            // 
            // rent_lbl
            // 
            this.rent_lbl.AutoSize = true;
            this.rent_lbl.BackColor = System.Drawing.Color.Transparent;
            this.rent_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rent_lbl.Location = new System.Drawing.Point(101, 340);
            this.rent_lbl.Name = "rent_lbl";
            this.rent_lbl.Size = new System.Drawing.Size(45, 15);
            this.rent_lbl.TabIndex = 48;
            this.rent_lbl.Text = "Rent :";
            // 
            // EmpSalaryLabel
            // 
            this.EmpSalaryLabel.AutoSize = true;
            this.EmpSalaryLabel.BackColor = System.Drawing.Color.Transparent;
            this.EmpSalaryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpSalaryLabel.Location = new System.Drawing.Point(23, 285);
            this.EmpSalaryLabel.Name = "EmpSalaryLabel";
            this.EmpSalaryLabel.Size = new System.Drawing.Size(126, 15);
            this.EmpSalaryLabel.TabIndex = 47;
            this.EmpSalaryLabel.Text = "Tenant Institution :";
            // 
            // EmpPhnLabel
            // 
            this.EmpPhnLabel.AutoSize = true;
            this.EmpPhnLabel.BackColor = System.Drawing.Color.Transparent;
            this.EmpPhnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpPhnLabel.Location = new System.Drawing.Point(6, 235);
            this.EmpPhnLabel.Name = "EmpPhnLabel";
            this.EmpPhnLabel.Size = new System.Drawing.Size(143, 15);
            this.EmpPhnLabel.TabIndex = 46;
            this.EmpPhnLabel.Text = "Tenant Phn Number :";
            // 
            // EmpNameLabel
            // 
            this.EmpNameLabel.AutoSize = true;
            this.EmpNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.EmpNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpNameLabel.Location = new System.Drawing.Point(48, 192);
            this.EmpNameLabel.Name = "EmpNameLabel";
            this.EmpNameLabel.Size = new System.Drawing.Size(101, 15);
            this.EmpNameLabel.TabIndex = 45;
            this.EmpNameLabel.Text = "Tenant Name :";
            // 
            // EmpIdLabel
            // 
            this.EmpIdLabel.AutoSize = true;
            this.EmpIdLabel.BackColor = System.Drawing.Color.Transparent;
            this.EmpIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpIdLabel.Location = new System.Drawing.Point(72, 139);
            this.EmpIdLabel.Name = "EmpIdLabel";
            this.EmpIdLabel.Size = new System.Drawing.Size(77, 15);
            this.EmpIdLabel.TabIndex = 44;
            this.EmpIdLabel.Text = "Tenant ID :";
            // 
            // Tenant_management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.tenphnnmbrtb2);
            this.Controls.Add(this.TenantTable);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LogoutBtn);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.ViewAllBtn);
            this.Controls.Add(this.RefreshBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.InsertBtn);
            this.Controls.Add(this.LoadBtn);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.trent_tb);
            this.Controls.Add(this.tenisnt_tb);
            this.Controls.Add(this.tenphnnmbrtb1);
            this.Controls.Add(this.tenname_tb);
            this.Controls.Add(this.tenid_tb);
            this.Controls.Add(this.rent_lbl);
            this.Controls.Add(this.EmpSalaryLabel);
            this.Controls.Add(this.EmpPhnLabel);
            this.Controls.Add(this.EmpNameLabel);
            this.Controls.Add(this.EmpIdLabel);
            this.Name = "Tenant_management";
            this.Text = "Tenant_management";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.on_form_closed);
            ((System.ComponentModel.ISupportInitialize)(this.TenantTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tenphnnmbrtb2;
        private System.Windows.Forms.DataGridView TenantTable;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button ViewAllBtn;
        private System.Windows.Forms.Button RefreshBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button InsertBtn;
        private System.Windows.Forms.Button LoadBtn;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.TextBox trent_tb;
        private System.Windows.Forms.TextBox tenisnt_tb;
        private System.Windows.Forms.TextBox tenphnnmbrtb1;
        private System.Windows.Forms.TextBox tenname_tb;
        private System.Windows.Forms.TextBox tenid_tb;
        private System.Windows.Forms.Label rent_lbl;
        private System.Windows.Forms.Label EmpSalaryLabel;
        private System.Windows.Forms.Label EmpPhnLabel;
        private System.Windows.Forms.Label EmpNameLabel;
        private System.Windows.Forms.Label EmpIdLabel;
    }
}