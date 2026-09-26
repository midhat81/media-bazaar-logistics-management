using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;
using DTOLayer;
using MediaBazaar;
using MediaBazaar.Classes;
using BusinessLogicLayer;



namespace MediaBazaar.Forms
{
    public partial class UserControlWorksheet : UserControl
    {
        private EmployeeWorksheetManager employeeWorksheetManager;
        private EmployeeManager employeeManager;
        private DataTable worksheetData;
        public UserControlWorksheet(EmployeeManager _employeeManager, EmployeeWorksheetManager _worksheetManager)
        {
            employeeWorksheetManager = _worksheetManager;
            employeeManager = _employeeManager;
            InitializeComponent();
            InitializeFocus();
            Load += UserControlWorksheet_Load;
            this.Resize += UserControlWorksheet_Resize;
            employeeWorksheetGrid.CellClick += employeeWorksheetGrid_CellClick;
            PopulateWorksheetData();
        }
        private void UserControlWorksheet_Resize(object sender, EventArgs e)
        {
            int padding = 31;
            int groupBoxWidth = this.ClientSize.Width / 4; 
            int otherControlsWidth = this.ClientSize.Width - groupBoxWidth - 2 * padding; 
            panelOperationsWorksheet.Width = otherControlsWidth;
            panelOperationsWorksheet.Location = new Point(padding, 73);
            employeeWorksheetGrid.Size = new Size(otherControlsWidth, this.ClientSize.Height - 200);
            employeeWorksheetGrid.Location = new Point(padding, panelOperationsWorksheet.Bottom + 10);
            groupBox1.Size = new Size(groupBoxWidth, this.ClientSize.Height - 100);
            groupBox1.Location = new Point(this.ClientSize.Width - groupBox1.Width - padding, padding);
            textBoxSearch.Width = cbFilter.Location.X - pictureBoxSearch.Width - textBoxSearch.Location.X - 10;
            pictureBoxSearch.Location = new Point(textBoxSearch.Location.X + textBoxSearch.Width, textBoxSearch.Location.Y);
        }

        private void UserControlWorksheet_Load(object sender, EventArgs e)
        {
            InitializeGridViewWorksheet();
            employeeWorksheetGrid.ClearSelection();
            groupBox1.Visible = false;
        }

        public void PopulateWorksheetData()
        {
            worksheetData = new DataTable();
            worksheetData.Columns.Add("ID", typeof(int));
            worksheetData.Columns.Add("Role", typeof(string));
            worksheetData.Columns.Add("TimeSlot", typeof(string));
            worksheetData.Columns.Add("Weekday", typeof(string));
            worksheetData.Columns.Add("Employee", typeof(string));
            worksheetData.Columns.Add("Week", typeof(int));
            worksheetData.Clear();
            employeeWorksheetManager.GetAllWorksheetsInDB();
            foreach (EmployeeWorksheet worksheet in employeeWorksheetManager.assignedWorksheets)
            {
                string employeeName = "Unassigned ✖️";
                string employeeRole = "Unassigned ✖️";
                if (worksheet.employee.HasValue)
                {
                    Employee employee = employeeManager.GetEmployeeById(worksheet.employee.Value);
                    if (employee != null)
                    {
                        employeeName = employee.GetFullName();
                        employeeRole = employee.Role.role.ToString();
                    }
                }
                worksheetData.Rows.Add(worksheet.id, employeeRole, worksheet.timeSlot.ToString(), worksheet.weekDay.ToString(), employeeName, worksheet.weekNr);
            }
            employeeWorksheetGrid.DataSource = worksheetData;
            employeeWorksheetGrid.ClearSelection();
            employeeWorksheetGrid.RowTemplate.Height = 70;
        }

        private void InitializeFocus()
        {
            textBoxSearch.GotFocus += new System.EventHandler(textBoxSearch_GotFocus);
            textBoxSearch.LostFocus += new System.EventHandler(textBoxSearch_LostFocus);
        }

