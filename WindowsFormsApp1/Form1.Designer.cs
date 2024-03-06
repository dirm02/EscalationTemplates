namespace WindowsFormsApp1
{
    partial class Escalation
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
            this.COPY = new System.Windows.Forms.Button();
            this.Q1 = new System.Windows.Forms.Label();
            this.Tb1 = new System.Windows.Forms.TextBox();
            this.Q2 = new System.Windows.Forms.Label();
            this.Q3 = new System.Windows.Forms.Label();
            this.Q4 = new System.Windows.Forms.Label();
            this.Q5 = new System.Windows.Forms.Label();
            this.Q6 = new System.Windows.Forms.Label();
            this.Q7 = new System.Windows.Forms.Label();
            this.Q8 = new System.Windows.Forms.Label();
            this.Q9 = new System.Windows.Forms.Label();
            this.Q10 = new System.Windows.Forms.Label();
            this.Tb2 = new System.Windows.Forms.TextBox();
            this.Valu1234 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.YN = new System.Windows.Forms.ComboBox();
            this.Q11 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.Q12 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.Q13 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.Q14 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.ERASE = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.P1st = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // COPY
            // 
            this.COPY.BackColor = System.Drawing.Color.LimeGreen;
            this.COPY.Location = new System.Drawing.Point(471, 12);
            this.COPY.Name = "COPY";
            this.COPY.Size = new System.Drawing.Size(131, 37);
            this.COPY.TabIndex = 1;
            this.COPY.Text = "COPY";
            this.COPY.UseVisualStyleBackColor = false;
            this.COPY.Click += new System.EventHandler(this.button2_Click);
            // 
            // Q1
            // 
            this.Q1.AutoSize = true;
            this.Q1.Location = new System.Drawing.Point(3, 70);
            this.Q1.Name = "Q1";
            this.Q1.Size = new System.Drawing.Size(120, 13);
            this.Q1.TabIndex = 5;
            this.Q1.Text = "Site Number / Location:";
            this.Q1.Click += new System.EventHandler(this.Q1_Click);
            // 
            // Tb1
            // 
            this.Tb1.Location = new System.Drawing.Point(151, 63);
            this.Tb1.Name = "Tb1";
            this.Tb1.Size = new System.Drawing.Size(166, 20);
            this.Tb1.TabIndex = 6;
            this.Tb1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Q2
            // 
            this.Q2.AutoSize = true;
            this.Q2.Location = new System.Drawing.Point(3, 96);
            this.Q2.Name = "Q2";
            this.Q2.Size = new System.Drawing.Size(71, 13);
            this.Q2.TabIndex = 7;
            this.Q2.Text = "Site Contact: ";
            // 
            // Q3
            // 
            this.Q3.AutoSize = true;
            this.Q3.Location = new System.Drawing.Point(3, 122);
            this.Q3.Name = "Q3";
            this.Q3.Size = new System.Drawing.Size(72, 13);
            this.Q3.TabIndex = 8;
            this.Q3.Text = "24 Hour Site: ";
            // 
            // Q4
            // 
            this.Q4.AutoSize = true;
            this.Q4.Location = new System.Drawing.Point(151, 122);
            this.Q4.Name = "Q4";
            this.Q4.Size = new System.Drawing.Size(115, 13);
            this.Q4.TabIndex = 9;
            this.Q4.Text = "Number of Pay Points: ";
            // 
            // Q5
            // 
            this.Q5.AutoSize = true;
            this.Q5.Location = new System.Drawing.Point(3, 149);
            this.Q5.Name = "Q5";
            this.Q5.Size = new System.Drawing.Size(110, 13);
            this.Q5.TabIndex = 10;
            this.Q5.Text = "Incident Description:  ";
            // 
            // Q6
            // 
            this.Q6.AutoSize = true;
            this.Q6.Location = new System.Drawing.Point(3, 173);
            this.Q6.Name = "Q6";
            this.Q6.Size = new System.Drawing.Size(80, 13);
            this.Q6.TabIndex = 11;
            this.Q6.Text = "Current Status: ";
            // 
            // Q7
            // 
            this.Q7.AutoSize = true;
            this.Q7.Location = new System.Drawing.Point(3, 206);
            this.Q7.Name = "Q7";
            this.Q7.Size = new System.Drawing.Size(87, 13);
            this.Q7.TabIndex = 12;
            this.Q7.Text = "Business Impact:";
            // 
            // Q8
            // 
            this.Q8.AutoSize = true;
            this.Q8.Location = new System.Drawing.Point(0, 256);
            this.Q8.Name = "Q8";
            this.Q8.Size = new System.Drawing.Size(61, 13);
            this.Q8.TabIndex = 13;
            this.Q8.Text = "Start Time: ";
            // 
            // Q9
            // 
            this.Q9.AutoSize = true;
            this.Q9.Location = new System.Drawing.Point(239, 256);
            this.Q9.Name = "Q9";
            this.Q9.Size = new System.Drawing.Size(55, 13);
            this.Q9.TabIndex = 14;
            this.Q9.Text = "End Time:";
            // 
            // Q10
            // 
            this.Q10.AutoSize = true;
            this.Q10.Location = new System.Drawing.Point(-2, 288);
            this.Q10.Name = "Q10";
            this.Q10.Size = new System.Drawing.Size(147, 13);
            this.Q10.TabIndex = 15;
            this.Q10.Text = "Total Incident Duration Time: ";
            // 
            // Tb2
            // 
            this.Tb2.Location = new System.Drawing.Point(151, 89);
            this.Tb2.Name = "Tb2";
            this.Tb2.Size = new System.Drawing.Size(166, 20);
            this.Tb2.TabIndex = 16;
            this.Tb2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Valu1234
            // 
            this.Valu1234.Location = new System.Drawing.Point(272, 115);
            this.Valu1234.Name = "Valu1234";
            this.Valu1234.Size = new System.Drawing.Size(61, 20);
            this.Valu1234.TabIndex = 18;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(151, 166);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(166, 20);
            this.textBox7.TabIndex = 20;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(151, 192);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(559, 50);
            this.textBox8.TabIndex = 21;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(154, 281);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(117, 20);
            this.textBox11.TabIndex = 24;
            this.textBox11.TextChanged += new System.EventHandler(this.textBox11_TextChanged);
            // 
            // YN
            // 
            this.YN.FormattingEnabled = true;
            this.YN.Location = new System.Drawing.Point(81, 116);
            this.YN.Name = "YN";
            this.YN.Size = new System.Drawing.Size(64, 21);
            this.YN.TabIndex = 25;
            this.YN.SelectedIndexChanged += new System.EventHandler(this.YN_SelectedIndexChanged);
            // 
            // Q11
            // 
            this.Q11.AutoSize = true;
            this.Q11.Location = new System.Drawing.Point(-2, 321);
            this.Q11.Name = "Q11";
            this.Q11.Size = new System.Drawing.Size(146, 13);
            this.Q11.TabIndex = 26;
            this.Q11.Text = " Reference Number CS/INC: ";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(154, 314);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(252, 20);
            this.textBox4.TabIndex = 27;
            // 
            // Q12
            // 
            this.Q12.AutoSize = true;
            this.Q12.Location = new System.Drawing.Point(-2, 353);
            this.Q12.Name = "Q12";
            this.Q12.Size = new System.Drawing.Size(115, 13);
            this.Q12.TabIndex = 28;
            this.Q12.Text = "Technician Assigned:  ";
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(124, 346);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(106, 20);
            this.textBox12.TabIndex = 29;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(81, 250);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(139, 20);
            this.dateTimePicker1.TabIndex = 30;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(303, 250);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(133, 20);
            this.dateTimePicker2.TabIndex = 31;
            // 
            // Q13
            // 
            this.Q13.AutoSize = true;
            this.Q13.Location = new System.Drawing.Point(239, 353);
            this.Q13.Name = "Q13";
            this.Q13.Size = new System.Drawing.Size(128, 13);
            this.Q13.TabIndex = 32;
            this.Q13.Text = " Second Level Assigned: ";
            this.Q13.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(373, 346);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(117, 20);
            this.textBox9.TabIndex = 33;
            // 
            // Q14
            // 
            this.Q14.AutoSize = true;
            this.Q14.Location = new System.Drawing.Point(0, 384);
            this.Q14.Name = "Q14";
            this.Q14.Size = new System.Drawing.Size(63, 13);
            this.Q14.TabIndex = 34;
            this.Q14.Text = "Chronology:";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(3, 417);
            this.textBox10.Multiline = true;
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(609, 165);
            this.textBox10.TabIndex = 35;
            // 
            // ERASE
            // 
            this.ERASE.BackColor = System.Drawing.Color.Red;
            this.ERASE.Location = new System.Drawing.Point(323, 12);
            this.ERASE.Name = "ERASE";
            this.ERASE.Size = new System.Drawing.Size(138, 37);
            this.ERASE.TabIndex = 36;
            this.ERASE.Text = "ERASE";
            this.ERASE.UseVisualStyleBackColor = false;
            this.ERASE.Click += new System.EventHandler(this.ERASE_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(151, 141);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(285, 21);
            this.comboBox1.TabIndex = 37;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // P1st
            // 
            this.P1st.FormattingEnabled = true;
            this.P1st.Location = new System.Drawing.Point(1, 12);
            this.P1st.Name = "P1st";
            this.P1st.Size = new System.Drawing.Size(129, 21);
            this.P1st.TabIndex = 38;
            // 
            // Escalation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(614, 585);
            this.Controls.Add(this.P1st);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.ERASE);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.Q14);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.Q13);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.Q12);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.Q11);
            this.Controls.Add(this.YN);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.Valu1234);
            this.Controls.Add(this.Tb2);
            this.Controls.Add(this.Q10);
            this.Controls.Add(this.Q9);
            this.Controls.Add(this.Q8);
            this.Controls.Add(this.Q7);
            this.Controls.Add(this.Q6);
            this.Controls.Add(this.Q5);
            this.Controls.Add(this.Q4);
            this.Controls.Add(this.Q3);
            this.Controls.Add(this.Q2);
            this.Controls.Add(this.Tb1);
            this.Controls.Add(this.Q1);
            this.Controls.Add(this.COPY);
            this.Name = "Escalation";
            this.Text = "P1 Escalation";
            this.Load += new System.EventHandler(this.Escalation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button COPY;
        private System.Windows.Forms.Label Q1;
        private System.Windows.Forms.TextBox Tb1;
        private System.Windows.Forms.Label Q2;
        private System.Windows.Forms.Label Q3;
        private System.Windows.Forms.Label Q4;
        private System.Windows.Forms.Label Q5;
        private System.Windows.Forms.Label Q6;
        private System.Windows.Forms.Label Q7;
        private System.Windows.Forms.Label Q8;
        private System.Windows.Forms.Label Q9;
        private System.Windows.Forms.Label Q10;
        private System.Windows.Forms.TextBox Tb2;
        private System.Windows.Forms.TextBox Valu1234;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.ComboBox YN;
        private System.Windows.Forms.Label Q11;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label Q12;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label Q13;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label Q14;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Button ERASE;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox P1st;
    }
}

