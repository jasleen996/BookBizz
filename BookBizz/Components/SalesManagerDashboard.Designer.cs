namespace BookBizz.Components
{
    partial class SalesManagerDashboard
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
            this.cancelSearch = new System.Windows.Forms.Button();
            this.searchClient = new System.Windows.Forms.TextBox();
            this.noLabel = new System.Windows.Forms.Label();
            this.addClient = new System.Windows.Forms.Button();
            this.section = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.logout = new System.Windows.Forms.Button();
            this.client = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.clientsView = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.street = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.city = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postal_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fax_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.credit_limit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchClientBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientsView)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelSearch
            // 
            this.cancelSearch.Location = new System.Drawing.Point(520, 165);
            this.cancelSearch.Name = "cancelSearch";
            this.cancelSearch.Size = new System.Drawing.Size(75, 28);
            this.cancelSearch.TabIndex = 24;
            this.cancelSearch.Text = "Cancel";
            this.cancelSearch.UseVisualStyleBackColor = true;
            this.cancelSearch.Visible = false;
            this.cancelSearch.Click += new System.EventHandler(this.cancelSearch_Click);
            // 
            // searchClient
            // 
            this.searchClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchClient.Location = new System.Drawing.Point(16, 165);
            this.searchClient.Name = "searchClient";
            this.searchClient.Size = new System.Drawing.Size(429, 28);
            this.searchClient.TabIndex = 22;
            this.searchClient.TextChanged += new System.EventHandler(this.searchClient_TextChanged);
            // 
            // noLabel
            // 
            this.noLabel.AutoSize = true;
            this.noLabel.BackColor = System.Drawing.Color.SteelBlue;
            this.noLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noLabel.ForeColor = System.Drawing.Color.White;
            this.noLabel.Location = new System.Drawing.Point(302, 468);
            this.noLabel.Name = "noLabel";
            this.noLabel.Size = new System.Drawing.Size(466, 46);
            this.noLabel.TabIndex = 20;
            this.noLabel.Text = "There is nothing to show!";
            this.noLabel.Click += new System.EventHandler(this.noLabel_Click);
            // 
            // addClient
            // 
            this.addClient.BackColor = System.Drawing.Color.SteelBlue;
            this.addClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addClient.ForeColor = System.Drawing.Color.White;
            this.addClient.Location = new System.Drawing.Point(818, 85);
            this.addClient.Name = "addClient";
            this.addClient.Size = new System.Drawing.Size(179, 41);
            this.addClient.TabIndex = 18;
            this.addClient.Text = "Add Client";
            this.addClient.UseVisualStyleBackColor = false;
            this.addClient.Click += new System.EventHandler(this.addClient_Click);
            // 
            // section
            // 
            this.section.AutoSize = true;
            this.section.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.section.Location = new System.Drawing.Point(11, 95);
            this.section.Name = "section";
            this.section.Size = new System.Drawing.Size(72, 25);
            this.section.TabIndex = 17;
            this.section.Text = "Clients";
            this.section.Click += new System.EventHandler(this.section_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Location = new System.Drawing.Point(-1, 132);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1010, 10);
            this.panel2.TabIndex = 16;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
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
            // client
            // 
            this.client.BackColor = System.Drawing.Color.White;
            this.client.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.client.ForeColor = System.Drawing.Color.SteelBlue;
            this.client.Location = new System.Drawing.Point(12, 8);
            this.client.Name = "client";
            this.client.Size = new System.Drawing.Size(136, 45);
            this.client.TabIndex = 0;
            this.client.Text = "Clients";
            this.client.UseVisualStyleBackColor = false;
            this.client.Click += new System.EventHandler(this.client_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.logout);
            this.panel1.Controls.Add(this.client);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1009, 62);
            this.panel1.TabIndex = 15;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // clientsView
            // 
            this.clientsView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.clientsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientsView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.name,
            this.street,
            this.city,
            this.postal_code,
            this.phone_number,
            this.fax_number,
            this.credit_limit});
            this.clientsView.Location = new System.Drawing.Point(16, 219);
            this.clientsView.Name = "clientsView";
            this.clientsView.RowHeadersWidth = 51;
            this.clientsView.RowTemplate.Height = 24;
            this.clientsView.Size = new System.Drawing.Size(981, 490);
            this.clientsView.TabIndex = 19;
            this.clientsView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clientsView_CellContentClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "Id";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 125;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Name";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.Width = 125;
            // 
            // street
            // 
            this.street.DataPropertyName = "street";
            this.street.HeaderText = "Street";
            this.street.MinimumWidth = 6;
            this.street.Name = "street";
            this.street.Width = 125;
            // 
            // city
            // 
            this.city.DataPropertyName = "city";
            this.city.HeaderText = "City";
            this.city.MinimumWidth = 6;
            this.city.Name = "city";
            this.city.Width = 125;
            // 
            // postal_code
            // 
            this.postal_code.DataPropertyName = "postal_code";
            this.postal_code.HeaderText = "Postal Code";
            this.postal_code.MinimumWidth = 6;
            this.postal_code.Name = "postal_code";
            this.postal_code.Width = 125;
            // 
            // phone_number
            // 
            this.phone_number.DataPropertyName = "phone_number";
            this.phone_number.HeaderText = "Phone Number";
            this.phone_number.MinimumWidth = 6;
            this.phone_number.Name = "phone_number";
            this.phone_number.Width = 125;
            // 
            // fax_number
            // 
            this.fax_number.DataPropertyName = "fax_nummber";
            this.fax_number.HeaderText = "Fax_number";
            this.fax_number.MinimumWidth = 6;
            this.fax_number.Name = "fax_number";
            this.fax_number.Width = 125;
            // 
            // credit_limit
            // 
            this.credit_limit.DataPropertyName = "credit_limit";
            this.credit_limit.HeaderText = "CreditLimit";
            this.credit_limit.MinimumWidth = 6;
            this.credit_limit.Name = "credit_limit";
            this.credit_limit.Width = 125;
            // 
            // searchClientBtn
            // 
            this.searchClientBtn.Location = new System.Drawing.Point(444, 165);
            this.searchClientBtn.Name = "searchClientBtn";
            this.searchClientBtn.Size = new System.Drawing.Size(75, 28);
            this.searchClientBtn.TabIndex = 26;
            this.searchClientBtn.Text = "Search";
            this.searchClientBtn.UseVisualStyleBackColor = true;
            this.searchClientBtn.Click += new System.EventHandler(this.searchClientBtn_Click);
            // 
            // SalesManagerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 727);
            this.Controls.Add(this.cancelSearch);
            this.Controls.Add(this.searchClient);
            this.Controls.Add(this.noLabel);
            this.Controls.Add(this.searchClientBtn);
            this.Controls.Add(this.addClient);
            this.Controls.Add(this.section);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.clientsView);
            this.Name = "SalesManagerDashboard";
            this.Text = "SalesManagerDashboard";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clientsView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelSearch;
        private System.Windows.Forms.TextBox searchClient;
        private System.Windows.Forms.Label noLabel;
        private System.Windows.Forms.Button addClient;
        private System.Windows.Forms.Label section;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button client;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView clientsView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn street;
        private System.Windows.Forms.DataGridViewTextBoxColumn city;
        private System.Windows.Forms.DataGridViewTextBoxColumn postal_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn fax_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn credit_limit;
        private System.Windows.Forms.Button searchClientBtn;
    }
}