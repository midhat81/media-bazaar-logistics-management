using BusinessLogicLayer;
using DTOLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MediaBazaar.Forms
{
    public partial class AddDepartmentDialogue : Form
    {
        private DepartmentManager departmentManager;
        private RoleManager roleManager;
        
        private List<RoleDTO> allRoles;
        private DepartmentDTO selectedDepartment;

        public AddDepartmentDialogue()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
            departmentManager = new DepartmentManager();
            
            roleManager = new RoleManager();
            allRoles= roleManager.GetAllRoles();
            InitializeRoleListBox();
        }
        public AddDepartmentDialogue(DepartmentDTO department) : this()
        {
            selectedDepartment = department;
            LoadDepartmentData();
        }

        private void InitializeRoleListBox()
        {
            listboxRole.Items.Clear();
            foreach (var role in allRoles)
            {
                listboxRole.Items.Add(role);
            }
            listboxRole.DisplayMember = "Role"; 
        }
        private void LoadDepartmentData()
        {
            if (selectedDepartment != null)
            {
                tbName.Text = selectedDepartment.Name;
                tbDescription.Text = selectedDepartment.Description;
                tbPointOfContact.Text = selectedDepartment.PointOfContact;
                UpdateAddedRolesListBox();
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tbName.Text) ||
                    string.IsNullOrWhiteSpace(tbDescription.Text) ||
                    string.IsNullOrWhiteSpace(tbPointOfContact.Text))
                {
                    lblErrorHandling.Text = "All fields must be provided!";
                    return;
                }

                if (selectedDepartment == null)
                {
                    selectedDepartment = new DepartmentDTO(0, tbName.Text, tbDescription.Text, tbPointOfContact.Text);
                }
                else
                {
                    selectedDepartment.Name = tbName.Text;
                    selectedDepartment.Description = tbDescription.Text;
                    selectedDepartment.PointOfContact = tbPointOfContact.Text;
                }

                if (selectedDepartment.Id == 0)
                {
                    departmentManager.AddDepartment(selectedDepartment);
                }
                else
                {
                    departmentManager.UpdateDepartment(selectedDepartment);
                }

                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                lblErrorHandling.Text = "An error occurred: " + ex.Message;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (listboxRole.SelectedItem == null || nUDNumber.Value == 0)
            {
                lblErrorHandling.Text = "Select a role and enter a number greater than 0!";
                return;
            }

            var selectedRole = (RoleDTO)listboxRole.SelectedItem;
            var numberOfEmployees = (int)nUDNumber.Value;
            if (selectedDepartment.RequiredPersonnel.ContainsKey(selectedRole.Id))
            {
                selectedDepartment.RequiredPersonnel[selectedRole.Id] = numberOfEmployees;
                UpdateAddedRolesListBox();
            }
            else
            {
                selectedDepartment.RequiredPersonnel.Add(selectedRole.Id, numberOfEmployees);
                listboxAdded.Items.Add($"{selectedRole.Role} - {numberOfEmployees}");
            }
        }

        private void UpdateAddedRolesListBox()
        {
            listboxAdded.Items.Clear();
            foreach (var rp in selectedDepartment.RequiredPersonnel)
            {
                var role = allRoles.FirstOrDefault(r => r.Id == rp.Key);
                if (role != null)
                {
                    listboxAdded.Items.Add($"{role.Role} - {rp.Value}");
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listboxAdded.SelectedItem == null)
            {
                lblErrorHandling.Text = "Select a role to remove!";
                return;
            }

            var selectedItem = listboxAdded.SelectedItem.ToString();
            var roleName = selectedItem.Split('-')[0].Trim();
            var role = allRoles.FirstOrDefault(r => r.Role == roleName);

            if (role != null && selectedDepartment.RequiredPersonnel.ContainsKey(role.Id))
            {
                selectedDepartment.RequiredPersonnel.Remove(role.Id);
                listboxAdded.Items.Remove(selectedItem);
            }
        }
    }
}
