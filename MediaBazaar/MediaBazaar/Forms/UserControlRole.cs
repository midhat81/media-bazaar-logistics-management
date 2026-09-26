using BusinessLogicLayer;
using DataAccessLayer;
using DTOLayer;
using MediaBazaar.Classes;
using MediaBazaar.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaBazaar
{
    public partial class UserControlRole : UserControl
    {
        private RoleManager roleManager;
        private DataTable roleData;
        private int selectedRole;
        public UserControlRole()
        {
            roleManager = new RoleManager();
            InitializeComponent();
            InitializeFocus();
            Load += UserControlRole_Load;
            this.Resize += UserControlRole_Resize;
            userDataGridView.CellClick += userDataGridView_CellClick;
            PopulateRoleData();
        }

        private void InitializeFocus()
        {
            textBoxSearch.GotFocus += new System.EventHandler(textBoxSearch_GotFocus);
            textBoxSearch.LostFocus += new System.EventHandler(textBoxSearch_LostFocus);
        }

        public void PopulateRoleData()
        {
            roleData = new DataTable();
            roleData.Columns.Add("ID", typeof(int));
            roleData.Columns.Add("Name", typeof(string));
          
           
            
            foreach (RoleDTO role in roleManager.GetAllRoles())
            {
              
                
                roleData.Rows.Add(role.Id,role.Role);
            }
            userDataGridView.DataSource = roleData;
            userDataGridView.ClearSelection();
            userDataGridView.RowTemplate.Height = 70;
        }

        private void UserControlRole_Load(object sender, EventArgs e)
        {
            InitializeGridViewRole();
            userDataGridView.ClearSelection();
            groupBox1.Visible = false;
        }

        private void UserControlRole_Resize(object sender, EventArgs e)
        {
            int padding = 31;
            int groupBoxWidth = this.ClientSize.Width / 4;
            int otherControlsWidth = this.ClientSize.Width - groupBoxWidth - 2 * padding;
            panelOperations.Width = otherControlsWidth;
            panelOperations.Location = new Point(padding, 73);
            userDataGridView.Size = new Size(otherControlsWidth, this.ClientSize.Height - 200);
            userDataGridView.Location = new Point(padding, panelOperations.Bottom + 10);
            groupBox1.Size = new Size(groupBoxWidth, this.ClientSize.Height - 100);
            groupBox1.Location = new Point(this.ClientSize.Width - groupBox1.Width - padding, padding);
            textBoxSearch.Width =  pictureBoxSearch.Width - textBoxSearch.Location.X - 10;
            pictureBoxSearch.Location = new Point(textBoxSearch.Location.X + textBoxSearch.Width, textBoxSearch.Location.Y);
        }

        private void InitializeGridViewRole()
        {
            userDataGridView.AutoGenerateColumns = false;
            userDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            userDataGridView.AllowUserToAddRows = false;
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
            userDataGridView.ScrollBars = ScrollBars.Vertical;
            userDataGridView.SelectionChanged += userDataGridView_SelectionChanged;
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

        private void userDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < roleData.Rows.Count)
            {
                DataGridViewRow selectedRow = userDataGridView.Rows[e.RowIndex];
                string roleName= selectedRow.Cells["Name"].Value.ToString();
                  
                        textBoxName.Text = roleName;
                selectedRole = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                  
                    textBoxName.Enabled = true;   
            }
        }

        private void addRoleBtn_Click(object sender, EventArgs e)
        {
            AddRoleDialogue addRoleDialogue = new AddRoleDialogue();
            addRoleDialogue.ShowDialog();
            PopulateRoleData();
            userDataGridView.DataSource = roleData;
            userDataGridView.ClearSelection();
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

        private void Search()
        {
            string searchTerm = textBoxSearch.Text.Trim();
           
            var query = roleData.AsEnumerable();
            try
            {
               

                if (!string.IsNullOrEmpty(searchTerm))
                {
                    query = query.Where(row => row.Field<string>("Name").Contains(searchTerm));
                }
                DataTable searchResults = query.Any() ? query.CopyToDataTable() : roleData.Clone();
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

        private void removeRoleBtn_Click(object sender, EventArgs e)
        {
            roleManager.DeleteRole(selectedRole);
            PopulateRoleData();
        }

        private void editRoleBtn_Click(Object sender, EventArgs e)
        {
            if (editRoleBtn.Text != "Save")
            {
                editRoleBtn.Text = "Save";
                textBoxName.ReadOnly = false;
            }
            else
            {
                RoleDTO updatedRole;
                try
                {
                    updatedRole = new RoleDTO(selectedRole, textBoxName.Text);
                    roleManager.UpdateRole(updatedRole);
                    PopulateRoleData();
                    editRoleBtn.Text = "Edit";
                }
                catch (Exception ex)
                {
                    throw new Exception("There was an error updating: ", ex);
                }
            }
        }
    }
}
