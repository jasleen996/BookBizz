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
    public partial class InventoryControllerDashboard : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\14383\Downloads\BookBizz\BookBizz\Database1.mdf;Integrated Security=True";

        public InventoryControllerDashboard()
        {
            InitializeComponent();
            addAuthor.Show();
            addBook.Hide();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT * FROM Authortable";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                if (dtbl.Rows.Count != 0)
                {
                    noLabel.Hide();
                    authorsView.DataSource = dtbl;
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

        private void author_Click(object sender, EventArgs e)
        {
            bookSearch.Visible = false;
            bookSearchBtn.Visible = false;
            authorSearch.Visible = true;
            authorSearchBtn.Visible = true;
            section.Text = "Authors";
            booksView.Visible = false;
            authorsView.Visible = true;
            author.BackColor = System.Drawing.Color.White;
            author.ForeColor = System.Drawing.Color.SteelBlue;
            book.BackColor = System.Drawing.Color.SteelBlue;
            book.ForeColor = System.Drawing.Color.White;
            addBook.Hide();
            addAuthor.Show();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT * FROM AuthorTable";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                if (dtbl.Rows.Count != 0)
                {
                    noLabel.Hide();
                    authorsView.DataSource = dtbl;
                }
                else
                {
                    noLabel.Show();
                }
                con.Close();
            }
        }

        private void book_Click(object sender, EventArgs e)
        {
            authorSearch.Visible = false;
            authorSearchBtn.Visible = false;
            bookSearch.Visible = true;
            bookSearchBtn.Visible = true;
            section.Text = "Books";
            authorsView.Visible = false;
            booksView.Visible = true;
            book.BackColor = System.Drawing.Color.White;
            book.ForeColor = System.Drawing.Color.SteelBlue;
            author.BackColor = System.Drawing.Color.SteelBlue;
            author.ForeColor = System.Drawing.Color.White;
            addAuthor.Hide();
            addBook.Show();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT * FROM BooksTable";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                if (dtbl.Rows.Count != 0)
                {
                    noLabel.Hide();
                    booksView.DataSource = dtbl;
                }
                else
                {
                    noLabel.Show();
                }
                con.Close();
            }
        }

        private void addAuthor_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddAuthor addAuthor = new AddAuthor();
            addAuthor.Show();
        }

        private void addBook_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddBook addBook = new AddBook();
            addBook.Show();
        }

        private void authorSearchBtn_Click(object sender, EventArgs e)
        {
            authorCancelSearch.Visible = true;
            string searchString = authorSearch.Text;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT * FROM AuthorTable WHERE first_name = '" + searchString + "' or last_name = '" + searchString + "' or email = '" + searchString + "';";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                if (dtbl.Rows.Count > 0)
                {
                    noLabel.Hide();
                    authorsView.DataSource = dtbl;
                }
                else
                {
                    authorsView.DataSource = "";
                    noLabel.Show();
                    noLabel.Text = "No data found";
                }
            }
        }

        private void bookSearchBtn_Click(object sender, EventArgs e)
        {
            bookSearchCancel.Visible = true;
            string searchString = bookSearch.Text;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT * FROM BooksTable WHERE isbn = '" + searchString + "' or title = '" + searchString + "';";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                if (dtbl.Rows.Count > 0)
                {
                    noLabel.Hide();
                    booksView.DataSource = dtbl;
                }
                else
                {
                    booksView.DataSource = "";
                    noLabel.Show();
                    noLabel.Text = "No data found";
                }
            }
        }

        private void authorCancelSearch_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                authorSearch.Text = "";
                con.Open();
                string query = "SELECT * FROM AuthorTable";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                if (dtbl.Rows.Count != 0)
                {
                    noLabel.Hide();
                    authorsView.DataSource = dtbl;
                }
                else
                {
                    noLabel.Show();
                }
            }
            authorCancelSearch.Visible = false;
        }

        private void bookSearchCancel_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                bookSearch.Text = "";
                con.Open();
                string query = "SELECT * FROM BooksTable";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                if (dtbl.Rows.Count != 0)
                {
                    noLabel.Hide();
                    booksView.DataSource = dtbl;
                }
                else
                {
                    noLabel.Show();
                }
            }
            bookSearchCancel.Visible = false;
        }

    }
}
