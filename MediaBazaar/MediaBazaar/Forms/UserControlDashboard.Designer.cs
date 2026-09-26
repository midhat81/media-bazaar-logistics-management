namespace MediaBazaar.Forms
{
    partial class UserControlDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlDashboard));
            userDataGridView = new DataGridView();
            groupBox1 = new GroupBox();
            dateTimePickerBirthday = new DateTimePicker();
            label5 = new Label();
            textBoxAddress = new TextBox();
            label6 = new Label();
            textBoxPhone = new TextBox();
            label4 = new Label();
            textBoxBSN = new TextBox();
            label3 = new Label();
            label2 = new Label();
            comboBoxRoleDetails = new ComboBox();
            removeEmployeeBtn = new CustomButton();
            resetPasswordBtn = new CustomButton();
            editEmployeeBtn = new CustomButton();
            pictureBox2 = new PictureBox();
            employeeDetailsLabel = new Label();
            userPictureBox = new PictureBox();
            textBoxEmail = new TextBox();
            textBoxName = new TextBox();
            label1 = new Label();
            lblRole = new Label();
            lblName = new Label();
            pictureBoxSearch = new PictureBox();
            comboBoxRole = new ComboBox();
            textBoxSearch = new TextBox();
            addEmployeeBtn = new CustomButton();
            panelOperations = new Panel();
            ((System.ComponentModel.ISupportInitialize)userDataGridView).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSearch).BeginInit();
            panelOperations.SuspendLayout();
            SuspendLayout();
            // 
            // userDataGridView
            // 
            userDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            userDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            userDataGridView.Location = new Point(41, 129);
            userDataGridView.Margin = new Padding(3, 2, 3, 2);
            userDataGridView.Name = "userDataGridView";
            userDataGridView.RowHeadersWidth = 51;
            userDataGridView.Size = new Size(1061, 564);
            userDataGridView.TabIndex = 22;
            userDataGridView.CellClick += userDataGridView_CellClick;
            userDataGridView.SelectionChanged += userDataGridView_SelectionChanged;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox1.BackColor = Color.OrangeRed;
            groupBox1.Controls.Add(dateTimePickerBirthday);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textBoxAddress);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(textBoxPhone);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBoxBSN);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(comboBoxRoleDetails);
            groupBox1.Controls.Add(removeEmployeeBtn);
            groupBox1.Controls.Add(resetPasswordBtn);
            groupBox1.Controls.Add(editEmployeeBtn);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(employeeDetailsLabel);
            groupBox1.Controls.Add(userPictureBox);
            groupBox1.Controls.Add(textBoxEmail);
            groupBox1.Controls.Add(textBoxName);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(lblRole);
            groupBox1.Controls.Add(lblName);
            groupBox1.Location = new Point(1123, 40);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(376, 653);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            // 
            // dateTimePickerBirthday
            // 
            dateTimePickerBirthday.Enabled = false;
            dateTimePickerBirthday.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            dateTimePickerBirthday.Format = DateTimePickerFormat.Short;
            dateTimePickerBirthday.Location = new Point(117, 320);
            dateTimePickerBirthday.Name = "dateTimePickerBirthday";
            dateTimePickerBirthday.Size = new Size(231, 27);
            dateTimePickerBirthday.TabIndex = 41;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label5.Location = new Point(16, 320);
            label5.Name = "label5";
            label5.Size = new Size(71, 20);
            label5.TabIndex = 39;
            label5.Text = "Birthday:";
            // 
            // textBoxAddress
            // 
            textBoxAddress.BackColor = SystemColors.ControlDark;
            textBoxAddress.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            textBoxAddress.Location = new Point(116, 351);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.ReadOnly = true;
            textBoxAddress.Size = new Size(232, 27);
            textBoxAddress.TabIndex = 38;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label6.Location = new Point(15, 353);
            label6.Name = "label6";
            label6.Size = new Size(67, 20);
            label6.TabIndex = 37;
            label6.Text = "Address:";
            // 
            // textBoxPhone
            // 
            textBoxPhone.BackColor = SystemColors.ControlDark;
            textBoxPhone.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            textBoxPhone.Location = new Point(117, 287);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.ReadOnly = true;
            textBoxPhone.Size = new Size(231, 27);
            textBoxPhone.TabIndex = 38;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(16, 290);
            label4.Name = "label4";
            label4.Size = new Size(105, 17);
            label4.TabIndex = 37;
            label4.Text = "Phone Number:";
            // 
            // textBoxBSN
            // 
            textBoxBSN.BackColor = SystemColors.ControlDark;
            textBoxBSN.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            textBoxBSN.Location = new Point(117, 258);
            textBoxBSN.Name = "textBoxBSN";
            textBoxBSN.ReadOnly = true;
            textBoxBSN.Size = new Size(231, 27);
            textBoxBSN.TabIndex = 36;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label3.Location = new Point(16, 258);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 35;
            label3.Text = "BSN:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label2.Location = new Point(16, 225);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 33;
            // 
            // comboBoxRoleDetails
            // 
            comboBoxRoleDetails.Cursor = Cursors.Hand;
            comboBoxRoleDetails.DropDownHeight = 108;
            comboBoxRoleDetails.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            comboBoxRoleDetails.FormattingEnabled = true;
            comboBoxRoleDetails.IntegralHeight = false;
            comboBoxRoleDetails.ItemHeight = 20;
            comboBoxRoleDetails.Items.AddRange(new object[] { "DepartmentManager", "HRManager", "SalesRepresentative", "SupportEmployee", "Cashier", "SecurityGuard", "DepotWorker" });
            comboBoxRoleDetails.Location = new Point(116, 156);
            comboBoxRoleDetails.Margin = new Padding(3, 2, 3, 2);
            comboBoxRoleDetails.Name = "comboBoxRoleDetails";
            comboBoxRoleDetails.Size = new Size(232, 28);
            comboBoxRoleDetails.TabIndex = 32;
            comboBoxRoleDetails.SelectedIndexChanged += comboBoxRoleDetails_SelectedIndexChanged;
            // 
            // removeEmployeeBtn
            // 
            removeEmployeeBtn.BackColor = Color.DarkOrange;
            removeEmployeeBtn.BackgroundColor = Color.DarkOrange;
            removeEmployeeBtn.BorderColor = Color.White;
            removeEmployeeBtn.BorderRadius = 10;
            removeEmployeeBtn.BorderSize = 2;
            removeEmployeeBtn.Cursor = Cursors.Hand;
            removeEmployeeBtn.FlatStyle = FlatStyle.Flat;
            removeEmployeeBtn.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            removeEmployeeBtn.ForeColor = Color.White;
            removeEmployeeBtn.Location = new Point(48, 560);
            removeEmployeeBtn.Name = "removeEmployeeBtn";
            removeEmployeeBtn.Size = new Size(286, 50);
            removeEmployeeBtn.TabIndex = 30;
            removeEmployeeBtn.Text = "Remove Employee";
            removeEmployeeBtn.TextColor = Color.White;
            removeEmployeeBtn.UseVisualStyleBackColor = false;
            removeEmployeeBtn.Click += removeEmployeeBtn_Click;
            // 
            // resetPasswordBtn
            // 
            resetPasswordBtn.BackColor = Color.DarkOrange;
            resetPasswordBtn.BackgroundColor = Color.DarkOrange;
            resetPasswordBtn.BorderColor = Color.White;
            resetPasswordBtn.BorderRadius = 9;
            resetPasswordBtn.BorderSize = 2;
            resetPasswordBtn.Cursor = Cursors.Hand;
            resetPasswordBtn.FlatStyle = FlatStyle.Flat;
            resetPasswordBtn.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            resetPasswordBtn.ForeColor = Color.White;
            resetPasswordBtn.Location = new Point(48, 496);
            resetPasswordBtn.Name = "resetPasswordBtn";
            resetPasswordBtn.Size = new Size(286, 50);
            resetPasswordBtn.TabIndex = 29;
            resetPasswordBtn.Text = "Reset Password";
            resetPasswordBtn.TextColor = Color.White;
            resetPasswordBtn.UseVisualStyleBackColor = false;
            resetPasswordBtn.Click += resetPasswordBtn_Click;
            // 
            // editEmployeeBtn
            // 
            editEmployeeBtn.BackColor = Color.DarkOrange;
            editEmployeeBtn.BackgroundColor = Color.DarkOrange;
            editEmployeeBtn.BorderColor = Color.White;
            editEmployeeBtn.BorderRadius = 9;
            editEmployeeBtn.BorderSize = 2;
            editEmployeeBtn.Cursor = Cursors.Hand;
            editEmployeeBtn.FlatStyle = FlatStyle.Flat;
            editEmployeeBtn.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editEmployeeBtn.ForeColor = Color.White;
            editEmployeeBtn.Location = new Point(48, 432);
            editEmployeeBtn.Name = "editEmployeeBtn";
            editEmployeeBtn.Size = new Size(286, 50);
            editEmployeeBtn.TabIndex = 29;
            editEmployeeBtn.Text = "Edit Employee";
            editEmployeeBtn.TextColor = Color.White;
            editEmployeeBtn.UseVisualStyleBackColor = false;
            editEmployeeBtn.Click += editEmployeeBtn_Click;
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
            employeeDetailsLabel.Location = new Point(16, 72);
            employeeDetailsLabel.Name = "employeeDetailsLabel";
            employeeDetailsLabel.Size = new Size(134, 21);
            employeeDetailsLabel.TabIndex = 26;
            employeeDetailsLabel.Text = "Employee details";
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
            // textBoxEmail
            // 
            textBoxEmail.BackColor = SystemColors.ControlDark;
            textBoxEmail.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            textBoxEmail.Location = new Point(117, 191);
            textBoxEmail.Margin = new Padding(3, 2, 3, 2);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.ReadOnly = true;
            textBoxEmail.Size = new Size(231, 27);
            textBoxEmail.TabIndex = 20;
            // 
            // textBoxName
            // 
            textBoxName.BackColor = SystemColors.ControlDark;
            textBoxName.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            textBoxName.Location = new Point(116, 120);
            textBoxName.Margin = new Padding(3, 2, 3, 2);
            textBoxName.Name = "textBoxName";
            textBoxName.ReadOnly = true;
            textBoxName.Size = new Size(232, 27);
            textBoxName.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label1.Location = new Point(16, 191);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 17;
            label1.Text = "Email:";
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            lblRole.Location = new Point(16, 156);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(43, 20);
            lblRole.TabIndex = 2;
            lblRole.Text = "Role:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            lblName.Location = new Point(16, 122);
            lblName.Name = "lblName";
            lblName.Size = new Size(54, 20);
            lblName.TabIndex = 0;
            lblName.Text = "Name:";
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
            pictureBoxSearch.Click += pictureBoxSearch_Click;
            // 
            // comboBoxRole
            // 
            comboBoxRole.Cursor = Cursors.Hand;
            comboBoxRole.DropDownHeight = 108;
            comboBoxRole.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBoxRole.FormattingEnabled = true;
            comboBoxRole.IntegralHeight = false;
            comboBoxRole.ItemHeight = 20;
            comboBoxRole.Items.AddRange(new object[] { "Any Role", "DepartmentManager", "HRManager", "SalesRepresentative", "SupportEmployee", "Cashier", "SecurityGuard", "DepotWorker" });
            comboBoxRole.Location = new Point(553, 16);
            comboBoxRole.Margin = new Padding(3, 2, 3, 2);
            comboBoxRole.Name = "comboBoxRole";
            comboBoxRole.Size = new Size(245, 28);
            comboBoxRole.TabIndex = 18;
            comboBoxRole.Text = "Choose Role";
            comboBoxRole.SelectedIndexChanged += comboBoxRole_SelectedIndexChanged;
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
            textBoxSearch.KeyDown += textBoxSearch_KeyDown;
            textBoxSearch.KeyPress += textBoxSearch_KeyPress;
            // 
            // addEmployeeBtn
            // 
            addEmployeeBtn.BackColor = Color.DarkOrange;
            addEmployeeBtn.BackgroundColor = Color.DarkOrange;
            addEmployeeBtn.BorderColor = Color.White;
            addEmployeeBtn.BorderRadius = 15;
            addEmployeeBtn.BorderSize = 2;
            addEmployeeBtn.Cursor = Cursors.Hand;
            addEmployeeBtn.FlatStyle = FlatStyle.Flat;
            addEmployeeBtn.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addEmployeeBtn.ForeColor = Color.White;
            addEmployeeBtn.Location = new Point(804, 3);
            addEmployeeBtn.Name = "addEmployeeBtn";
            addEmployeeBtn.Size = new Size(136, 50);
            addEmployeeBtn.TabIndex = 31;
            addEmployeeBtn.Text = "Add Employee";
            addEmployeeBtn.TextColor = Color.White;
            addEmployeeBtn.UseVisualStyleBackColor = false;
            addEmployeeBtn.Click += addEmployeeBtn_Click;
            // 
            // panelOperations
            // 
            panelOperations.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelOperations.Controls.Add(pictureBoxSearch);
            panelOperations.Controls.Add(addEmployeeBtn);
            panelOperations.Controls.Add(comboBoxRole);
            panelOperations.Controls.Add(textBoxSearch);
            panelOperations.Location = new Point(41, 67);
            panelOperations.Name = "panelOperations";
            panelOperations.Size = new Size(946, 57);
            panelOperations.TabIndex = 32;
            // 
            // UserControlDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelOperations);
            Controls.Add(userDataGridView);
            Controls.Add(groupBox1);
            Cursor = Cursors.Hand;
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "UserControlDashboard";
            Size = new Size(1499, 730);
            ((System.ComponentModel.ISupportInitialize)userDataGridView).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)userPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSearch).EndInit();
            panelOperations.ResumeLayout(false);
            panelOperations.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView userDataGridView;
        private GroupBox groupBox1;
        private PictureBox pictureBox2;
        private Label employeeDetailsLabel;
        private PictureBox userPictureBox;
        private TextBox textBoxEmail;
        private TextBox textBoxName;
        private Label label1;
        private Label lblRole;
        private Label lblName;
        private PictureBox pictureBoxSearch;
        private ComboBox comboBoxRole;
        private TextBox textBoxSearch;
        private CustomButton removeEmployeeBtn;
        private CustomButton editEmployeeBtn;
        private CustomButton addEmployeeBtn;
        private ComboBox comboBoxRoleDetails;
        private TextBox textBoxBSN;
        private Label label3;
        private Label label2;
        private TextBox textBoxPhone;
        private Label label4;
        private Label label5;
        private DateTimePicker dateTimePickerBirthday;
        private TextBox textBoxAddress;
        private Label label6;
        private Panel panelOperations;
        private CustomButton resetPasswordBtn;
    }
}
