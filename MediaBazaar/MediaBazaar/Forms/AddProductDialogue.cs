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
    public partial class addProductForm : Form
    {
        public ProductManager productManager { get; private set; }
        public addProductForm(ProductManager _productManager)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
            productManager = _productManager;
            foreach (var category in Enum.GetValues(typeof(ProductCategoryEum)))
            {
                addCategoryCombo.Items.Add(category);
            }
        }

        private void addFormProductBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(addModelTextBox.Text) ||
                    string.IsNullOrWhiteSpace(addBrandTextBox.Text) ||
                    addPriceNumeric.Value <= 0 ||
                    string.IsNullOrWhiteSpace(descriptionTextBox.Text) ||
                    addWeightNumeric.Value <= 0 ||
                    addHeightNumeric.Value <= 0 ||
                    addWidthNumeric.Value <= 0 ||
                    addDepthNumeric.Value <= 0 ||
                    addCategoryCombo.SelectedIndex < 0 ||
                    addStockNumeric.Value < 0)
                {
                    lblErrorHandling.Text = "Please fill out all fields correctly.";
                    return;
                }

                var model = addModelTextBox.Text;
                var brand = addBrandTextBox.Text;
                var price = addPriceNumeric.Value;
                var description = descriptionTextBox.Text;
                var weight = addWeightNumeric.Value;
                var height = addHeightNumeric.Value;
                var width = addWidthNumeric.Value;
                var depth = addDepthNumeric.Value;
                var category = (ProductCategoryEum)Enum.Parse(typeof(ProductCategoryEum), addCategoryCombo.SelectedItem.ToString());
                var stock = Decimal.ToInt32(addStockNumeric.Value);
                var product = new Product(0, model, brand, price, description, weight, height, width, depth, category, stock);
                productManager.AddProduct(product);
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                lblErrorHandling.Text = "An error occurred: " + ex.Message;
            }
        }
    }
}
