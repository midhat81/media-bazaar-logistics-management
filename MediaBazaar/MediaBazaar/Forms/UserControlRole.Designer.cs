namespace MediaBazaar
{
    partial class UserControlRole
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlRole));
            panelOperations = new Panel();
            pictureBoxSearch = new PictureBox();
            addRoleBtn = new CustomButton();
            textBoxSearch = new TextBox();
            userDataGridView = new DataGridView();
            groupBox1 = new GroupBox();
            removeRoleBtn = new CustomButton();
            label2 = new Label();
            editRoleBtn = new CustomButton();
            pictureBox2 = new PictureBox();
            employeeDetailsLabel = new Label();
            userPictureBox = new PictureBox();
            textBoxName = new TextBox();
            lblName = new Label();
            panelOperations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSearch).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userDataGridView).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userPictureBox).BeginInit();
            SuspendLayout();
            // 
            // panelOperations
            // 
            panelOperations.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelOperations.Controls.Add(pictureBoxSearch);
            panelOperations.Controls.Add(addRoleBtn);
            panelOperations.Controls.Add(textBoxSearch);
            panelOperations.Location = new Point(20, 66);
            panelOperations.Name = "panelOperations";
            panelOperations.Size = new Size(946, 57);
            panelOperations.TabIndex = 35;
            // 
            // pictureBoxSearch
            // 
            pictureBoxSearch.BackColor = Color.White;
            pictureBoxSearch.Cursor = Cursors.Hand;
            pictureBoxSearch.Image = Properties.Resources.search_icon;
            pictureBoxSearch.Location = new Point(506, 16);
            pictureBoxSearch.Margin = new Padding(3, 2, 3, 2);
            pictureBoxSearch.Name = "pictureBoxSearch";
            pictureBoxSearch.Size = new Size(41, 27);
            pictureBoxSearch.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxSearch.TabIndex = 19;
            pictureBoxSearch.TabStop = false;
            // 
            // addRoleBtn
            // 
            addRoleBtn.BackColor = Color.DarkOrange;
            addRoleBtn.BackgroundColor = Color.DarkOrange;
            addRoleBtn.BorderColor = Color.White;
            addRoleBtn.BorderRadius = 15;
            addRoleBtn.BorderSize = 2;
            addRoleBtn.Cursor = Cursors.Hand;
            addRoleBtn.FlatStyle = FlatStyle.Flat;
            addRoleBtn.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addRoleBtn.ForeColor = Color.White;
            addRoleBtn.Location = new Point(804, 3);
            addRoleBtn.Name = "addRoleBtn";
            addRoleBtn.Size = new Size(136, 50);
            addRoleBtn.TabIndex = 31;
            addRoleBtn.Text = "Add Role";
            addRoleBtn.TextColor = Color.White;
            addRoleBtn.UseVisualStyleBackColor = false;
            addRoleBtn.Click += addRoleBtn_Click;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Cursor = Cursors.IBeam;
            textBoxSearch.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            textBoxSearch.Location = new Point(13, 16);
            textBoxSearch.Margin = new Padding(3, 2, 3, 2);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(523, 27);
            textBoxSearch.TabIndex = 17;
            // 
            // userDataGridView
            // 
            userDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            userDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            userDataGridView.Location = new Point(20, 128);
            userDataGridView.Margin = new Padding(3, 2, 3, 2);
            userDataGridView.Name = "userDataGridView";
            userDataGridView.RowHeadersWidth = 51;
            userDataGridView.Size = new Size(1061, 564);
            userDataGridView.TabIndex = 34;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox1.BackColor = Color.OrangeRed;
            groupBox1.Controls.Add(removeRoleBtn);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(editRoleBtn);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(employeeDetailsLabel);
            groupBox1.Controls.Add(userPictureBox);
            groupBox1.Controls.Add(textBoxName);
            groupBox1.Controls.Add(lblName);
            groupBox1.Location = new Point(1100, 40);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(376, 653);
            groupBox1.TabIndex = 33;
            groupBox1.TabStop = false;
            // 
            // removeRoleBtn
            // 
            removeRoleBtn.BackColor = Color.DarkOrange;
            removeRoleBtn.BackgroundColor = Color.DarkOrange;
            removeRoleBtn.BorderColor = Color.White;
            removeRoleBtn.BorderRadius = 9;
            removeRoleBtn.BorderSize = 2;
            removeRoleBtn.Cursor = Cursors.Hand;
            removeRoleBtn.FlatStyle = FlatStyle.Flat;
            removeRoleBtn.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            removeRoleBtn.ForeColor = Color.White;
            removeRoleBtn.Location = new Point(48, 560);
            removeRoleBtn.Name = "removeRoleBtn";
            removeRoleBtn.Size = new Size(286, 50);
            removeRoleBtn.TabIndex = 34;
            removeRoleBtn.Text = "Remove Role";
            removeRoleBtn.TextColor = Color.White;
            removeRoleBtn.UseVisualStyleBackColor = false;
            removeRoleBtn.Click += removeRoleBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label2.Location = new Point(16, 224);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 33;
            // 
            // editRoleBtn
            // 
            editRoleBtn.BackColor = Color.DarkOrange;
            editRoleBtn.BackgroundColor = Color.DarkOrange;
            editRoleBtn.BorderColor = Color.White;
            editRoleBtn.BorderRadius = 9;
            editRoleBtn.BorderSize = 2;
            editRoleBtn.Cursor = Cursors.Hand;
            editRoleBtn.FlatStyle = FlatStyle.Flat;
            editRoleBtn.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editRoleBtn.ForeColor = Color.White;
            editRoleBtn.Location = new Point(48, 496);
            editRoleBtn.Name = "editRoleBtn";
            editRoleBtn.Size = new Size(286, 50);
            editRoleBtn.TabIndex = 29;
            editRoleBtn.Text = "Edit Role";
            editRoleBtn.TextColor = Color.White;
            editRoleBtn.UseVisualStyleBackColor = false;
            editRoleBtn.Click += this.editRoleBtn_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.DimGray;
            pictureBox2.Location = new Point(16, 92);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(330, 8);
            pictureBox2.TabIndex = 25;
            pictureBox2.TabStop = false;
            // 
            // employeeDetailsLabel
            // 
            employeeDetailsLabel.AutoSize = true;
            employeeDetailsLabel.BackColor = Color.Transparent;
            employeeDetailsLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            employeeDetailsLabel.ForeColor = Color.DimGray;
            employeeDetailsLabel.Location = new Point(16, 71);
            employeeDetailsLabel.Name = "employeeDetailsLabel";
            employeeDetailsLabel.Size = new Size(89, 21);
            employeeDetailsLabel.TabIndex = 26;
            employeeDetailsLabel.Text = "Role Detail";
            // 
            // userPictureBox
            // 
            userPictureBox.BackColor = Color.OrangeRed;
            userPictureBox.Image = (Image)resources.GetObject("userPictureBox.Image");
            userPictureBox.Location = new Point(8, 28);
            userPictureBox.Margin = new Padding(3, 2, 3, 2);
            userPictureBox.Name = "userPictureBox";
            userPictureBox.Size = new Size(115, 41);
            userPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            userPictureBox.TabIndex = 25;
            userPictureBox.TabStop = false;
            // 
            // textBoxName
            // 
            textBoxName.BackColor = SystemColors.ControlDark;
            textBoxName.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            textBoxName.Location = new Point(120, 212);
            textBoxName.Margin = new Padding(3, 2, 3, 2);
            textBoxName.Name = "textBoxName";
            textBoxName.ReadOnly = true;
            textBoxName.Size = new Size(232, 27);
            textBoxName.TabIndex = 18;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            lblName.Location = new Point(20, 213);
            lblName.Name = "lblName";
            lblName.Size = new Size(54, 20);
            lblName.TabIndex = 0;
            lblName.Text = "Name:";
            // 
            // UserControlRole
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelOperations);
            Controls.Add(userDataGridView);
            Controls.Add(groupBox1);
            Name = "UserControlRole";
            Size = new Size(1499, 730);
            panelOperations.ResumeLayout(false);
            panelOperations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSearch).EndInit();
            ((System.ComponentModel.ISupportInitialize)userDataGridView).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)userPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelOperations;
        private PictureBox pictureBoxSearch;
        private CustomButton addRoleBtn;
        private TextBox textBoxSearch;
        private DataGridView userDataGridView;
        private GroupBox groupBox1;
        private DateTimePicker dateTimePickerBirthday;
        private Label label5;
        private TextBox textBoxAddress;
        private Label label6;
        private TextBox textBoxPhone;
        private Label label4;
        private TextBox textBoxBSN;
        private Label label3;
        private Label label2;
        private ComboBox comboBoxRoleDetails;
        private CustomButton removeEmployeeBtn;
        private CustomButton resetPasswordBtn;
        private CustomButton editRoleBtn;
        private PictureBox pictureBox2;
        private Label employeeDetailsLabel;
        private PictureBox userPictureBox;
        private TextBox textBoxEmail;
        private TextBox textBoxName;
        private Label label1;
        private Label lblRole;
        private Label lblName;
        private CustomButton removeRoleBtn;
    }
}
