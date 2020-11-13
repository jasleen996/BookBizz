using System;
using System.Collections;
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
    public partial class AddBook : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\14383\Downloads\BookBizz\BookBizz\Database1.mdf;Integrated Security=True";
        ArrayList authorIdArray = new ArrayList();

        public AddBook()
        {
            InitializeComponent();
            SqlConnection con = new SqlConnection(connectionString);
            string query = "SELECT * FROM AuthorTable";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader myReader;
            try
            {
                con.Open();
                myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                    string name = myReader.GetString(1) + " " + myReader.GetString(2);
                    authors.Items.Add(name);
                    authorIdArray.Add(myReader.GetInt32(0));

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void createBook_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            int modified;
            string isbn = bookIsbn.Text;
            string title = bookTitle.Text;
            string unitPrice = bookUnitPrice.Text;
            string year = bookYear.Text;
            string qohand = qoh.Text;
            SqlConnection con = new SqlConnection(connectionString);
            string query = "INSERT INTO BooksTable output inserted.Id VALUES " +
                "('" + isbn + "', '" + title + "', '" + unitPrice + "', '" + year + "', '" + qohand + "');";
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                con.Open();
                modified = (int)cmd.ExecuteScalar();
                if (con.State == System.Data.ConnectionState.Open) con.Close();
            }
            Console.WriteLine(modified);
            foreach(int index in authors.SelectedIndices)
            {
                string str = "(" + modified + "," + authorIdArray[index] + ")";
                sb.Append(str);
                sb.Append(",");
            }
            sb.Remove(sb.Length - 1, 1);
            string query1 = "INSERT INTO BookAuth VALUES " + sb;
            using (SqlCommand cmd = new SqlCommand(query1, con))
            {
                con.Open();
                cmd.ExecuteReader();
                if (con.State == System.Data.ConnectionState.Open) con.Close();
            }
            this.Hide();
            InventoryControllerDashboard dashboard = new InventoryControllerDashboard();
            dashboard.Show();
        }
    }
}
