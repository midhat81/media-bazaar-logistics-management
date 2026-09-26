using BusinessLogicLayer;
using DataAccessLayer;
using DataAccessLayer.Interfaces;
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
    public partial class UserControlRestock : UserControl
    {
        private RestockRequestManager restockRequestManager;
        public UserControlRestock()
        {
            InitializeComponent();
            // Sizing and responsiveness
            this.Resize += UserControlRestock_Resize;
            this.MinimumSize = new Size(800, 600);
            // No DI from SOLID due to time constraints and refactoring complexity
            IRestockRequestDAL restockRequestDAL = new RestockRequestDAL();
            restockRequestManager = new RestockRequestManager(restockRequestDAL);
            InitializeRestockGrid();
            productDetailsGroupbox.Visible = false;
            restockGrid.SelectionChanged += restockGrid_SelectionChanged;
            LoadRestockRequests();
        }

        public void LoadRestockRequests()
        {
            var requests = restockRequestManager.GetAllRestockRequests().Select(r => new
            {
                r.RequestId,
                r.ProductId,
                r.ProductName,
                r.RequestedQuantity,
                r.Status,
                r.RequestDate,
                r.SenderName,
                ResponseDate = r.ResponseDate?.ToString("g") ?? "N/A"
            }).ToList();

            restockGrid.DataSource = requests;
            restockGrid.Columns["RequestId"].Visible = false;

            // Check if there are any requests
            if (requests.Any())
            {
                restockGrid.Visible = true;
                restockStatusLabel.Text = "";
            }
            else
            {
                restockGrid.Visible = true;
                restockStatusLabel.Text = "No restock requests found.";
                restockStatusLabel.ForeColor = Color.Red;
            }
        }


        private void restockGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (restockGrid.CurrentRow != null && restockGrid.CurrentRow.Selected)
            {
                string status = restockGrid.CurrentRow.Cells["Status"].Value.ToString();
                approveRequestBtn.Enabled = status.Equals("Pending", StringComparison.OrdinalIgnoreCase);
                denyRequestBtn.Enabled = status.Equals("Pending", StringComparison.OrdinalIgnoreCase);
                senderLabel.Text = restockGrid.CurrentRow.Cells["SenderName"].Value.ToString();
                productOutOfStockLabel.Text = restockGrid.CurrentRow.Cells["ProductName"].Value.ToString();

                productDetailsGroupbox.Visible = true;
            }
            else
            {
                productDetailsGroupbox.Visible = false;
            }
        }

        private void UserControlRestock_Resize(object sender, EventArgs e)
        {
            int padding = 31;
            int groupBoxWidth = this.ClientSize.Width / 4;
            int otherControlsWidth = this.ClientSize.Width - groupBoxWidth - 2 * padding;
            restockGrid.Size = new Size(otherControlsWidth, this.ClientSize.Height - 200);
            restockGrid.Location = new Point(padding, refreshBtnRestock.Bottom + 10);
            productDetailsGroupbox.Size = new Size(groupBoxWidth, this.ClientSize.Height - 100);
            productDetailsGroupbox.Location = new Point(this.ClientSize.Width - productDetailsGroupbox.Width - padding, padding);
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            LoadRestockRequests();
        }

        private void InitializeRestockGrid()
        {
            restockGrid.AutoGenerateColumns = false;
            restockGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            restockGrid.AllowUserToAddRows = false;
            restockGrid.EnableHeadersVisualStyles = false;
            restockGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(33, 150, 243);
            restockGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            restockGrid.DefaultCellStyle.BackColor = Color.White;
            restockGrid.DefaultCellStyle.ForeColor = Color.FromArgb(33, 33, 33);
            restockGrid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(200, 200, 200);
            restockGrid.DefaultCellStyle.SelectionForeColor = Color.FromArgb(33, 33, 33);
            restockGrid.RowTemplate.Height = 70;
            restockGrid.RowHeadersVisible = false;
            restockGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            restockGrid.Font = new Font("Segoe UI Semibold", 14);
            restockGrid.BorderStyle = BorderStyle.None;
            restockGrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            restockGrid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(235, 235, 235);
            restockGrid.DefaultCellStyle.SelectionForeColor = Color.FromArgb(33, 33, 33);
            restockGrid.BackgroundColor = Color.White;
            restockGrid.ScrollBars = ScrollBars.Vertical;
            // Define columns
            AddGridColumn("ProductName", "Product Name", false);
            AddGridColumn("RequestedQuantity", "Requested Quantity", false);
            AddGridColumn("Status", "Status", false);
            AddGridColumn("RequestDate", "Request Date", true);
            AddGridColumn("ResponseDate", "Response Date", true);
            AddGridColumn("SenderName", "Sender Name", false);
            var requestIdColumn = AddGridColumn("RequestId", "Request ID", false);
            requestIdColumn.Visible = false;

            restockGrid.CellMouseEnter += (sender, e) =>
            {
                if (e.RowIndex >= 0)
                {
                    restockGrid.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
                }
            };

            restockGrid.CellMouseLeave += (sender, e) =>
            {
                if (e.RowIndex >= 0)
                {
                    restockGrid.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                }
            };
        }

        private DataGridViewColumn AddGridColumn(string dataPropertyName, string headerText, bool isDate)
        {
            DataGridViewColumn column;
            if (isDate)
            {
                column = new DataGridViewTextBoxColumn
                {
                    DefaultCellStyle = new DataGridViewCellStyle { Format = "g" }
                };
            }
            else
            {
                column = new DataGridViewTextBoxColumn();
            }

            column.DataPropertyName = dataPropertyName;
            column.Name = dataPropertyName;
            column.HeaderText = headerText;
            restockGrid.Columns.Add(column);

            return column;
        }

        private void deleteRequestBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (restockGrid.CurrentRow != null)
                {
                    int requestId = Convert.ToInt32(restockGrid.CurrentRow.Cells["RequestId"].Value);
                    var confirmResult = MessageBox.Show("Are you sure to delete this item?", "Confirm Delete", MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        restockRequestManager.DeleteRestockRequest(requestId);
                        LoadRestockRequests();
                    }
                }
            }
            catch (Exception ex)
            {
                restockStatusLabel.Text = ex.Message;
            }
            finally
            {
                Task.Delay(3000).ContinueWith(t => restockStatusLabel.Text = "");

            }
        }

        private void approveRequestBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (restockGrid.CurrentRow != null)
                {
                    int requestId = Convert.ToInt32(restockGrid.CurrentRow.Cells["RequestId"].Value);
                    restockRequestManager.ApproveRestockRequest(requestId);
                    LoadRestockRequests();
                }
            }
            catch (Exception ex)
            {
                restockStatusLabel.Text = ex.Message;
            }
            finally
            {
                Task.Delay(3000).ContinueWith(t => restockStatusLabel.Text = "");
            }
        }

        private void denyRequestBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (restockGrid.CurrentRow != null)
                {
                    int requestId = Convert.ToInt32(restockGrid.CurrentRow.Cells["RequestId"].Value);
                    restockRequestManager.DenyRestockRequest(requestId);
                    LoadRestockRequests();
                }
            }
            catch (Exception ex)
            {
                restockStatusLabel.Text = ex.Message;
            }
            finally
            {
                Task.Delay(3000).ContinueWith(t => restockStatusLabel.Text = "");
            }
        }

        private void refreshBtnRestock_Click(object sender, EventArgs e)
        {
            LoadRestockRequests();
        }
    }
}