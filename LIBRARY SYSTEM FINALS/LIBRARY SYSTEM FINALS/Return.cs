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
    public partial class Return : Form
    {
        public Return()
        {
            InitializeComponent();
            LoadBorrowers();
            this.StartPosition = FormStartPosition.CenterScreen;
            comboReturn.KeyPress += new KeyPressEventHandler(returnenterKey);
        }

        private void returnenterKey(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;

                buttonreturn_Click(sender, new EventArgs());
            }
        }

        private string returnComment = string.Empty;

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void LoadBorrowers()
        {
            comboReturn.Items.Clear();
            var lines = File.ReadAllLines(@"db.txt");
            foreach (var line in lines)
            {
                var parts = line.Split(',');
                var availability = parts[3].Split('=')[1].Trim();
                var borrower = parts[4].Split('=')[1].Trim();
                if (availability == "BORROWED" && borrower != "N/A")
                {
                    comboReturn.Items.Add(borrower);
                }
            }
        }

        private void comboReturn_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void commentsTextBox_TextChanged(object sender, EventArgs e)
        {
            returnComment = commentsTextBox.Text;
        }

        private void buttonreturn_Click(object sender, EventArgs e)
        {
            var selectedBorrower = comboReturn.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedBorrower))
            {
                MessageBox.Show("Please select a borrower.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var lines = File.ReadAllLines(@"db.txt").ToList();
            string book = string.Empty;

            for (int i = 0; i < lines.Count; i++)
            {
                var parts = lines[i].Split(',');
                var borrower = parts[4].Split('=')[1].Trim();
                if (borrower == selectedBorrower)
                {
                    parts[3] = "avail=AVAILABLE";
                    parts[4] = "borrower=N/A";
                    parts[5] = "rate=" + returnrate;
                    lines[i] = string.Join(",", parts);

                    //book name extractor
                    foreach (var part in parts)
                    {
                        if (part.StartsWith("book="))
                        {
                            book = part.Split('=')[1];
                            break;
                        }
                    }

                    break;
                }
            }

            File.WriteAllLines(@"db.txt", lines);

            string returnInfo = $"Book: {book}, Borrower: {selectedBorrower}, Date: {DateTime.Now.ToString("yyyy-MM-dd")}, Rate: {returnrate}" + Environment.NewLine +
                   $"Comments: {returnComment}";
            File.AppendAllText(@"dbcomments.txt", returnInfo + Environment.NewLine);

            MessageBox.Show("Book returned successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadBorrowers();

            if (Owner is Form1 mainForm)
            {
                mainForm.RefreshListBoxes();
            }
            this.Close();
        }

        private int returnrate = 0;

        private void ratereturnB1_CheckedChanged(object sender, EventArgs e)
        {
            if (ratereturnB1.Checked)
            {
                returnrate = 1;
            }
        }

        private void ratereturnB2_CheckedChanged(object sender, EventArgs e)
        {
            if (ratereturnB2.Checked)
            {
                returnrate = 2;
            }
        }

        private void ratereturnB3_CheckedChanged(object sender, EventArgs e)
        {
            if (ratereturnB3.Checked)
            {
                returnrate = 3;
            }
        }

        private void ratereturnB4_CheckedChanged(object sender, EventArgs e)
        {
            if (ratereturnB4.Checked)
            {
                returnrate = 4;
            }
        }

        private void ratereturnB5_CheckedChanged(object sender, EventArgs e)
        {
            if (ratereturnB5.Checked)
            {
                returnrate = 5;
            }
        }
    }
}
