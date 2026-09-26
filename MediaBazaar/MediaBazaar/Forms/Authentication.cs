using System;
using BusinessLogicLayer;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTOLayer;
using MediaBazaar.Classes;

namespace MediaBazaar.Forms
{
    public partial class Authentication : Form
    {
        public EmployeeManager employeeManager { get; private set; }
        public EmployeeWorksheetManager worksheetManager { get; private set; }
        public ProductManager productManager { get; private set; }
        public bool isAuthenticated { get; private set; } = false;
        public Role UserRole { get; private set; }
        public Authentication()
        {
            employeeManager = new EmployeeManager();
            worksheetManager = new EmployeeWorksheetManager();
            productManager = new ProductManager();
            InitializeComponent();
            passwordLoginTxt.PasswordChar = '*';
            this.Resize += AuthenticationForm_Resize;
            passwordLoginTxt.KeyDown += passwordLoginTxt_KeyDown;
        }


        // Responsive UI Design for Authentication Form Elements
        private void AuthenticationForm_Resize(object sender, EventArgs e)
        {
            int groupX = (this.ClientSize.Width - loginFormGroup.Width) / 2;
            int groupY = (this.ClientSize.Height - loginFormGroup.Height) / 2;
            loginFormGroup.Location = new Point(groupX, groupY);
            int statusLabelX = groupX;
            int statusLabelY = groupY + loginFormGroup.Height + 10;
            int labelX = groupX + (loginFormGroup.Width - label1.Width) / 2;
            int labelY = groupY - label1.Height - 10;
            label1.Location = new Point(labelX, labelY);
            pictureBoxJupiter.Location = new Point(groupX + (loginFormGroup.Width - pictureBoxJupiter.Width) / 2, groupY - pictureBoxJupiter.Height - label1.Height - 20);
            loginStatusLabel.Location = new Point(statusLabelX, statusLabelY);
            loginBtn.Location = new Point(groupX + (loginFormGroup.Width - loginBtn.Width) / 2, statusLabelY + loginStatusLabel.Height + 10);
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string email = userNameLoginTxt.Text;
            string password = passwordLoginTxt.Text;

            try
            {
                Employee employee = employeeManager.AuthenticateEmployee(email, password);

                if (employee != null)
                {
                    UserRole = employee.Role;
                    if (employee.IsManager || (UserRole.role=="DepotWorker"))
                    {
                        isAuthenticated = true;
                        this.Close();
                    }
                    else
                    {
                        throw (new Exception("⚠️ Invalid credentials or unauthorized access"));
                    }
                }
            }
            catch (Exception ex)
            {
                loginStatusLabel.Text = ex.Message;
            }
        }

        private void passwordLoginTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginBtn_Click(sender, e);
            }
        }

    }
}