        private void InitializeGridViewWorksheet()
        {
            employeeWorksheetGrid.AutoGenerateColumns = false;
            employeeWorksheetGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            employeeWorksheetGrid.AllowUserToAddRows = false;
            employeeWorksheetGrid.EnableHeadersVisualStyles = false;
            employeeWorksheetGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(33, 150, 243);
            employeeWorksheetGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            employeeWorksheetGrid.DefaultCellStyle.BackColor = Color.White;
            employeeWorksheetGrid.DefaultCellStyle.ForeColor = Color.FromArgb(33, 33, 33);
            employeeWorksheetGrid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(200, 200, 200);
            employeeWorksheetGrid.DefaultCellStyle.SelectionForeColor = Color.FromArgb(33, 33, 33);
            employeeWorksheetGrid.RowHeadersVisible = false;
            employeeWorksheetGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            employeeWorksheetGrid.Font = new Font("Segoe UI Semibold", 14);
            employeeWorksheetGrid.EnableHeadersVisualStyles = false;
            employeeWorksheetGrid.BorderStyle = BorderStyle.None;
            employeeWorksheetGrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            employeeWorksheetGrid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(235, 235, 235);
            employeeWorksheetGrid.DefaultCellStyle.SelectionForeColor = Color.FromArgb(33, 33, 33);
            employeeWorksheetGrid.BackgroundColor = Color.White;
            employeeWorksheetGrid.CellMouseEnter += (sender, e) =>
            {
                if (e.RowIndex >= 0)
                {
                    employeeWorksheetGrid.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
                }
            };

            employeeWorksheetGrid.CellMouseLeave += (sender, e) =>
            {
                if (e.RowIndex >= 0)
                {
                    employeeWorksheetGrid.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                }
            };
            employeeWorksheetGrid.ScrollBars = ScrollBars.Vertical;
            employeeWorksheetGrid.SelectionChanged += dataGridViewWorksheet_SelectionChanged;
        }

