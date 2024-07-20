namespace LIBRARY_SYSTEM_FINALS
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Returnbtn = new System.Windows.Forms.Button();
            this.borrowedbtn = new System.Windows.Forms.Button();
            this.addbtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.authorsListBox = new System.Windows.Forms.ListBox();
            this.booksListBox = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.availListBox = new System.Windows.Forms.ListBox();
            this.ClearBooks = new System.Windows.Forms.Button();
            this.rating = new System.Windows.Forms.Label();
            this.ratingListBox = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.borrowerListBox = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.booksIDListBox = new System.Windows.Forms.ListBox();
            this.Commentbtn = new System.Windows.Forms.Button();
            this.Members = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(151)))), ((int)(((byte)(233)))));
            this.panel1.Controls.Add(this.Members);
            this.panel1.Controls.Add(this.Commentbtn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Returnbtn);
            this.panel1.Controls.Add(this.borrowedbtn);
            this.panel1.Controls.Add(this.addbtn);
            this.panel1.Controls.Add(this.ClearBooks);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(0, -29);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1274, 208);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(51, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 40);
            this.label2.TabIndex = 8;
            this.label2.Text = "LIBRARY HUB";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(51, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 40);
            this.label1.TabIndex = 7;
            this.label1.Text = "WELCOME TO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Returnbtn
            // 
            this.Returnbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(105)))), ((int)(((byte)(203)))));
            this.Returnbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(105)))), ((int)(((byte)(203)))));
            this.Returnbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Returnbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Returnbtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Returnbtn.Location = new System.Drawing.Point(1146, 125);
            this.Returnbtn.Margin = new System.Windows.Forms.Padding(2);
            this.Returnbtn.Name = "Returnbtn";
            this.Returnbtn.Size = new System.Drawing.Size(117, 28);
            this.Returnbtn.TabIndex = 3;
            this.Returnbtn.Text = "RETURN";
            this.Returnbtn.UseVisualStyleBackColor = false;
            this.Returnbtn.Click += new System.EventHandler(this.Returnbtn_Click);
            // 
            // borrowedbtn
            // 
            this.borrowedbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(105)))), ((int)(((byte)(203)))));
            this.borrowedbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(105)))), ((int)(((byte)(203)))));
            this.borrowedbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.borrowedbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowedbtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.borrowedbtn.Location = new System.Drawing.Point(1146, 84);
            this.borrowedbtn.Margin = new System.Windows.Forms.Padding(2);
            this.borrowedbtn.Name = "borrowedbtn";
            this.borrowedbtn.Size = new System.Drawing.Size(117, 28);
            this.borrowedbtn.TabIndex = 2;
            this.borrowedbtn.Text = "BORROW";
            this.borrowedbtn.UseVisualStyleBackColor = false;
            this.borrowedbtn.Click += new System.EventHandler(this.borrowedbtn_Click);
            // 
            // addbtn
            // 
            this.addbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(105)))), ((int)(((byte)(203)))));
            this.addbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(105)))), ((int)(((byte)(203)))));
            this.addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbtn.ForeColor = System.Drawing.Color.OldLace;
            this.addbtn.Location = new System.Drawing.Point(1146, 42);
            this.addbtn.Margin = new System.Windows.Forms.Padding(2);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(117, 28);
            this.addbtn.TabIndex = 1;
            this.addbtn.Text = "ADD";
            this.addbtn.UseVisualStyleBackColor = false;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(24)))), ((int)(((byte)(162)))));
            this.label3.Location = new System.Drawing.Point(256, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "BOOKS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(24)))), ((int)(((byte)(162)))));
            this.label4.Location = new System.Drawing.Point(465, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "AUTHOR";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(24)))), ((int)(((byte)(162)))));
            this.label5.Location = new System.Drawing.Point(666, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "AVAILABILITY";
            // 
            // authorsListBox
            // 
            this.authorsListBox.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.authorsListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.authorsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorsListBox.FormattingEnabled = true;
            this.authorsListBox.ItemHeight = 20;
            this.authorsListBox.Location = new System.Drawing.Point(407, 286);
            this.authorsListBox.Name = "authorsListBox";
            this.authorsListBox.Size = new System.Drawing.Size(200, 300);
            this.authorsListBox.TabIndex = 12;
            this.authorsListBox.SelectedIndexChanged += new System.EventHandler(this.authorsListBox_SelectedIndexChanged);
            // 
            // booksListBox
            // 
            this.booksListBox.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.booksListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.booksListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.booksListBox.FormattingEnabled = true;
            this.booksListBox.ItemHeight = 20;
            this.booksListBox.Location = new System.Drawing.Point(188, 286);
            this.booksListBox.Name = "booksListBox";
            this.booksListBox.Size = new System.Drawing.Size(200, 300);
            this.booksListBox.TabIndex = 13;
            this.booksListBox.SelectedIndexChanged += new System.EventHandler(this.booksListBox_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(105)))), ((int)(((byte)(203)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(105)))), ((int)(((byte)(203)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.OldLace;
            this.button1.Location = new System.Drawing.Point(999, 84);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 69);
            this.button1.TabIndex = 9;
            this.button1.Text = "REFRESH";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // availListBox
            // 
            this.availListBox.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.availListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.availListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availListBox.ForeColor = System.Drawing.Color.DarkGreen;
            this.availListBox.FormattingEnabled = true;
            this.availListBox.ItemHeight = 20;
            this.availListBox.Location = new System.Drawing.Point(625, 286);
            this.availListBox.Name = "availListBox";
            this.availListBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.availListBox.Size = new System.Drawing.Size(200, 300);
            this.availListBox.TabIndex = 14;
            this.availListBox.SelectedIndexChanged += new System.EventHandler(this.availListBox_SelectedIndexChanged);
            // 
            // ClearBooks
            // 
            this.ClearBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(105)))), ((int)(((byte)(203)))));
            this.ClearBooks.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(105)))), ((int)(((byte)(203)))));
            this.ClearBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearBooks.ForeColor = System.Drawing.Color.OldLace;
            this.ClearBooks.Location = new System.Drawing.Point(999, 166);
            this.ClearBooks.Margin = new System.Windows.Forms.Padding(2);
            this.ClearBooks.Name = "ClearBooks";
            this.ClearBooks.Size = new System.Drawing.Size(117, 28);
            this.ClearBooks.TabIndex = 15;
            this.ClearBooks.Text = "CLEAR";
            this.ClearBooks.UseVisualStyleBackColor = false;
            this.ClearBooks.Click += new System.EventHandler(this.ClearBooks_Click);
            // 
            // rating
            // 
            this.rating.AutoSize = true;
            this.rating.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rating.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(24)))), ((int)(((byte)(162)))));
            this.rating.Location = new System.Drawing.Point(1127, 235);
            this.rating.Name = "rating";
            this.rating.Size = new System.Drawing.Size(70, 21);
            this.rating.TabIndex = 16;
            this.rating.Text = "RATING";
            // 
            // ratingListBox
            // 
            this.ratingListBox.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ratingListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ratingListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ratingListBox.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.ratingListBox.FormattingEnabled = true;
            this.ratingListBox.ItemHeight = 20;
            this.ratingListBox.Location = new System.Drawing.Point(1063, 286);
            this.ratingListBox.Name = "ratingListBox";
            this.ratingListBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ratingListBox.Size = new System.Drawing.Size(200, 300);
            this.ratingListBox.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(24)))), ((int)(((byte)(162)))));
            this.label6.Location = new System.Drawing.Point(890, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 21);
            this.label6.TabIndex = 18;
            this.label6.Text = "BORROWER";
            // 
            // borrowerListBox
            // 
            this.borrowerListBox.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.borrowerListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.borrowerListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowerListBox.ForeColor = System.Drawing.Color.Black;
            this.borrowerListBox.FormattingEnabled = true;
            this.borrowerListBox.ItemHeight = 20;
            this.borrowerListBox.Location = new System.Drawing.Point(844, 286);
            this.borrowerListBox.Name = "borrowerListBox";
            this.borrowerListBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.borrowerListBox.Size = new System.Drawing.Size(200, 300);
            this.borrowerListBox.TabIndex = 19;
            this.borrowerListBox.SelectedIndexChanged += new System.EventHandler(this.borrowerListBox_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(24)))), ((int)(((byte)(162)))));
            this.label7.Location = new System.Drawing.Point(49, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 21);
            this.label7.TabIndex = 20;
            this.label7.Text = "BOOK ID";
            // 
            // booksIDListBox
            // 
            this.booksIDListBox.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.booksIDListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.booksIDListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.booksIDListBox.FormattingEnabled = true;
            this.booksIDListBox.ItemHeight = 20;
            this.booksIDListBox.Location = new System.Drawing.Point(12, 286);
            this.booksIDListBox.Name = "booksIDListBox";
            this.booksIDListBox.Size = new System.Drawing.Size(155, 300);
            this.booksIDListBox.TabIndex = 21;
            this.booksIDListBox.SelectedIndexChanged += new System.EventHandler(this.booksIDListBox_SelectedIndexChanged);
            // 
            // Commentbtn
            // 
            this.Commentbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(105)))), ((int)(((byte)(203)))));
            this.Commentbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(105)))), ((int)(((byte)(203)))));
            this.Commentbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Commentbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Commentbtn.ForeColor = System.Drawing.Color.OldLace;
            this.Commentbtn.Location = new System.Drawing.Point(1146, 166);
            this.Commentbtn.Margin = new System.Windows.Forms.Padding(2);
            this.Commentbtn.Name = "Commentbtn";
            this.Commentbtn.Size = new System.Drawing.Size(117, 28);
            this.Commentbtn.TabIndex = 22;
            this.Commentbtn.Text = "COMMENTS";
            this.Commentbtn.UseVisualStyleBackColor = false;
            this.Commentbtn.Click += new System.EventHandler(this.Commentbtn_Click);
            // 
            // Members
            // 
            this.Members.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(105)))), ((int)(((byte)(203)))));
            this.Members.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(105)))), ((int)(((byte)(203)))));
            this.Members.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Members.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Members.ForeColor = System.Drawing.Color.OldLace;
            this.Members.Location = new System.Drawing.Point(999, 40);
            this.Members.Margin = new System.Windows.Forms.Padding(2);
            this.Members.Name = "Members";
            this.Members.Size = new System.Drawing.Size(117, 28);
            this.Members.TabIndex = 23;
            this.Members.Text = "?";
            this.Members.UseVisualStyleBackColor = false;
            this.Members.Click += new System.EventHandler(this.Members_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1275, 598);
            this.Controls.Add(this.booksIDListBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.borrowerListBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ratingListBox);
            this.Controls.Add(this.rating);
            this.Controls.Add(this.availListBox);
            this.Controls.Add(this.booksListBox);
            this.Controls.Add(this.authorsListBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library Hub";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Button Returnbtn;
        private System.Windows.Forms.Button borrowedbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ListBox authorsListBox;
        public System.Windows.Forms.ListBox booksListBox;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.ListBox availListBox;
        private System.Windows.Forms.Button ClearBooks;
        private System.Windows.Forms.Label rating;
        public System.Windows.Forms.ListBox ratingListBox;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.ListBox borrowerListBox;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.ListBox booksIDListBox;
        private System.Windows.Forms.Button Commentbtn;
        private System.Windows.Forms.Button Members;
    }
}

