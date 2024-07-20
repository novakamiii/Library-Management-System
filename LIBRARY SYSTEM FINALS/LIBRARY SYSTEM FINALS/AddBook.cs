using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static LIBRARY_SYSTEM_FINALS.AddBook;
using System.Net.NetworkInformation;

namespace LIBRARY_SYSTEM_FINALS
{
    public partial class AddBook : Form
    {
        public AddBook()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            addbookty.KeyPress += new KeyPressEventHandler(TextBox_KeyPress);
            authorty.KeyPress += new KeyPressEventHandler(TextBox_KeyPress);
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ',')
            {
                e.Handled = true;
                MessageBox.Show("Commas are not allowed.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; 

                buttonAdd_Click(sender, e);
            }
        }
        public void Borrow_Load(object sender, EventArgs e)
        {

        }

        private void Greetingtext_TextChanged(object sender, EventArgs e)
        {

        }

        private void HubTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void HubT_TextChanged(object sender, EventArgs e)
        {

        }

        public void buttonAdd_Click(object sender, EventArgs e)
        {
            string book = addbookty.Text;
            string author = authorty.Text;
            string availability = "AVAILABLE";
            string borrower = "N/A";
            string rating = "N/A"; 

            if (string.IsNullOrWhiteSpace(book) || string.IsNullOrWhiteSpace(author))
            {
                MessageBox.Show("Please enter both book and author names.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            int newBookID = GenerateNewBookID();


            using (StreamWriter sw = File.AppendText(@"db.txt"))
            {
                sw.WriteLine($"bookID={newBookID:D4},book={book},author={author},avail={availability},borrower={borrower},rate={rating}");
            }


            addbookty.Text = "";
            authorty.Text = "";

            if (Owner is Form1 mainForm)
            {
                mainForm.RefreshListBoxes();
            }

            MessageBox.Show("Book Added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private int GenerateNewBookID()
        {
            string[] lines = File.ReadAllLines(@"db.txt");

            int maxID = 0;

            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                if (parts.Length >= 1)
                {
                    string bookIDPart = parts[0];
                    int id = int.Parse(bookIDPart.Split('=')[1].Trim());
                    if (id > maxID)
                    {
                        maxID = id;
                    }
                }
            }

            return maxID + 1;
        }

        public void addbookty_TextChanged(object sender, EventArgs e)
        {

        }

        public void authorty_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private int rating = 0;
    }
}
