namespace BookBizz
{
    partial class AdminDashboard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.logout = new System.Windows.Forms.Button();
            this.employee = new System.Windows.Forms.Button();
            this.user = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.section = new System.Windows.Forms.Label();
            this.addUser = new System.Windows.Forms.Button();
            this.usersView = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.first_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.last_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noLabel = new System.Windows.Forms.Label();
            this.addEmployee = new System.Windows.Forms.Button();
            this.searchUser = new System.Windows.Forms.TextBox();
            this.searchUserBtn = new System.Windows.Forms.Button();
            this.cancelSearch = new System.Windows.Forms.Button();
            this.empCancelSearch = new System.Windows.Forms.Button();
            this.employeeSearchBtn = new System.Windows.Forms.Button();
            this.employeeSearch = new System.Windows.Forms.TextBox();
            this.employeesView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emp_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emp_lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.logout);
            this.panel1.Controls.Add(this.employee);
            this.panel1.Controls.Add(this.user);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1010, 62);
            this.panel1.TabIndex = 0;
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.Color.SteelBlue;
            this.logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.ForeColor = System.Drawing.Color.White;
            this.logout.Location = new System.Drawing.Point(862, 8);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(136, 45);
            this.logout.TabIndex = 4;
            this.logout.Text = "Logout";
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // employee
            // 
            this.employee.BackColor = System.Drawing.Color.SteelBlue;
            this.employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employee.ForeColor = System.Drawing.Color.White;
            this.employee.Location = new System.Drawing.Point(175, 8);
            this.employee.Name = "employee";
            this.employee.Size = new System.Drawing.Size(136, 45);
            this.employee.TabIndex = 3;
            this.employee.Text = "Employees";
            this.employee.UseVisualStyleBackColor = false;
            this.employee.Click += new System.EventHandler(this.employees_Click);
            // 
            // user
            // 
            this.user.BackColor = System.Drawing.Color.White;
            this.user.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user.ForeColor = System.Drawing.Color.SteelBlue;
            this.user.Location = new System.Drawing.Point(12, 8);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(136, 45);
            this.user.TabIndex = 0;
            this.user.Text = "Users";
            this.user.UseVisualStyleBackColor = false;
            this.user.Click += new System.EventHandler(this.user_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Location = new System.Drawing.Point(0, 114);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1010, 10);
            this.panel2.TabIndex = 1;
            // 
            // section
            // 
            this.section.AutoSize = true;
            this.section.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.section.Location = new System.Drawing.Point(12, 77);
            this.section.Name = "section";
            this.section.Size = new System.Drawing.Size(63, 25);
            this.section.TabIndex = 2;
            this.section.Text = "Users";
            // 
            // addUser
            // 
            this.addUser.BackColor = System.Drawing.Color.SteelBlue;
            this.addUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUser.ForeColor = System.Drawing.Color.White;
            this.addUser.Location = new System.Drawing.Point(819, 67);
            this.addUser.Name = "addUser";
            this.addUser.Size = new System.Drawing.Size(179, 41);
            this.addUser.TabIndex = 5;
            this.addUser.Text = "Add User";
            this.addUser.UseVisualStyleBackColor = false;
            this.addUser.Click += new System.EventHandler(this.addUser_Click);
            // 
            // usersView
            // 
            this.usersView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.usersView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.first_name,
            this.last_name,
            this.phone_number,
            this.email,
            this.empId});
            this.usersView.Location = new System.Drawing.Point(17, 201);
            this.usersView.Name = "usersView";
            this.usersView.RowHeadersWidth = 51;
            this.usersView.RowTemplate.Height = 24;
            this.usersView.Size = new System.Drawing.Size(981, 490);
            this.usersView.TabIndex = 6;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "Id";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 125;
            // 
            // first_name
            // 
            this.first_name.DataPropertyName = "first_name";
            this.first_name.HeaderText = "First Name";
            this.first_name.MinimumWidth = 6;
            this.first_name.Name = "first_name";
            this.first_name.Width = 200;
            // 
            // last_name
            // 
            this.last_name.DataPropertyName = "last_name";
            this.last_name.HeaderText = "Last Name";
            this.last_name.MinimumWidth = 6;
            this.last_name.Name = "last_name";
            this.last_name.Width = 200;
            // 
            // phone_number
            // 
            this.phone_number.DataPropertyName = "phone";
            this.phone_number.HeaderText = "Phone Number";
            this.phone_number.MinimumWidth = 6;
            this.phone_number.Name = "phone_number";
            this.phone_number.Width = 200;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Email";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            this.email.Width = 200;
            // 
            // empId
            // 
            this.empId.DataPropertyName = "empId";
            this.empId.HeaderText = "Employee Id";
            this.empId.MinimumWidth = 6;
            this.empId.Name = "empId";
            this.empId.Width = 125;
            // 
            // noLabel
            // 
            this.noLabel.AutoSize = true;
            this.noLabel.BackColor = System.Drawing.Color.SteelBlue;
            this.noLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noLabel.ForeColor = System.Drawing.Color.White;
            this.noLabel.Location = new System.Drawing.Point(303, 450);
            this.noLabel.Name = "noLabel";
            this.noLabel.Size = new System.Drawing.Size(466, 46);
            this.noLabel.TabIndex = 7;
            this.noLabel.Text = "There is nothing to show!";
            // 
            // addEmployee
            // 
            this.addEmployee.BackColor = System.Drawing.Color.SteelBlue;
            this.addEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployee.ForeColor = System.Drawing.Color.White;
            this.addEmployee.Location = new System.Drawing.Point(820, 68);
            this.addEmployee.Name = "addEmployee";
            this.addEmployee.Size = new System.Drawing.Size(179, 41);
            this.addEmployee.TabIndex = 8;
            this.addEmployee.Text = "Add Employee";
            this.addEmployee.UseVisualStyleBackColor = false;
            this.addEmployee.Click += new System.EventHandler(this.addEmployee_Click);
            // 
            // searchUser
            // 
            this.searchUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchUser.Location = new System.Drawing.Point(17, 147);
            this.searchUser.Name = "searchUser";
            this.searchUser.Size = new System.Drawing.Size(429, 28);
            this.searchUser.TabIndex = 9;
            // 
            // searchUserBtn
            // 
            this.searchUserBtn.Location = new System.Drawing.Point(445, 147);
            this.searchUserBtn.Name = "searchUserBtn";
            this.searchUserBtn.Size = new System.Drawing.Size(75, 28);
            this.searchUserBtn.TabIndex = 10;
            this.searchUserBtn.Text = "Search";
            this.searchUserBtn.UseVisualStyleBackColor = true;
            this.searchUserBtn.Click += new System.EventHandler(this.searchUserBtn_Click);
            // 
            // cancelSearch
            // 
            this.cancelSearch.Location = new System.Drawing.Point(521, 147);
            this.cancelSearch.Name = "cancelSearch";
            this.cancelSearch.Size = new System.Drawing.Size(75, 28);
            this.cancelSearch.TabIndex = 11;
            this.cancelSearch.Text = "Cancel";
            this.cancelSearch.UseVisualStyleBackColor = true;
            this.cancelSearch.Visible = false;
            this.cancelSearch.Click += new System.EventHandler(this.cancelSearch_Click);
            // 
            // empCancelSearch
            // 
            this.empCancelSearch.Location = new System.Drawing.Point(521, 147);
            this.empCancelSearch.Name = "empCancelSearch";
            this.empCancelSearch.Size = new System.Drawing.Size(75, 28);
            this.empCancelSearch.TabIndex = 14;
            this.empCancelSearch.Text = "Cancel";
            this.empCancelSearch.UseVisualStyleBackColor = true;
            this.empCancelSearch.Visible = false;
            this.empCancelSearch.Click += new System.EventHandler(this.empCancelSearch_Click);
            // 
            // employeeSearchBtn
            // 
            this.employeeSearchBtn.Location = new System.Drawing.Point(445, 147);
            this.employeeSearchBtn.Name = "employeeSearchBtn";
            this.employeeSearchBtn.Size = new System.Drawing.Size(75, 28);
            this.employeeSearchBtn.TabIndex = 13;
            this.employeeSearchBtn.Text = "Search";
            this.employeeSearchBtn.UseVisualStyleBackColor = true;
            this.employeeSearchBtn.Visible = false;
            this.employeeSearchBtn.Click += new System.EventHandler(this.employeeSearchBtn_Click);
            // 
            // employeeSearch
            // 
            this.employeeSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeSearch.Location = new System.Drawing.Point(17, 147);
            this.employeeSearch.Name = "employeeSearch";
            this.employeeSearch.Size = new System.Drawing.Size(429, 28);
            this.employeeSearch.TabIndex = 12;
            this.employeeSearch.Visible = false;
            // 
            // employeesView
            // 
            this.employeesView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.employeesView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeesView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.emp_name,
            this.emp_lastname,
            this.role,
            this.username,
            this.password});
            this.employeesView.Location = new System.Drawing.Point(17, 201);
            this.employeesView.Name = "employeesView";
            this.employeesView.RowHeadersWidth = 51;
            this.employeesView.RowTemplate.Height = 24;
            this.employeesView.Size = new System.Drawing.Size(981, 490);
            this.employeesView.TabIndex = 15;
            this.employeesView.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // emp_name
            // 
            this.emp_name.DataPropertyName = "first_name";
            this.emp_name.HeaderText = "First Name";
            this.emp_name.MinimumWidth = 6;
            this.emp_name.Name = "emp_name";
            this.emp_name.Width = 200;
            // 
            // emp_lastname
            // 
            this.emp_lastname.DataPropertyName = "last_name";
            this.emp_lastname.HeaderText = "Last Name";
            this.emp_lastname.MinimumWidth = 6;
            this.emp_lastname.Name = "emp_lastname";
            this.emp_lastname.Width = 200;
            // 
            // role
            // 
            this.role.DataPropertyName = "role";
            this.role.HeaderText = "Role";
            this.role.MinimumWidth = 6;
            this.role.Name = "role";
            this.role.Width = 125;
            // 
            // username
            // 
            this.username.DataPropertyName = "username";
            this.username.HeaderText = "Username";
            this.username.MinimumWidth = 6;
            this.username.Name = "username";
            this.username.Width = 200;
            // 
            // password
            // 
            this.password.DataPropertyName = "password";
            this.password.HeaderText = "Password";
            this.password.MinimumWidth = 6;
            this.password.Name = "password";
            this.password.Width = 200;
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1010, 718);
            this.Controls.Add(this.employeesView);
            this.Controls.Add(this.empCancelSearch);
            this.Controls.Add(this.employeeSearchBtn);
            this.Controls.Add(this.employeeSearch);
            this.Controls.Add(this.cancelSearch);
            this.Controls.Add(this.searchUserBtn);
            this.Controls.Add(this.searchUser);
            this.Controls.Add(this.addEmployee);
            this.Controls.Add(this.noLabel);
            this.Controls.Add(this.usersView);
            this.Controls.Add(this.addUser);
            this.Controls.Add(this.section);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AdminDashboard";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usersView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button user;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button employee;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label section;
        private System.Windows.Forms.Button addUser;
        private System.Windows.Forms.DataGridView usersView;
        private System.Windows.Forms.Label noLabel;
        private System.Windows.Forms.Button addEmployee;
        private System.Windows.Forms.TextBox searchUser;
        private System.Windows.Forms.Button searchUserBtn;
        private System.Windows.Forms.Button cancelSearch;
        private System.Windows.Forms.Button empCancelSearch;
        private System.Windows.Forms.Button employeeSearchBtn;
        private System.Windows.Forms.TextBox employeeSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn first_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn last_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn empId;
        private System.Windows.Forms.DataGridView employeesView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn emp_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn emp_lastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn role;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
    }
}