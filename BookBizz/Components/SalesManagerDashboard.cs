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
    public partial class SalesManagerDashboard : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\14383\Downloads\BookBizz\BookBizz\Database1.mdf;Integrated Security=True";
        string userId;
        public SalesManagerDashboard(string userId)
        {
            this.userId = userId;
            InitializeComponent();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT * FROM ClientTable WHERE userId = " + userId;
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                if (dtbl.Rows.Count != 0)
                {
                    noLabel.Hide();
                    clientsView.DataSource = dtbl;
                }
                else
                {
                    noLabel.Show();
                }
                con.Close();
            }
        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Userlogin userLogin = new Userlogin();
            userLogin.Show();
        }

        private void addClient_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddClient addClient = new AddClient(userId);
            addClient.Show();
        }

        private void searchClientBtn_Click(object sender, EventArgs e)
        {
            cancelSearch.Visible = true;
            string searchString = searchClient.Text;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT * FROM ClientTable WHERE name = '" + searchString + "' or street = '" + searchString + "' or city = '" + searchString + "' or phone_number = '" + searchString + "' or fax_nummber = '" + searchString + "';";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                if (dtbl.Rows.Count > 0)
                {
                    noLabel.Hide();
                    clientsView.DataSource = dtbl;
                }
                else
                {
                    clientsView.DataSource = "";
                    noLabel.Show();
                    noLabel.Text = "No data found";
                }
            }
        }

        private void cancelSearch_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                searchClient.Text = "";
                con.Open();
                string query = "SELECT * FROM ClientTable";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                if (dtbl.Rows.Count != 0)
                {
                    noLabel.Hide();
                    clientsView.DataSource = dtbl;
                }
                else
                {
                    noLabel.Show();
                }
            }
            cancelSearch.Visible = false;
        }

        private void searchClient_TextChanged(object sender, EventArgs e)
        {

        }

        private void noLabel_Click(object sender, EventArgs e)
        {

        }

        private void section_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void client_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void clientsView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
