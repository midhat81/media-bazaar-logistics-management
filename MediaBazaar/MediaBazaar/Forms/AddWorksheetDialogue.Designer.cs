namespace MediaBazaar.Forms
{
    partial class AddWorksheetDialogue
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
            panel1 = new Panel();
            comboBoxEmployee = new ComboBox();
            comboBoxTimeSlot = new ComboBox();
            textBoxWeekNumber = new TextBox();
            btnSubmit = new CustomButton();
            comboBoxWeekDay = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(comboBoxEmployee);
            panel1.Controls.Add(comboBoxTimeSlot);
            panel1.Controls.Add(textBoxWeekNumber);
            panel1.Controls.Add(btnSubmit);
            panel1.Controls.Add(comboBoxWeekDay);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(83, 37);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(883, 470);
            panel1.TabIndex = 0;
            // 
            // comboBoxEmployee
            // 
            comboBoxEmployee.Font = new Font("Segoe UI", 12F);
            comboBoxEmployee.FormattingEnabled = true;
            comboBoxEmployee.Location = new Point(64, 258);
            comboBoxEmployee.Margin = new Padding(4, 5, 4, 5);
            comboBoxEmployee.Name = "comboBoxEmployee";
            comboBoxEmployee.Size = new Size(335, 40);
            comboBoxEmployee.TabIndex = 28;
            // 
            // comboBoxTimeSlot
            // 
            comboBoxTimeSlot.Font = new Font("Segoe UI", 12F);
            comboBoxTimeSlot.FormattingEnabled = true;
            comboBoxTimeSlot.Items.AddRange(new object[] { "Morning", "Afternoon", "Evening" });
            comboBoxTimeSlot.Location = new Point(64, 147);
            comboBoxTimeSlot.Margin = new Padding(4, 3, 4, 3);
            comboBoxTimeSlot.Name = "comboBoxTimeSlot";
            comboBoxTimeSlot.Size = new Size(335, 40);
            comboBoxTimeSlot.TabIndex = 27;
            // 
            // textBoxWeekNumber
            // 
            textBoxWeekNumber.Font = new Font("Segoe UI", 12F);
            textBoxWeekNumber.Location = new Point(519, 258);
            textBoxWeekNumber.Margin = new Padding(4, 5, 4, 5);
            textBoxWeekNumber.Name = "textBoxWeekNumber";
            textBoxWeekNumber.Size = new Size(293, 39);
            textBoxWeekNumber.TabIndex = 26;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.DarkOrange;
            btnSubmit.BackgroundColor = Color.DarkOrange;
            btnSubmit.BorderColor = Color.White;
            btnSubmit.BorderRadius = 15;
            btnSubmit.BorderSize = 1;
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(354, 377);
            btnSubmit.Margin = new Padding(4, 5, 4, 5);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(156, 68);
            btnSubmit.TabIndex = 23;
            btnSubmit.Text = "Submit";
            btnSubmit.TextColor = Color.White;
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // comboBoxWeekDay
            // 
            comboBoxWeekDay.Font = new Font("Segoe UI", 12F);
            comboBoxWeekDay.FormattingEnabled = true;
            comboBoxWeekDay.Items.AddRange(new object[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" });
            comboBoxWeekDay.Location = new Point(519, 147);
            comboBoxWeekDay.Margin = new Padding(4, 3, 4, 3);
            comboBoxWeekDay.Name = "comboBoxWeekDay";
            comboBoxWeekDay.Size = new Size(293, 40);
            comboBoxWeekDay.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(519, 228);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(129, 25);
            label5.TabIndex = 13;
            label5.Text = "Week Number:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(519, 117);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(90, 25);
            label4.TabIndex = 12;
            label4.Text = "WeekDay:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(64, 228);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(94, 25);
            label3.TabIndex = 11;
            label3.Text = "Employee:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 117);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(90, 25);
            label2.TabIndex = 10;
            label2.Text = "Time Slot:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(313, 45);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(264, 38);
            label1.TabIndex = 0;
            label1.Text = "Worksheet Details:";
            // 
            // AddWorksheetDialogue
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OrangeRed;
            ClientSize = new Size(1074, 572);
            Controls.Add(panel1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "AddWorksheetDialogue";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AddWorksheetDialogue";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label3;
        private Label label2;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label4;
        private Label label5;
        private Label label7;
        private TextBox textBox5;
        private ComboBox comboBoxWeekDay;
        private CustomButton btnSubmit;
        private TextBox textBoxWeekNumber;
        private TextBox textBox4;
        private ComboBox comboBoxTimeSlot;
        private ComboBox comboBoxEmployee;
    }
}