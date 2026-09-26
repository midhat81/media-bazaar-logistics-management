namespace MediaBazaar
{
    partial class UserControlDepartment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlDepartment));
            panelOperations = new Panel();
            pictureBoxSearch = new PictureBox();
            addDepartmentBtn = new CustomButton();
            textBoxSearch = new TextBox();
            departmentDataGridView = new DataGridView();
            groupBox1 = new GroupBox();
            textBoxDescription = new RichTextBox();
            label3 = new Label();
            textBoxPointOfContact = new TextBox();
            label1 = new Label();
            label2 = new Label();
            removeEmployeeBtn = new CustomButton();
            editEmployeeBtn = new CustomButton();
            pictureBox2 = new PictureBox();
            employeeDetailsLabel = new Label();
            userPictureBox = new PictureBox();
            textBoxName = new TextBox();
            lblName = new Label();
            panelOperations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSearch).BeginInit();
            ((System.ComponentModel.ISupportInitialize)departmentDataGridView).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userPictureBox).BeginInit();
            SuspendLayout();
            // 
            // panelOperations
            // 
            panelOperations.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelOperations.Controls.Add(pictureBoxSearch);
            panelOperations.Controls.Add(addDepartmentBtn);
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
            // addDepartmentBtn
            // 
            addDepartmentBtn.BackColor = Color.DarkOrange;
            addDepartmentBtn.BackgroundColor = Color.DarkOrange;
            addDepartmentBtn.BorderColor = Color.White;
            addDepartmentBtn.BorderRadius = 15;
            addDepartmentBtn.BorderSize = 2;
            addDepartmentBtn.Cursor = Cursors.Hand;
            addDepartmentBtn.FlatStyle = FlatStyle.Flat;
            addDepartmentBtn.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addDepartmentBtn.ForeColor = Color.White;
            addDepartmentBtn.Location = new Point(804, 3);
            addDepartmentBtn.Name = "addDepartmentBtn";
            addDepartmentBtn.Size = new Size(136, 50);
            addDepartmentBtn.TabIndex = 31;
            addDepartmentBtn.Text = "Add Department";
            addDepartmentBtn.TextColor = Color.White;
            addDepartmentBtn.UseVisualStyleBackColor = false;
            addDepartmentBtn.Click += addDepartmentBtn_Click;
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
            // departmentDataGridView
            // 
            departmentDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            departmentDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            departmentDataGridView.Location = new Point(20, 128);
            departmentDataGridView.Margin = new Padding(3, 2, 3, 2);
            departmentDataGridView.Name = "departmentDataGridView";
            departmentDataGridView.RowHeadersWidth = 51;
            departmentDataGridView.Size = new Size(1061, 564);
            departmentDataGridView.TabIndex = 34;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox1.BackColor = Color.OrangeRed;
            groupBox1.Controls.Add(textBoxDescription);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBoxPointOfContact);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(removeEmployeeBtn);
            groupBox1.Controls.Add(editEmployeeBtn);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(employeeDetailsLabel);
            groupBox1.Controls.Add(userPictureBox);
            groupBox1.Controls.Add(textBoxName);
            groupBox1.Controls.Add(lblName);
            groupBox1.Location = new Point(1102, 39);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(376, 653);
            groupBox1.TabIndex = 33;
            groupBox1.TabStop = false;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(108, 168);
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.ReadOnly = true;
            textBoxDescription.Size = new Size(252, 96);
            textBoxDescription.TabIndex = 38;
            textBoxDescription.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label3.Location = new Point(16, 173);
            label3.Name = "label3";
            label3.Size = new Size(95, 20);
            label3.TabIndex = 36;
            label3.Text = "Description: ";
            // 
            // textBoxPointOfContact
            // 
            textBoxPointOfContact.BackColor = SystemColors.ControlDark;
            textBoxPointOfContact.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            textBoxPointOfContact.Location = new Point(116, 296);
            textBoxPointOfContact.Margin = new Padding(3, 2, 3, 2);
            textBoxPointOfContact.Name = "textBoxPointOfContact";
            textBoxPointOfContact.ReadOnly = true;
            textBoxPointOfContact.Size = new Size(232, 27);
            textBoxPointOfContact.TabIndex = 35;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label1.Location = new Point(24, 300);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 34;
            label1.Text = "PoC:";
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
            removeEmployeeBtn.Text = "Remove Department";
            removeEmployeeBtn.TextColor = Color.White;
            removeEmployeeBtn.UseVisualStyleBackColor = false;
            removeEmployeeBtn.Click += this.removeEmployeeBtn_Click;
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
            editEmployeeBtn.Location = new Point(48, 504);
            editEmployeeBtn.Name = "editEmployeeBtn";
            editEmployeeBtn.Size = new Size(286, 50);
            editEmployeeBtn.TabIndex = 29;
            editEmployeeBtn.Text = "Edit Department";
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
            employeeDetailsLabel.Location = new Point(16, 71);
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
            // textBoxName
            // 
            textBoxName.BackColor = SystemColors.ControlDark;
            textBoxName.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            textBoxName.Location = new Point(108, 120);
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
            lblName.Location = new Point(16, 121);
            lblName.Name = "lblName";
            lblName.Size = new Size(54, 20);
            lblName.TabIndex = 0;
            lblName.Text = "Name:";
            // 
            // UserControlDepartment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelOperations);
            Controls.Add(departmentDataGridView);
            Controls.Add(groupBox1);
            Name = "UserControlDepartment";
            Size = new Size(1499, 730);
            panelOperations.ResumeLayout(false);
            panelOperations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSearch).EndInit();
            ((System.ComponentModel.ISupportInitialize)departmentDataGridView).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)userPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelOperations;
        private PictureBox pictureBoxSearch;
        private CustomButton addDepartmentBtn;
        private TextBox textBoxSearch;
        private DataGridView departmentDataGridView;
        private GroupBox groupBox1;
        private Label label2;
        private CustomButton removeEmployeeBtn;
        private CustomButton editEmployeeBtn;
        private PictureBox pictureBox2;
        private Label employeeDetailsLabel;
        private PictureBox userPictureBox;
        private TextBox textBoxName;
        private Label lblName;
        private RichTextBox textBoxDescription;
        private Label label3;
        private TextBox textBoxPointOfContact;
        private Label label1;
    }
}
