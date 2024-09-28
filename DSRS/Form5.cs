using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DSRS
{
    public partial class Form5 : Form
    {
        private string userName, fromLocation, toLocation, journeyDate, trainName;
        public Form5()
        {
            InitializeComponent();
        }


        private string scheduleID, customerID, seatType;
        private int NumberOfSeats;
        private double totalPrice;
        public Form5(string scheduleID, string customerID, string seatType, int NumberOfSeats, double totalPrice) : this()
        {
            this.scheduleID = scheduleID;
            this.customerID = customerID;
            this.seatType = seatType;
            this.NumberOfSeats = NumberOfSeats;
            this.totalPrice = totalPrice;

            ticket_price_lvl.Text = $"Total Price: {totalPrice}";
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void pay_btn_Click(object sender, EventArgs e)
        {
            string error;
            string query = $@"INSERT INTO [Ticket Purchase] ([Schedule ID], [User ID], [Seat Type], [Number Of Seats], [Total Price])
                             VALUES ('{this.scheduleID}', '{this.customerID}', '{this.seatType}', {this.NumberOfSeats}, {this.totalPrice})";

            DataBase.ExecuteNonQuery(query, out error);
            if (!string.IsNullOrWhiteSpace(error))
            {
                MessageBox.Show($"Class: Form5 Function: pay_btn_Click (1)\nError: {error}");
                return;
            }

            if (seatType == "Sitting")
                query = $@"UPDATE [dbo].[Train Schedule]
                        SET [Sitting Seat] = [Sitting Seat] - {this.NumberOfSeats}
                        WHERE [ID] = {this.scheduleID} AND [Sitting Seat] > 0";

            else
                query = $@"UPDATE [dbo].[Train Schedule]
                        SET [Standing Seat] = [Standing Seat] - {this.NumberOfSeats}
                        WHERE [ID] = {this.scheduleID} AND [Standing Seat] > 0";


            DataBase.ExecuteNonQuery(query, out error);
            if (!string.IsNullOrWhiteSpace(error))
            {
                MessageBox.Show($"Class: Form5 Function: pay_btn_Click (2)\nError: {error}");
                return;
            }


            print(sender, e);
           

        }

        private void print(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to print the ticket?", "Info", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
                printButton_Click(sender, e);


            if (dialogResult == DialogResult.No)
                dialogResult = MessageBox.Show("Are you sure you can not print the ticket?", "Info", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                this.Hide();
                Form4 form4 = new Form4(this.customerID);
                form4.Show();
            }

            else if (dialogResult == DialogResult.No)
                print(sender, e);

        }


        private void printButton_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);
            PrintDialog printDialog = new PrintDialog
            {
                Document = printDocument
            };

            if (printDialog.ShowDialog() == DialogResult.OK)
                printDocument.Print();
            
        }

        private void PrintDataCollection()
        {
            string error;
            string query = $@"SELECT 
                                u.[Name] AS [User Name], 
                                ts.[From] AS [From], 
                                ts.[To] AS [To], 
                                ts.[Train Name] AS [Train Name],
                                ts.[Date] AS [Date]
                            FROM 
                                [dbo].[User Information] u
                            INNER JOIN 
                                [dbo].[Train Schedule] ts
                            ON 
                                u.[Id] = {this.customerID}
                            WHERE 
                                ts.[ID] = {this.scheduleID}";

            DataSet dataSet = DataBase.DataAccess(query,out error);

            if (!string.IsNullOrWhiteSpace(error))
            {
                MessageBox.Show($"Class: Form5 Function: PrintDataCollection \nerror: {error}");
                return;
            }

            userName = dataSet.Tables[0].Rows[0]["User Name"].ToString();
            fromLocation = dataSet.Tables[0].Rows[0]["From"].ToString(); 
            toLocation = dataSet.Tables[0].Rows[0]["To"].ToString(); 
            journeyDate = dataSet.Tables[0].Rows[0]["Date"].ToString(); 
            trainName = dataSet.Tables[0].Rows[0]["Train Name"].ToString();

        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            PrintDataCollection();
            // Set up font and brush for text
            Font titleFont = new Font("Arial", 16, FontStyle.Bold);
            Font normalFont = new Font("Arial", 12);
            Brush brush = Brushes.Black;

            // Draw watermark
            string watermarkText = "DSRS";
            Font watermarkFont = new Font("Arial", 60, FontStyle.Bold | FontStyle.Italic);
            SizeF watermarkSize = e.Graphics.MeasureString(watermarkText, watermarkFont);
            float watermarkX = 300;
            float watermarkY = 120;

            // Draw watermark with light gray color and semi-transparent
            Color watermarkColor = Color.FromArgb(50, 200, 200, 200); // Semi-transparent
            using (SolidBrush watermarkBrush = new SolidBrush(watermarkColor))
                e.Graphics.DrawString(watermarkText, watermarkFont, watermarkBrush, new PointF(watermarkX, watermarkY));
            
            // Print ticket details below the watermark
            e.Graphics.DrawString("Ticket Information", titleFont, brush, new PointF(300, 50));
            e.Graphics.DrawString($"Owner Name: {userName}", normalFont, brush, new PointF(100, 100));
            e.Graphics.DrawString($"From: {fromLocation}", normalFont, brush, new PointF(100, 130));
            e.Graphics.DrawString($"To: {toLocation}", normalFont, brush, new PointF(100, 160));
            e.Graphics.DrawString($"Number of Seats: {this.NumberOfSeats}", normalFont, brush, new PointF(100, 190));
            e.Graphics.DrawString($"Journey Date: {journeyDate}", normalFont, brush, new PointF(100, 220));
            e.Graphics.DrawString($"Train Name: {trainName}", normalFont, brush, new PointF(100, 250));

        }
    }
}
