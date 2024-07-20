namespace LIBRARY_SYSTEM_FINALS
{
    partial class Borrow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Borrow));
            this.buttonborrow = new System.Windows.Forms.Button();
            this.borrowerNamety = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBookPicker = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonborrow
            // 
            this.buttonborrow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(105)))), ((int)(((byte)(203)))));
            this.buttonborrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonborrow.FlatAppearance.BorderSize = 0;
            this.buttonborrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonborrow.ForeColor = System.Drawing.Color.White;
            this.buttonborrow.Location = new System.Drawing.Point(269, 261);
            this.buttonborrow.Name = "buttonborrow";
            this.buttonborrow.Size = new System.Drawing.Size(106, 27);
            this.buttonborrow.TabIndex = 14;
            this.buttonborrow.Text = "BORROW";
            this.buttonborrow.UseVisualStyleBackColor = false;
            this.buttonborrow.Click += new System.EventHandler(this.buttonborrow_Click);
            // 
            // borrowerNamety
            // 
            this.borrowerNamety.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(132)))), ((int)(((byte)(211)))));
            this.borrowerNamety.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.borrowerNamety.Location = new System.Drawing.Point(236, 210);
            this.borrowerNamety.Multiline = true;
            this.borrowerNamety.Name = "borrowerNamety";
            this.borrowerNamety.Size = new System.Drawing.Size(198, 19);
            this.borrowerNamety.TabIndex = 13;
            this.borrowerNamety.TextChanged += new System.EventHandler(this.borrowerNamety_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 25.8F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(240, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 40);
            this.label1.TabIndex = 15;
            this.label1.Text = "BORROW";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(260, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 21);
            this.label2.TabIndex = 16;
            this.label2.Text = "LIBRARY HUB";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(164, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 21);
            this.label3.TabIndex = 17;
            this.label3.Text = "BOOK:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(37, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 21);
            this.label4.TabIndex = 18;
            this.label4.Text = "BORROWER\'S NAME:";
            // 
            // comboBookPicker
            // 
            this.comboBookPicker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(132)))), ((int)(((byte)(211)))));
            this.comboBookPicker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBookPicker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBookPicker.FormattingEnabled = true;
            this.comboBookPicker.Location = new System.Drawing.Point(236, 146);
            this.comboBookPicker.Name = "comboBookPicker";
            this.comboBookPicker.Size = new System.Drawing.Size(198, 21);
            this.comboBookPicker.TabIndex = 19;
            this.comboBookPicker.SelectedIndexChanged += new System.EventHandler(this.comboBookPicker_SelectedIndexChanged);
            // 
            // Borrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(151)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(624, 321);
            this.Controls.Add(this.comboBookPicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonborrow);
            this.Controls.Add(this.borrowerNamety);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Borrow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Borrow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonborrow;
        private System.Windows.Forms.TextBox borrowerNamety;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBookPicker;
        private System.Windows.Forms.TextBox bookborrowty;

    }
}