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
    public partial class AdminDashboard : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\14383\Downloads\BookBizz\BookBizz\Database1.mdf;Integrated Security=True";
        public AdminDashboard()
        {
            InitializeComponent();
            addUser.Show();
            addEmployee.Hide();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "UPDATE UserTable SET UserTable.empId = EmployeeTable.Id FROM UserTable INNER JOIN EmployeeTable ON UserTable.Id = EmployeeTable.userId ;";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteReader();
                con.Close();
            }
            using (SqlConnection con = new SqlConnection(connectionString))
            { 
                con.Open();
                string query = "SELECT * FROM UserTable";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                if(dtbl.Rows.Count != 0)
                {
                    noLabel.Hide();
                    usersView.DataSource = dtbl;
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

        private void user_Click(object sender, EventArgs e)
        {
            employeeSearch.Visible = false;
            employeeSearchBtn.Visible = false;
            searchUser.Visible = true;
            searchUserBtn.Visible = true;
            section.Text = "Users";
            employeesView.Visible = false;
            usersView.Visible = true;
            user.BackColor = System.Drawing.Color.White;
            user.ForeColor = System.Drawing.Color.SteelBlue;
            employee.BackColor = System.Drawing.Color.SteelBlue;
            employee.ForeColor = System.Drawing.Color.White;
            addEmployee.Hide();
            addUser.Show();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "UPDATE UserTable SET UserTable.empId = EmployeeTable.Id FROM UserTable INNER JOIN EmployeeTable ON UserTable.Id = EmployeeTable.userId ;";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteReader();
                this.Hide();
                AdminDashboard dashboard = new AdminDashboard();
                dashboard.Show();
                con.Close();
            }
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT * FROM UserTable";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                if (dtbl.Rows.Count != 0)
                {
                    noLabel.Hide();
                    usersView.DataSource = dtbl;
                }
                else
                {
                    noLabel.Show();
                }
                con.Close();
            }
        }

        private void employees_Click(object sender, EventArgs e)
        {
            searchUser.Visible = false;
            searchUserBtn.Visible = false;
            employeeSearch.Visible = true;
            employeeSearchBtn.Visible = true;
            section.Text = "Employees";
            usersView.Visible = false;
            employeesView.Visible = true;
            employee.BackColor = System.Drawing.Color.White;
            employee.ForeColor = System.Drawing.Color.SteelBlue;
            user.BackColor = System.Drawing.Color.SteelBlue;
            user.ForeColor = System.Drawing.Color.White;
            addUser.Hide();
            addEmployee.Show();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT et.Id, ut.first_name, ut.last_name, et.role, et.username, et.password FROM UserTable AS ut INNER JOIN EmployeeTable AS et ON et.userId = ut.Id;";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                if (dtbl.Rows.Count != 0)
                {
                    noLabel.Hide();
                    employeesView.DataSource = dtbl;
                }
                else
                {
                    noLabel.Show();
                }
            }
        }

        private void addUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddUser addUser = new AddUser();
            addUser.Show();
        }

        private void addEmployee_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddEmployee addEmployee = new AddEmployee();
            addEmployee.Show();
        }

        private void searchUserBtn_Click(object sender, EventArgs e)
        {
            cancelSearch.Visible = true;
            string searchString = searchUser.Text;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT * FROM UserTable WHERE first_name = '" + searchString + "' or last_name = '" + searchString + "' or phone = '" +  searchString + "' or email = '" + searchString + "';";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                if (dtbl.Rows.Count > 0)
                {
                    noLabel.Hide();
                    usersView.DataSource = dtbl;
                }
                else
                {
                    usersView.DataSource = "";
                    noLabel.Show();
                    noLabel.Text = "No data found";
                }
            }
        }

        private void cancelSearch_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                searchUser.Text = "";
                con.Open();
                string query = "SELECT * FROM UserTable";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                if (dtbl.Rows.Count != 0)
                {
                    noLabel.Hide();
                    usersView.DataSource = dtbl;
                }
                else
                {
                    noLabel.Show();
                }
            }
            cancelSearch.Visible = false;

        }

        private void employeeSearchBtn_Click(object sender, EventArgs e)
        {
            empCancelSearch.Visible = true;
            string searchString = employeeSearch.Text;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT ut.first_name, ut.last_name, et.role, et.username, et.password FROM UserTable AS ut INNER JOIN EmployeeTable AS et ON et.userId = ut.Id WHERE ut.first_name = '" + searchString + "' or ut.last_name = '" + searchString +"' or ut.last_name = '" + searchString + "' or et.role = '" + searchString + "' or et.username = '" + searchString + "' or et.password = '" + searchString + "';";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                if (dtbl.Rows.Count > 0)
                {
                    noLabel.Hide();
                    employeesView.DataSource = dtbl;
                }
                else
                {
                    employeesView.DataSource = "";
                    noLabel.Show();
                    noLabel.Text = "No data found";
                }
            }
        }

        private void empCancelSearch_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                employeeSearch.Text = "";
                con.Open();
                string query = "SELECT et.Id, ut.first_name, ut.last_name, et.role, et.username, et.password FROM UserTable AS ut INNER JOIN EmployeeTable AS et ON et.userId = ut.Id;";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                if (dtbl.Rows.Count != 0)
                {
                    noLabel.Hide();
                    employeesView.DataSource = dtbl;
                }
                else
                {
                    noLabel.Show();
                }
            }
            empCancelSearch.Visible = false;

        }

    }
}
