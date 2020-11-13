using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookBizz.Components
{
    public partial class AddClient : Form

    { 
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\14383\Downloads\BookBizz\BookBizz\Database1.mdf;Integrated Security=True";
        string userId;
        public AddClient(string userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = clientName.Text;
            string street = clientStreet.Text;
            string city = clientCity.Text;
            string postal = clientPostal.Text;
            string number = clientNumber.Text;
            string faxNumber = clientFaxNumber.Text;
            string creditLimit = clientCreditLimit.Text;

            if (number.Length < 10)
            {
                error.Visible = true;
                errorCont.Visible = true;
                error.Text = "Phone number is not valid";
            }
            else if (faxNumber.Length < 10)
            {
                error.Visible = true;
                errorCont.Visible = true;
                error.Text = "Fax Number is not valid";
            }
            else
            {
                error.Visible = false;
                errorCont.Visible = false;
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "INSERT INTO ClientTable VALUES " +
                        "('" + name + "', '" + street + "', '" + city + "', '" + postal + "', '" + number + "', '" + faxNumber + "', '" + creditLimit + "', '" + userId + "');";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteReader();
                    this.Hide();
                    SalesManagerDashboard dashboard = new SalesManagerDashboard(userId.ToString());
                    dashboard.Show();
                }
            }
        }
    }
}
