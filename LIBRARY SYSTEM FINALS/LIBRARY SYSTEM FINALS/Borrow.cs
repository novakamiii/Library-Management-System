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

namespace LIBRARY_SYSTEM_FINALS
{
    public partial class Borrow : Form
    {
        public Borrow()
        {
            InitializeComponent();
            PopulateComboBox();
            this.StartPosition = FormStartPosition.CenterScreen;
            comboBookPicker.KeyPress += new KeyPressEventHandler(enterKey);
            borrowerNamety.KeyPress += new KeyPressEventHandler(enterKey);
        }

        private void PopulateComboBox()
        {
            // Read lines from db.txt
            string[] lines = File.ReadAllLines(@"db.txt");

            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                string book = parts[1].Split('=')[1].Trim();
                string availability = parts[3].Split('=')[1].Trim();

                if (availability == "AVAILABLE")
                {
                    comboBookPicker.Items.Add(book);
                }
            }
        }

        private void enterKey(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;

                buttonborrow_Click(sender, new EventArgs());
            }
        }

        private void bookborrowty_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBookPicker_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void borrowerNamety_TextChanged(object sender, EventArgs e)
        {

        }

        public void buttonborrow_Click(object sender, EventArgs e)
        {
            if (comboBookPicker.SelectedItem == null)
            {
                MessageBox.Show("Please select a book.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string borrowerName = borrowerNamety.Text.Trim();

            if (string.IsNullOrWhiteSpace(borrowerName))
            {
                MessageBox.Show("Please enter the borrower's name.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string selectedBook = comboBookPicker.SelectedItem.ToString();

            string[] lines = File.ReadAllLines(@"db.txt");
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].Contains($"book={selectedBook}"))
                {
                    string[] parts = lines[i].Split(',');
                    for (int j = 0; j < parts.Length; j++)
                    {
                        if (parts[j].Trim().StartsWith("avail="))
                        {
                            parts[j] = "avail=BORROWED";
                        }
                        else if (parts[j].Trim().StartsWith("borrower="))
                        {
                            parts[j] = $"borrower={borrowerName}";
                        }
                    }
                    lines[i] = string.Join(",", parts);
                    break;
                }
            }

            File.WriteAllLines(@"db.txt", lines);


            if (Owner is Form1 mainForm)
            {
                mainForm.RefreshListBoxes();
            }

            MessageBox.Show("Book Borrowed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }


    }
}
