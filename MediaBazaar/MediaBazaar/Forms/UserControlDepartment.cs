using BusinessLogicLayer;
using DataAccessLayer;
using DTOLayer;
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
    public partial class UserControlDepartment : UserControl
    {
        private DepartmentManager departmentManager;
        private DataTable departmentData;
        private int selectedDepartment;
        public UserControlDepartment()
        {
            departmentManager = new DepartmentManager();
            InitializeComponent();
            InitializeFocus();
            Load += UserControlDepartment_Load;
            this.Resize += UserControlDepartment_Resize;
            departmentDataGridView.CellClick += departmentDataGridView_CellClick;
            PopulateDepartmentData();
        }

        private void InitializeFocus()
        {
            textBoxSearch.GotFocus += new System.EventHandler(textBoxSearch_GotFocus);
            textBoxSearch.LostFocus += new System.EventHandler(textBoxSearch_LostFocus);
        }

        public void PopulateDepartmentData()
        {
            departmentData = new DataTable();
            departmentData.Columns.Add("ID", typeof(int));
            departmentData.Columns.Add("Name", typeof(string));
            departmentData.Columns.Add("Description", typeof(string));
            departmentData.Columns.Add("PointOfContact", typeof(string));

            foreach (DepartmentDTO department in departmentManager.GetAllDepartments())
            {
                departmentData.Rows.Add(department.Id, department.Name, department.Description, department.PointOfContact);
            }
            departmentDataGridView.DataSource = departmentData;
            departmentDataGridView.ClearSelection();
            departmentDataGridView.RowTemplate.Height = 70;
        }

        private void UserControlDepartment_Load(object sender, EventArgs e)
        {
            InitializeGridViewDepartment();
            departmentDataGridView.ClearSelection();
            groupBox1.Visible = false;
        }

        private void UserControlDepartment_Resize(object sender, EventArgs e)
        {
            int padding = 31;
            int groupBoxWidth = this.ClientSize.Width / 4;
            int otherControlsWidth = this.ClientSize.Width - groupBoxWidth - 2 * padding;
            panelOperations.Width = otherControlsWidth;
            panelOperations.Location = new Point(padding, 73);
            departmentDataGridView.Size = new Size(otherControlsWidth, this.ClientSize.Height - 200);
            departmentDataGridView.Location = new Point(padding, panelOperations.Bottom + 10);
            groupBox1.Size = new Size(groupBoxWidth, this.ClientSize.Height - 100);
            groupBox1.Location = new Point(this.ClientSize.Width - groupBox1.Width - padding, padding);
            textBoxSearch.Width = pictureBoxSearch.Width - textBoxSearch.Location.X - 10;
            pictureBoxSearch.Location = new Point(textBoxSearch.Location.X + textBoxSearch.Width, textBoxSearch.Location.Y);
        }

        private void InitializeGridViewDepartment()
        {
            departmentDataGridView.AutoGenerateColumns = false;
            departmentDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            departmentDataGridView.AllowUserToAddRows = false;
            departmentDataGridView.EnableHeadersVisualStyles = false;
            departmentDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(33, 150, 243);
            departmentDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            departmentDataGridView.DefaultCellStyle.BackColor = Color.White;
            departmentDataGridView.DefaultCellStyle.ForeColor = Color.FromArgb(33, 33, 33);
            departmentDataGridView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(200, 200, 200);
            departmentDataGridView.DefaultCellStyle.SelectionForeColor = Color.FromArgb(33, 33, 33);
            departmentDataGridView.RowHeadersVisible = false;
            departmentDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            departmentDataGridView.Font = new Font("Segoe UI Semibold", 14);
            departmentDataGridView.EnableHeadersVisualStyles = false;
            departmentDataGridView.BorderStyle = BorderStyle.None;
            departmentDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            departmentDataGridView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(235, 235, 235);
            departmentDataGridView.DefaultCellStyle.SelectionForeColor = Color.FromArgb(33, 33, 33);
            departmentDataGridView.BackgroundColor = Color.White;
            departmentDataGridView.CellMouseEnter += (sender, e) =>
            {
                if (e.RowIndex >= 0)
                {
                    departmentDataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
                }
            };

            departmentDataGridView.CellMouseLeave += (sender, e) =>
            {
                if (e.RowIndex >= 0)
                {
                    departmentDataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                }
            };
            departmentDataGridView.ScrollBars = ScrollBars.Vertical;
            departmentDataGridView.SelectionChanged += departmentDataGridView_SelectionChanged;
        }

        private void departmentDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (departmentDataGridView.SelectedRows.Count > 0)
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

        private void departmentDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < departmentData.Rows.Count)
            {
                DataGridViewRow selectedRow = departmentDataGridView.Rows[e.RowIndex];
                string departmentName = selectedRow.Cells["Name"].Value.ToString();
                string departmentDescription = selectedRow.Cells["Description"].Value.ToString();
                string departmentPointOfContact = selectedRow.Cells["PointOfContact"].Value.ToString();
                selectedDepartment = Convert.ToInt32(selectedRow.Cells["Id"].Value);

                textBoxName.Text = departmentName;
                textBoxDescription.Text = departmentDescription;
                textBoxPointOfContact.Text = departmentPointOfContact;

                textBoxName.Enabled = true;
                textBoxDescription.Enabled = true;
                textBoxPointOfContact.Enabled = true;
            }
        }

        private void addDepartmentBtn_Click(object sender, EventArgs e)
        {
            AddDepartmentDialogue addDepartmentDialogue = new AddDepartmentDialogue();
            addDepartmentDialogue.ShowDialog();
            PopulateDepartmentData();
            departmentDataGridView.DataSource = departmentData;
            departmentDataGridView.ClearSelection();
        }

        private void editEmployeeBtn_Click(object sender, EventArgs e)
        {
            AddDepartmentDialogue addDepartmentDialogue = new AddDepartmentDialogue(departmentManager.GetDepartmentById(selectedDepartment));
            addDepartmentDialogue.ShowDialog();
            PopulateDepartmentData();
            departmentDataGridView.DataSource = departmentData;
            departmentDataGridView.ClearSelection();
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

            var query = departmentData.AsEnumerable();
            try
            {


                if (!string.IsNullOrEmpty(searchTerm))
                {
                    query = query.Where(row => row.Field<string>("Employee").Contains(searchTerm));
                }
                DataTable searchResults = query.Any() ? query.CopyToDataTable() : departmentData.Clone();
                departmentDataGridView.DataSource = searchResults;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while filtering: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                departmentDataGridView.ClearSelection();
            }
        }

        private void removeEmployeeBtn_Click(object sender, EventArgs e)
        {
            departmentManager.DeleteDepartment(selectedDepartment);
            PopulateDepartmentData();

        }

    }
}
