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

namespace MediaBazaar.Forms
{
    public partial class AddRoleDialogue : Form
    {

        private RoleManager roleManager;
        public AddRoleDialogue()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
            roleManager = new RoleManager();
        }


        private void createRoleBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tbName.Text))
                {
                    lblErrorHandling.Text = "Name must be provided!";

                    return;
                }

                roleManager.AddRole(new RoleDTO(1, tbName.Text));
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                lblErrorHandling.Text = "An error occured: " + ex.Message;
            }


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
