/*
Kathleen Woodbury
Purdue University Global
IT481 Advanced Software Development
Professor Kovacic
Unit 9 Assignment
11/20/2023
 */

using Microsoft.VisualBasic.ApplicationServices;
using static Azure.Core.HttpHeader;

namespace IT481_Unit9Assignment
{
    public partial class Form1 : Form
    {
        private Controller controller;
        private string user;
        private string password;
        private string server;
        private string database;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            user = tbUser.Text;
            password = tbPassword.Text;
            server = tbServer.Text;
            database = tbDatabase.Text;

            if (user.Length == 0 || password.Length == 0 ||
                server.Length == 0 || database.Length == 0)
            {
                isValid = false;
                MessageBox.Show("You must enter user name, password, server, and database values");
            }

            else if (password != "password123")
            {
                isValid = false;
                MessageBox.Show("You must enter a valid password");
            }

            if (isValid)
            {
                controller = new Controller("Server = " + server + "\\SQLEXPRESS;" +
                    "Database = " + database + ";" +
                    "User Id = " + user + ";" +
                    "Password = " + password + ";" +
                    "trustServerCertificate = true;"
                    );

                MessageBox.Show("Connection information sent");

            }
        }

        private void btnQuery1_Click(object sender, EventArgs e)
        {
            if (user == "User_CEO" && password == "password123" || user == "User_Sales" && password == "password123")
            {
                string count = controller.getCustomerCount();
                MessageBox.Show(count, "Customer Count");
            }
            else if (user == "User_HR")
            {
                MessageBox.Show("Please enter valid ID.");
            }
            else if (password != "password123")
            {
                MessageBox.Show("Please enter valid password.");
            }
        }

        private void btnQuery2_Click(object sender, EventArgs e)
        {
            if (user == "User_CEO" && password == "password123" || user == "User_Sales" && password == "password123")
            {
                string names = controller.getCompanyNames();
                MessageBox.Show(names, "Company Names");
            }
            else if (user == "User_HR")
            {
                MessageBox.Show("Please enter valid ID.");
            }
            else if (password != "password123")
            {
                MessageBox.Show("Please enter valid password.");
            }
        }

        private void btnQuery3_Click(object sender, EventArgs e)
        {
            if (user == "User_CEO" && password == "password123" || user == "User_Sales" && password == "password123")
            {
                string count = controller.getOrderCount();
                MessageBox.Show(count, "Order Count");
            }
            else if (user == "User_HR")
            {
                MessageBox.Show("Please enter valid ID.");
            }
            else if (password != "password123")
            {
                MessageBox.Show("Please enter valid password.");
            }
        }

        private void btnQuery4_Click(object sender, EventArgs e)
        {
            if (user == "User_CEO" && password == "password123" || user == "User_Sales" && password == "password123")
            {
                string names = controller.getShipNames();
                MessageBox.Show(names, "Order Ship Names");
            }
            else if (user == "User_HR")
            {
                MessageBox.Show("Please enter valid ID.");
            }
            else if (password != "password123")
            {
                MessageBox.Show("Please enter valid password.");
            }
        }

        private void btnQuery5_Click(object sender, EventArgs e)
        {
            if (user == "User_CEO" && password == "password123" || user == "User_HR" && password == "password123")
            {
                string count = controller.getEmployeeCount();
                MessageBox.Show(count, "Employee Count");
            }
            else if (user == "User_Sales")
            {
                MessageBox.Show("Please enter valid ID.");
            }
            else if (password != "password123")
            {
                MessageBox.Show("Please enter valid password.");
            }
        }

        private void btnQuery6_Click(object sender, EventArgs e)
        {
            if (user == "User_CEO" && password == "password123" || user == "User_HR" && password == "password123")
            {
                string names = controller.getEmployeeNames();
                MessageBox.Show(names, "Employee Names");
            }
            else if (user == "User_Sales")
            {
                MessageBox.Show("Please enter valid ID.");
            }
            else if (password != "password123")
            {
                MessageBox.Show("Please enter valid password.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}