using System;
using System.Collections;
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
    public partial class AddEmployee : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\14383\Downloads\BookBizz\BookBizz\Database1.mdf;Integrated Security=True";
        ArrayList userIdArray = new ArrayList();
        int userId;
        string department;
        public AddEmployee()
        {
            InitializeComponent();
            SqlConnection con = new SqlConnection(connectionString);
            string query = "SELECT * FROM UserTable WHERE empId = 0";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader myReader;

            try
            {
                con.Open();
                myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                    string name = myReader.GetString(1) + " " + myReader.GetString(2);
                    users.Items.Add(name);
                    userIdArray.Add(myReader.GetInt32(0));

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void addLoginDetails(int userId, string department, string username, string password)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "INSERT INTO UserLogin VALUES " +
                    "('" + username + "', '" + password + "', '" + department + "', '" + userId + "');";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteReader();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = empusername.Text;
            string pass = emppassword.Text;
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "INSERT INTO EmployeeTable VALUES " +
                    "('" + userId + "', '" + department + "', '" + user + "', '" + pass + "');";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteReader();
                addLoginDetails(userId, department, user, pass);
                this.Hide();
                AdminDashboard dashboard = new AdminDashboard();
                dashboard.Show();
            }
            
        }

        private void usersOnChange(object sender, EventArgs e)
        {
            userId = (int)userIdArray[users.SelectedIndex-1];
            Console.WriteLine(userIdArray);
        }

        private void departmentOnChange(object sender, EventArgs e)
        {
            department = (string)departments.SelectedItem;
        }

    }
}
