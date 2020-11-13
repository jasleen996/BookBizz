using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net.Sockets;
using System.Text.RegularExpressions;

namespace BookBizz.Components
{
    public partial class AddUser : Form
    {
        public AddUser()
        { 
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\14383\Downloads\BookBizz\BookBizz\Database1.mdf;Integrated Security=True";
            string fName = firstname.Text;
            string lName = lastname.Text;
            string number = phone.Text;
            string mail = email.Text;
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(mail);

            if (number.Length < 10)
            {
                error.Visible = true;
                errorCont.Visible = true;
                error.Text = "Phone number is not valid";
            }
            else if (!match.Success)
            {
                error.Visible = true;
                errorCont.Visible = true;
                error.Text = "Email is not valid";
            }
            else
            {
                error.Visible = false;
                errorCont.Visible = false;
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "INSERT INTO UserTable VALUES " +
                        "('" + fName + "', '" + lName + "', " + number + ", '" + mail + "', 0)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteReader();
                    this.Hide();
                    AdminDashboard dashboard = new AdminDashboard();
                    dashboard.Show();
                }
            }
        }
    }
}
