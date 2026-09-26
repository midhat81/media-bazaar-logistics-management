namespace MediaBazaar.Forms
{
    partial class UserControlWorksheet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlWorksheet));
            btnUnassignWorksheet = new CustomButton();
            btnAddWorksheet = new CustomButton();
            employeeWorksheetGrid = new DataGridView();
            groupBox1 = new GroupBox();
            textBoxName = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            cbShift = new ComboBox();
            lbDate = new Label();
            lbShift = new Label();
            pictureBox2 = new PictureBox();
            worksheetDetailsLabel = new Label();
            userPictureBox = new PictureBox();
            comboBoxRole = new ComboBox();
            lblRole = new Label();
            lblName = new Label();
            assignUnassignGroup = new GroupBox();
            btnRemoveWorksheet = new CustomButton();
            btnAssignWorksheet = new CustomButton();
            textBoxSearch = new TextBox();
            pictureBoxSearch = new PictureBox();
            cbFilter = new ComboBox();
            panelOperationsWorksheet = new Panel();
            cbDayFilter = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)employeeWorksheetGrid).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userPictureBox).BeginInit();
            assignUnassignGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSearch).BeginInit();
            panelOperationsWorksheet.SuspendLayout();
            SuspendLayout();
            // 
            // btnUnassignWorksheet
            // 
            btnUnassignWorksheet.BackColor = Color.DarkOrange;
            btnUnassignWorksheet.BackgroundColor = Color.DarkOrange;
            btnUnassignWorksheet.BorderColor = Color.White;
            btnUnassignWorksheet.BorderRadius = 15;
            btnUnassignWorksheet.BorderSize = 2;
            btnUnassignWorksheet.FlatStyle = FlatStyle.Flat;
            btnUnassignWorksheet.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btnUnassignWorksheet.ForeColor = Color.White;
            btnUnassignWorksheet.Location = new Point(17, 99);
            btnUnassignWorksheet.Margin = new Padding(3, 2, 3, 2);
            btnUnassignWorksheet.Name = "btnUnassignWorksheet";
            btnUnassignWorksheet.Size = new Size(286, 57);
            btnUnassignWorksheet.TabIndex = 24;
            btnUnassignWorksheet.Text = "Unassign Worksheet";
            btnUnassignWorksheet.TextColor = Color.White;
            btnUnassignWorksheet.UseVisualStyleBackColor = false;
            btnUnassignWorksheet.Click += btnUnassignedWorksheet_Click_1;
            // 
            // btnAddWorksheet
            // 
            btnAddWorksheet.BackColor = Color.DarkOrange;
            btnAddWorksheet.BackgroundColor = Color.DarkOrange;
            btnAddWorksheet.BorderColor = Color.White;
            btnAddWorksheet.BorderRadius = 15;
            btnAddWorksheet.BorderSize = 2;
            btnAddWorksheet.FlatStyle = FlatStyle.Flat;
            btnAddWorksheet.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddWorksheet.ForeColor = Color.White;
            btnAddWorksheet.Location = new Point(868, 3);
            btnAddWorksheet.Name = "btnAddWorksheet";
            btnAddWorksheet.Size = new Size(159, 62);
            btnAddWorksheet.TabIndex = 23;
            btnAddWorksheet.Text = "Add Worksheet";
            btnAddWorksheet.TextColor = Color.White;
            btnAddWorksheet.UseVisualStyleBackColor = false;
            btnAddWorksheet.Click += btnAddWorksheet_Click_1;
            // 
            // employeeWorksheetGrid
            // 
            employeeWorksheetGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            employeeWorksheetGrid.Cursor = Cursors.Hand;
            employeeWorksheetGrid.Location = new Point(41, 129);
            employeeWorksheetGrid.Margin = new Padding(3, 2, 3, 2);
            employeeWorksheetGrid.Name = "employeeWorksheetGrid";
            employeeWorksheetGrid.RowHeadersWidth = 51;
            employeeWorksheetGrid.Size = new Size(1079, 564);
            employeeWorksheetGrid.TabIndex = 22;
            employeeWorksheetGrid.CellClick += employeeWorksheetGrid_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.OrangeRed;
            groupBox1.Controls.Add(textBoxName);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(cbShift);
            groupBox1.Controls.Add(lbDate);
            groupBox1.Controls.Add(lbShift);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(worksheetDetailsLabel);
            groupBox1.Controls.Add(userPictureBox);
            groupBox1.Controls.Add(comboBoxRole);
            groupBox1.Controls.Add(lblRole);
            groupBox1.Controls.Add(lblName);
            groupBox1.Controls.Add(assignUnassignGroup);
            groupBox1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(1123, 58);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(376, 666);
            groupBox1.TabIndex = 25;
            groupBox1.TabStop = false;
            // 
            // textBoxName
            // 
            textBoxName.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            textBoxName.FormattingEnabled = true;
            textBoxName.Location = new Point(102, 79);
            textBoxName.Margin = new Padding(2);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(238, 28);
            textBoxName.TabIndex = 45;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(102, 182);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(238, 27);
            dateTimePicker1.TabIndex = 39;
            // 
            // cbShift
            // 
            cbShift.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            cbShift.FormattingEnabled = true;
            cbShift.Items.AddRange(new object[] { "Morning", "Afternoon", "Evening" });
            cbShift.Location = new Point(102, 239);
            cbShift.Name = "cbShift";
            cbShift.Size = new Size(238, 28);
            cbShift.TabIndex = 38;
            // 
            // lbDate
            // 
            lbDate.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            lbDate.Location = new Point(48, 188);
            lbDate.Name = "lbDate";
            lbDate.Size = new Size(48, 20);
            lbDate.TabIndex = 37;
            lbDate.Text = "Date:";
            // 
            // lbShift
            // 
            lbShift.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            lbShift.Location = new Point(51, 247);
            lbShift.Name = "lbShift";
            lbShift.Size = new Size(48, 24);
            lbShift.TabIndex = 36;
            lbShift.Text = "Shift:";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.DimGray;
            pictureBox2.Location = new Point(18, 59);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(253, 2);
            pictureBox2.TabIndex = 25;
            pictureBox2.TabStop = false;
            // 
            // worksheetDetailsLabel
            // 
            worksheetDetailsLabel.AutoSize = true;
            worksheetDetailsLabel.BackColor = Color.Transparent;
            worksheetDetailsLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            worksheetDetailsLabel.ForeColor = Color.Black;
            worksheetDetailsLabel.Location = new Point(65, 33);
            worksheetDetailsLabel.Name = "worksheetDetailsLabel";
            worksheetDetailsLabel.Size = new Size(141, 21);
            worksheetDetailsLabel.TabIndex = 26;
            worksheetDetailsLabel.Text = "Worksheet details";
            // 
            // userPictureBox
            // 
            userPictureBox.BackColor = Color.OrangeRed;
            userPictureBox.Image = (Image)resources.GetObject("userPictureBox.Image");
            userPictureBox.Location = new Point(6, 25);
            userPictureBox.Margin = new Padding(3, 2, 3, 2);
            userPictureBox.Name = "userPictureBox";
            userPictureBox.Size = new Size(53, 33);
            userPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            userPictureBox.TabIndex = 25;
            userPictureBox.TabStop = false;
            // 
            // comboBoxRole
            // 
            comboBoxRole.BackColor = SystemColors.Control;
            comboBoxRole.DropDownHeight = 108;
            comboBoxRole.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRole.Enabled = false;
            comboBoxRole.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            comboBoxRole.FormattingEnabled = true;
            comboBoxRole.IntegralHeight = false;
            comboBoxRole.ItemHeight = 20;
            comboBoxRole.Items.AddRange(new object[] { "HRManager", "SalesRepresentative", "SupportEmployee", "Cashier", "SecurityGuard", "DepotWorker" });
            comboBoxRole.Location = new Point(102, 130);
            comboBoxRole.Margin = new Padding(3, 2, 3, 2);
            comboBoxRole.Name = "comboBoxRole";
            comboBoxRole.Size = new Size(238, 28);
            comboBoxRole.TabIndex = 16;
            // 
            // lblRole
            // 
            lblRole.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            lblRole.Location = new Point(48, 134);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(42, 24);
            lblRole.TabIndex = 2;
            lblRole.Text = "Role:";
            // 
            // lblName
            // 
            lblName.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            lblName.Location = new Point(18, 84);
            lblName.Margin = new Padding(1, 0, 1, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(81, 27);
            lblName.TabIndex = 0;
            lblName.Text = "Employee:";
            // 
            // assignUnassignGroup
            // 
            assignUnassignGroup.Controls.Add(btnRemoveWorksheet);
            assignUnassignGroup.Controls.Add(btnAssignWorksheet);
            assignUnassignGroup.Controls.Add(btnUnassignWorksheet);
            assignUnassignGroup.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            assignUnassignGroup.Location = new Point(34, 401);
            assignUnassignGroup.Margin = new Padding(2);
            assignUnassignGroup.Name = "assignUnassignGroup";
            assignUnassignGroup.Padding = new Padding(2);
            assignUnassignGroup.Size = new Size(316, 252);
            assignUnassignGroup.TabIndex = 44;
            assignUnassignGroup.TabStop = false;
            assignUnassignGroup.Text = "Assignation";
            // 
            // btnRemoveWorksheet
            // 
            btnRemoveWorksheet.BackColor = Color.DarkOrange;
            btnRemoveWorksheet.BackgroundColor = Color.DarkOrange;
            btnRemoveWorksheet.BorderColor = Color.White;
            btnRemoveWorksheet.BorderRadius = 15;
            btnRemoveWorksheet.BorderSize = 2;
            btnRemoveWorksheet.FlatStyle = FlatStyle.Flat;
            btnRemoveWorksheet.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btnRemoveWorksheet.ForeColor = Color.White;
            btnRemoveWorksheet.Location = new Point(17, 173);
            btnRemoveWorksheet.Name = "btnRemoveWorksheet";
            btnRemoveWorksheet.Size = new Size(286, 57);
            btnRemoveWorksheet.TabIndex = 43;
            btnRemoveWorksheet.Text = "Remove Worksheet";
            btnRemoveWorksheet.TextColor = Color.White;
            btnRemoveWorksheet.UseVisualStyleBackColor = false;
            btnRemoveWorksheet.Click += btnRemoveWorksheet_Click;
            // 
            // btnAssignWorksheet
            // 
            btnAssignWorksheet.BackColor = Color.DarkOrange;
            btnAssignWorksheet.BackgroundColor = Color.DarkOrange;
            btnAssignWorksheet.BorderColor = Color.White;
            btnAssignWorksheet.BorderRadius = 15;
            btnAssignWorksheet.BorderSize = 2;
            btnAssignWorksheet.FlatStyle = FlatStyle.Flat;
            btnAssignWorksheet.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btnAssignWorksheet.ForeColor = Color.White;
            btnAssignWorksheet.Location = new Point(17, 27);
            btnAssignWorksheet.Margin = new Padding(3, 2, 3, 2);
            btnAssignWorksheet.Name = "btnAssignWorksheet";
            btnAssignWorksheet.Size = new Size(286, 57);
            btnAssignWorksheet.TabIndex = 24;
            btnAssignWorksheet.Text = "Assign Worksheet";
            btnAssignWorksheet.TextColor = Color.White;
            btnAssignWorksheet.UseVisualStyleBackColor = false;
            btnAssignWorksheet.Click += btnAssignWorksheet_Click;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Cursor = Cursors.IBeam;
            textBoxSearch.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxSearch.Location = new Point(13, 19);
            textBoxSearch.Margin = new Padding(3, 2, 3, 2);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(514, 29);
            textBoxSearch.TabIndex = 26;
            textBoxSearch.Text = "Search...";
            textBoxSearch.KeyDown += textBoxSearch_KeyDown;
            textBoxSearch.KeyPress += textBoxSearch_KeyPress;
            // 
            // pictureBoxSearch
            // 
            pictureBoxSearch.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBoxSearch.BackColor = Color.White;
            pictureBoxSearch.Cursor = Cursors.Hand;
            pictureBoxSearch.Image = Properties.Resources.search_icon;
            pictureBoxSearch.Location = new Point(504, 20);
            pictureBoxSearch.Margin = new Padding(3, 2, 3, 2);
            pictureBoxSearch.Name = "pictureBoxSearch";
            pictureBoxSearch.Size = new Size(42, 28);
            pictureBoxSearch.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxSearch.TabIndex = 28;
            pictureBoxSearch.TabStop = false;
            pictureBoxSearch.Click += pictureBoxSearch_Click;
            // 
            // cbFilter
            // 
            cbFilter.Cursor = Cursors.Hand;
            cbFilter.DropDownHeight = 108;
            cbFilter.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbFilter.FormattingEnabled = true;
            cbFilter.IntegralHeight = false;
            cbFilter.ItemHeight = 20;
            cbFilter.Items.AddRange(new object[] { "Any Role", "DepartmentManager", "HRManager", "SalesRepresentative", "SupportEmployee", "Cashier", "SecurityGuard", "DepotWorker" });
            cbFilter.Location = new Point(552, 19);
            cbFilter.Name = "cbFilter";
            cbFilter.Size = new Size(168, 28);
            cbFilter.TabIndex = 29;
            cbFilter.Text = "Choose Role";
            cbFilter.SelectedIndexChanged += cbFilter_SelectedIndexChanged;
            // 
            // panelOperationsWorksheet
            // 
            panelOperationsWorksheet.Controls.Add(cbDayFilter);
            panelOperationsWorksheet.Controls.Add(pictureBoxSearch);
            panelOperationsWorksheet.Controls.Add(btnAddWorksheet);
            panelOperationsWorksheet.Controls.Add(cbFilter);
            panelOperationsWorksheet.Controls.Add(textBoxSearch);
            panelOperationsWorksheet.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panelOperationsWorksheet.Location = new Point(32, 64);
            panelOperationsWorksheet.Name = "panelOperationsWorksheet";
            panelOperationsWorksheet.Size = new Size(1030, 70);
            panelOperationsWorksheet.TabIndex = 30;
            // 
            // cbDayFilter
            // 
            cbDayFilter.Cursor = Cursors.Hand;
            cbDayFilter.DropDownHeight = 108;
            cbDayFilter.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbDayFilter.FormattingEnabled = true;
            cbDayFilter.IntegralHeight = false;
            cbDayFilter.ItemHeight = 20;
            cbDayFilter.Items.AddRange(new object[] { "Any Day", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" });
            cbDayFilter.Location = new Point(726, 20);
            cbDayFilter.Name = "cbDayFilter";
            cbDayFilter.Size = new Size(136, 28);
            cbDayFilter.TabIndex = 30;
            cbDayFilter.Text = "Choose Day";
            cbDayFilter.SelectedIndexChanged += cbDayFilter_SelectedIndexChanged;
            // 
            // UserControlWorksheet
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelOperationsWorksheet);
            Controls.Add(groupBox1);
            Controls.Add(employeeWorksheetGrid);
            Cursor = Cursors.Hand;
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "UserControlWorksheet";
            Size = new Size(1499, 730);
            ((System.ComponentModel.ISupportInitialize)employeeWorksheetGrid).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)userPictureBox).EndInit();
            assignUnassignGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxSearch).EndInit();
            panelOperationsWorksheet.ResumeLayout(false);
            panelOperationsWorksheet.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private CustomButton btnUnassignWorksheet;
        private CustomButton btnAddWorksheet;
        private DataGridView employeeWorksheetGrid;
        private GroupBox groupBox1;
        private PictureBox pictureBox2;
        private Label worksheetDetailsLabel;
        private PictureBox userPictureBox;
        private TextBox textBoxEmployee;
        private ComboBox comboBoxRole;
        private Label lblRole;
        private Label lblName;
        private TextBox textBoxSearch;
        private ComboBox comboBoxRoleWorksheet;
        private PictureBox pictureBoxSearch;
        private DateTimePicker dateTimePicker1;
        private ComboBox cbShift;
        private Label lbDate;
        private Label lbShift;
        private CustomButton btnAssignWorksheet;
        private CustomButton btnRemoveWorksheet;
        private GroupBox assignUnassignGroup;
        private ComboBox cbFilter;
        private ComboBox textBoxName;
        private Panel panelOperationsWorksheet;
        private ComboBox cbDayFilter;
    }
}
