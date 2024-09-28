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

namespace DSRS
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private string Gender()
        {
            if (male_rb.Checked) return "Male";
            if (female_rb.Checked) return "Female";
            if (others_rb.Checked) return "OThers";
            else return null;
        }
        private void registration_btn_Click(object sender, EventArgs e)
        {
            string name = name_txt.Text;
            string dob = dob_txt.Text;
            string email = email_txt.Text;
            string nid = nid_txt.Text;
            string phoneNumber = number_txt.Text;
            string password = password_txt.Text;
            string confrimPassword = confirm_password_txt.Text;
            string gender = Gender();

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Please enter your name");
                name_txt.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(dob))
            {
                MessageBox.Show("Please enter your date of birth");
                dob_txt.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(gender))
            {
                MessageBox.Show("Please enter your gender");
                gender_panel.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(nid))
            {
                MessageBox.Show("Please enter your nid number");
                nid_txt.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Please enter your email");
                email_txt.Focus();
                return;
            }

            if (string.IsNullOrEmpty(phoneNumber))
            {
                MessageBox.Show("Please enter your phone number");
                number_txt.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter password");
                password_txt.Focus();   
                return;
            }

            if (string.IsNullOrWhiteSpace(confrimPassword))
            {
                MessageBox.Show("Please enter the password on more time");
                confirm_password_txt.Focus();
                return;
            }

            if (password != confrimPassword)
            {
                MessageBox.Show("Password does not match");
                confirm_password_txt.Focus();
                return;
            }

            string query, error;
            // Check if the email is already registered
            query = $@"
                    SELECT TOP 1 * FROM [User Information] WHERE [Email] = '{email}'";
            DataSet dataSet = DataBase.DataAccess(query, out error);
            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show($"Class Name: From3 Function: registration_btn_Click 1\nError: {error}", "Email");
                return;
            }

            if (dataSet.Tables[0].Rows.Count > 0)
            {
                MessageBox.Show("This EMAIL is already registered");
                email_txt.Focus();
                return;
            }

            // Check if the phone number is already registered
            query = $"SELECT TOP 1 * FROM [User Information] WHERE [Phone Number] = '{phoneNumber}'";
            dataSet = DataBase.DataAccess(query, out error);
            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show($"Class Name: Form3 Function:  registration_btn_Click 2 \nError: {error}", "Phone Number");
                return;
            }

            if (dataSet.Tables[0].Rows.Count > 0)
            {
                MessageBox.Show("This PHONE NUMBER is already registered");
                number_txt.Focus();
                return;
            }

            query = $@"INSERT INTO [User Information] (Name, Email, [Phone Number], NID, DOB, Gender, Password)
                              VALUES ('{name}', '{email}', '{phoneNumber}', '{nid}', '{dob}', '{gender}', '{password}')";
            DataBase.ExecuteNonQuery(query, out error);


            if (!string.IsNullOrWhiteSpace(error))
            {
                MessageBox.Show($"Class name form3 function login_btn_Click \nError: {error}");
                return;
            }

            MessageBox.Show($"{name} your account successfully created");
            this.Hide();    
            Form2 loginForm = new Form2(2);
            loginForm.Show();

            
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 loginForm = new Form2(2);
            loginForm.Show();
        }
    }
}
