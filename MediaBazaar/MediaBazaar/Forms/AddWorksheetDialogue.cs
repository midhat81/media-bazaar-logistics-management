using DTOLayer;
using MediaBazaar.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaBazaar.Forms
{
    public partial class AddWorksheetDialogue : Form
    {
        private EmployeeWorksheetManager _employeeWorksheetManager;
        private EmployeeManager _employeeManager;

        public AddWorksheetDialogue(EmployeeManager employeeManager, EmployeeWorksheetManager worksheetManager)
        {
            InitializeComponent();
            _employeeWorksheetManager = worksheetManager;
            _employeeManager = employeeManager;
            ReloadEmployees();
        }

        private void ReloadEmployees()
        {
            _employeeManager.GetEmployeesFromDB();
            foreach (var employee in _employeeManager.GetAllEmployees())
            {
                comboBoxEmployee.Items.Add($"{employee.FirstName} {employee.LastName}");
            }
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateFields();
                string employeeName = comboBoxEmployee.SelectedItem.ToString();
                if (!Enum.TryParse(comboBoxWeekDay.SelectedItem?.ToString(), out WeekDayEnum weekDay))
                {
                    MessageBox.Show("Invalid week day selected.");
                    return;
                }
                int weekNr = Convert.ToInt32(textBoxWeekNumber.Text);
                if (!Enum.TryParse(comboBoxTimeSlot.SelectedItem.ToString(), out WorkingTime timeSlot))
                {
                    MessageBox.Show("Invalid time slot selected.");
                    return;
                }
                int employeeId = GetEmployeeIdByName(employeeName);
                if (employeeId == -1)
                {
                    MessageBox.Show("Employee not found.");
                    return;
                }

                if(_employeeWorksheetManager.CanAssignWorksheet(employeeId, weekDay, timeSlot, weekNr))
                {
                _employeeWorksheetManager.CreateWorksheet(_employeeWorksheetManager.GetNextId(), timeSlot, weekDay, employeeId, weekNr);
                _employeeWorksheetManager.AddWorksheetToDB(_employeeWorksheetManager.ViewEmployeeWorksheets().Last());
                MessageBox.Show("Worksheet created and added to the database successfully.");
                this.Close();
                }
                else
                {
                    MessageBox.Show("Cannot create worksheet because the employee already has two worksheets on the same day or the shifts are not adjacent.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ValidateFields()
        {
            if (comboBoxWeekDay.SelectedItem == null)
            {
                throw new Exception("Please select a week day.");
            }

            if (comboBoxTimeSlot.SelectedItem == null)
            {
                throw new Exception("Please select a time slot.");
            }

            if (string.IsNullOrEmpty(comboBoxEmployee.SelectedItem?.ToString()))
            {
                throw new Exception("Please enter the employee's name.");
            }

            if (string.IsNullOrEmpty(textBoxWeekNumber.Text) || !int.TryParse(textBoxWeekNumber.Text, out int weekNr))
            {
                throw new Exception("Week number must be a valid integer.");
            }
            if (weekNr < 1 || weekNr > 52)
            {
                throw new Exception("Week number must be between 1 and 52.");
            }
        }

        private Employee GetEmployeeByName(string name)
        {
            return _employeeManager.GetAllEmployees().FirstOrDefault(emp => $"{emp.FirstName} {emp.LastName}" == name);
        }

        private int GetEmployeeIdByName(string name)
        {
            Employee employee = GetEmployeeByName(name);
            return employee != null ? employee.EmployeeID : -1;
        }
    }
}
