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
    public partial class OrderClerkDashboard : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\14383\Downloads\BookBizz\BookBizz\Database1.mdf;Integrated Security=True";
        public OrderClerkDashboard()
        {
            InitializeComponent();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT co.Id, ct.name, bt.title, co.qty, co.orderPayment FROM ClientTable AS ct INNER JOIN ClientOrder AS co ON co.clientId = ct.Id INNER JOIN BooksTable AS bt ON co.bookId = bt.Id;";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                if (dtbl.Rows.Count != 0)
                {
                    noLabel.Hide();
                    ordersView.DataSource = dtbl;
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
            AddOrders addOrders = new AddOrders();
            addOrders.Show();
        }

        private void searchOrderBtn_Click(object sender, EventArgs e)
        {
            cancelSearch.Visible = true;
            string searchString = searchOrder.Text;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT co.Id, ct.name, bt.title, co.qty, co.orderPayment FROM ClientTable AS ct INNER JOIN ClientOrder AS co ON co.clientId = ct.Id INNER JOIN BooksTable AS bt ON co.bookId = bt.Id WHERE ct.name = '" + searchString + "' or bt.title = '" + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                if (dtbl.Rows.Count > 0)
                {
                    noLabel.Hide();
                    ordersView.DataSource = dtbl;
                }
                else
                {
                    ordersView.DataSource = "";
                    noLabel.Show();
                    noLabel.Text = "No data found";
                }
            }
        }

        private void ordersView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(ordersView.Columns[e.ColumnIndex].Name == "delete")
            {
                if(MessageBox.Show("Are you sure? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DataGridViewRow row = ordersView.Rows[e.RowIndex];
                    Console.WriteLine(row.Cells["ID"].Value);
                    int orderId = (int)row.Cells["ID"].Value;
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();
                        string query = "DELETE FROM ClientOrder WHERE Id = " + orderId;
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.ExecuteReader();
                        this.Hide();
                        OrderClerkDashboard dashboard = new OrderClerkDashboard();
                        dashboard.Show();
                    }
                }
            }
        }

        private void cancelSearch_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                searchOrder.Text = "";
                con.Open();
                string query = "SELECT co.Id, ct.name, bt.title, co.qty, co.orderPayment FROM ClientTable AS ct INNER JOIN ClientOrder AS co ON co.clientId = ct.Id INNER JOIN BooksTable AS bt ON co.bookId = bt.Id;";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                if (dtbl.Rows.Count != 0)
                {
                    noLabel.Hide();
                    ordersView.DataSource = dtbl;
                }
                else
                {
                    noLabel.Show();
                }
            }
            cancelSearch.Visible = false;
        }
    }
}