        private void dataGridViewWorksheet_SelectionChanged(object sender, EventArgs e)
        {
            if (employeeWorksheetGrid.SelectedRows.Count > 0)
            {
                groupBox1.Visible = true;
            }
            else
            {
                groupBox1.Visible = false;
            }
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

        private void employeeWorksheetGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < worksheetData.Rows.Count)
            {
                DataGridViewRow selectedRow = employeeWorksheetGrid.Rows[e.RowIndex];
                string employeeName = selectedRow.Cells["Employee"].Value.ToString();
                if (employeeName == "Unassigned ✖️")
                {
                    textBoxName.Items.Clear();
                    List<Employee> employees = employeeManager.GetAllEmployees();
                    foreach (Employee employee in employees)
                    {
                        textBoxName.Items.Add(employee.GetFullName());
                    }
                    textBoxName.Enabled = true;
                }
                else
                {
                    textBoxName.Items.Clear();
                    textBoxName.Items.Add(employeeName);
                    textBoxName.SelectedIndex = 0;
                    textBoxName.Enabled = false;
                }
                comboBoxRole.SelectedItem = selectedRow.Cells["Role"].Value.ToString();
                int weekNumber = Convert.ToInt32(selectedRow.Cells["Week"].Value);
                DayOfWeek dayOfWeek = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), selectedRow.Cells["WeekDay"].Value.ToString());
                DateTime jan1 = new DateTime(DateTime.Now.Year, 1, 1);
                while (jan1.DayOfWeek != dayOfWeek)
                {
                    jan1 = jan1.AddDays(1);
                }
                DateTime result = jan1.AddDays((weekNumber - 1) * 7);
                dateTimePicker1.Value = result;
                string timeSlot = selectedRow.Cells["TimeSlot"].Value.ToString();
                if (timeSlot == "Morning")
                    cbShift.SelectedItem = "Morning";
                else if (timeSlot == "Afternoon")
                    cbShift.SelectedItem = "Afternoon";
                else if (timeSlot == "Evening")
                    cbShift.SelectedItem = "Evening";
            }
        }

        private void Search()
        {
            string searchTerm = textBoxSearch.Text.Trim();
            string selectedRole = cbFilter.SelectedItem?.ToString();
            string selectedDay = cbDayFilter.SelectedItem?.ToString();
            var query = worksheetData.AsEnumerable();
            try
            {
                if (!string.IsNullOrEmpty(selectedRole) && selectedRole != "Any Role")
                {
                    query = query.Where(row => row.Field<string>("Role") == selectedRole);
                }

                if (!string.IsNullOrEmpty(selectedDay) && selectedDay != "Any Day")
                {
                    query = query.Where(row => row.Field<string>("Weekday") == selectedDay); 
                }

                if (!string.IsNullOrEmpty(searchTerm))
                {
                    query = query.Where(row => row.Field<string>("Employee").Contains(searchTerm));
                }
                DataTable searchResults = query.Any() ? query.CopyToDataTable() : worksheetData.Clone();
                employeeWorksheetGrid.DataSource = searchResults;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while filtering: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                employeeWorksheetGrid.ClearSelection();
            }
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search();
        }


        private void pictureBoxSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void textBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Search();
            e.Handled = true;
        }

        private void textBoxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                Search();
            }
        }

        private void btnAddWorksheet_Click_1(object sender, EventArgs e)
        {
            AddWorksheetDialogue addWorksheetDialogue = new AddWorksheetDialogue(employeeManager, employeeWorksheetManager);
            addWorksheetDialogue.ShowDialog();
            PopulateWorksheetData();
            employeeWorksheetGrid.DataSource = worksheetData;
            employeeWorksheetGrid.ClearSelection();
        }

        private void btnUnassignedWorksheet_Click_1(object sender, EventArgs e)
        {
            if (employeeWorksheetGrid.SelectedRows.Count > 0)
            {
                int selectedRow = employeeWorksheetGrid.SelectedRows[0].Index;
                int id = Convert.ToInt32(employeeWorksheetGrid.Rows[selectedRow].Cells["ID"].Value);
                EmployeeWorksheet worksheet = employeeWorksheetManager.GetWorksheetById(id);
                if (worksheet.employee.HasValue)
                {
                    employeeWorksheetManager.UnassignWorksheet(worksheet);
                    PopulateWorksheetData();
                    MessageBox.Show("Worksheet unassigned successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("This worksheet is already unassigned", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRemoveWorksheet_Click(object sender, EventArgs e)
        {
            if (employeeWorksheetGrid.SelectedRows.Count > 0)
            {
                int selectedRow = employeeWorksheetGrid.SelectedRows[0].Index;
                int id = Convert.ToInt32(employeeWorksheetGrid.Rows[selectedRow].Cells["ID"].Value);
                EmployeeWorksheet worksheet = employeeWorksheetManager.GetWorksheetById(id);
                if (worksheet != null)
                {
                    employeeWorksheetManager.DeleteWorksheet(worksheet);
                    employeeWorksheetManager.DeleteWorksheetInDB(worksheet);
                    PopulateWorksheetData();
                    MessageBox.Show("Worksheet removed successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("This worksheet does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAssignWorksheet_Click(object sender, EventArgs e)
        {
            if (employeeWorksheetGrid.SelectedRows.Count > 0 && textBoxName.SelectedItem != null)
            {
                int selectedRow = employeeWorksheetGrid.SelectedRows[0].Index;
                int id = Convert.ToInt32(employeeWorksheetGrid.Rows[selectedRow].Cells["ID"].Value);
                EmployeeWorksheet worksheet = employeeWorksheetManager.GetWorksheetById(id);
                string employeeName = textBoxName.SelectedItem.ToString();
                Employee employee = employeeManager.GetEmployeeByName(employeeName);
                if (employee != null)
                {
                    if(employeeWorksheetManager.CanAssignWorksheet(employee.EmployeeID, worksheet.weekDay, worksheet.timeSlot, worksheet.weekNr))
                    {
                        worksheet.UpdateWorksheet(worksheet.timeSlot, worksheet.weekDay, employee.EmployeeID, worksheet.weekNr);
                        employeeWorksheetManager.UpdateWorksheetInDB(worksheet);
                        PopulateWorksheetData();
                        MessageBox.Show("Worksheet assigned successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    } else
                    {
                        MessageBox.Show("Cannot assign worksheet. Employee already has two shifts or the shifts are not adjacent.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Employee does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cbDayFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search();
        }
    }
}

