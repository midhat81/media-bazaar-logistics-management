namespace MediaBazaar.Forms
{
    partial class AddRoleDialogue
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
            tbName = new TextBox();
            label1 = new Label();
            createRoleBtn = new CustomButton();
            lblErrorHandling = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lblErrorHandling);
            panel1.Controls.Add(tbName);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(createRoleBtn);
            panel1.Location = new Point(32, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(436, 328);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // tbName
            // 
            tbName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbName.Location = new Point(124, 96);
            tbName.Name = "tbName";
            tbName.Size = new Size(272, 33);
            tbName.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(32, 100);
            label1.Name = "label1";
            label1.Size = new Size(69, 25);
            label1.TabIndex = 1;
            label1.Text = "Name:";
            // 
            // createRoleBtn
            // 
            createRoleBtn.BackColor = Color.DarkOrange;
            createRoleBtn.BackgroundColor = Color.DarkOrange;
            createRoleBtn.BorderColor = Color.White;
            createRoleBtn.BorderRadius = 15;
            createRoleBtn.BorderSize = 2;
            createRoleBtn.FlatStyle = FlatStyle.Flat;
            createRoleBtn.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createRoleBtn.ForeColor = Color.White;
            createRoleBtn.Location = new Point(124, 212);
            createRoleBtn.Name = "createRoleBtn";
            createRoleBtn.Size = new Size(188, 52);
            createRoleBtn.TabIndex = 0;
            createRoleBtn.Text = "Create Role";
            createRoleBtn.TextColor = Color.White;
            createRoleBtn.UseVisualStyleBackColor = false;
            createRoleBtn.Click += createRoleBtn_Click;
            // 
            // lblErrorHandling
            // 
            lblErrorHandling.AutoSize = true;
            lblErrorHandling.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblErrorHandling.ForeColor = Color.Red;
            lblErrorHandling.Location = new Point(84, 160);
            lblErrorHandling.Name = "lblErrorHandling";
            lblErrorHandling.Size = new Size(0, 20);
            lblErrorHandling.TabIndex = 3;
            // 
            // AddRoleDialogue
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OrangeRed;
            ClientSize = new Size(510, 377);
            Controls.Add(panel1);
            Name = "AddRoleDialogue";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox tbName;
        private Label label1;
        private CustomButton createRoleBtn;
        private Label lblErrorHandling;
    }
}