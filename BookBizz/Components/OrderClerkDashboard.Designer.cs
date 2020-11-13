namespace BookBizz.Components
{
    partial class OrderClerkDashboard
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
            this.searchOrder = new System.Windows.Forms.TextBox();
            this.noLabel = new System.Windows.Forms.Label();
            this.searchOrderBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logout = new System.Windows.Forms.Button();
            this.client = new System.Windows.Forms.Button();
            this.addClient = new System.Windows.Forms.Button();
            this.section = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ordersView = new System.Windows.Forms.DataGridView();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderPayment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersView)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelSearch
            // 
            this.cancelSearch.Location = new System.Drawing.Point(520, 154);
            this.cancelSearch.Name = "cancelSearch";
            this.cancelSearch.Size = new System.Drawing.Size(75, 28);
            this.cancelSearch.TabIndex = 34;
            this.cancelSearch.Text = "Cancel";
            this.cancelSearch.UseVisualStyleBackColor = true;
            this.cancelSearch.Visible = false;
            this.cancelSearch.Click += new System.EventHandler(this.cancelSearch_Click);
            // 
            // searchOrder
            // 
            this.searchOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchOrder.Location = new System.Drawing.Point(16, 154);
            this.searchOrder.Name = "searchOrder";
            this.searchOrder.Size = new System.Drawing.Size(429, 28);
            this.searchOrder.TabIndex = 33;
            // 
            // noLabel
            // 
            this.noLabel.AutoSize = true;
            this.noLabel.BackColor = System.Drawing.Color.SteelBlue;
            this.noLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noLabel.ForeColor = System.Drawing.Color.White;
            this.noLabel.Location = new System.Drawing.Point(302, 457);
            this.noLabel.Name = "noLabel";
            this.noLabel.Size = new System.Drawing.Size(466, 46);
            this.noLabel.TabIndex = 32;
            this.noLabel.Text = "There is nothing to show!";
            // 
            // searchOrderBtn
            // 
            this.searchOrderBtn.Location = new System.Drawing.Point(444, 154);
            this.searchOrderBtn.Name = "searchOrderBtn";
            this.searchOrderBtn.Size = new System.Drawing.Size(75, 28);
            this.searchOrderBtn.TabIndex = 35;
            this.searchOrderBtn.Text = "Search";
            this.searchOrderBtn.UseVisualStyleBackColor = true;
            this.searchOrderBtn.Click += new System.EventHandler(this.searchOrderBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.logout);
            this.panel1.Controls.Add(this.client);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 62);
            this.panel1.TabIndex = 27;
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
            this.client.Text = "Orders";
            this.client.UseVisualStyleBackColor = false;
            // 
            // addClient
            // 
            this.addClient.BackColor = System.Drawing.Color.SteelBlue;
            this.addClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addClient.ForeColor = System.Drawing.Color.White;
            this.addClient.Location = new System.Drawing.Point(818, 74);
            this.addClient.Name = "addClient";
            this.addClient.Size = new System.Drawing.Size(179, 41);
            this.addClient.TabIndex = 30;
            this.addClient.Text = "Add Order";
            this.addClient.UseVisualStyleBackColor = false;
            this.addClient.Click += new System.EventHandler(this.addClient_Click);
            // 
            // section
            // 
            this.section.AutoSize = true;
            this.section.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.section.Location = new System.Drawing.Point(11, 84);
            this.section.Name = "section";
            this.section.Size = new System.Drawing.Size(72, 25);
            this.section.TabIndex = 29;
            this.section.Text = "Orders";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Location = new System.Drawing.Point(-1, 121);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1010, 10);
            this.panel2.TabIndex = 28;
            // 
            // ordersView
            // 
            this.ordersView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.ordersView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.delete,
            this.ID,
            this.clientId,
            this.bookId,
            this.qty,
            this.orderPayment});
            this.ordersView.Location = new System.Drawing.Point(16, 208);
            this.ordersView.Name = "ordersView";
            this.ordersView.RowHeadersWidth = 51;
            this.ordersView.RowTemplate.Height = 24;
            this.ordersView.Size = new System.Drawing.Size(981, 490);
            this.ordersView.TabIndex = 31;
            this.ordersView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ordersView_CellContentClick);
            // 
            // delete
            // 
            this.delete.HeaderText = "Delete";
            this.delete.MinimumWidth = 6;
            this.delete.Name = "delete";
            this.delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.delete.Text = "Delete";
            this.delete.ToolTipText = "Delete";
            this.delete.UseColumnTextForButtonValue = true;
            this.delete.Width = 150;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "Id";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 125;
            // 
            // clientId
            // 
            this.clientId.DataPropertyName = "name";
            this.clientId.HeaderText = "ClientId";
            this.clientId.MinimumWidth = 6;
            this.clientId.Name = "clientId";
            this.clientId.Width = 150;
            // 
            // bookId
            // 
            this.bookId.DataPropertyName = "title";
            this.bookId.HeaderText = "BookId";
            this.bookId.MinimumWidth = 6;
            this.bookId.Name = "bookId";
            this.bookId.Width = 150;
            // 
            // qty
            // 
            this.qty.DataPropertyName = "qty";
            this.qty.HeaderText = "Quantity";
            this.qty.MinimumWidth = 6;
            this.qty.Name = "qty";
            this.qty.Width = 150;
            // 
            // orderPayment
            // 
            this.orderPayment.DataPropertyName = "orderPayment";
            this.orderPayment.HeaderText = "Order Payment";
            this.orderPayment.MinimumWidth = 6;
            this.orderPayment.Name = "orderPayment";
            this.orderPayment.Width = 150;
            // 
            // OrderClerkDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 686);
            this.Controls.Add(this.cancelSearch);
            this.Controls.Add(this.searchOrder);
            this.Controls.Add(this.noLabel);
            this.Controls.Add(this.searchOrderBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.addClient);
            this.Controls.Add(this.section);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ordersView);
            this.Name = "OrderClerkDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderClerkDashboard";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ordersView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelSearch;
        private System.Windows.Forms.TextBox searchOrder;
        private System.Windows.Forms.Label noLabel;
        private System.Windows.Forms.Button searchOrderBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button client;
        private System.Windows.Forms.Button addClient;
        private System.Windows.Forms.Label section;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView ordersView;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientId;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookId;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderPayment;
    }
}