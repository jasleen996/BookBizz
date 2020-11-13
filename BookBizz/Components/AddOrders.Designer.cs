namespace BookBizz.Components
{
    partial class AddOrders
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
            this.button1 = new System.Windows.Forms.Button();
            this.qty = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.books = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.clients = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lab2 = new System.Windows.Forms.Label();
            this.lab1 = new System.Windows.Forms.Label();
            this.lab3 = new System.Windows.Forms.Label();
            this.unitPrice = new System.Windows.Forms.Label();
            this.avlStock = new System.Windows.Forms.Label();
            this.orderPayment = new System.Windows.Forms.Label();
            this.orderErrorCont = new System.Windows.Forms.Panel();
            this.orderError = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.orderErrorCont.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(411, 550);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 45);
            this.button1.TabIndex = 68;
            this.button1.Text = "Add Order";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // qty
            // 
            this.qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qty.Location = new System.Drawing.Point(325, 409);
            this.qty.Name = "qty";
            this.qty.Size = new System.Drawing.Size(353, 34);
            this.qty.TabIndex = 65;
            this.qty.Leave += new System.EventHandler(this.qty_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.SteelBlue;
            this.label6.Location = new System.Drawing.Point(90, 412);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 29);
            this.label6.TabIndex = 64;
            this.label6.Text = "Quantity";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(867, 74);
            this.panel1.TabIndex = 63;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(315, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 44);
            this.label1.TabIndex = 6;
            this.label1.Text = "New Order";
            // 
            // books
            // 
            this.books.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.books.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.books.FormattingEnabled = true;
            this.books.Location = new System.Drawing.Point(325, 294);
            this.books.Name = "books";
            this.books.Size = new System.Drawing.Size(353, 37);
            this.books.TabIndex = 72;
            this.books.SelectedIndexChanged += new System.EventHandler(this.books_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(90, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 29);
            this.label2.TabIndex = 71;
            this.label2.Text = "Select Client";
            // 
            // clients
            // 
            this.clients.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clients.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clients.FormattingEnabled = true;
            this.clients.Items.AddRange(new object[] {
            "Select User"});
            this.clients.Location = new System.Drawing.Point(325, 224);
            this.clients.Name = "clients";
            this.clients.Size = new System.Drawing.Size(353, 37);
            this.clients.TabIndex = 70;
            this.clients.SelectedIndexChanged += new System.EventHandler(this.clients_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.SteelBlue;
            this.label8.Location = new System.Drawing.Point(90, 297);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 29);
            this.label8.TabIndex = 69;
            this.label8.Text = "Select Book";
            // 
            // lab2
            // 
            this.lab2.AutoSize = true;
            this.lab2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab2.Location = new System.Drawing.Point(473, 351);
            this.lab2.Name = "lab2";
            this.lab2.Size = new System.Drawing.Size(158, 25);
            this.lab2.TabIndex = 73;
            this.lab2.Text = "Available Stock: ";
            // 
            // lab1
            // 
            this.lab1.AutoSize = true;
            this.lab1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab1.Location = new System.Drawing.Point(334, 351);
            this.lab1.Name = "lab1";
            this.lab1.Size = new System.Drawing.Size(106, 25);
            this.lab1.TabIndex = 74;
            this.lab1.Text = "Unit Price: ";
            // 
            // lab3
            // 
            this.lab3.AutoSize = true;
            this.lab3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab3.Location = new System.Drawing.Point(473, 457);
            this.lab3.Name = "lab3";
            this.lab3.Size = new System.Drawing.Size(140, 25);
            this.lab3.TabIndex = 75;
            this.lab3.Text = "Total Amount: ";
            // 
            // unitPrice
            // 
            this.unitPrice.AutoSize = true;
            this.unitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitPrice.Location = new System.Drawing.Point(431, 351);
            this.unitPrice.Name = "unitPrice";
            this.unitPrice.Size = new System.Drawing.Size(23, 25);
            this.unitPrice.TabIndex = 77;
            this.unitPrice.Text = "0";
            // 
            // avlStock
            // 
            this.avlStock.AutoSize = true;
            this.avlStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avlStock.Location = new System.Drawing.Point(625, 351);
            this.avlStock.Name = "avlStock";
            this.avlStock.Size = new System.Drawing.Size(23, 25);
            this.avlStock.TabIndex = 78;
            this.avlStock.Text = "0";
            // 
            // orderPayment
            // 
            this.orderPayment.AutoSize = true;
            this.orderPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderPayment.Location = new System.Drawing.Point(608, 457);
            this.orderPayment.Name = "orderPayment";
            this.orderPayment.Size = new System.Drawing.Size(23, 25);
            this.orderPayment.TabIndex = 79;
            this.orderPayment.Text = "0";
            // 
            // orderErrorCont
            // 
            this.orderErrorCont.Controls.Add(this.orderError);
            this.orderErrorCont.Location = new System.Drawing.Point(24, 614);
            this.orderErrorCont.Name = "orderErrorCont";
            this.orderErrorCont.Size = new System.Drawing.Size(439, 51);
            this.orderErrorCont.TabIndex = 80;
            // 
            // orderError
            // 
            this.orderError.AutoSize = true;
            this.orderError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderError.ForeColor = System.Drawing.Color.Red;
            this.orderError.Location = new System.Drawing.Point(18, 16);
            this.orderError.Name = "orderError";
            this.orderError.Size = new System.Drawing.Size(347, 20);
            this.orderError.TabIndex = 0;
            this.orderError.Text = "Order Quantity is greater than available stock";
            // 
            // AddOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 677);
            this.Controls.Add(this.orderErrorCont);
            this.Controls.Add(this.orderPayment);
            this.Controls.Add(this.avlStock);
            this.Controls.Add(this.unitPrice);
            this.Controls.Add(this.lab3);
            this.Controls.Add(this.lab1);
            this.Controls.Add(this.lab2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.qty);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.books);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.clients);
            this.Controls.Add(this.label8);
            this.Name = "AddOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddOrders";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.orderErrorCont.ResumeLayout(false);
            this.orderErrorCont.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox qty;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox books;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox clients;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lab2;
        private System.Windows.Forms.Label lab1;
        private System.Windows.Forms.Label lab3;
        private System.Windows.Forms.Label unitPrice;
        private System.Windows.Forms.Label avlStock;
        private System.Windows.Forms.Label orderPayment;
        private System.Windows.Forms.Panel orderErrorCont;
        private System.Windows.Forms.Label orderError;
    }
}