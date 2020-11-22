namespace HostelX
{
    partial class tenant_applications
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tenant_applications));
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.InsertBtn = new System.Windows.Forms.Button();
            this.appbodyTB = new System.Windows.Forms.TextBox();
            this.appsubTB = new System.Windows.Forms.TextBox();
            this.EmpSalaryLabel = new System.Windows.Forms.Label();
            this.EmpNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.BackBtn.Location = new System.Drawing.Point(28, 12);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(83, 34);
            this.BackBtn.TabIndex = 61;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
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
            // InsertBtn
            // 
            this.InsertBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertBtn.Location = new System.Drawing.Point(885, 453);
            this.InsertBtn.Name = "InsertBtn";
            this.InsertBtn.Size = new System.Drawing.Size(75, 23);
            this.InsertBtn.TabIndex = 56;
            this.InsertBtn.Text = "Send";
            this.InsertBtn.UseVisualStyleBackColor = true;
            this.InsertBtn.Click += new System.EventHandler(this.InsertBtn_Click);
            // 
            // appbodyTB
            // 
            this.appbodyTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appbodyTB.Location = new System.Drawing.Point(81, 175);
            this.appbodyTB.Multiline = true;
            this.appbodyTB.Name = "appbodyTB";
            this.appbodyTB.Size = new System.Drawing.Size(890, 262);
            this.appbodyTB.TabIndex = 52;
            // 
            // appsubTB
            // 
            this.appsubTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appsubTB.Location = new System.Drawing.Point(115, 120);
            this.appsubTB.Name = "appsubTB";
            this.appsubTB.Size = new System.Drawing.Size(198, 22);
            this.appsubTB.TabIndex = 50;
            // 
            // EmpSalaryLabel
            // 
            this.EmpSalaryLabel.AutoSize = true;
            this.EmpSalaryLabel.BackColor = System.Drawing.Color.Transparent;
            this.EmpSalaryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpSalaryLabel.Location = new System.Drawing.Point(29, 178);
            this.EmpSalaryLabel.Name = "EmpSalaryLabel";
            this.EmpSalaryLabel.Size = new System.Drawing.Size(46, 15);
            this.EmpSalaryLabel.TabIndex = 47;
            this.EmpSalaryLabel.Text = "Body :";
            // 
            // EmpNameLabel
            // 
            this.EmpNameLabel.AutoSize = true;
            this.EmpNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.EmpNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpNameLabel.Location = new System.Drawing.Point(29, 127);
            this.EmpNameLabel.Name = "EmpNameLabel";
            this.EmpNameLabel.Size = new System.Drawing.Size(63, 15);
            this.EmpNameLabel.TabIndex = 45;
            this.EmpNameLabel.Text = "Subject :";
            // 
            // tenant_applications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.LogoutBtn);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.RefreshBtn);
            this.Controls.Add(this.InsertBtn);
            this.Controls.Add(this.appbodyTB);
            this.Controls.Add(this.appsubTB);
            this.Controls.Add(this.EmpSalaryLabel);
            this.Controls.Add(this.EmpNameLabel);
            this.Name = "tenant_applications";
            this.Text = "tenant_applications";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Tenant_applications_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button RefreshBtn;
        private System.Windows.Forms.Button InsertBtn;
        private System.Windows.Forms.TextBox appbodyTB;
        private System.Windows.Forms.TextBox appsubTB;
        private System.Windows.Forms.Label EmpSalaryLabel;
        private System.Windows.Forms.Label EmpNameLabel;
    }
}