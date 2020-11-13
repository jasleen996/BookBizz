namespace BookBizz.Components
{
    partial class AddBook
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
            this.label1 = new System.Windows.Forms.Label();
            this.createBook = new System.Windows.Forms.Button();
            this.bookUnitPrice = new System.Windows.Forms.TextBox();
            this.unitPrice = new System.Windows.Forms.Label();
            this.bookTitle = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.Label();
            this.bookIsbn = new System.Windows.Forms.TextBox();
            this.isbn = new System.Windows.Forms.Label();
            this.qoh = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bookYear = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.authors = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(873, 74);
            this.panel1.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(346, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 44);
            this.label1.TabIndex = 6;
            this.label1.Text = "New Book";
            // 
            // createBook
            // 
            this.createBook.BackColor = System.Drawing.Color.SteelBlue;
            this.createBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createBook.ForeColor = System.Drawing.Color.White;
            this.createBook.Location = new System.Drawing.Point(479, 664);
            this.createBook.Name = "createBook";
            this.createBook.Size = new System.Drawing.Size(197, 45);
            this.createBook.TabIndex = 59;
            this.createBook.Text = "Create Book";
            this.createBook.UseVisualStyleBackColor = false;
            this.createBook.Click += new System.EventHandler(this.createBook_Click);
            // 
            // bookUnitPrice
            // 
            this.bookUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookUnitPrice.Location = new System.Drawing.Point(390, 432);
            this.bookUnitPrice.Name = "bookUnitPrice";
            this.bookUnitPrice.Size = new System.Drawing.Size(353, 34);
            this.bookUnitPrice.TabIndex = 58;
            // 
            // unitPrice
            // 
            this.unitPrice.AutoSize = true;
            this.unitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitPrice.ForeColor = System.Drawing.Color.SteelBlue;
            this.unitPrice.Location = new System.Drawing.Point(155, 435);
            this.unitPrice.Name = "unitPrice";
            this.unitPrice.Size = new System.Drawing.Size(127, 29);
            this.unitPrice.TabIndex = 57;
            this.unitPrice.Text = "Unit Price";
            // 
            // bookTitle
            // 
            this.bookTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookTitle.Location = new System.Drawing.Point(390, 355);
            this.bookTitle.Name = "bookTitle";
            this.bookTitle.Size = new System.Drawing.Size(353, 34);
            this.bookTitle.TabIndex = 56;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.SteelBlue;
            this.title.Location = new System.Drawing.Point(155, 358);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(66, 29);
            this.title.TabIndex = 55;
            this.title.Text = "Title";
            // 
            // bookIsbn
            // 
            this.bookIsbn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookIsbn.Location = new System.Drawing.Point(390, 289);
            this.bookIsbn.Name = "bookIsbn";
            this.bookIsbn.Size = new System.Drawing.Size(353, 34);
            this.bookIsbn.TabIndex = 54;
            // 
            // isbn
            // 
            this.isbn.AutoSize = true;
            this.isbn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isbn.ForeColor = System.Drawing.Color.SteelBlue;
            this.isbn.Location = new System.Drawing.Point(155, 292);
            this.isbn.Name = "isbn";
            this.isbn.Size = new System.Drawing.Size(73, 29);
            this.isbn.TabIndex = 53;
            this.isbn.Text = "ISBN";
            // 
            // qoh
            // 
            this.qoh.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qoh.Location = new System.Drawing.Point(390, 594);
            this.qoh.Name = "qoh";
            this.qoh.Size = new System.Drawing.Size(353, 34);
            this.qoh.TabIndex = 64;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(155, 597);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 29);
            this.label3.TabIndex = 63;
            this.label3.Text = "Qoh";
            // 
            // bookYear
            // 
            this.bookYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookYear.Location = new System.Drawing.Point(390, 517);
            this.bookYear.Name = "bookYear";
            this.bookYear.Size = new System.Drawing.Size(353, 34);
            this.bookYear.TabIndex = 62;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SteelBlue;
            this.label5.Location = new System.Drawing.Point(155, 520);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 29);
            this.label5.TabIndex = 61;
            this.label5.Text = "Year Published";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(142, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 29);
            this.label2.TabIndex = 65;
            this.label2.Text = "Select Authors";
            // 
            // authors
            // 
            this.authors.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authors.FormattingEnabled = true;
            this.authors.ItemHeight = 20;
            this.authors.Location = new System.Drawing.Point(390, 86);
            this.authors.Name = "authors";
            this.authors.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.authors.Size = new System.Drawing.Size(254, 144);
            this.authors.TabIndex = 66;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Location = new System.Drawing.Point(0, 247);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(869, 11);
            this.panel2.TabIndex = 67;
            // 
            // AddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 718);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.authors);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.qoh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bookYear);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.createBook);
            this.Controls.Add(this.bookUnitPrice);
            this.Controls.Add(this.unitPrice);
            this.Controls.Add(this.bookTitle);
            this.Controls.Add(this.title);
            this.Controls.Add(this.bookIsbn);
            this.Controls.Add(this.isbn);
            this.Name = "AddBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddBook";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button createBook;
        private System.Windows.Forms.TextBox bookUnitPrice;
        private System.Windows.Forms.Label unitPrice;
        private System.Windows.Forms.TextBox bookTitle;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.TextBox bookIsbn;
        private System.Windows.Forms.Label isbn;
        private System.Windows.Forms.TextBox qoh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox bookYear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox authors;
        private System.Windows.Forms.Panel panel2;
    }
}