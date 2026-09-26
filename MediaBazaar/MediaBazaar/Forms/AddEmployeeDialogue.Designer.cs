namespace MediaBazaar.Forms
{
	partial class AddEmployeeForm
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

        private void InitializeComponent()
        {
            addEmployeeTabControl = new TabControl();
            employeeContractTab = new TabPage();
            label5 = new Label();
            nextBtnP1 = new CustomButton();
            label4 = new Label();
            contractStartDatePicker = new DateTimePicker();
            contractWeeklyHoursTextBox = new TextBox();
            label3 = new Label();
            contractHourlyWageTextBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            contractEmpRoleComboBox = new ComboBox();
            employeeEmergencyDetailsTab = new TabPage();
            label6 = new Label();
            previousBtnP2 = new CustomButton();
            nextBtnP2 = new CustomButton();
            emcLastNameBox = new TextBox();
            emcFirstNameBox = new TextBox();
            emcEmailBox = new TextBox();
            emcPhoneText = new TextBox();
            emcEmail = new Label();
            emcPhoneNum = new Label();
            emcLastName = new Label();
            emcFirstName = new Label();
            employeeDetailsTab = new TabPage();
            phoneText = new TextBox();
            phoneNumLabel = new Label();
            addressLabel = new Label();
            addressText = new TextBox();
            label7 = new Label();
            previousBtnP3 = new CustomButton();
            completeFormBtn = new CustomButton();
            lastNameText = new TextBox();
            firstNameText = new TextBox();
            emailText = new TextBox();
            passwordText = new TextBox();
            bsnText = new TextBox();
            birthdayDatePicker = new DateTimePicker();
            personalBirthday = new Label();
            personalBsn = new Label();
            personalPassword = new Label();
            personalEmail = new Label();
            personalLastName = new Label();
            personalFirstName = new Label();
            label8 = new Label();
            cbDepartment = new ComboBox();
            addEmployeeTabControl.SuspendLayout();
            employeeContractTab.SuspendLayout();
            employeeEmergencyDetailsTab.SuspendLayout();
            employeeDetailsTab.SuspendLayout();
            SuspendLayout();
            // 
            // addEmployeeTabControl
            // 
            addEmployeeTabControl.Anchor = AnchorStyles.Top;
            addEmployeeTabControl.Controls.Add(employeeContractTab);
            addEmployeeTabControl.Controls.Add(employeeEmergencyDetailsTab);
            addEmployeeTabControl.Controls.Add(employeeDetailsTab);
            addEmployeeTabControl.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addEmployeeTabControl.ItemSize = new Size(30, 30);
            addEmployeeTabControl.Location = new Point(18, 12);
            addEmployeeTabControl.Name = "addEmployeeTabControl";
            addEmployeeTabControl.SelectedIndex = 0;
            addEmployeeTabControl.Size = new Size(493, 455);
            addEmployeeTabControl.TabIndex = 0;
            addEmployeeTabControl.Tag = "";
            // 
            // employeeContractTab
            // 
            employeeContractTab.BackColor = Color.White;
            employeeContractTab.Controls.Add(label8);
            employeeContractTab.Controls.Add(cbDepartment);
            employeeContractTab.Controls.Add(label5);
            employeeContractTab.Controls.Add(nextBtnP1);
            employeeContractTab.Controls.Add(label4);
            employeeContractTab.Controls.Add(contractStartDatePicker);
            employeeContractTab.Controls.Add(contractWeeklyHoursTextBox);
            employeeContractTab.Controls.Add(label3);
            employeeContractTab.Controls.Add(contractHourlyWageTextBox);
            employeeContractTab.Controls.Add(label2);
            employeeContractTab.Controls.Add(label1);
            employeeContractTab.Controls.Add(contractEmpRoleComboBox);
            employeeContractTab.Location = new Point(4, 34);
            employeeContractTab.Name = "employeeContractTab";
            employeeContractTab.Padding = new Padding(3);
            employeeContractTab.Size = new Size(485, 417);
            employeeContractTab.TabIndex = 0;
            employeeContractTab.Text = "📝 Contract Details";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F);
            label5.Location = new Point(124, 14);
            label5.Name = "label5";
            label5.Size = new Size(223, 32);
            label5.TabIndex = 9;
            label5.Text = "Contract Details 📝";
            // 
            // nextBtnP1
            // 
            nextBtnP1.BackColor = Color.DarkOrange;
            nextBtnP1.BackgroundColor = Color.DarkOrange;
            nextBtnP1.BorderColor = Color.White;
            nextBtnP1.BorderRadius = 15;
            nextBtnP1.BorderSize = 1;
            nextBtnP1.FlatStyle = FlatStyle.Flat;
            nextBtnP1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            nextBtnP1.ForeColor = Color.White;
            nextBtnP1.Location = new Point(376, 386);
            nextBtnP1.Name = "nextBtnP1";
            nextBtnP1.Size = new Size(106, 41);
            nextBtnP1.TabIndex = 8;
            nextBtnP1.Text = "Next ➜";
            nextBtnP1.TextColor = Color.White;
            nextBtnP1.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F);
            label4.Location = new Point(71, 116);
            label4.Name = "label4";
            label4.Size = new Size(94, 25);
            label4.TabIndex = 7;
            label4.Text = "Start Date";
            // 
            // contractStartDatePicker
            // 
            contractStartDatePicker.CalendarFont = new Font("Segoe UI", 12F);
            contractStartDatePicker.Format = DateTimePickerFormat.Short;
            contractStartDatePicker.Location = new Point(51, 154);
            contractStartDatePicker.Name = "contractStartDatePicker";
            contractStartDatePicker.Size = new Size(148, 27);
            contractStartDatePicker.TabIndex = 6;
            // 
            // contractWeeklyHoursTextBox
            // 
            contractWeeklyHoursTextBox.Font = new Font("Segoe UI", 12F);
            contractWeeklyHoursTextBox.Location = new Point(51, 260);
            contractWeeklyHoursTextBox.Name = "contractWeeklyHoursTextBox";
            contractWeeklyHoursTextBox.Size = new Size(148, 29);
            contractWeeklyHoursTextBox.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F);
            label3.Location = new Point(60, 220);
            label3.Name = "label3";
            label3.Size = new Size(127, 25);
            label3.TabIndex = 4;
            label3.Text = "Weekly Hours";
            // 
            // contractHourlyWageTextBox
            // 
            contractHourlyWageTextBox.Font = new Font("Segoe UI", 12F);
            contractHourlyWageTextBox.Location = new Point(258, 260);
            contractHourlyWageTextBox.Name = "contractHourlyWageTextBox";
            contractHourlyWageTextBox.Size = new Size(177, 29);
            contractHourlyWageTextBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F);
            label2.Location = new Point(275, 220);
            label2.Name = "label2";
            label2.Size = new Size(121, 25);
            label2.TabIndex = 2;
            label2.Text = "Hourly Wage";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F);
            label1.Location = new Point(275, 116);
            label1.Name = "label1";
            label1.Size = new Size(135, 25);
            label1.TabIndex = 1;
            label1.Text = "Employee Role";
            // 
            // contractEmpRoleComboBox
            // 
            contractEmpRoleComboBox.Font = new Font("Segoe UI", 12F);
            contractEmpRoleComboBox.FormattingEnabled = true;
            contractEmpRoleComboBox.Location = new Point(258, 154);
            contractEmpRoleComboBox.Name = "contractEmpRoleComboBox";
            contractEmpRoleComboBox.Size = new Size(177, 29);
            contractEmpRoleComboBox.TabIndex = 0;
            // 
            // employeeEmergencyDetailsTab
            // 
            employeeEmergencyDetailsTab.BackColor = Color.White;
            employeeEmergencyDetailsTab.Controls.Add(label6);
            employeeEmergencyDetailsTab.Controls.Add(previousBtnP2);
            employeeEmergencyDetailsTab.Controls.Add(nextBtnP2);
            employeeEmergencyDetailsTab.Controls.Add(emcLastNameBox);
            employeeEmergencyDetailsTab.Controls.Add(emcFirstNameBox);
            employeeEmergencyDetailsTab.Controls.Add(emcEmailBox);
            employeeEmergencyDetailsTab.Controls.Add(emcPhoneText);
            employeeEmergencyDetailsTab.Controls.Add(emcEmail);
            employeeEmergencyDetailsTab.Controls.Add(emcPhoneNum);
            employeeEmergencyDetailsTab.Controls.Add(emcLastName);
            employeeEmergencyDetailsTab.Controls.Add(emcFirstName);
            employeeEmergencyDetailsTab.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            employeeEmergencyDetailsTab.Location = new Point(4, 34);
            employeeEmergencyDetailsTab.Name = "employeeEmergencyDetailsTab";
            employeeEmergencyDetailsTab.Padding = new Padding(3);
            employeeEmergencyDetailsTab.Size = new Size(485, 417);
            employeeEmergencyDetailsTab.TabIndex = 1;
            employeeEmergencyDetailsTab.Text = "🚑 Emergency Contact";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(114, 12);
            label6.Name = "label6";
            label6.Size = new Size(261, 32);
            label6.TabIndex = 10;
            label6.Text = "🚑 Emergency Contact";
            // 
            // previousBtnP2
            // 
            previousBtnP2.BackColor = Color.DarkOrange;
            previousBtnP2.BackgroundColor = Color.DarkOrange;
            previousBtnP2.BorderColor = Color.White;
            previousBtnP2.BorderRadius = 15;
            previousBtnP2.BorderSize = 1;
            previousBtnP2.FlatStyle = FlatStyle.Flat;
            previousBtnP2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            previousBtnP2.ForeColor = Color.White;
            previousBtnP2.Location = new Point(6, 386);
            previousBtnP2.Name = "previousBtnP2";
            previousBtnP2.Size = new Size(111, 40);
            previousBtnP2.TabIndex = 9;
            previousBtnP2.Text = "⬅️ Previous";
            previousBtnP2.TextColor = Color.White;
            previousBtnP2.UseVisualStyleBackColor = false;
            // 
            // nextBtnP2
            // 
            nextBtnP2.BackColor = Color.DarkOrange;
            nextBtnP2.BackgroundColor = Color.DarkOrange;
            nextBtnP2.BorderColor = Color.White;
            nextBtnP2.BorderRadius = 15;
            nextBtnP2.BorderSize = 1;
            nextBtnP2.FlatStyle = FlatStyle.Flat;
            nextBtnP2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nextBtnP2.ForeColor = Color.White;
            nextBtnP2.Location = new Point(370, 386);
            nextBtnP2.Name = "nextBtnP2";
            nextBtnP2.Size = new Size(111, 40);
            nextBtnP2.TabIndex = 8;
            nextBtnP2.Text = "Next ➜";
            nextBtnP2.TextColor = Color.White;
            nextBtnP2.UseVisualStyleBackColor = false;
            // 
            // emcLastNameBox
            // 
            emcLastNameBox.Font = new Font("Segoe UI", 15F);
            emcLastNameBox.Location = new Point(270, 151);
            emcLastNameBox.Name = "emcLastNameBox";
            emcLastNameBox.Size = new Size(154, 34);
            emcLastNameBox.TabIndex = 7;
            // 
            // emcFirstNameBox
            // 
            emcFirstNameBox.Font = new Font("Segoe UI", 15F);
            emcFirstNameBox.Location = new Point(42, 151);
            emcFirstNameBox.Name = "emcFirstNameBox";
            emcFirstNameBox.Size = new Size(154, 34);
            emcFirstNameBox.TabIndex = 6;
            // 
            // emcEmailBox
            // 
            emcEmailBox.Font = new Font("Segoe UI", 15F);
            emcEmailBox.Location = new Point(270, 265);
            emcEmailBox.Name = "emcEmailBox";
            emcEmailBox.Size = new Size(154, 34);
            emcEmailBox.TabIndex = 5;
            // 
            // emcPhoneText
            // 
            emcPhoneText.Font = new Font("Segoe UI", 15F);
            emcPhoneText.Location = new Point(42, 265);
            emcPhoneText.Name = "emcPhoneText";
            emcPhoneText.Size = new Size(154, 34);
            emcPhoneText.TabIndex = 4;
            // 
            // emcEmail
            // 
            emcEmail.AutoSize = true;
            emcEmail.Font = new Font("Segoe UI", 15F);
            emcEmail.Location = new Point(312, 220);
            emcEmail.Name = "emcEmail";
            emcEmail.Size = new Size(59, 28);
            emcEmail.TabIndex = 3;
            emcEmail.Text = "Email";
            // 
            // emcPhoneNum
            // 
            emcPhoneNum.AutoSize = true;
            emcPhoneNum.Font = new Font("Segoe UI", 15F);
            emcPhoneNum.Location = new Point(51, 220);
            emcPhoneNum.Name = "emcPhoneNum";
            emcPhoneNum.Size = new Size(144, 28);
            emcPhoneNum.TabIndex = 2;
            emcPhoneNum.Text = "Phone Number";
            // 
            // emcLastName
            // 
            emcLastName.AutoSize = true;
            emcLastName.Font = new Font("Segoe UI", 15F);
            emcLastName.Location = new Point(293, 108);
            emcLastName.Name = "emcLastName";
            emcLastName.Size = new Size(103, 28);
            emcLastName.TabIndex = 1;
            emcLastName.Text = "Last Name";
            // 
            // emcFirstName
            // 
            emcFirstName.AutoSize = true;
            emcFirstName.Font = new Font("Segoe UI", 15F);
            emcFirstName.Location = new Point(62, 108);
            emcFirstName.Name = "emcFirstName";
            emcFirstName.Size = new Size(106, 28);
            emcFirstName.TabIndex = 0;
            emcFirstName.Text = "First Name";
            // 
            // employeeDetailsTab
            // 
            employeeDetailsTab.BackColor = Color.White;
            employeeDetailsTab.Controls.Add(phoneText);
            employeeDetailsTab.Controls.Add(phoneNumLabel);
            employeeDetailsTab.Controls.Add(addressLabel);
            employeeDetailsTab.Controls.Add(addressText);
            employeeDetailsTab.Controls.Add(label7);
            employeeDetailsTab.Controls.Add(previousBtnP3);
            employeeDetailsTab.Controls.Add(completeFormBtn);
            employeeDetailsTab.Controls.Add(lastNameText);
            employeeDetailsTab.Controls.Add(firstNameText);
            employeeDetailsTab.Controls.Add(emailText);
            employeeDetailsTab.Controls.Add(passwordText);
            employeeDetailsTab.Controls.Add(bsnText);
            employeeDetailsTab.Controls.Add(birthdayDatePicker);
            employeeDetailsTab.Controls.Add(personalBirthday);
            employeeDetailsTab.Controls.Add(personalBsn);
            employeeDetailsTab.Controls.Add(personalPassword);
            employeeDetailsTab.Controls.Add(personalEmail);
            employeeDetailsTab.Controls.Add(personalLastName);
            employeeDetailsTab.Controls.Add(personalFirstName);
            employeeDetailsTab.Location = new Point(4, 34);
            employeeDetailsTab.Name = "employeeDetailsTab";
            employeeDetailsTab.Padding = new Padding(3);
            employeeDetailsTab.Size = new Size(485, 417);
            employeeDetailsTab.TabIndex = 2;
            employeeDetailsTab.Text = "👤 Personal Details";
            // 
            // phoneText
            // 
            phoneText.Font = new Font("Segoe UI", 15F);
            phoneText.Location = new Point(270, 311);
            phoneText.Name = "phoneText";
            phoneText.Size = new Size(184, 34);
            phoneText.TabIndex = 18;
            // 
            // phoneNumLabel
            // 
            phoneNumLabel.AutoSize = true;
            phoneNumLabel.Font = new Font("Microsoft Sans Serif", 12F);
            phoneNumLabel.Location = new Point(296, 285);
            phoneNumLabel.Name = "phoneNumLabel";
            phoneNumLabel.Size = new Size(55, 20);
            phoneNumLabel.TabIndex = 17;
            phoneNumLabel.Text = "Phone";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Font = new Font("Microsoft Sans Serif", 12F);
            addressLabel.Location = new Point(62, 285);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new Size(68, 20);
            addressLabel.TabIndex = 16;
            addressLabel.Text = "Address";
            // 
            // addressText
            // 
            addressText.Font = new Font("Segoe UI", 15F);
            addressText.Location = new Point(36, 311);
            addressText.Name = "addressText";
            addressText.Size = new Size(173, 34);
            addressText.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 18F);
            label7.Location = new Point(135, 15);
            label7.Name = "label7";
            label7.Size = new Size(217, 32);
            label7.TabIndex = 14;
            label7.Text = "👤 Personal Details";
            // 
            // previousBtnP3
            // 
            previousBtnP3.BackColor = Color.DarkOrange;
            previousBtnP3.BackgroundColor = Color.DarkOrange;
            previousBtnP3.BorderColor = Color.White;
            previousBtnP3.BorderRadius = 15;
            previousBtnP3.BorderSize = 1;
            previousBtnP3.FlatStyle = FlatStyle.Flat;
            previousBtnP3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            previousBtnP3.ForeColor = Color.White;
            previousBtnP3.Location = new Point(6, 392);
            previousBtnP3.Name = "previousBtnP3";
            previousBtnP3.Size = new Size(129, 34);
            previousBtnP3.TabIndex = 13;
            previousBtnP3.Text = "⬅️ Previous";
            previousBtnP3.TextColor = Color.White;
            previousBtnP3.UseVisualStyleBackColor = false;
            // 
            // completeFormBtn
            // 
            completeFormBtn.BackColor = Color.DarkOrange;
            completeFormBtn.BackgroundColor = Color.DarkOrange;
            completeFormBtn.BorderColor = Color.White;
            completeFormBtn.BorderRadius = 15;
            completeFormBtn.BorderSize = 1;
            completeFormBtn.FlatStyle = FlatStyle.Flat;
            completeFormBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            completeFormBtn.ForeColor = Color.White;
            completeFormBtn.Location = new Point(316, 389);
            completeFormBtn.Name = "completeFormBtn";
            completeFormBtn.Size = new Size(166, 37);
            completeFormBtn.TabIndex = 12;
            completeFormBtn.Text = "Complete Form";
            completeFormBtn.TextColor = Color.White;
            completeFormBtn.UseVisualStyleBackColor = false;
            completeFormBtn.Click += completeFormBtn_Click;
            // 
            // lastNameText
            // 
            lastNameText.Font = new Font("Segoe UI", 15F);
            lastNameText.Location = new Point(277, 90);
            lastNameText.Name = "lastNameText";
            lastNameText.Size = new Size(170, 34);
            lastNameText.TabIndex = 11;
            // 
            // firstNameText
            // 
            firstNameText.Font = new Font("Segoe UI", 15F);
            firstNameText.Location = new Point(36, 90);
            firstNameText.Name = "firstNameText";
            firstNameText.Size = new Size(173, 34);
            firstNameText.TabIndex = 10;
            // 
            // emailText
            // 
            emailText.Font = new Font("Segoe UI", 15F);
            emailText.Location = new Point(36, 164);
            emailText.Name = "emailText";
            emailText.Size = new Size(173, 34);
            emailText.TabIndex = 9;
            // 
            // passwordText
            // 
            passwordText.Font = new Font("Segoe UI", 15F);
            passwordText.Location = new Point(270, 164);
            passwordText.Name = "passwordText";
            passwordText.PasswordChar = '*';
            passwordText.Size = new Size(177, 34);
            passwordText.TabIndex = 8;
            // 
            // bsnText
            // 
            bsnText.Font = new Font("Segoe UI", 15F);
            bsnText.Location = new Point(36, 245);
            bsnText.Name = "bsnText";
            bsnText.Size = new Size(173, 34);
            bsnText.TabIndex = 7;
            // 
            // birthdayDatePicker
            // 
            birthdayDatePicker.Font = new Font("Segoe UI", 12F);
            birthdayDatePicker.Format = DateTimePickerFormat.Short;
            birthdayDatePicker.Location = new Point(270, 245);
            birthdayDatePicker.Name = "birthdayDatePicker";
            birthdayDatePicker.Size = new Size(184, 29);
            birthdayDatePicker.TabIndex = 6;
            // 
            // personalBirthday
            // 
            personalBirthday.AutoSize = true;
            personalBirthday.Font = new Font("Microsoft Sans Serif", 12F);
            personalBirthday.Location = new Point(296, 217);
            personalBirthday.Name = "personalBirthday";
            personalBirthday.Size = new Size(67, 20);
            personalBirthday.TabIndex = 5;
            personalBirthday.Text = "Birthday";
            // 
            // personalBsn
            // 
            personalBsn.AutoSize = true;
            personalBsn.Font = new Font("Microsoft Sans Serif", 12F);
            personalBsn.Location = new Point(62, 217);
            personalBsn.Name = "personalBsn";
            personalBsn.Size = new Size(42, 20);
            personalBsn.TabIndex = 4;
            personalBsn.Text = "BSN";
            // 
            // personalPassword
            // 
            personalPassword.AutoSize = true;
            personalPassword.Font = new Font("Microsoft Sans Serif", 12F);
            personalPassword.Location = new Point(296, 136);
            personalPassword.Name = "personalPassword";
            personalPassword.Size = new Size(78, 20);
            personalPassword.TabIndex = 3;
            personalPassword.Text = "Password";
            // 
            // personalEmail
            // 
            personalEmail.AutoSize = true;
            personalEmail.Font = new Font("Microsoft Sans Serif", 12F);
            personalEmail.Location = new Point(62, 136);
            personalEmail.Name = "personalEmail";
            personalEmail.Size = new Size(48, 20);
            personalEmail.TabIndex = 2;
            personalEmail.Text = "Email";
            // 
            // personalLastName
            // 
            personalLastName.AutoSize = true;
            personalLastName.Font = new Font("Microsoft Sans Serif", 12F);
            personalLastName.Location = new Point(290, 62);
            personalLastName.Name = "personalLastName";
            personalLastName.Size = new Size(86, 20);
            personalLastName.TabIndex = 1;
            personalLastName.Text = "Last Name";
            // 
            // personalFirstName
            // 
            personalFirstName.AutoSize = true;
            personalFirstName.Font = new Font("Microsoft Sans Serif", 12F);
            personalFirstName.Location = new Point(62, 62);
            personalFirstName.Name = "personalFirstName";
            personalFirstName.Size = new Size(86, 20);
            personalFirstName.TabIndex = 0;
            personalFirstName.Text = "First Name";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F);
            label8.Location = new Point(164, 300);
            label8.Name = "label8";
            label8.Size = new Size(112, 25);
            label8.TabIndex = 11;
            label8.Text = "Department";
            // 
            // cbDepartment
            // 
            cbDepartment.Font = new Font("Segoe UI", 12F);
            cbDepartment.FormattingEnabled = true;
            cbDepartment.Location = new Point(147, 338);
            cbDepartment.Name = "cbDepartment";
            cbDepartment.Size = new Size(177, 29);
            cbDepartment.TabIndex = 10;
            // 
            // AddEmployeeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OrangeRed;
            ClientSize = new Size(531, 481);
            Controls.Add(addEmployeeTabControl);
            Name = "AddEmployeeForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add Employee Dialogue";
            addEmployeeTabControl.ResumeLayout(false);
            employeeContractTab.ResumeLayout(false);
            employeeContractTab.PerformLayout();
            employeeEmergencyDetailsTab.ResumeLayout(false);
            employeeEmergencyDetailsTab.PerformLayout();
            employeeDetailsTab.ResumeLayout(false);
            employeeDetailsTab.PerformLayout();
            ResumeLayout(false);
        }


        #endregion

        private TabControl addEmployeeTabControl;
		private TabPage employeeContractTab;
		private TabPage employeeEmergencyDetailsTab;
		private TabPage employeeDetailsTab;
		private Label label4;
		private DateTimePicker contractStartDatePicker;
		private TextBox contractWeeklyHoursTextBox;
		private Label label3;
		private TextBox contractHourlyWageTextBox;
		private Label label2;
		private Label label1;
		private ComboBox contractEmpRoleComboBox;
		private CustomButton nextBtnP1;
		private Label emcFirstName;
		private Label emcEmail;
		private Label emcPhoneNum;
		private Label emcLastName;
		private TextBox emcLastNameBox;
		private TextBox emcFirstNameBox;
		private TextBox emcEmailBox;
		private TextBox emcPhoneText;
		private DateTimePicker birthdayDatePicker;
		private Label personalBirthday;
		private Label personalBsn;
		private Label personalPassword;
		private Label personalEmail;
		private Label personalLastName;
		private Label personalFirstName;
		private TextBox lastNameText;
		private TextBox firstNameText;
		private TextBox emailText;
		private TextBox passwordText;
		private TextBox bsnText;
		private CustomButton nextBtnP2;
		private CustomButton completeFormBtn;
		private CustomButton previousBtnP2;
		private CustomButton previousBtnP3;
		private Label label5;
		private Label label6;
		private Label label7;
		private Label addressLabel;
		private TextBox addressText;
		private TextBox phoneText;
		private Label phoneNumLabel;
        private Label label8;
        private ComboBox cbDepartment;
    }
}