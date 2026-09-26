using System.Data;
using System.Drawing;
using System.Windows.Forms;
using BusinessLogicLayer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using DataAccessLayer;
using DTOLayer;
using MediaBazaar.Classes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MediaBazaar.Forms
{
    public partial class UserControlDashboard : UserControl
    {
        private DataTable employeeData;
        private EmployeeManager employeeManager;
        private EmployeeWorksheetManager employeeWorksheetManager;
        private List<(Control control, Color originalBackColor, bool originalReadOnly)> originalControlStates = new List<(Control, Color, bool)>();

        public UserControlDashboard(EmployeeManager _employeeManager, EmployeeWorksheetManager _employeeWorksheetManager)
        {
            employeeManager = _employeeManager;
            employeeWorksheetManager = _employeeWorksheetManager;
            InitializeComponent();
            InitializeData();
            InitializeDataGridView();
            InitializeControls();
            InitializeFocus();
            SubscribeToLoadEvent();
            this.Resize += UserControlDashboard_Resize;
            this.MinimumSize = new Size(800, 600);
        }

        private void UserControlDashboard_Resize(object sender, EventArgs e)
        {
            int padding = 31;
            int groupBoxWidth = this.ClientSize.Width / 4;
            int otherControlsWidth = this.ClientSize.Width - groupBoxWidth - 2 * padding;

            panelOperations.Width = otherControlsWidth;
            panelOperations.Location = new Point(padding, 67);

            userDataGridView.Size = new Size(otherControlsWidth, this.ClientSize.Height - 200);
            userDataGridView.Location = new Point(padding, panelOperations.Bottom + 10);

            groupBox1.Size = new Size(groupBoxWidth, this.ClientSize.Height - 100);
            groupBox1.Location = new Point(this.ClientSize.Width - groupBox1.Width - padding, padding);
        }



        private void SubscribeToLoadEvent()
        {
            Load += UserControlDashboard_Load;
            Load += YourFormName_Load;
        }

        private void InitializeControls()
        {
            originalControlStates.Add((textBoxName, textBoxName.BackColor, textBoxName.ReadOnly));
            originalControlStates.Add((comboBoxRoleDetails, comboBoxRoleDetails.BackColor, comboBoxRoleDetails.Enabled));
            originalControlStates.Add((textBoxEmail, textBoxEmail.BackColor, textBoxEmail.ReadOnly));
            originalControlStates.Add((textBoxBSN, textBoxBSN.BackColor, textBoxBSN.ReadOnly));
            originalControlStates.Add((textBoxPhone, textBoxPhone.BackColor, textBoxPhone.ReadOnly));
            originalControlStates.Add((dateTimePickerBirthday, dateTimePickerBirthday.BackColor, dateTimePickerBirthday.Enabled));
            originalControlStates.Add((textBoxAddress, textBoxAddress.BackColor, textBoxAddress.ReadOnly));
        }

        private void PopulateDataTable(DataTable employeeData)
        {
            employeeData.Clear();

            employeeManager.GetEmployeesFromDB();
            foreach (Employee employee in employeeManager.employees)

            {
                if(employee.Contract.isActive)
                employeeData.Rows.Add(employee.EmployeeID, $"{employee.FirstName} {employee.LastName}", employee.Email, employee.Role.role.ToString(), employee.Contract.weeklyHours);
            }
        }
        

        internal void InitializeData()
        {
            employeeData = new DataTable();
            employeeData.Columns.Add("EmployeeID", typeof(int));
            employeeData.Columns.Add("Name", typeof(string));
            employeeData.Columns.Add("Email", typeof(string));
            employeeData.Columns.Add("Role", typeof(string));
            employeeData.Columns.Add("WeeklyHours", typeof(int));
            PopulateDataTable(employeeData);
            userDataGridView.DataSource = employeeData;
        }


        private void UserControlDashboard_Load(object sender, EventArgs e)
        {
            userDataGridView.ClearSelection();
            groupBox1.Visible = false;
        }

        private void YourFormName_Load(object sender, EventArgs e)
        {
            userDataGridView.ClearSelection();
            groupBox1.Visible = false;
        }

        private void InitializeDataGridView()
        {
            userDataGridView.AutoGenerateColumns = false;
            userDataGridView.AllowUserToAddRows = false;
            userDataGridView.DataSource = employeeData;
            userDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            userDataGridView.EnableHeadersVisualStyles = false;
            userDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(33, 150, 243);
            userDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            userDataGridView.DefaultCellStyle.BackColor = Color.White;
            userDataGridView.DefaultCellStyle.ForeColor = Color.FromArgb(33, 33, 33);
            userDataGridView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(200, 200, 200);
            userDataGridView.DefaultCellStyle.SelectionForeColor = Color.FromArgb(33, 33, 33);
            userDataGridView.RowHeadersVisible = false;
            userDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            userDataGridView.Font = new Font("Segoe UI Semibold", 14);
            userDataGridView.RowTemplate.Height = 70;
            userDataGridView.EnableHeadersVisualStyles = false;
            userDataGridView.BorderStyle = BorderStyle.None;
            userDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            userDataGridView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(235, 235, 235);
            userDataGridView.DefaultCellStyle.SelectionForeColor = Color.FromArgb(33, 33, 33);
            userDataGridView.BackgroundColor = Color.White;
            userDataGridView.CellMouseEnter += (sender, e) =>
            {
                if (e.RowIndex >= 0)
                {
                    userDataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
                }
            };

            userDataGridView.CellMouseLeave += (sender, e) =>
            {
                if (e.RowIndex >= 0)
                {
                    userDataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                }
            };

            userDataGridView.SelectionChanged += DataGridView1_SelectionChanged;
            userDataGridView.ScrollBars = ScrollBars.Vertical;
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (userDataGridView.SelectedRows.Count > 0)
            {
                groupBox1.Visible = true;
            }
            else
            {
                groupBox1.Visible = false;
            }
        }

        private void MoveControlsToLocation(Control control, Point location, Size size)
        {
            control.Location = location;
            control.Size = size;
        }

        private void pictureBoxSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void InitializeFocus()
        {
            textBoxSearch.GotFocus += new System.EventHandler(textBoxSearch_GotFocus);
            textBoxSearch.LostFocus += new System.EventHandler(textBoxSearch_LostFocus);
        }

        private string placeholder = "Search...";

        private void textBoxSearch_GotFocus(object sender, EventArgs e)
        {
            if (textBoxSearch.Text == placeholder)
            {
                textBoxSearch.Text = "";
            }
        }

        private void textBoxSearch_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxSearch.Text))
            {
                textBoxSearch.Text = placeholder;
            }
        }

        private void textBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Search();
            }
        }

        private void textBoxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
            }
        }

        private void Search()
        {
            string searchTerm = textBoxSearch.Text.Trim();
            string selectedRole = comboBoxRole.SelectedItem?.ToString();
            var query = employeeData.AsEnumerable();
            try
            {
                if (!string.IsNullOrEmpty(selectedRole) && selectedRole != "Any Role")
                {
                    query = query.Where(row => row.Field<string>("Role") == selectedRole);
                }

                if (!string.IsNullOrEmpty(searchTerm))
                {
                    bool isNumber = int.TryParse(searchTerm, out int number);
                    bool isValidEmail = new System.ComponentModel.DataAnnotations.EmailAddressAttribute().IsValid(searchTerm);
                    query = query.Where(row =>
                    {
                        if (isNumber)
                        {
                            return row.Field<int>("EmployeeID") == number;
                        }
                        else
                        {
                            string name = row.Field<string>("Name");
                            string[] nameParts = name.Split(' ');
                            string firstName = nameParts[0];
                            string lastName = nameParts.Length > 1 ? nameParts[1] : "";
                            return (firstName.Contains(searchTerm) || lastName.Contains(searchTerm)
                                    || (isValidEmail && row.Field<string>("Email") == searchTerm)
                                    || row.Field<string>("Role").Contains(searchTerm));
                        }
                    });
                }
                DataTable searchResults = query.Any() ? query.CopyToDataTable() : employeeData.Clone();
                userDataGridView.DataSource = searchResults;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while filtering: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                userDataGridView.ClearSelection();
            }
        }

        private void comboBoxRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void addEmployeeBtn_Click(object sender, EventArgs e)
        {
            AddEmployeeForm addEmployeeDialogue = new AddEmployeeForm(employeeManager, employeeManager._contractManager);
            addEmployeeDialogue.ShowDialog();
            employeeData.Clear();
            PopulateDataTable(employeeData);
            userDataGridView.DataSource = employeeData;
            userDataGridView.ClearSelection();
        }

        private void editEmployeeBtn_Click(object sender, EventArgs e)
        {
            if (editEmployeeBtn.Text == "Edit Employee")
            {
                textBoxAddress.ReadOnly = false;
                foreach (var (control, _, _) in originalControlStates)
                {
                    control.BackColor = Color.White;
                    if (control is System.Windows.Forms.TextBox textBox)
                    {
                        textBox.ReadOnly = false;


                    }
                    else if (control is System.Windows.Forms.ComboBox comboBox)
                    {
                        comboBox.Enabled = true;
                    }
                    else if (control is DateTimePicker dateTimePicker)
                    {
                        dateTimePicker.Enabled = true;
                    }
                }
                textBoxBSN.ReadOnly = true;
                dateTimePickerBirthday.Enabled = false;
                editEmployeeBtn.Text = "Save";
            }
            else if (editEmployeeBtn.Text == "Save")
            {
                UpdateEmployeeDetails();
                textBoxAddress.ReadOnly = false;
                foreach (var (control, originalBackColor, originalReadOnly) in originalControlStates)
                {
                    control.BackColor = originalBackColor;
                    if (control is System.Windows.Forms.TextBox textBox)
                    {
                        textBox.ReadOnly = originalReadOnly;

                    }
                    else if (control is System.Windows.Forms.ComboBox comboBox)
                    {
                        comboBox.Enabled = false;
                    }
                    else if (control is DateTimePicker dateTimePicker)
                    {
                        dateTimePicker.Enabled = false;
                    }
                }
                textBoxBSN.ReadOnly = true;
                dateTimePickerBirthday.Enabled = false;
                editEmployeeBtn.Text = "Edit Employee";
            }
        }


        private void userDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (userDataGridView.SelectedRows.Count > 0)
            {
                groupBox1.Visible = true;
            }
            else
            {
                groupBox1.Visible = false;
            }
        }

        private void UpdateEmployeeDetails()
        {
            try
            {
                if (userDataGridView.SelectedRows.Count > 0)
                    if (comboBoxRoleDetails.SelectedIndex + 1 > 0)
                    {
                        DataGridViewRow selectedRow = userDataGridView.SelectedRows[0];
                        int employeeId = Convert.ToInt32(selectedRow.Cells["EmployeeID"].Value);
                        string fullName = textBoxName.Text;
                        if (!string.IsNullOrEmpty(fullName))
                        {
                            string[] nameParts = fullName.Split(' ');

                            if (nameParts.Length == 2)
                            {

                                string firstName = nameParts[0];
                                string lastName = nameParts[1];
                                EmployeeDTO employee = new EmployeeDTO(
                                employeeId,
                                firstName,
                                lastName,
                                textBoxEmail.Text,

                                textBoxPhone.Text,
                                textBoxAddress.Text,
                                comboBoxRoleDetails.SelectedIndex + 1,
                                employeeManager.CheckManager((EmployeeRoleEnum)(comboBoxRoleDetails.SelectedIndex))
                                );

                                employeeManager.employeeDAL.UpdateEmployee(employee);
                                PopulateDataTable(employeeData);
                            }
                            else MessageBox.Show("Only input First and Last name");
                        }
                        else MessageBox.Show("You must select a role");
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void userDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < employeeData.Rows.Count)
            {
                DataGridViewRow selectedRow = userDataGridView.Rows[e.RowIndex];
                Employee selectedEmployee = employeeManager.GetEmployeeById(Convert.ToInt32(selectedRow.Cells["EmployeeID"].Value));

                textBoxName.Text = selectedRow.Cells["Name"].Value.ToString();
                comboBoxRoleDetails.Text = selectedRow.Cells["Role"].Value.ToString();
                textBoxEmail.Text = selectedRow.Cells["Email"].Value.ToString();
                textBoxBSN.Text = selectedEmployee.BSN;
                textBoxPhone.Text = selectedEmployee.PhoneNumber;
                textBoxAddress.Text = selectedEmployee.Address;

                dateTimePickerBirthday.Value = (DateTime)selectedEmployee.Birthday;
                dateTimePickerBirthday.Enabled = false;

                textBoxName.ReadOnly = true;
                comboBoxRoleDetails.Enabled = false;
                textBoxEmail.ReadOnly = true;
                textBoxBSN.ReadOnly = true;
                textBoxPhone.ReadOnly = true;
                textBoxAddress.ReadOnly = true;
            }
        }


        private string newRole;
        private void comboBoxRoleDetails_SelectedIndexChanged(object sender, EventArgs e)
        {
            newRole = comboBoxRoleDetails.SelectedItem?.ToString();
        }
        private void UpdateRoleInDataGridView(string newRole)
        {
            if (userDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = userDataGridView.SelectedRows[0];
                selectedRow.Cells["Role"].Value = newRole;
            }
        }

        private void removeEmployeeBtn_Click(object sender, EventArgs e)
        {
            if (userDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = userDataGridView.SelectedRows[0];
                int employeeId = Convert.ToInt32(selectedRow.Cells["EmployeeID"].Value);
                DialogResult result = MessageBox.Show("Are you sure you want to remove this employee?", "Remove Employee", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        employeeWorksheetManager.UnassignAllWorksheetsOfEmployee(employeeId);
                        employeeManager.DeleteEmployee(employeeId);
                        InitializeData();
                        MessageBox.Show("Employee removed successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("No employee selected currently.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void resetPasswordBtn_Click(object sender, EventArgs e)
        {
            if (userDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = userDataGridView.SelectedRows[0];
                int employeeId = Convert.ToInt32(selectedRow.Cells["EmployeeID"].Value);
                DialogResult result = MessageBox.Show("Are you sure you want to reset the password for this employee?", "Reset Password", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        employeeManager.ResetPassword(employeeId);
                        MessageBox.Show("PasswordReseted Successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("No employee selected currently.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

