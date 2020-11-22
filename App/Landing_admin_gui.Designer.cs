namespace HostelX
{
    partial class Landing_admin_gui
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Landing_admin_gui));
            this.btn_mngemp = new System.Windows.Forms.Button();
            this.btn_mngten = new System.Windows.Forms.Button();
            this.btn_mngapp = new System.Windows.Forms.Button();
            this.btn_mngcomp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_logout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_mngemp
            // 
            this.btn_mngemp.BackColor = System.Drawing.SystemColors.Info;
            this.btn_mngemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mngemp.Location = new System.Drawing.Point(27, 276);
            this.btn_mngemp.Name = "btn_mngemp";
            this.btn_mngemp.Size = new System.Drawing.Size(138, 87);
            this.btn_mngemp.TabIndex = 0;
            this.btn_mngemp.Text = "Manage Emoloyee";
            this.btn_mngemp.UseVisualStyleBackColor = false;
            this.btn_mngemp.Click += new System.EventHandler(this.Btn_mngemp_Click);
            // 
            // btn_mngten
            // 
            this.btn_mngten.BackColor = System.Drawing.SystemColors.Info;
            this.btn_mngten.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mngten.Location = new System.Drawing.Point(249, 276);
            this.btn_mngten.Name = "btn_mngten";
            this.btn_mngten.Size = new System.Drawing.Size(138, 87);
            this.btn_mngten.TabIndex = 1;
            this.btn_mngten.Text = "Manage Tenant";
            this.btn_mngten.UseVisualStyleBackColor = false;
            this.btn_mngten.Click += new System.EventHandler(this.Btn_mngten_Click);
            // 
            // btn_mngapp
            // 
            this.btn_mngapp.BackColor = System.Drawing.SystemColors.Info;
            this.btn_mngapp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mngapp.Location = new System.Drawing.Point(517, 276);
            this.btn_mngapp.Name = "btn_mngapp";
            this.btn_mngapp.Size = new System.Drawing.Size(138, 87);
            this.btn_mngapp.TabIndex = 2;
            this.btn_mngapp.Text = "Manage Application";
            this.btn_mngapp.UseVisualStyleBackColor = false;
            this.btn_mngapp.Click += new System.EventHandler(this.Btn_mngapp_Click);
            // 
            // btn_mngcomp
            // 
            this.btn_mngcomp.BackColor = System.Drawing.SystemColors.Info;
            this.btn_mngcomp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mngcomp.Location = new System.Drawing.Point(794, 276);
            this.btn_mngcomp.Name = "btn_mngcomp";
            this.btn_mngcomp.Size = new System.Drawing.Size(138, 87);
            this.btn_mngcomp.TabIndex = 3;
            this.btn_mngcomp.Text = "Manage Complains";
            this.btn_mngcomp.UseVisualStyleBackColor = false;
            this.btn_mngcomp.Click += new System.EventHandler(this.Btn_mngcomp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 55);
            this.label1.TabIndex = 5;
            this.label1.Text = "Welcome Admin";
            // 
            // btn_logout
            // 
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.ForeColor = System.Drawing.Color.Black;
            this.btn_logout.Location = new System.Drawing.Point(849, 12);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(101, 41);
            this.btn_logout.TabIndex = 7;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.Btn_logout_Click);
            // 
            // Landing_admin_gui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_mngcomp);
            this.Controls.Add(this.btn_mngapp);
            this.Controls.Add(this.btn_mngten);
            this.Controls.Add(this.btn_mngemp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Landing_admin_gui";
            this.Text = "HostelX";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.on_form_closing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_mngemp;
        private System.Windows.Forms.Button btn_mngten;
        private System.Windows.Forms.Button btn_mngapp;
        private System.Windows.Forms.Button btn_mngcomp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_logout;
    }
}