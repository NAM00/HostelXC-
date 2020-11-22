namespace HostelX
{
    partial class Employee_management
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee_management));
            this.EmpPhnNumberTB2 = new System.Windows.Forms.TextBox();
            this.EmployeeTable = new System.Windows.Forms.DataGridView();
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
            this.EmpDesignationTB = new System.Windows.Forms.TextBox();
            this.EmpSalaryTB = new System.Windows.Forms.TextBox();
            this.EmpPhnNumberTB1 = new System.Windows.Forms.TextBox();
            this.EmpNameTB = new System.Windows.Forms.TextBox();
            this.EmpIdTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.EmpSalaryLabel = new System.Windows.Forms.Label();
            this.EmpPhnLabel = new System.Windows.Forms.Label();
            this.EmpNameLabel = new System.Windows.Forms.Label();
            this.EmpIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeTable)).BeginInit();
            this.SuspendLayout();
            // 
            // EmpPhnNumberTB2
            // 
            this.EmpPhnNumberTB2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpPhnNumberTB2.Location = new System.Drawing.Point(207, 232);
            this.EmpPhnNumberTB2.Name = "EmpPhnNumberTB2";
            this.EmpPhnNumberTB2.Size = new System.Drawing.Size(158, 22);
            this.EmpPhnNumberTB2.TabIndex = 43;
            // 
            // EmployeeTable
            // 
            this.EmployeeTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeeTable.Location = new System.Drawing.Point(413, 109);
            this.EmployeeTable.Name = "EmployeeTable";
            this.EmployeeTable.ReadOnly = true;
            this.EmployeeTable.Size = new System.Drawing.Size(559, 299);
            this.EmployeeTable.TabIndex = 42;
            this.EmployeeTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmployeeTable_CellClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(401, 441);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 15);
            this.label6.TabIndex = 41;
            this.label6.Text = "Search Here :";
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutBtn.Location = new System.Drawing.Point(878, 12);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(86, 32);
            this.LogoutBtn.TabIndex = 40;
            this.LogoutBtn.Text = "Logout";
            this.LogoutBtn.UseVisualStyleBackColor = true;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBtn.Location = new System.Drawing.Point(2, 12);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(83, 34);
            this.BackBtn.TabIndex = 39;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // ViewAllBtn
            // 
            this.ViewAllBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewAllBtn.Location = new System.Drawing.Point(413, 71);
            this.ViewAllBtn.Name = "ViewAllBtn";
            this.ViewAllBtn.Size = new System.Drawing.Size(559, 23);
            this.ViewAllBtn.TabIndex = 38;
            this.ViewAllBtn.Text = "View All Employees";
            this.ViewAllBtn.UseVisualStyleBackColor = true;
            this.ViewAllBtn.Click += new System.EventHandler(this.ViewAllBtn_Click);
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Enabled = false;
            this.RefreshBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshBtn.Location = new System.Drawing.Point(21, 71);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(323, 23);
            this.RefreshBtn.TabIndex = 37;
            this.RefreshBtn.Text = "Refresh";
            this.RefreshBtn.UseVisualStyleBackColor = true;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Enabled = false;
            this.DeleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.Location = new System.Drawing.Point(290, 429);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.DeleteBtn.TabIndex = 36;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Enabled = false;
            this.UpdateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBtn.Location = new System.Drawing.Point(186, 429);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(75, 23);
            this.UpdateBtn.TabIndex = 35;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // InsertBtn
            // 
            this.InsertBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertBtn.Location = new System.Drawing.Point(97, 429);
            this.InsertBtn.Name = "InsertBtn";
            this.InsertBtn.Size = new System.Drawing.Size(75, 23);
            this.InsertBtn.TabIndex = 34;
            this.InsertBtn.Text = "Insert";
            this.InsertBtn.UseVisualStyleBackColor = true;
            this.InsertBtn.Click += new System.EventHandler(this.InsertBtn_Click);
            // 
            // LoadBtn
            // 
            this.LoadBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadBtn.Location = new System.Drawing.Point(5, 429);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(75, 23);
            this.LoadBtn.TabIndex = 33;
            this.LoadBtn.Text = "Load";
            this.LoadBtn.UseVisualStyleBackColor = true;
            this.LoadBtn.Click += new System.EventHandler(this.LoadBtn_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBox.Location = new System.Drawing.Point(500, 441);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(472, 22);
            this.SearchBox.TabIndex = 32;
            this.SearchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            // 
            // EmpDesignationTB
            // 
            this.EmpDesignationTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpDesignationTB.Location = new System.Drawing.Point(169, 340);
            this.EmpDesignationTB.Name = "EmpDesignationTB";
            this.EmpDesignationTB.Size = new System.Drawing.Size(198, 22);
            this.EmpDesignationTB.TabIndex = 31;
            // 
            // EmpSalaryTB
            // 
            this.EmpSalaryTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpSalaryTB.Location = new System.Drawing.Point(169, 282);
            this.EmpSalaryTB.Name = "EmpSalaryTB";
            this.EmpSalaryTB.Size = new System.Drawing.Size(198, 22);
            this.EmpSalaryTB.TabIndex = 30;
            // 
            // EmpPhnNumberTB1
            // 
            this.EmpPhnNumberTB1.Enabled = false;
            this.EmpPhnNumberTB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpPhnNumberTB1.Location = new System.Drawing.Point(167, 232);
            this.EmpPhnNumberTB1.Name = "EmpPhnNumberTB1";
            this.EmpPhnNumberTB1.Size = new System.Drawing.Size(36, 22);
            this.EmpPhnNumberTB1.TabIndex = 29;
            this.EmpPhnNumberTB1.Text = "+880";
            // 
            // EmpNameTB
            // 
            this.EmpNameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpNameTB.Location = new System.Drawing.Point(167, 185);
            this.EmpNameTB.Name = "EmpNameTB";
            this.EmpNameTB.Size = new System.Drawing.Size(198, 22);
            this.EmpNameTB.TabIndex = 28;
            // 
            // EmpIdTB
            // 
            this.EmpIdTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpIdTB.Location = new System.Drawing.Point(167, 136);
            this.EmpIdTB.Name = "EmpIdTB";
            this.EmpIdTB.Size = new System.Drawing.Size(198, 22);
            this.EmpIdTB.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(2, 340);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 15);
            this.label5.TabIndex = 26;
            this.label5.Text = "Employee Designation :";
            // 
            // EmpSalaryLabel
            // 
            this.EmpSalaryLabel.AutoSize = true;
            this.EmpSalaryLabel.BackColor = System.Drawing.Color.Transparent;
            this.EmpSalaryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpSalaryLabel.Location = new System.Drawing.Point(39, 285);
            this.EmpSalaryLabel.Name = "EmpSalaryLabel";
            this.EmpSalaryLabel.Size = new System.Drawing.Size(122, 15);
            this.EmpSalaryLabel.TabIndex = 25;
            this.EmpSalaryLabel.Text = "Employee Salary :";
            // 
            // EmpPhnLabel
            // 
            this.EmpPhnLabel.AutoSize = true;
            this.EmpPhnLabel.BackColor = System.Drawing.Color.Transparent;
            this.EmpPhnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpPhnLabel.Location = new System.Drawing.Point(-1, 235);
            this.EmpPhnLabel.Name = "EmpPhnLabel";
            this.EmpPhnLabel.Size = new System.Drawing.Size(162, 15);
            this.EmpPhnLabel.TabIndex = 24;
            this.EmpPhnLabel.Text = "Employee Phn Number :";
            // 
            // EmpNameLabel
            // 
            this.EmpNameLabel.AutoSize = true;
            this.EmpNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.EmpNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpNameLabel.Location = new System.Drawing.Point(41, 192);
            this.EmpNameLabel.Name = "EmpNameLabel";
            this.EmpNameLabel.Size = new System.Drawing.Size(120, 15);
            this.EmpNameLabel.TabIndex = 23;
            this.EmpNameLabel.Text = "Employee Name :";
            // 
            // EmpIdLabel
            // 
            this.EmpIdLabel.AutoSize = true;
            this.EmpIdLabel.BackColor = System.Drawing.Color.Transparent;
            this.EmpIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpIdLabel.Location = new System.Drawing.Point(65, 139);
            this.EmpIdLabel.Name = "EmpIdLabel";
            this.EmpIdLabel.Size = new System.Drawing.Size(96, 15);
            this.EmpIdLabel.TabIndex = 22;
            this.EmpIdLabel.Text = "Employee ID :";
            // 
            // Employee_management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.EmpPhnNumberTB2);
            this.Controls.Add(this.EmployeeTable);
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
            this.Controls.Add(this.EmpDesignationTB);
            this.Controls.Add(this.EmpSalaryTB);
            this.Controls.Add(this.EmpPhnNumberTB1);
            this.Controls.Add(this.EmpNameTB);
            this.Controls.Add(this.EmpIdTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.EmpSalaryLabel);
            this.Controls.Add(this.EmpPhnLabel);
            this.Controls.Add(this.EmpNameLabel);
            this.Controls.Add(this.EmpIdLabel);
            this.Name = "Employee_management";
            this.Text = "Employee_management";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.onformclosed);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EmpPhnNumberTB2;
        private System.Windows.Forms.DataGridView EmployeeTable;
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
        private System.Windows.Forms.TextBox EmpDesignationTB;
        private System.Windows.Forms.TextBox EmpSalaryTB;
        private System.Windows.Forms.TextBox EmpPhnNumberTB1;
        private System.Windows.Forms.TextBox EmpNameTB;
        private System.Windows.Forms.TextBox EmpIdTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label EmpSalaryLabel;
        private System.Windows.Forms.Label EmpPhnLabel;
        private System.Windows.Forms.Label EmpNameLabel;
        private System.Windows.Forms.Label EmpIdLabel;
    }
}