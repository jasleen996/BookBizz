using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookBizz.Components
{
    public partial class AddAuthor : Form
    {
        public AddAuthor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\14383\Downloads\BookBizz\BookBizz\Database1.mdf;Integrated Security=True";
            string fname = firstname.Text;
            string lname = lastname.Text;
            string mail = email.Text;
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(mail);

            if (!match.Success)
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
                    string query = "INSERT INTO AuthorTable VALUES " +
                        "('" + fname + "', '" + lname + "', '" + mail + "');";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteReader();
                    this.Hide();
                    InventoryControllerDashboard dashboard = new InventoryControllerDashboard();
                    dashboard.Show();
                }
            }
        }
    }
}
