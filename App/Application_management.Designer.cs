namespace HostelX
{
    partial class Application_management
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Application_management));
            this.AppTable = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.ViewAllBtn = new System.Windows.Forms.Button();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.InsertBtn = new System.Windows.Forms.Button();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.appbodytb = new System.Windows.Forms.TextBox();
            this.apid_tb = new System.Windows.Forms.TextBox();
            this.EmpSalaryLabel = new System.Windows.Forms.Label();
            this.EmpNameLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.statusTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AppTable)).BeginInit();
            this.SuspendLayout();
            // 
            // AppTable
            // 
            this.AppTable.BackgroundColor = System.Drawing.SystemColors.Info;
            this.AppTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AppTable.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AppTable.Location = new System.Drawing.Point(409, 109);
            this.AppTable.Name = "AppTable";
            this.AppTable.ReadOnly = true;
            this.AppTable.Size = new System.Drawing.Size(559, 299);
            this.AppTable.TabIndex = 88;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(397, 441);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 15);
            this.label6.TabIndex = 87;
            this.label6.Text = "Search Here :";
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutBtn.Location = new System.Drawing.Point(874, 12);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(86, 32);
            this.LogoutBtn.TabIndex = 86;
            this.LogoutBtn.Text = "Logout";
            this.LogoutBtn.UseVisualStyleBackColor = true;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBtn.Location = new System.Drawing.Point(21, 12);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(83, 34);
            this.BackBtn.TabIndex = 85;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // ViewAllBtn
            // 
            this.ViewAllBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewAllBtn.Location = new System.Drawing.Point(409, 71);
            this.ViewAllBtn.Name = "ViewAllBtn";
            this.ViewAllBtn.Size = new System.Drawing.Size(559, 23);
            this.ViewAllBtn.TabIndex = 84;
            this.ViewAllBtn.Text = "View Applications";
            this.ViewAllBtn.UseVisualStyleBackColor = true;
            this.ViewAllBtn.Click += new System.EventHandler(this.ViewAllBtn_Click);
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Enabled = false;
            this.RefreshBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshBtn.Location = new System.Drawing.Point(17, 71);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(323, 23);
            this.RefreshBtn.TabIndex = 83;
            this.RefreshBtn.Text = "Refresh";
            this.RefreshBtn.UseVisualStyleBackColor = true;
            // 
            // InsertBtn
            // 
            this.InsertBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertBtn.Location = new System.Drawing.Point(265, 433);
            this.InsertBtn.Name = "InsertBtn";
            this.InsertBtn.Size = new System.Drawing.Size(75, 23);
            this.InsertBtn.TabIndex = 82;
            this.InsertBtn.Text = "Load";
            this.InsertBtn.UseVisualStyleBackColor = true;
            this.InsertBtn.Click += new System.EventHandler(this.InsertBtn_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBox.Location = new System.Drawing.Point(496, 441);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(472, 22);
            this.SearchBox.TabIndex = 81;
            this.SearchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            // 
            // appbodytb
            // 
            this.appbodytb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appbodytb.Location = new System.Drawing.Point(70, 175);
            this.appbodytb.Multiline = true;
            this.appbodytb.Name = "appbodytb";
            this.appbodytb.Size = new System.Drawing.Size(270, 233);
            this.appbodytb.TabIndex = 80;
            // 
            // apid_tb
            // 
            this.apid_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apid_tb.Location = new System.Drawing.Point(112, 124);
            this.apid_tb.Name = "apid_tb";
            this.apid_tb.Size = new System.Drawing.Size(198, 22);
            this.apid_tb.TabIndex = 79;
            // 
            // EmpSalaryLabel
            // 
            this.EmpSalaryLabel.AutoSize = true;
            this.EmpSalaryLabel.BackColor = System.Drawing.Color.Transparent;
            this.EmpSalaryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpSalaryLabel.Location = new System.Drawing.Point(18, 178);
            this.EmpSalaryLabel.Name = "EmpSalaryLabel";
            this.EmpSalaryLabel.Size = new System.Drawing.Size(46, 15);
            this.EmpSalaryLabel.TabIndex = 78;
            this.EmpSalaryLabel.Text = "Body :";
            // 
            // EmpNameLabel
            // 
            this.EmpNameLabel.AutoSize = true;
            this.EmpNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.EmpNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpNameLabel.Location = new System.Drawing.Point(11, 127);
            this.EmpNameLabel.Name = "EmpNameLabel";
            this.EmpNameLabel.Size = new System.Drawing.Size(98, 15);
            this.EmpNameLabel.TabIndex = 77;
            this.EmpNameLabel.Text = "Application id:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(354, 511);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 89;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // statusTB
            // 
            this.statusTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusTB.Location = new System.Drawing.Point(128, 512);
            this.statusTB.Name = "statusTB";
            this.statusTB.Size = new System.Drawing.Size(198, 22);
            this.statusTB.TabIndex = 90;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 515);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 91;
            this.label1.Text = "Status :";
            // 
            // Application_management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusTB);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AppTable);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LogoutBtn);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.ViewAllBtn);
            this.Controls.Add(this.RefreshBtn);
            this.Controls.Add(this.InsertBtn);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.appbodytb);
            this.Controls.Add(this.apid_tb);
            this.Controls.Add(this.EmpSalaryLabel);
            this.Controls.Add(this.EmpNameLabel);
            this.Name = "Application_management";
            this.Text = "Application_management";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Application_management_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.AppTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView AppTable;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button ViewAllBtn;
        private System.Windows.Forms.Button RefreshBtn;
        private System.Windows.Forms.Button InsertBtn;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.TextBox appbodytb;
        private System.Windows.Forms.TextBox apid_tb;
        private System.Windows.Forms.Label EmpSalaryLabel;
        private System.Windows.Forms.Label EmpNameLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox statusTB;
        private System.Windows.Forms.Label label1;
    }
}