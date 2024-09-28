using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSRS
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(int userType) : this()
        {
            if (userType == 1) // Admin doesnot have registration option.
                registration_btn.Visible = false;
            else if (userType == 2) // Customer have registration option
                registration_btn.Visible = true;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            string id = userid_txt.Text;
            string password = password_txt.Text;


            if (string.IsNullOrWhiteSpace(id) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Enter the id pr password");
                return;
            }

            if (id == "admin" && password == "admin")
            {
                this.Hide();
                Form7 adminDashboard = new Form7();
                adminDashboard.Show();
                return;
            }

            string error;
            string query = $"SELECT * From [User Information] WHERE Email = '{id}' AND PASSWORD = '{password}'";

            DataSet dataSet = DataBase.DataAccess(query, out error);

            if (!string.IsNullOrWhiteSpace(error))
            {
                MessageBox.Show($"Class name form2 function login_btn_Click \nError: {error}");
                return;
            }


            if (dataSet.Tables[0].Rows.Count <= 0)
            {
                MessageBox.Show("Invalid email or password");
                return;

            }

            this.Hide();
            Form4 customerDashboard = new Form4(customerID: dataSet.Tables[0].Rows[0]["Id"].ToString());
            customerDashboard.Show();

        }

        private void registration_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 registrationForm = new Form3();
            registrationForm.Show();
        }
    }
}
