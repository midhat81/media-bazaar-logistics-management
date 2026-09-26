namespace MediaBazaar.Forms
{
    partial class addProductForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            addFormProductBtn = new CustomButton();
            addStockNumeric = new NumericUpDown();
            lblAddStock = new Label();
            lblErrorHandling = new Label();
            lblAddCategory = new Label();
            addCategoryCombo = new ComboBox();
            lblAddDescription = new Label();
            descriptionTextBox = new RichTextBox();
            dimensionsGroup = new GroupBox();
            addDepthNumeric = new NumericUpDown();
            addHeightNumeric = new NumericUpDown();
            addWidthNumeric = new NumericUpDown();
            lblAddWidth = new Label();
            lblAddDepth = new Label();
            lblAddHeight = new Label();
            addWeightNumeric = new NumericUpDown();
            lblAddWeight = new Label();
            addPriceNumeric = new NumericUpDown();
            lblAddPrice = new Label();
            addBrandTextBox = new TextBox();
            lblAddBrand = new Label();
            lblAddModel = new Label();
            addModelTextBox = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)addStockNumeric).BeginInit();
            dimensionsGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)addDepthNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)addHeightNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)addWidthNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)addWeightNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)addPriceNumeric).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(addFormProductBtn);
            panel1.Controls.Add(addStockNumeric);
            panel1.Controls.Add(lblAddStock);
            panel1.Controls.Add(lblErrorHandling);
            panel1.Controls.Add(lblAddCategory);
            panel1.Controls.Add(addCategoryCombo);
            panel1.Controls.Add(lblAddDescription);
            panel1.Controls.Add(descriptionTextBox);
            panel1.Controls.Add(dimensionsGroup);
            panel1.Controls.Add(addWeightNumeric);
            panel1.Controls.Add(lblAddWeight);
            panel1.Controls.Add(addPriceNumeric);
            panel1.Controls.Add(lblAddPrice);
            panel1.Controls.Add(addBrandTextBox);
            panel1.Controls.Add(lblAddBrand);
            panel1.Controls.Add(lblAddModel);
            panel1.Controls.Add(addModelTextBox);
            panel1.Location = new Point(34, 29);
            panel1.Name = "panel1";
            panel1.Size = new Size(805, 587);
            panel1.TabIndex = 0;
            // 
            // addFormProductBtn
            // 
            addFormProductBtn.BackColor = Color.DarkOrange;
            addFormProductBtn.BackgroundColor = Color.DarkOrange;
            addFormProductBtn.BorderColor = Color.White;
            addFormProductBtn.BorderRadius = 15;
            addFormProductBtn.BorderSize = 2;
            addFormProductBtn.Cursor = Cursors.Hand;
            addFormProductBtn.FlatStyle = FlatStyle.Flat;
            addFormProductBtn.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addFormProductBtn.ForeColor = Color.White;
            addFormProductBtn.Location = new Point(261, 518);
            addFormProductBtn.Margin = new Padding(3, 2, 3, 2);
            addFormProductBtn.Name = "addFormProductBtn";
            addFormProductBtn.Size = new Size(243, 48);
            addFormProductBtn.TabIndex = 33;
            addFormProductBtn.Text = "Add Product";
            addFormProductBtn.TextColor = Color.White;
            addFormProductBtn.UseVisualStyleBackColor = false;
            addFormProductBtn.Click += addFormProductBtn_Click;
            // 
            // addStockNumeric
            // 
            addStockNumeric.Font = new Font("Segoe UI", 14.25F);
            addStockNumeric.Location = new Point(584, 252);
            addStockNumeric.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            addStockNumeric.Name = "addStockNumeric";
            addStockNumeric.Size = new Size(154, 33);
            addStockNumeric.TabIndex = 27;
            // 
            // lblAddStock
            // 
            lblAddStock.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddStock.Location = new Point(482, 254);
            lblAddStock.Name = "lblAddStock";
            lblAddStock.Size = new Size(82, 30);
            lblAddStock.TabIndex = 26;
            lblAddStock.Text = "Stock:";
            lblAddStock.TextAlign = ContentAlignment.TopRight;
            // 
            // lblErrorHandling
            // 
            lblErrorHandling.Font = new Font("Segoe UI", 12F);
            lblErrorHandling.ForeColor = Color.Red;
            lblErrorHandling.Location = new Point(27, 436);
            lblErrorHandling.Name = "lblErrorHandling";
            lblErrorHandling.Size = new Size(745, 66);
            lblErrorHandling.TabIndex = 25;
            lblErrorHandling.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAddCategory
            // 
            lblAddCategory.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddCategory.Location = new Point(-7, 251);
            lblAddCategory.Name = "lblAddCategory";
            lblAddCategory.Size = new Size(116, 30);
            lblAddCategory.TabIndex = 16;
            lblAddCategory.Text = "Category:";
            lblAddCategory.TextAlign = ContentAlignment.TopRight;
            // 
            // addCategoryCombo
            // 
            addCategoryCombo.Font = new Font("Segoe UI", 14.25F);
            addCategoryCombo.FormattingEnabled = true;
            addCategoryCombo.Location = new Point(115, 249);
            addCategoryCombo.Name = "addCategoryCombo";
            addCategoryCombo.Size = new Size(262, 33);
            addCategoryCombo.TabIndex = 15;
            // 
            // lblAddDescription
            // 
            lblAddDescription.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddDescription.Location = new Point(27, 315);
            lblAddDescription.Name = "lblAddDescription";
            lblAddDescription.Size = new Size(133, 30);
            lblAddDescription.TabIndex = 14;
            lblAddDescription.Text = "Description:";
            lblAddDescription.TextAlign = ContentAlignment.TopRight;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Font = new Font("Segoe UI", 14.25F);
            descriptionTextBox.Location = new Point(27, 348);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(745, 86);
            descriptionTextBox.TabIndex = 13;
            descriptionTextBox.Text = "";
            // 
            // dimensionsGroup
            // 
            dimensionsGroup.Controls.Add(addDepthNumeric);
            dimensionsGroup.Controls.Add(addHeightNumeric);
            dimensionsGroup.Controls.Add(addWidthNumeric);
            dimensionsGroup.Controls.Add(lblAddWidth);
            dimensionsGroup.Controls.Add(lblAddDepth);
            dimensionsGroup.Controls.Add(lblAddHeight);
            dimensionsGroup.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dimensionsGroup.Location = new Point(450, 31);
            dimensionsGroup.Name = "dimensionsGroup";
            dimensionsGroup.Size = new Size(306, 182);
            dimensionsGroup.TabIndex = 12;
            dimensionsGroup.TabStop = false;
            dimensionsGroup.Text = "Dimensions";
            // 
            // addDepthNumeric
            // 
            addDepthNumeric.DecimalPlaces = 2;
            addDepthNumeric.Font = new Font("Segoe UI", 14.25F);
            addDepthNumeric.Location = new Point(135, 130);
            addDepthNumeric.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            addDepthNumeric.Name = "addDepthNumeric";
            addDepthNumeric.Size = new Size(154, 33);
            addDepthNumeric.TabIndex = 15;
            // 
            // addHeightNumeric
            // 
            addHeightNumeric.DecimalPlaces = 2;
            addHeightNumeric.Font = new Font("Segoe UI", 14.25F);
            addHeightNumeric.Location = new Point(135, 87);
            addHeightNumeric.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            addHeightNumeric.Name = "addHeightNumeric";
            addHeightNumeric.Size = new Size(154, 33);
            addHeightNumeric.TabIndex = 14;
            // 
            // addWidthNumeric
            // 
            addWidthNumeric.DecimalPlaces = 2;
            addWidthNumeric.Font = new Font("Segoe UI", 14.25F);
            addWidthNumeric.Location = new Point(135, 41);
            addWidthNumeric.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            addWidthNumeric.Name = "addWidthNumeric";
            addWidthNumeric.Size = new Size(154, 33);
            addWidthNumeric.TabIndex = 13;
            // 
            // lblAddWidth
            // 
            lblAddWidth.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddWidth.Location = new Point(7, 41);
            lblAddWidth.Name = "lblAddWidth";
            lblAddWidth.Size = new Size(122, 33);
            lblAddWidth.TabIndex = 9;
            lblAddWidth.Text = "Width (cm):";
            lblAddWidth.TextAlign = ContentAlignment.TopRight;
            // 
            // lblAddDepth
            // 
            lblAddDepth.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddDepth.Location = new Point(7, 130);
            lblAddDepth.Name = "lblAddDepth";
            lblAddDepth.Size = new Size(122, 33);
            lblAddDepth.TabIndex = 11;
            lblAddDepth.Text = "Depth (cm):";
            lblAddDepth.TextAlign = ContentAlignment.TopRight;
            // 
            // lblAddHeight
            // 
            lblAddHeight.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddHeight.Location = new Point(6, 87);
            lblAddHeight.Name = "lblAddHeight";
            lblAddHeight.Size = new Size(123, 33);
            lblAddHeight.TabIndex = 10;
            lblAddHeight.Text = "Height (cm):";
            lblAddHeight.TextAlign = ContentAlignment.TopRight;
            // 
            // addWeightNumeric
            // 
            addWeightNumeric.DecimalPlaces = 2;
            addWeightNumeric.Font = new Font("Segoe UI", 14.25F);
            addWeightNumeric.Location = new Point(174, 194);
            addWeightNumeric.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            addWeightNumeric.Name = "addWeightNumeric";
            addWeightNumeric.Size = new Size(147, 33);
            addWeightNumeric.TabIndex = 8;
            // 
            // lblAddWeight
            // 
            lblAddWeight.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddWeight.Location = new Point(3, 197);
            lblAddWeight.Name = "lblAddWeight";
            lblAddWeight.Size = new Size(123, 30);
            lblAddWeight.TabIndex = 7;
            lblAddWeight.Text = "Weight (kg):";
            lblAddWeight.TextAlign = ContentAlignment.TopRight;
            // 
            // addPriceNumeric
            // 
            addPriceNumeric.DecimalPlaces = 2;
            addPriceNumeric.Font = new Font("Segoe UI", 14.25F);
            addPriceNumeric.Location = new Point(174, 141);
            addPriceNumeric.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            addPriceNumeric.Name = "addPriceNumeric";
            addPriceNumeric.Size = new Size(147, 33);
            addPriceNumeric.TabIndex = 6;
            // 
            // lblAddPrice
            // 
            lblAddPrice.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddPrice.Location = new Point(27, 143);
            lblAddPrice.Name = "lblAddPrice";
            lblAddPrice.Size = new Size(82, 30);
            lblAddPrice.TabIndex = 5;
            lblAddPrice.Text = "Price:";
            lblAddPrice.TextAlign = ContentAlignment.TopRight;
            // 
            // addBrandTextBox
            // 
            addBrandTextBox.Font = new Font("Segoe UI Semibold", 14.25F);
            addBrandTextBox.Location = new Point(115, 90);
            addBrandTextBox.Name = "addBrandTextBox";
            addBrandTextBox.Size = new Size(262, 33);
            addBrandTextBox.TabIndex = 4;
            // 
            // lblAddBrand
            // 
            lblAddBrand.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddBrand.Location = new Point(27, 93);
            lblAddBrand.Name = "lblAddBrand";
            lblAddBrand.Size = new Size(82, 30);
            lblAddBrand.TabIndex = 3;
            lblAddBrand.Text = "Brand:";
            lblAddBrand.TextAlign = ContentAlignment.TopRight;
            // 
            // lblAddModel
            // 
            lblAddModel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddModel.Location = new Point(27, 34);
            lblAddModel.Name = "lblAddModel";
            lblAddModel.Size = new Size(82, 30);
            lblAddModel.TabIndex = 2;
            lblAddModel.Text = "Model:";
            lblAddModel.TextAlign = ContentAlignment.TopRight;
            // 
            // addModelTextBox
            // 
            addModelTextBox.Font = new Font("Segoe UI Semibold", 14.25F);
            addModelTextBox.Location = new Point(115, 31);
            addModelTextBox.Name = "addModelTextBox";
            addModelTextBox.Size = new Size(262, 33);
            addModelTextBox.TabIndex = 1;
            // 
            // addProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OrangeRed;
            ClientSize = new Size(870, 648);
            Controls.Add(panel1);
            Name = "addProductForm";
            Text = "Add Product";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)addStockNumeric).EndInit();
            dimensionsGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)addDepthNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)addHeightNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)addWidthNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)addWeightNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)addPriceNumeric).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblAddModel;
        private TextBox addModelTextBox;
        private NumericUpDown addPriceNumeric;
        private Label lblAddPrice;
        private TextBox addBrandTextBox;
        private Label lblAddBrand;
        private NumericUpDown addWeightNumeric;
        private Label lblAddWeight;
        private Label lblAddDepth;
        private Label lblAddHeight;
        private Label lblAddWidth;
        private GroupBox dimensionsGroup;
        private NumericUpDown addDepthNumeric;
        private NumericUpDown addHeightNumeric;
        private NumericUpDown addWidthNumeric;
        private Label lblAddCategory;
        private ComboBox addCategoryCombo;
        private Label lblAddDescription;
        private RichTextBox descriptionTextBox;
        private CustomButton btnSubmit;
        private Label lblErrorHandling;
        private NumericUpDown addStockNumeric;
        private Label lblAddStock;
        private CustomButton addFormProductBtn;
    }
}