using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LIBRARY_SYSTEM_FINALS.AddBook;

namespace LIBRARY_SYSTEM_FINALS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.Form1_Load);
            this.StartPosition = FormStartPosition.CenterScreen;
        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            AddBook AddBook = new AddBook();

            AddBook.Owner = this;

            AddBook.ShowDialog();
        }

        private void AvailabilitytextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void borrowedbtn_Click(object sender, EventArgs e)
        {
            Borrow Borrow = new Borrow();

            Borrow.Owner = this;

            Borrow.ShowDialog();
        }

        private void Returnbtn_Click(object sender, EventArgs e)
        {
            Return Return = new Return();

            Return.Owner = this;

            Return.ShowDialog();
        }

        private void Commentbtn_Click(object sender, EventArgs e)
        {
            string filePath = @"dbcomments.txt";


            if (File.Exists(filePath))
            {
                
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = "notepad.exe",
                    Arguments = $"\"{filePath}\"", 
                    UseShellExecute = false,
                    WindowStyle = ProcessWindowStyle.Normal
                };

                try
                {
                    Process.Start(psi);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error opening file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("File not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Book1textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Book2textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void booksListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void authorsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void availListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void borrowerListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void booksIDListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void Form1_Load(object sender, EventArgs e)
        {

            string[] lines = File.ReadAllLines(@"db.txt");

            foreach (string line in lines)
            {
                // adjust
                string[] parts = line.Split(',');

                string bookID = "";
                string book = "";
                string author = "";
                string availability = "";
                string borrower = "";
                string rating = "N/A";


                if (parts.Length >= 6)
                {
                    bookID = parts[0].Split('=')[1].Trim(); 
                    book = parts[1].Split('=')[1].Trim();    
                    author = parts[2].Split('=')[1].Trim();  
                    availability = parts[3].Split('=')[1].Trim();
                    borrower = parts[4].Split('=')[1].Trim();
                    rating = parts[5].Split('=')[1].Trim();
                }

                booksIDListBox.Items.Add(bookID);
                booksListBox.Items.Add(book);
                authorsListBox.Items.Add(author);
                availListBox.Items.Add(availability);
                ratingListBox.Items.Add(rating);
                borrowerListBox.Items.Add(borrower);
            }
        }

        public void RefreshListBoxes()
        {

            booksIDListBox.Items.Clear();
            booksListBox.Items.Clear();
            authorsListBox.Items.Clear();
            availListBox.Items.Clear();
            ratingListBox.Items.Clear();
            borrowerListBox.Items.Clear();

            Form1_Load(null, EventArgs.Empty);
        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RefreshListBoxes();
        }

        private void ClearBooks_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to clear the library?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;

                    string dbFilePath = Path.Combine(currentDirectory, "db.txt");
                    File.WriteAllText(dbFilePath, string.Empty);

                    string dbCommentsFilePath = Path.Combine(currentDirectory, "dbcomments.txt");
                    File.WriteAllText(dbCommentsFilePath, string.Empty);

                    MessageBox.Show("Databases cleared successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error clearing databases: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {

            }

            RefreshListBoxes ();
        }

        private void Members_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"BSIT 1-1 PUP-SPC\nSevilla\nBordeos\nApeta\nDio\nRanchez\nGutay\nPalec\nObeda\nEbarsabal\nRoque", "Members", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
    }
}
