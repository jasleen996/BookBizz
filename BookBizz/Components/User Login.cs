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
using BookBizz.Components;

namespace BookBizz
{
    public partial class Userlogin : Form
    {

        public static string role;

        public Userlogin()
        {
            InitializeComponent();
        }
        private void login_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\14383\Downloads\BookBizz\BookBizz\Database1.mdf;Integrated Security=True");
            string query = "SELECT * FROM UserLogin WHERE username = '" + txtUsername.Text.Trim() + "' and password = '" + txtPassword.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            Console.WriteLine(dtbl.Rows.Count + txtUsername.Text.Trim() + txtPassword.Text.Trim());
            if(dtbl.Rows.Count == 1)
            {
                role = dtbl.Rows[0]["role"].ToString();
                if(role == "MIS Manager")
                {
                    this.Hide();
                    AdminDashboard dashboard = new AdminDashboard();
                    dashboard.Show(); 
                }
                else if(role == "Sales Manager")
                {
                    this.Hide();
                    SalesManagerDashboard dashboard2 = new SalesManagerDashboard(dtbl.Rows[0]["userId"].ToString());
                    dashboard2.Show();
                }
                else if (role == "Inventory Controller")
                {
                    this.Hide();
                    InventoryControllerDashboard dashboard3 = new InventoryControllerDashboard();
                    dashboard3.Show();
                }
                else if (role == "Order Clerks")
                {
                    this.Hide();
                    OrderClerkDashboard dashboard4 = new OrderClerkDashboard();
                    dashboard4.Show();
                }
            }
            else
            {
                MessageBox.Show("Check your username and password");
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
