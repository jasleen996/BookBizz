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
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace BookBizz.Components
{
    public partial class AddOrders : Form
    {
        int selectedClient;
        int clientId;
        int selectedBook;
        int bookId;
        string quantity;
        string price;
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\14383\Downloads\BookBizz\BookBizz\Database1.mdf;Integrated Security=True";
        ArrayList clientIdArray = new ArrayList();
        ArrayList bookIdArray = new ArrayList();
        ArrayList bookQtyArray = new ArrayList();
        ArrayList bookPriceArray = new ArrayList();
        public AddOrders()
        {
            InitializeComponent();
            orderErrorCont.Visible = false;
            SqlConnection con = new SqlConnection(connectionString);
            string query = "SELECT * FROM ClientTable";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader myReader;

            try
            {
                con.Open();
                myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                    string name = myReader.GetString(1);
                    clients.Items.Add(name);
                    clientIdArray.Add(myReader.GetInt32(0));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

            string query2 = "SELECT * FROM BooksTable";
            cmd = new SqlCommand(query2, con);

            try
            {
                con.Open();
                myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                    string name = myReader.GetString(2);
                    books.Items.Add(name);
                    bookIdArray.Add(myReader.GetInt32(0));
                    bookPriceArray.Add(myReader.GetString(3));
                    bookQtyArray.Add(myReader.GetString(5));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\14383\Downloads\BookBizz\BookBizz\Database1.mdf;Integrated Security=True";
            int client = clientId;
            int book = bookId;
            int quantity = Int32.Parse(qty.Text);
            int payment = Int32.Parse(orderPayment.Text);
            
            if (orderErrorCont.Visible == false)
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "INSERT INTO ClientOrder VALUES " +
                        "(" + client + ", " + book + ", " + quantity + ", " + payment + ")";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteReader();
                }
            }
            this.Hide();
            OrderClerkDashboard dashboard = new OrderClerkDashboard();
            dashboard.Show();
        }

        private void clients_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedClient = clients.SelectedIndex;
            clientId = (int)clientIdArray[selectedClient-1];
        }

        private void books_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedBook = books.SelectedIndex;
            bookId = (int)bookIdArray[selectedBook];
            quantity = (string)bookQtyArray[selectedBook];
            price = (string)bookPriceArray[selectedBook];
            avlStock.Text = quantity;
            unitPrice.Text = price;
        }

        private void qty_Leave(object sender, EventArgs e)
        {
            if(qty.Text.Trim() != "")
            {
                int quantity = Int32.Parse(avlStock.Text);
                int qtyInput = Int32.Parse(qty.Text);
                int uniPrice = Int32.Parse(unitPrice.Text);
                int totalAmount = qtyInput * uniPrice; 
                if (qtyInput > quantity)
                {
                    Console.WriteLine(qtyInput + " " + quantity + " " + (quantity < qtyInput));
                    orderErrorCont.Visible = true;
                    orderError.Text = "Order quantity is higher than stock.";
                }
                else
                {
                    orderErrorCont.Visible = false;
                    orderPayment.Text = totalAmount.ToString();
                }
            }
        }

    }
}
