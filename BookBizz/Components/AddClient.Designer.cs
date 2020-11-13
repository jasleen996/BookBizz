namespace BookBizz.Components
{
    partial class AddClient
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
            this.errorCont = new System.Windows.Forms.Panel();
            this.error = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.clientPostal = new System.Windows.Forms.TextBox();
            this.postal_code = new System.Windows.Forms.Label();
            this.clientCity = new System.Windows.Forms.TextBox();
            this.city = new System.Windows.Forms.Label();
            this.clientStreet = new System.Windows.Forms.TextBox();
            this.street = new System.Windows.Forms.Label();
            this.clientName = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.clientCreditLimit = new System.Windows.Forms.TextBox();
            this.credit_limit = new System.Windows.Forms.Label();
            this.clientFaxNumber = new System.Windows.Forms.TextBox();
            this.fax_number = new System.Windows.Forms.Label();
            this.clientNumber = new System.Windows.Forms.TextBox();
            this.phone_nummber = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.errorCont.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(814, 74);
            this.panel1.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(363, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 44);
            this.label1.TabIndex = 6;
            this.label1.Text = "New Client";
            // 
            // errorCont
            // 
            this.errorCont.Controls.Add(this.error);
            this.errorCont.Location = new System.Drawing.Point(28, 653);
            this.errorCont.Name = "errorCont";
            this.errorCont.Size = new System.Drawing.Size(337, 62);
            this.errorCont.TabIndex = 51;
            this.errorCont.Visible = false;
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error.ForeColor = System.Drawing.Color.Red;
            this.error.Location = new System.Drawing.Point(35, 21);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(202, 20);
            this.error.TabIndex = 0;
            this.error.Text = "Phone number is not valid";
            this.error.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(501, 653);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 45);
            this.button1.TabIndex = 50;
            this.button1.Text = "Create Client";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // clientPostal
            // 
            this.clientPostal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientPostal.Location = new System.Drawing.Point(386, 325);
            this.clientPostal.Name = "clientPostal";
            this.clientPostal.Size = new System.Drawing.Size(353, 34);
            this.clientPostal.TabIndex = 49;
            // 
            // postal_code
            // 
            this.postal_code.AutoSize = true;
            this.postal_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postal_code.ForeColor = System.Drawing.Color.SteelBlue;
            this.postal_code.Location = new System.Drawing.Point(151, 328);
            this.postal_code.Name = "postal_code";
            this.postal_code.Size = new System.Drawing.Size(156, 29);
            this.postal_code.TabIndex = 48;
            this.postal_code.Text = "Postal Code";
            // 
            // clientCity
            // 
            this.clientCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientCity.Location = new System.Drawing.Point(386, 249);
            this.clientCity.Name = "clientCity";
            this.clientCity.Size = new System.Drawing.Size(353, 34);
            this.clientCity.TabIndex = 47;
            // 
            // city
            // 
            this.city.AutoSize = true;
            this.city.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.city.ForeColor = System.Drawing.Color.SteelBlue;
            this.city.Location = new System.Drawing.Point(151, 252);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(57, 29);
            this.city.TabIndex = 46;
            this.city.Text = "City";
            // 
            // clientStreet
            // 
            this.clientStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientStreet.Location = new System.Drawing.Point(386, 180);
            this.clientStreet.Name = "clientStreet";
            this.clientStreet.Size = new System.Drawing.Size(353, 34);
            this.clientStreet.TabIndex = 45;
            // 
            // street
            // 
            this.street.AutoSize = true;
            this.street.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.street.ForeColor = System.Drawing.Color.SteelBlue;
            this.street.Location = new System.Drawing.Point(151, 183);
            this.street.Name = "street";
            this.street.Size = new System.Drawing.Size(83, 29);
            this.street.TabIndex = 44;
            this.street.Text = "Street";
            // 
            // clientName
            // 
            this.clientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientName.Location = new System.Drawing.Point(386, 114);
            this.clientName.Name = "clientName";
            this.clientName.Size = new System.Drawing.Size(353, 34);
            this.clientName.TabIndex = 43;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.Color.SteelBlue;
            this.name.Location = new System.Drawing.Point(151, 117);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(82, 29);
            this.name.TabIndex = 42;
            this.name.Text = "Name";
            // 
            // clientCreditLimit
            // 
            this.clientCreditLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientCreditLimit.Location = new System.Drawing.Point(386, 544);
            this.clientCreditLimit.Name = "clientCreditLimit";
            this.clientCreditLimit.Size = new System.Drawing.Size(353, 34);
            this.clientCreditLimit.TabIndex = 57;
            // 
            // credit_limit
            // 
            this.credit_limit.AutoSize = true;
            this.credit_limit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.credit_limit.ForeColor = System.Drawing.Color.SteelBlue;
            this.credit_limit.Location = new System.Drawing.Point(151, 547);
            this.credit_limit.Name = "credit_limit";
            this.credit_limit.Size = new System.Drawing.Size(147, 29);
            this.credit_limit.TabIndex = 56;
            this.credit_limit.Text = "Credit Limit";
            // 
            // clientFaxNumber
            // 
            this.clientFaxNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientFaxNumber.Location = new System.Drawing.Point(386, 468);
            this.clientFaxNumber.Name = "clientFaxNumber";
            this.clientFaxNumber.Size = new System.Drawing.Size(353, 34);
            this.clientFaxNumber.TabIndex = 55;
            // 
            // fax_number
            // 
            this.fax_number.AutoSize = true;
            this.fax_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fax_number.ForeColor = System.Drawing.Color.SteelBlue;
            this.fax_number.Location = new System.Drawing.Point(151, 471);
            this.fax_number.Name = "fax_number";
            this.fax_number.Size = new System.Drawing.Size(155, 29);
            this.fax_number.TabIndex = 54;
            this.fax_number.Text = "Fax Number";
            // 
            // clientNumber
            // 
            this.clientNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientNumber.Location = new System.Drawing.Point(386, 399);
            this.clientNumber.Name = "clientNumber";
            this.clientNumber.Size = new System.Drawing.Size(353, 34);
            this.clientNumber.TabIndex = 53;
            // 
            // phone_nummber
            // 
            this.phone_nummber.AutoSize = true;
            this.phone_nummber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone_nummber.ForeColor = System.Drawing.Color.SteelBlue;
            this.phone_nummber.Location = new System.Drawing.Point(151, 402);
            this.phone_nummber.Name = "phone_nummber";
            this.phone_nummber.Size = new System.Drawing.Size(188, 29);
            this.phone_nummber.TabIndex = 52;
            this.phone_nummber.Text = "Phone Number";
            // 
            // AddClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 743);
            this.Controls.Add(this.clientCreditLimit);
            this.Controls.Add(this.credit_limit);
            this.Controls.Add(this.clientFaxNumber);
            this.Controls.Add(this.fax_number);
            this.Controls.Add(this.clientNumber);
            this.Controls.Add(this.phone_nummber);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.errorCont);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.clientPostal);
            this.Controls.Add(this.postal_code);
            this.Controls.Add(this.clientCity);
            this.Controls.Add(this.city);
            this.Controls.Add(this.clientStreet);
            this.Controls.Add(this.street);
            this.Controls.Add(this.clientName);
            this.Controls.Add(this.name);
            this.Name = "AddClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddClient";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.errorCont.ResumeLayout(false);
            this.errorCont.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel errorCont;
        private System.Windows.Forms.Label error;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox clientPostal;
        private System.Windows.Forms.Label postal_code;
        private System.Windows.Forms.TextBox clientCity;
        private System.Windows.Forms.Label city;
        private System.Windows.Forms.TextBox clientStreet;
        private System.Windows.Forms.Label street;
        private System.Windows.Forms.TextBox clientName;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox clientCreditLimit;
        private System.Windows.Forms.Label credit_limit;
        private System.Windows.Forms.TextBox clientFaxNumber;
        private System.Windows.Forms.Label fax_number;
        private System.Windows.Forms.TextBox clientNumber;
        private System.Windows.Forms.Label phone_nummber;
    }
}