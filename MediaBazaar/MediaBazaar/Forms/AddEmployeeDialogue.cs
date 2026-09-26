using BusinessLogicLayer;
using DTOLayer;
using MediaBazaar.Classes;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaBazaar.Forms
{
    public partial class AddEmployeeForm : Form
    {
        private EmployeeManager _employeeManager;
        private ContractManager _contractManager;
        private DepartmentManager _departmentManager;
        private List<DepartmentDTO> _departments;
        private RoleManager _roleManager;
        private List<RoleDTO> _roles;

        public AddEmployeeForm(EmployeeManager employeeManager, ContractManager contractManager)
        {
            _employeeManager = employeeManager;
            _contractManager = contractManager;
            _departmentManager = new DepartmentManager();
            _roleManager = new RoleManager();
            InitializeComponent();
            HideTabControls();
            InitializeTabNavigation();
            LoadDepartments();
            LoadRoles();
            

        }

        private void completeFormBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Role selectedrole;
                decimal hourlyWage;
                int weeklyHours;
                Department department;

                ValidateFields();

                // Retrieve values for role, hourly wage, and weekly hours after validation
                selectedrole = _roleManager.ConvertToEntity((RoleDTO)contractEmpRoleComboBox.SelectedItem);
                hourlyWage = decimal.Parse(contractHourlyWageTextBox.Text);
                weeklyHours = int.Parse(contractWeeklyHoursTextBox.Text);
                department = _departmentManager.ConvertToEntity((DepartmentDTO)cbDepartment.SelectedItem);

                int contractId = _contractManager.GetNextContractId();
                var contract = new Contract(contractId, selectedrole, hourlyWage, weeklyHours, contractStartDatePicker.Value, null, true, null,department);

                int employeeId = _employeeManager.GetNextEmployeeId();
                var emergencyContact = new EmergencyContact(employeeId, emcFirstNameBox.Text, emcLastNameBox.Text, emcPhoneText.Text, emcEmailBox.Text);

                var employee = new Employee(employeeId, firstNameText.Text, lastNameText.Text, emailText.Text, passwordText.Text, phoneText.Text, bsnText.Text, birthdayDatePicker.Value, _roleManager.ConvertToEntity(_roleManager.GetRoleById(selectedrole.id)), false, emergencyContact, addressText.Text, contract,true,"0");

                _contractManager.AddContract(contract);
                _employeeManager._emergencyContactManager.AddEmergencyContact(emergencyContact);
                _employeeManager.AddEmployee(employee);

                MessageBox.Show("Employee added successfully.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadDepartments()
        {
            _departments = _departmentManager.GetAllDepartments();
            cbDepartment.DataSource = _departments;
            cbDepartment.DisplayMember = "Name";
        }

        private void LoadRoles()
        {
            _roles = _roleManager.GetAllRoles();
            contractEmpRoleComboBox.DataSource=_roles;
            contractEmpRoleComboBox.DisplayMember = "Role";


        }

        private void InitializeTabNavigation()
        {
            // nav indexing logic
            nextBtnP1.Click += (sender, e) => { addEmployeeTabControl.SelectedIndex = 1; };
            previousBtnP2.Click += (sender, e) => { addEmployeeTabControl.SelectedIndex = 0; };
            nextBtnP2.Click += (sender, e) => { addEmployeeTabControl.SelectedIndex = 2; };
            previousBtnP3.Click += (sender, e) => { addEmployeeTabControl.SelectedIndex = 1; };

            addEmployeeTabControl.SelectedIndexChanged += (sender, e) =>
            {
                if (addEmployeeTabControl.SelectedIndex == 0)
                {
                    previousBtnP2.Enabled = false;
                }
                else if (addEmployeeTabControl.SelectedIndex == 1)
                {
                    previousBtnP2.Enabled = true;
                    nextBtnP1.Enabled = true;
                    nextBtnP2.Enabled = true;
                }
                else if (addEmployeeTabControl.SelectedIndex == 2)
                {
                    nextBtnP2.Enabled = false;
                }
            };
        }

        private void HideTabControls()
        {
            addEmployeeTabControl.Appearance = TabAppearance.FlatButtons;
            addEmployeeTabControl.SizeMode = TabSizeMode.Fixed;
            addEmployeeTabControl.ItemSize = new Size(0, 1);
        }

        private void ValidateFields()
        {
            StringBuilder validationErrors = new StringBuilder(); 

            

            decimal hourlyWage;
            if (!decimal.TryParse(contractHourlyWageTextBox.Text, out hourlyWage))
                validationErrors.AppendLine("Hourly wage must be a decimal number.");

            int weeklyHours;
            if (!int.TryParse(contractWeeklyHoursTextBox.Text, out weeklyHours))
                validationErrors.AppendLine("Weekly hours must be an integer.");

            if (string.IsNullOrWhiteSpace(firstNameText.Text))
                validationErrors.AppendLine("First name is required.");

            if (string.IsNullOrWhiteSpace(lastNameText.Text))
                validationErrors.AppendLine("Last name is required.");

            if (string.IsNullOrWhiteSpace(emailText.Text))
                validationErrors.AppendLine("Email is required.");

            if (string.IsNullOrWhiteSpace(passwordText.Text))
                validationErrors.AppendLine("Password is required.");

            if (string.IsNullOrWhiteSpace(phoneText.Text))
                validationErrors.AppendLine("Phone number is required.");

            if (string.IsNullOrWhiteSpace(bsnText.Text))
                validationErrors.AppendLine("BSN is required.");

            // bsn regex validation
            else if (!Regex.IsMatch(bsnText.Text, @"^\d{8,9}$"))
                validationErrors.AppendLine("BSN must be 8 or 9 digits.");

            if (string.IsNullOrWhiteSpace(addressText.Text))
                validationErrors.AppendLine("Address is required.");

            if (string.IsNullOrWhiteSpace(emcFirstNameBox.Text))
                validationErrors.AppendLine("Emergency contact first name is required.");

            if (string.IsNullOrWhiteSpace(emcLastNameBox.Text))
                validationErrors.AppendLine("Emergency contact last name is required.");

            if (string.IsNullOrWhiteSpace(emcPhoneText.Text))
                validationErrors.AppendLine("Emergency contact phone number is required.");

            if (string.IsNullOrWhiteSpace(emcEmailBox.Text))
                validationErrors.AppendLine("Emergency contact email is required.");

            // email validation regex
            var emailRegex = new Regex(@"^[\w-]+(\.[\w-]+)*@([\w-]+\.)+[a-zA-Z]{2,7}$");

            if (!emailRegex.IsMatch(emailText.Text))
                validationErrors.AppendLine("Email is not in a valid format.");

            if (!emailRegex.IsMatch(emcEmailBox.Text))
                validationErrors.AppendLine("Emergency contact email is not in a valid format.");

            // phone num validation regex
            var phoneRegex = new Regex(@"^\d{9}$");
            if (!phoneRegex.IsMatch(phoneText.Text))
                validationErrors.AppendLine("Phone number is not in a valid format. It should be exactly 9 digits.");

            if (!phoneRegex.IsMatch(emcPhoneText.Text))
                validationErrors.AppendLine("Emergency contact phone number is required.");

            if (contractStartDatePicker.Value.Date > DateTime.Now.Date)
                validationErrors.AppendLine("Contract start date cannot be in the future.");

            if (birthdayDatePicker.Value.Date > DateTime.Now.Date)
                validationErrors.AppendLine("Employee birthday cannot be in the future.");

            if (validationErrors.Length > 0)
                throw new Exception(validationErrors.ToString());
        }
    }
}
