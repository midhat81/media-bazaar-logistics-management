using MediaBazaar.Classes;
using MediaBazaar.Forms;
using DTOLayer;
using BusinessLogicLayer;

namespace MediaBazaar
{

    public partial class MainForm : Form
    {
        private EmployeeManager employeeManager;
        private EmployeeWorksheetManager worksheetManager;
        private ProductManager productManager;
        private UserControlDashboard userControlDashboard;
        private UserControlWorksheet userControlWorksheet;
        private UserControlDeport userControlDeport;
        private UserControlRole userControlRole;
        private UserControlDepartment userControlDepartment;
        private UserControlRestock userControlRestock;



        public MainForm(EmployeeManager _employeeManager, EmployeeWorksheetManager _worksheetManager, ProductManager _productManager,Role userRole)
        {
            employeeManager = _employeeManager;
            worksheetManager = _worksheetManager;
            productManager = _productManager;
            Application.EnableVisualStyles();
            InitializeComponent();
            userControlDashboard = new UserControlDashboard(employeeManager, worksheetManager);
            userControlWorksheet = new UserControlWorksheet(employeeManager, worksheetManager);
            userControlDeport = new UserControlDeport(productManager);
            userControlRole = new UserControlRole();
            userControlDepartment = new UserControlDepartment();
            userControlRestock = new UserControlRestock();
            Controls.Add(userControlDashboard);
            Controls.Add(userControlWorksheet);
            Controls.Add(userControlDeport);
            Controls.Add(userControlRestock);

            userControlDashboard.Show();
            userControlWorksheet.Hide();
            userControlDeport.Hide();
            userControlDeport.Hide();
            if (userRole.role == "DepotWorker")
            {
                userControlDeport.Show();
                userControlDashboard.Hide();
                userControlWorksheet.Hide();
                userControlRestock.Show();
                btnDashboard.Hide();
                btnWorksheet.Hide();
                lineEmployee.Hide(); 
                worksheetLine.Hide();
            }
            else if(userRole.role == "HRManager")
            {
                worksheetLine.Visible = true;
                lineEmployee.Visible = true;
                lineProduct.Visible = true;
                lineRestock.Visible = true;
                userControlDashboard.Show();
                userControlWorksheet.Hide();
                userControlDeport.Hide();
                btnProduct.Hide();
                lineProduct.Hide();
            }

            else
            {
                Controls.Add(userControlRole);
                Controls.Add(userControlDepartment);
                userControlDashboard.Hide();
                userControlWorksheet.Hide();
                userControlDeport.Hide();
                userControlDepartment.Hide();
                userControlRole.Show();
                btnProduct.Hide();

                lineProduct.Hide();
                btnDashboard.Text = "Roles";
                btnWorksheet.Text = "Departments";
            }

            this.Resize += MainForm_Resize;
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            pictureBoxJupiter.Location = new Point(25, -4);
            pictureBoxLogo.Location = new Point(pictureBoxJupiter.Right + 10, 0);
            btnDashboard.Location = new Point(panel1.Width / 5 - btnDashboard.Width / 2, 8); 
            btnWorksheet.Location = new Point(panel1.Width * 2 / 5 - btnWorksheet.Width / 2, 8); 
            btnProduct.Location = new Point(panel1.Width * 3 / 5 - btnProduct.Width / 2, 8); 
            btnRestocks.Location = new Point(panel1.Width * 4 / 5 - btnRestocks.Width / 2, 8); 
            logOutBtn.Location = new Point(panel1.Width - logOutBtn.Width - 25, 9);
            worksheetLine.Location = new Point(btnDashboard.Location.X + (btnDashboard.Width - worksheetLine.Width) / 2, btnDashboard.Location.Y + btnDashboard.Height + 10);
            lineEmployee.Location = new Point(btnWorksheet.Location.X + (btnWorksheet.Width - lineEmployee.Width) / 2, btnWorksheet.Location.Y + btnWorksheet.Height + 10);
            lineProduct.Location = new Point(btnProduct.Location.X + (btnProduct.Width - lineProduct.Width) / 2, btnProduct.Location.Y + btnProduct.Height + 10);
            lineRestock.Location = new Point(btnRestocks.Location.X + (btnRestocks.Width - lineRestock.Width) / 2, btnRestocks.Location.Y + btnRestocks.Height + 10);
            userControlDashboard.Size = new Size(this.ClientSize.Width, this.ClientSize.Height - panel1.Height);
            userControlDashboard.Location = new Point(0, panel1.Height);
            userControlWorksheet.Size = new Size(this.ClientSize.Width, this.ClientSize.Height - panel1.Height);
            userControlWorksheet.Location = new Point(0, panel1.Height);
            userControlDeport.Size = new Size(this.ClientSize.Width, this.ClientSize.Height - panel1.Height);
            userControlDeport.Location = new Point(0, panel1.Height);
            userControlRestock.Size = new Size(this.ClientSize.Width, this.ClientSize.Height - panel1.Height);
            userControlRestock.Location = new Point(0, panel1.Height);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            if (btnDashboard.Text != "Roles")
            {
                userControlWorksheet.Hide();
                userControlDeport.Hide();
                userControlDashboard.InitializeData();
                userControlDashboard.Show();
            }
            else
            {
                userControlDepartment.Hide();
               
                userControlRole.Show();
            }
        }

        private void btnWorksheet_Click(object sender, EventArgs e)
        {
            if (btnWorksheet.Text != "Departments")
            {
                userControlDashboard.Hide();
                userControlDeport.Hide();
                userControlWorksheet.PopulateWorksheetData();
                userControlWorksheet.Show();
            }
            else
            {
                userControlRole.Hide();
                userControlRestock.Hide();
                userControlDepartment.Show();
            }
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            userControlDashboard.Hide();
            userControlWorksheet.Hide();
            userControlDeport.InitializeProductData();
            userControlDeport.ClearProductDetails();
            userControlDeport.Show();
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            Authentication authForm = new Authentication();
            this.Hide();
            authForm.ShowDialog();
            if (authForm.isAuthenticated)
            {
                this.Show();
            }
            else
            {
                this.Close();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnRestocks_Click(object sender, EventArgs e)
        {
            userControlDashboard.Hide();
            userControlWorksheet.Hide();
            userControlDeport.Hide();
            userControlRestock.LoadRestockRequests();
            userControlRestock.Show();
        }
    }
}
