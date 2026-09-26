using BusinessLogicLayer;
using DataAccessLayer;
using DTOLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace MediaBazaar.Forms
{
    public partial class UserControlDeport : UserControl
    {
        public ProductManager productManager { get; private set; }
        private DataTable productData;
        public UserControlDeport(ProductManager _productManager)
        {
            this.productManager = _productManager;
            InitializeComponent();
            Load += UserControlDeport_Load;
            this.Resize += UserControlDeport_Resize;
            productsGrid.CellClick += ProductsGrid_CellClick;
            this.MinimumSize = new Size(800, 600);
            textBoxSearch.KeyPress += textBoxSearch_KeyPress;
        }

        private void UserControlDeport_Load(object sender, EventArgs e)
        {
            InitializeProductData();
            InitializeControls();
            productsGrid.ClearSelection();
            productDetailsGroupbox.Visible = false;
        }
        private void InitializeControls()
        {
            // Initialize controls here
            productsGrid.AutoGenerateColumns = false;
            productsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            productsGrid.AllowUserToAddRows = false;
            productsGrid.EnableHeadersVisualStyles = false;
            productsGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(33, 150, 243);
            productsGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            productsGrid.DefaultCellStyle.BackColor = Color.White;
            productsGrid.DefaultCellStyle.ForeColor = Color.FromArgb(33, 33, 33);
            productsGrid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(200, 200, 200);
            productsGrid.DefaultCellStyle.SelectionForeColor = Color.FromArgb(33, 33, 33);
            productsGrid.RowHeadersVisible = false;
            productsGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            productsGrid.Font = new Font("Segoe UI Semibold", 14);
            productsGrid.Columns["Id"].Visible = false;
            productsGrid.BorderStyle = BorderStyle.None;
            productsGrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            productsGrid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(235, 235, 235);
            productsGrid.DefaultCellStyle.SelectionForeColor = Color.FromArgb(33, 33, 33);
            productsGrid.BackgroundColor = Color.White;
            foreach (var category in Enum.GetValues(typeof(ProductCategoryEum)))
            {
                comboBoxCategory.Items.Add(category.ToString());
            }
            productsGrid.CellMouseEnter += (sender, e) =>
            {
                if (e.RowIndex >= 0)
                {
                    productsGrid.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
                }
            };

            productsGrid.CellMouseLeave += (sender, e) =>
            {
                if (e.RowIndex >= 0)
                {
                    productsGrid.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                }
            };
            productsGrid.ScrollBars = ScrollBars.Vertical;
        }


        public void InitializeProductData()
        {
            productData = new DataTable();
            productData.Columns.Add("Id", typeof(int));
            productData.Columns.Add("Model", typeof(string));
            productData.Columns.Add("Brand", typeof(string));
            productData.Columns.Add("Price", typeof(decimal));
            productData.Columns.Add("Category", typeof(string));
            productData.Columns.Add("Stock", typeof(int));
            productData.Clear();
            productManager.GetAllProducts();
            if (productManager.Products.Count > 0)
            {
                foreach (Product product in productManager.Products)
                {
                    productData.Rows.Add(product.Id, product.Model, product.Brand, product.Price, product.Category.ToString(), product.Stock);
                }
            }
            else
            {
                productsErrorLabel.Text = "No products loaded from the database.";
            }
            productsGrid.RowTemplate.Height = 70;
            productsGrid.DataSource = productData;
            productsGrid.ClearSelection();
        }

        private void UserControlDeport_Resize(object sender, EventArgs e)
        {
            int padding = 31;
            int groupBoxWidth = this.ClientSize.Width / 4;
            int otherControlsWidth = this.ClientSize.Width - groupBoxWidth - 2 * padding;

            panelOperationsProduct.Width = otherControlsWidth;
            panelOperationsProduct.Location = new Point(padding, 73);

            productsGrid.Size = new Size(otherControlsWidth, this.ClientSize.Height - 200);
            productsGrid.Location = new Point(padding, panelOperationsProduct.Bottom + 10);

            productDetailsGroupbox.Size = new Size(groupBoxWidth, this.ClientSize.Height - 100);
            productDetailsGroupbox.Location = new Point(this.ClientSize.Width - productDetailsGroupbox.Width - padding, padding);

            textBoxSearch.Width = categoryFilter.Location.X - searchPictureBox.Width - textBoxSearch.Location.X - 10;
            searchPictureBox.Location = new Point(textBoxSearch.Location.X + textBoxSearch.Width, textBoxSearch.Location.Y);

            productsErrorLabel.Location = new Point(productsGrid.Location.X, productsGrid.Bottom + 5);
        }

        private void ProductsGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < productsGrid.Rows.Count)
            {
                DataGridViewRow row = this.productsGrid.Rows[e.RowIndex];
                int selectedProductId = Convert.ToInt32(row.Cells["Id"].Value);
                // Populate the fields in the product Details Group box
                textBoxModel.Text = row.Cells["Model"].Value.ToString();
                textBoxBrand.Text = row.Cells["Brand"].Value.ToString();
                priceNumericUpDown.Value = Convert.ToDecimal(row.Cells["Price"].Value);
                numericUpDownStock.Value = Convert.ToInt32(row.Cells["Stock"].Value);
                // Get the product details from the Product Manager
                Product product = productManager.GetProductById(selectedProductId);
                if (product != null)
                {
                    textBoxDescription.Text = product.Description;
                    numericUpDownWeight.Value = product.Weight;
                    numericUpDownWidth.Value = product.Width;
                    numericUpDownHeight.Value = product.Height;
                    numericUpDownDepth.Value = product.Depth;
                    comboBoxCategory.SelectedItem = product.Category.ToString();
                }
                productDetailsGroupbox.Visible = true;
            }
        }

        private void UserControlDeport_MouseClick(object sender, MouseEventArgs e)
        {
            if (!productsGrid.RectangleToScreen(productsGrid.DisplayRectangle).Contains(e.Location) && !productDetailsGroupbox.RectangleToScreen(productDetailsGroupbox.DisplayRectangle).Contains(e.Location))
            {
                ClearProductDetails();
            }
        }

        public void ClearProductDetails()
        {
            textBoxModel.Text = "";
            textBoxBrand.Text = "";
            priceNumericUpDown.Value = 0;
            textBoxDescription.Text = "";
            numericUpDownWeight.Value = 0;
            numericUpDownWidth.Value = 0;
            numericUpDownHeight.Value = 0;
            numericUpDownDepth.Value = 0;
            comboBoxCategory.SelectedIndex = -1;
            numericUpDownStock.Value = 0;
            productDetailsGroupbox.Visible = false;
        }

        private void searchPictureBox_Click(object sender, EventArgs e)
        {
            Search();
        }

        // Enter search term and press Enter to search
        private void textBoxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Search();
                e.Handled = true;
            }
        }


        private void categoryFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search();
        }
        private void updateProductBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (productsGrid.SelectedRows.Count > 0)
                {
                    if (string.IsNullOrWhiteSpace(textBoxModel.Text) ||
               string.IsNullOrWhiteSpace(textBoxBrand.Text) ||
               priceNumericUpDown.Value <= 0 ||
               string.IsNullOrWhiteSpace(textBoxDescription.Text) ||
               numericUpDownWeight.Value <= 0 ||
               numericUpDownHeight.Value <= 0 ||
               numericUpDownWidth.Value <= 0 ||
               numericUpDownDepth.Value <= 0 ||
               comboBoxCategory.SelectedIndex < 0 ||
               numericUpDownStock.Value < 0)
                    {
                        productsErrorLabel.Text = "Please fill out all fields correctly.";
                        return;
                    }
                    int selectedProductId = Convert.ToInt32(productsGrid.SelectedRows[0].Cells["Id"].Value);
                    Product selectedProduct = productManager.GetProductById(selectedProductId);
                    string model = textBoxModel.Text;
                    string brand = textBoxBrand.Text;
                    decimal price = priceNumericUpDown.Value;
                    string description = textBoxDescription.Text;
                    decimal weight = numericUpDownWeight.Value;
                    decimal width = numericUpDownWidth.Value;
                    decimal height = numericUpDownHeight.Value;
                    decimal depth = numericUpDownDepth.Value;
                    ProductCategoryEum category = (ProductCategoryEum)Enum.Parse(typeof(ProductCategoryEum), comboBoxCategory.SelectedItem.ToString());
                    int stock = (int)numericUpDownStock.Value;
                    selectedProduct.UpdateProduct(model, brand, price, description, weight, height, width, depth, category, stock);
                    productManager.UpdateProduct(selectedProduct);
                    InitializeProductData();
                    productsErrorLabel.Text = "";
                }
            }
            catch (Exception ex)
            {
                productsErrorLabel.Text = "An error occurred: " + ex.Message;
            }
        }



        private void removeProductBtn_Click(object sender, EventArgs e)
        {
            if (productsGrid.SelectedRows.Count > 0)
            {
                int selectedProductId = Convert.ToInt32(productsGrid.SelectedRows[0].Cells["Id"].Value);
                productManager.DeleteProduct(selectedProductId);
                InitializeProductData();
                productsErrorLabel.Text = "";
            }
        }

        private void addProductBtn_Click(object sender, EventArgs e)
        {
            try
            {
                addProductForm AddProductForm = new addProductForm(productManager);
                if (AddProductForm.ShowDialog(this.ParentForm) == DialogResult.OK)
                {
                    InitializeProductData();
                    productsErrorLabel.Text = "";
                }
            }
            catch (Exception ex)
            {
                productsErrorLabel.Text = "An error occurred: " + ex.Message;
            }
        }

        private void Search()
        {
            string searchTerm = textBoxSearch.Text.Trim();
            string selectedCategory = categoryFilter.SelectedItem?.ToString();
            var query = productData.AsEnumerable();
            if (!string.IsNullOrEmpty(selectedCategory) && selectedCategory != "Any Category")
            {
                query = query.Where(row => row.Field<string>("Category") == selectedCategory);
            }

            if (!string.IsNullOrEmpty(searchTerm))
            {
                query = query.Where(row => row.Field<string>("Model").Contains(searchTerm) || row.Field<string>("Brand").Contains(searchTerm));
            }

            DataTable searchResults = query.Any() ? query.CopyToDataTable() : productData.Clone();
            productsGrid.DataSource = searchResults;
            productsGrid.ClearSelection();
        }
    }
}
