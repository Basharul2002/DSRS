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
    public partial class Form4 : Form
    {
        private string customerID;
        public Form4()
        {
            InitializeComponent();
        }

        public Form4(string customerID) : this()
        {
            this.customerID = customerID;
        }
        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ticket_booking_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(from_cb.Text))
            {
                MessageBox.Show("Choose Living From City");
                return;
            }

            if (string.IsNullOrWhiteSpace (to_cb.Text))
            {
                MessageBox.Show("Choose the Living To City");
                return;
            }

            if (string.IsNullOrWhiteSpace(class_cb.Text))
            {
                MessageBox.Show("Choose the seat type");
                return;
            }

            if (string.IsNullOrWhiteSpace(numberOfNumber_cb.Text))
            {
                MessageBox.Show("Choose the number of seat");
                return;
            }

            if (from_cb.Text == to_cb.Text)
            {
                MessageBox.Show("Please choose the Different City");
                return;
            }

            string error;
            //string query = "SELECT "
            
        }
    }
}
