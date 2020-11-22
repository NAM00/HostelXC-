namespace HostelX
{
    partial class Complains_management
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Complains_management));
            this.ComplainsTable = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.ViewAllBtn = new System.Windows.Forms.Button();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.LoadBtn = new System.Windows.Forms.Button();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.cbodyTB = new System.Windows.Forms.TextBox();
            this.cidTB = new System.Windows.Forms.TextBox();
            this.EmpSalaryLabel = new System.Windows.Forms.Label();
            this.EmpNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ComplainsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // ComplainsTable
            // 
            this.ComplainsTable.BackgroundColor = System.Drawing.SystemColors.Info;
            this.ComplainsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ComplainsTable.Location = new System.Drawing.Point(409, 109);
            this.ComplainsTable.Name = "ComplainsTable";
            this.ComplainsTable.ReadOnly = true;
            this.ComplainsTable.Size = new System.Drawing.Size(559, 299);
            this.ComplainsTable.TabIndex = 76;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(397, 441);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 15);
            this.label6.TabIndex = 75;
            this.label6.Text = "Search Here :";
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutBtn.Location = new System.Drawing.Point(874, 12);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(86, 32);
            this.LogoutBtn.TabIndex = 74;
            this.LogoutBtn.Text = "Logout";
            this.LogoutBtn.UseVisualStyleBackColor = true;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBtn.Location = new System.Drawing.Point(21, 22);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(83, 34);
            this.BackBtn.TabIndex = 73;
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
            this.ViewAllBtn.TabIndex = 72;
            this.ViewAllBtn.Text = "View complains";
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
            this.RefreshBtn.TabIndex = 71;
            this.RefreshBtn.Text = "Refresh";
            this.RefreshBtn.UseVisualStyleBackColor = true;
            // 
            // LoadBtn
            // 
            this.LoadBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadBtn.Location = new System.Drawing.Point(265, 433);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(75, 23);
            this.LoadBtn.TabIndex = 70;
            this.LoadBtn.Text = "Load";
            this.LoadBtn.UseVisualStyleBackColor = true;
            this.LoadBtn.Click += new System.EventHandler(this.LoadBtn_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBox.Location = new System.Drawing.Point(496, 441);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(472, 22);
            this.SearchBox.TabIndex = 69;
            this.SearchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            // 
            // cbodyTB
            // 
            this.cbodyTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbodyTB.Location = new System.Drawing.Point(70, 175);
            this.cbodyTB.Multiline = true;
            this.cbodyTB.Name = "cbodyTB";
            this.cbodyTB.Size = new System.Drawing.Size(270, 233);
            this.cbodyTB.TabIndex = 68;
            // 
            // cidTB
            // 
            this.cidTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cidTB.Location = new System.Drawing.Point(112, 124);
            this.cidTB.Name = "cidTB";
            this.cidTB.Size = new System.Drawing.Size(198, 22);
            this.cidTB.TabIndex = 67;
            // 
            // EmpSalaryLabel
            // 
            this.EmpSalaryLabel.AutoSize = true;
            this.EmpSalaryLabel.BackColor = System.Drawing.Color.Transparent;
            this.EmpSalaryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpSalaryLabel.Location = new System.Drawing.Point(18, 178);
            this.EmpSalaryLabel.Name = "EmpSalaryLabel";
            this.EmpSalaryLabel.Size = new System.Drawing.Size(46, 15);
            this.EmpSalaryLabel.TabIndex = 66;
            this.EmpSalaryLabel.Text = "Body :";
            // 
            // EmpNameLabel
            // 
            this.EmpNameLabel.AutoSize = true;
            this.EmpNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.EmpNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpNameLabel.Location = new System.Drawing.Point(18, 127);
            this.EmpNameLabel.Name = "EmpNameLabel";
            this.EmpNameLabel.Size = new System.Drawing.Size(88, 15);
            this.EmpNameLabel.TabIndex = 65;
            this.EmpNameLabel.Text = "Complain id:";
            // 
            // Complains_management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.ComplainsTable);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LogoutBtn);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.ViewAllBtn);
            this.Controls.Add(this.RefreshBtn);
            this.Controls.Add(this.LoadBtn);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.cbodyTB);
            this.Controls.Add(this.cidTB);
            this.Controls.Add(this.EmpSalaryLabel);
            this.Controls.Add(this.EmpNameLabel);
            this.Name = "Complains_management";
            this.Text = "Complains_management";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Complains_management_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.ComplainsTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ComplainsTable;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button ViewAllBtn;
        private System.Windows.Forms.Button RefreshBtn;
        private System.Windows.Forms.Button LoadBtn;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.TextBox cbodyTB;
        private System.Windows.Forms.TextBox cidTB;
        private System.Windows.Forms.Label EmpSalaryLabel;
        private System.Windows.Forms.Label EmpNameLabel;
    }
}