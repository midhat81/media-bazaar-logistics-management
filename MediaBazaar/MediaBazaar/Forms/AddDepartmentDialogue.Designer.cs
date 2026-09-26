namespace MediaBazaar.Forms
{
    partial class AddDepartmentDialogue
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
            btnRemove = new CustomButton();
            btnSave = new CustomButton();
            btnAdd = new CustomButton();
            nUDNumber = new NumericUpDown();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tbPointOfContact = new TextBox();
            tbDescription = new RichTextBox();
            tbName = new TextBox();
            listboxAdded = new ListBox();
            listboxRole = new ListBox();
            lblErrorHandling = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nUDNumber).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lblErrorHandling);
            panel1.Controls.Add(btnRemove);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(nUDNumber);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(tbPointOfContact);
            panel1.Controls.Add(tbDescription);
            panel1.Controls.Add(tbName);
            panel1.Controls.Add(listboxAdded);
            panel1.Controls.Add(listboxRole);
            panel1.Location = new Point(20, 16);
            panel1.Name = "panel1";
            panel1.Size = new Size(1056, 604);
            panel1.TabIndex = 0;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.FromArgb(255, 145, 10);
            btnRemove.BackgroundColor = Color.FromArgb(255, 145, 10);
            btnRemove.BorderColor = Color.FromArgb(255, 248, 240);
            btnRemove.BorderRadius = 15;
            btnRemove.BorderSize = 3;
            btnRemove.FlatStyle = FlatStyle.Flat;
            btnRemove.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnRemove.ForeColor = Color.White;
            btnRemove.Location = new Point(896, 408);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(132, 40);
            btnRemove.TabIndex = 11;
            btnRemove.Text = "Remove";
            btnRemove.TextColor = Color.White;
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.DarkOrange;
            btnSave.BackgroundColor = Color.DarkOrange;
            btnSave.BorderColor = Color.FromArgb(255, 248, 240);
            btnSave.BorderRadius = 15;
            btnSave.BorderSize = 3;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(816, 532);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(150, 40);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.TextColor = Color.White;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(255, 145, 10);
            btnAdd.BackgroundColor = Color.FromArgb(255, 145, 10);
            btnAdd.BorderColor = Color.FromArgb(255, 248, 240);
            btnAdd.BorderRadius = 15;
            btnAdd.BorderSize = 3;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(292, 408);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(132, 40);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Add";
            btnAdd.TextColor = Color.White;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // nUDNumber
            // 
            nUDNumber.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            nUDNumber.Location = new Point(304, 288);
            nUDNumber.Name = "nUDNumber";
            nUDNumber.Size = new Size(120, 27);
            nUDNumber.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label3.Location = new Point(60, 156);
            label3.Name = "label3";
            label3.Size = new Size(40, 20);
            label3.TabIndex = 7;
            label3.Text = "PoC:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label2.Location = new Point(28, 60);
            label2.Name = "label2";
            label2.Size = new Size(93, 20);
            label2.TabIndex = 6;
            label2.Text = "Description:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label1.Location = new Point(64, 32);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 5;
            label1.Text = "Name:";
            // 
            // tbPointOfContact
            // 
            tbPointOfContact.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            tbPointOfContact.Location = new Point(148, 156);
            tbPointOfContact.Name = "tbPointOfContact";
            tbPointOfContact.Size = new Size(292, 27);
            tbPointOfContact.TabIndex = 4;
            // 
            // tbDescription
            // 
            tbDescription.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            tbDescription.Location = new Point(148, 56);
            tbDescription.Name = "tbDescription";
            tbDescription.Size = new Size(292, 96);
            tbDescription.TabIndex = 3;
            tbDescription.Text = "";
            // 
            // tbName
            // 
            tbName.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            tbName.Location = new Point(148, 28);
            tbName.Name = "tbName";
            tbName.Size = new Size(288, 27);
            tbName.TabIndex = 2;
            // 
            // listboxAdded
            // 
            listboxAdded.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            listboxAdded.FormattingEnabled = true;
            listboxAdded.ItemHeight = 20;
            listboxAdded.Location = new Point(608, 252);
            listboxAdded.Name = "listboxAdded";
            listboxAdded.Size = new Size(268, 204);
            listboxAdded.TabIndex = 1;
            // 
            // listboxRole
            // 
            listboxRole.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            listboxRole.FormattingEnabled = true;
            listboxRole.ItemHeight = 20;
            listboxRole.Location = new Point(36, 256);
            listboxRole.Name = "listboxRole";
            listboxRole.Size = new Size(224, 204);
            listboxRole.TabIndex = 0;
            // 
            // lblErrorHandling
            // 
            lblErrorHandling.AutoSize = true;
            lblErrorHandling.ForeColor = Color.Red;
            lblErrorHandling.Location = new Point(648, 472);
            lblErrorHandling.Name = "lblErrorHandling";
            lblErrorHandling.Size = new Size(0, 15);
            lblErrorHandling.TabIndex = 12;
            // 
            // AddDepartmentDialogue
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OrangeRed;
            ClientSize = new Size(1095, 637);
            Controls.Add(panel1);
            Name = "AddDepartmentDialogue";
            Text = "AddDepartmentDialogue";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nUDNumber).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private TextBox tbPointOfContact;
        private RichTextBox tbDescription;
        private TextBox tbName;
        private ListBox listboxAdded;
        private ListBox listboxRole;
        private CustomButton btnSave;
        private CustomButton btnAdd;
        private NumericUpDown nUDNumber;
        private Label label3;
        private CustomButton btnRemove;
        private Label lblErrorHandling;
    }
}