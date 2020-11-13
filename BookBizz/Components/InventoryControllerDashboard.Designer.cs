namespace BookBizz.Components
{
    partial class InventoryControllerDashboard
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
            this.authorCancelSearch = new System.Windows.Forms.Button();
            this.authorSearch = new System.Windows.Forms.TextBox();
            this.bookSearchCancel = new System.Windows.Forms.Button();
            this.authorSearchBtn = new System.Windows.Forms.Button();
            this.bookSearch = new System.Windows.Forms.TextBox();
            this.noLabel = new System.Windows.Forms.Label();
            this.bookSearchBtn = new System.Windows.Forms.Button();
            this.addAuthor = new System.Windows.Forms.Button();
            this.section = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.logout = new System.Windows.Forms.Button();
            this.book = new System.Windows.Forms.Button();
            this.author = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.authorsView = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.first_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.last_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addBook = new System.Windows.Forms.Button();
            this.booksView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isbn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearPublished = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qoh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.authorsView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksView)).BeginInit();
            this.SuspendLayout();
            // 
            // authorCancelSearch
            // 
            this.authorCancelSearch.Location = new System.Drawing.Point(521, 149);
            this.authorCancelSearch.Name = "authorCancelSearch";
            this.authorCancelSearch.Size = new System.Drawing.Size(75, 28);
            this.authorCancelSearch.TabIndex = 27;
            this.authorCancelSearch.Text = "Cancel";
            this.authorCancelSearch.UseVisualStyleBackColor = true;
            this.authorCancelSearch.Visible = false;
            this.authorCancelSearch.Click += new System.EventHandler(this.authorCancelSearch_Click);
            // 
            // authorSearch
            // 
            this.authorSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorSearch.Location = new System.Drawing.Point(17, 148);
            this.authorSearch.Name = "authorSearch";
            this.authorSearch.Size = new System.Drawing.Size(429, 28);
            this.authorSearch.TabIndex = 25;
            // 
            // bookSearchCancel
            // 
            this.bookSearchCancel.Location = new System.Drawing.Point(521, 148);
            this.bookSearchCancel.Name = "bookSearchCancel";
            this.bookSearchCancel.Size = new System.Drawing.Size(75, 28);
            this.bookSearchCancel.TabIndex = 24;
            this.bookSearchCancel.Text = "Cancel";
            this.bookSearchCancel.UseVisualStyleBackColor = true;
            this.bookSearchCancel.Visible = false;
            this.bookSearchCancel.Click += new System.EventHandler(this.bookSearchCancel_Click);
            // 
            // authorSearchBtn
            // 
            this.authorSearchBtn.Location = new System.Drawing.Point(445, 149);
            this.authorSearchBtn.Name = "authorSearchBtn";
            this.authorSearchBtn.Size = new System.Drawing.Size(75, 28);
            this.authorSearchBtn.TabIndex = 23;
            this.authorSearchBtn.Text = "Search";
            this.authorSearchBtn.UseVisualStyleBackColor = true;
            this.authorSearchBtn.Click += new System.EventHandler(this.authorSearchBtn_Click);
            // 
            // bookSearch
            // 
            this.bookSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookSearch.Location = new System.Drawing.Point(17, 148);
            this.bookSearch.Name = "bookSearch";
            this.bookSearch.Size = new System.Drawing.Size(429, 28);
            this.bookSearch.TabIndex = 22;
            this.bookSearch.Visible = false;
            // 
            // noLabel
            // 
            this.noLabel.AutoSize = true;
            this.noLabel.BackColor = System.Drawing.Color.SteelBlue;
            this.noLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noLabel.ForeColor = System.Drawing.Color.White;
            this.noLabel.Location = new System.Drawing.Point(303, 451);
            this.noLabel.Name = "noLabel";
            this.noLabel.Size = new System.Drawing.Size(466, 46);
            this.noLabel.TabIndex = 20;
            this.noLabel.Text = "There is nothing to show!";
            // 
            // bookSearchBtn
            // 
            this.bookSearchBtn.Location = new System.Drawing.Point(445, 148);
            this.bookSearchBtn.Name = "bookSearchBtn";
            this.bookSearchBtn.Size = new System.Drawing.Size(75, 28);
            this.bookSearchBtn.TabIndex = 26;
            this.bookSearchBtn.Text = "Search";
            this.bookSearchBtn.UseVisualStyleBackColor = true;
            this.bookSearchBtn.Visible = false;
            this.bookSearchBtn.Click += new System.EventHandler(this.bookSearchBtn_Click);
            // 
            // addAuthor
            // 
            this.addAuthor.BackColor = System.Drawing.Color.SteelBlue;
            this.addAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAuthor.ForeColor = System.Drawing.Color.White;
            this.addAuthor.Location = new System.Drawing.Point(819, 68);
            this.addAuthor.Name = "addAuthor";
            this.addAuthor.Size = new System.Drawing.Size(179, 41);
            this.addAuthor.TabIndex = 18;
            this.addAuthor.Text = "Add Author";
            this.addAuthor.UseVisualStyleBackColor = false;
            this.addAuthor.Click += new System.EventHandler(this.addAuthor_Click);
            // 
            // section
            // 
            this.section.AutoSize = true;
            this.section.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.section.Location = new System.Drawing.Point(12, 78);
            this.section.Name = "section";
            this.section.Size = new System.Drawing.Size(80, 25);
            this.section.TabIndex = 17;
            this.section.Text = "Authors";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Location = new System.Drawing.Point(0, 115);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1010, 10);
            this.panel2.TabIndex = 16;
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
            // book
            // 
            this.book.BackColor = System.Drawing.Color.SteelBlue;
            this.book.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.book.ForeColor = System.Drawing.Color.White;
            this.book.Location = new System.Drawing.Point(175, 8);
            this.book.Name = "book";
            this.book.Size = new System.Drawing.Size(136, 45);
            this.book.TabIndex = 3;
            this.book.Text = "Books";
            this.book.UseVisualStyleBackColor = false;
            this.book.Click += new System.EventHandler(this.book_Click);
            // 
            // author
            // 
            this.author.BackColor = System.Drawing.Color.White;
            this.author.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.author.ForeColor = System.Drawing.Color.SteelBlue;
            this.author.Location = new System.Drawing.Point(12, 8);
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(136, 45);
            this.author.TabIndex = 0;
            this.author.Text = "Authors";
            this.author.UseVisualStyleBackColor = false;
            this.author.Click += new System.EventHandler(this.author_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.logout);
            this.panel1.Controls.Add(this.book);
            this.panel1.Controls.Add(this.author);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1026, 62);
            this.panel1.TabIndex = 15;
            // 
            // authorsView
            // 
            this.authorsView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.authorsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.authorsView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.first_name,
            this.last_name,
            this.email});
            this.authorsView.Location = new System.Drawing.Point(17, 196);
            this.authorsView.Name = "authorsView";
            this.authorsView.RowHeadersWidth = 51;
            this.authorsView.RowTemplate.Height = 24;
            this.authorsView.Size = new System.Drawing.Size(981, 490);
            this.authorsView.TabIndex = 19;
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
            this.first_name.Width = 270;
            // 
            // last_name
            // 
            this.last_name.DataPropertyName = "last_name";
            this.last_name.HeaderText = "Last Name";
            this.last_name.MinimumWidth = 6;
            this.last_name.Name = "last_name";
            this.last_name.Width = 270;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Email";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            this.email.Width = 270;
            // 
            // addBook
            // 
            this.addBook.BackColor = System.Drawing.Color.SteelBlue;
            this.addBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBook.ForeColor = System.Drawing.Color.White;
            this.addBook.Location = new System.Drawing.Point(819, 68);
            this.addBook.Name = "addBook";
            this.addBook.Size = new System.Drawing.Size(179, 41);
            this.addBook.TabIndex = 28;
            this.addBook.Text = "Add Book";
            this.addBook.UseVisualStyleBackColor = false;
            this.addBook.Click += new System.EventHandler(this.addBook_Click);
            // 
            // booksView
            // 
            this.booksView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.booksView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.booksView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.isbn,
            this.title,
            this.unitPrice,
            this.yearPublished,
            this.qoh});
            this.booksView.Location = new System.Drawing.Point(17, 196);
            this.booksView.Name = "booksView";
            this.booksView.RowHeadersWidth = 51;
            this.booksView.RowTemplate.Height = 24;
            this.booksView.Size = new System.Drawing.Size(981, 490);
            this.booksView.TabIndex = 29;
            this.booksView.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // isbn
            // 
            this.isbn.DataPropertyName = "isbn";
            this.isbn.HeaderText = "ISBN";
            this.isbn.MinimumWidth = 6;
            this.isbn.Name = "isbn";
            this.isbn.Width = 125;
            // 
            // title
            // 
            this.title.DataPropertyName = "title";
            this.title.HeaderText = "Title";
            this.title.MinimumWidth = 6;
            this.title.Name = "title";
            this.title.Width = 200;
            // 
            // unitPrice
            // 
            this.unitPrice.DataPropertyName = "unitPrice";
            this.unitPrice.HeaderText = "Unit Price";
            this.unitPrice.MinimumWidth = 6;
            this.unitPrice.Name = "unitPrice";
            this.unitPrice.Width = 150;
            // 
            // yearPublished
            // 
            this.yearPublished.DataPropertyName = "yearPublished";
            this.yearPublished.HeaderText = "Year Published";
            this.yearPublished.MinimumWidth = 6;
            this.yearPublished.Name = "yearPublished";
            this.yearPublished.Width = 200;
            // 
            // qoh
            // 
            this.qoh.DataPropertyName = "qoh";
            this.qoh.HeaderText = "Quantity On Hand";
            this.qoh.MinimumWidth = 6;
            this.qoh.Name = "qoh";
            this.qoh.Width = 200;
            // 
            // InventoryControllerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 692);
            this.Controls.Add(this.booksView);
            this.Controls.Add(this.addBook);
            this.Controls.Add(this.authorCancelSearch);
            this.Controls.Add(this.authorSearch);
            this.Controls.Add(this.bookSearchCancel);
            this.Controls.Add(this.authorSearchBtn);
            this.Controls.Add(this.bookSearch);
            this.Controls.Add(this.noLabel);
            this.Controls.Add(this.bookSearchBtn);
            this.Controls.Add(this.addAuthor);
            this.Controls.Add(this.section);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.authorsView);
            this.Name = "InventoryControllerDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InventoryControllerDashboard";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.authorsView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button authorCancelSearch;
        private System.Windows.Forms.TextBox authorSearch;
        private System.Windows.Forms.Button bookSearchCancel;
        private System.Windows.Forms.Button authorSearchBtn;
        private System.Windows.Forms.TextBox bookSearch;
        private System.Windows.Forms.Label noLabel;
        private System.Windows.Forms.Button bookSearchBtn;
        private System.Windows.Forms.Button addAuthor;
        private System.Windows.Forms.Label section;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button book;
        private System.Windows.Forms.Button author;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView authorsView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn first_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn last_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.Button addBook;
        private System.Windows.Forms.DataGridView booksView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn isbn;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearPublished;
        private System.Windows.Forms.DataGridViewTextBoxColumn qoh;
    }
}