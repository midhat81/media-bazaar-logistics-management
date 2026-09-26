namespace MediaBazaar.Forms
{
    partial class UserControlRestock
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlRestock));
            restockGrid = new DataGridView();
            approveRequestBtn = new CustomButton();
            denyRequestBtn = new CustomButton();
            refreshBtnRestock = new CustomButton();
            productDetailsGroupbox = new GroupBox();
            productOutOfStockLabel = new Label();
            senderLabel = new Label();
            label3 = new Label();
            label1 = new Label();
            requestOperationsBox = new GroupBox();
            deleteRequestBtn = new CustomButton();
            productPictureBox = new PictureBox();
            productDetailsLabel = new Label();
            productImage = new PictureBox();
            restockStatusLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)restockGrid).BeginInit();
            productDetailsGroupbox.SuspendLayout();
            requestOperationsBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)productPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productImage).BeginInit();
            SuspendLayout();
            // 
            // restockGrid
            // 
            restockGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            restockGrid.Cursor = Cursors.Hand;
            restockGrid.Location = new Point(41, 129);
            restockGrid.Margin = new Padding(3, 2, 3, 2);
            restockGrid.Name = "restockGrid";
            restockGrid.RowHeadersWidth = 51;
            restockGrid.Size = new Size(1079, 564);
            restockGrid.TabIndex = 23;
            // 
            // approveRequestBtn
            // 
            approveRequestBtn.BackColor = Color.MediumSeaGreen;
            approveRequestBtn.BackgroundColor = Color.MediumSeaGreen;
            approveRequestBtn.BorderColor = Color.White;
            approveRequestBtn.BorderRadius = 15;
            approveRequestBtn.BorderSize = 2;
            approveRequestBtn.Cursor = Cursors.Hand;
            approveRequestBtn.FlatStyle = FlatStyle.Flat;
            approveRequestBtn.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            approveRequestBtn.ForeColor = Color.White;
            approveRequestBtn.Location = new Point(14, 36);
            approveRequestBtn.Margin = new Padding(3, 2, 3, 2);
            approveRequestBtn.Name = "approveRequestBtn";
            approveRequestBtn.Size = new Size(215, 44);
            approveRequestBtn.TabIndex = 33;
            approveRequestBtn.Text = "Approve Request";
            approveRequestBtn.TextColor = Color.White;
            approveRequestBtn.UseVisualStyleBackColor = false;
            approveRequestBtn.Click += approveRequestBtn_Click;
            // 
            // denyRequestBtn
            // 
            denyRequestBtn.BackColor = Color.Crimson;
            denyRequestBtn.BackgroundColor = Color.Crimson;
            denyRequestBtn.BorderColor = Color.White;
            denyRequestBtn.BorderRadius = 15;
            denyRequestBtn.BorderSize = 2;
            denyRequestBtn.Cursor = Cursors.Hand;
            denyRequestBtn.FlatStyle = FlatStyle.Flat;
            denyRequestBtn.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            denyRequestBtn.ForeColor = Color.White;
            denyRequestBtn.Location = new Point(14, 94);
            denyRequestBtn.Margin = new Padding(3, 2, 3, 2);
            denyRequestBtn.Name = "denyRequestBtn";
            denyRequestBtn.Size = new Size(219, 44);
            denyRequestBtn.TabIndex = 34;
            denyRequestBtn.Text = "Deny Request";
            denyRequestBtn.TextColor = Color.White;
            denyRequestBtn.UseVisualStyleBackColor = false;
            denyRequestBtn.Click += denyRequestBtn_Click;
            // 
            // refreshBtnRestock
            // 
            refreshBtnRestock.BackColor = Color.DarkOrange;
            refreshBtnRestock.BackgroundColor = Color.DarkOrange;
            refreshBtnRestock.BorderColor = Color.White;
            refreshBtnRestock.BorderRadius = 15;
            refreshBtnRestock.BorderSize = 2;
            refreshBtnRestock.Cursor = Cursors.Hand;
            refreshBtnRestock.FlatStyle = FlatStyle.Flat;
            refreshBtnRestock.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            refreshBtnRestock.ForeColor = Color.White;
            refreshBtnRestock.Location = new Point(892, 81);
            refreshBtnRestock.Margin = new Padding(3, 2, 3, 2);
            refreshBtnRestock.Name = "refreshBtnRestock";
            refreshBtnRestock.Size = new Size(228, 44);
            refreshBtnRestock.TabIndex = 35;
            refreshBtnRestock.Text = "Refresh Requests ♾️";
            refreshBtnRestock.TextColor = Color.White;
            refreshBtnRestock.UseVisualStyleBackColor = false;
            refreshBtnRestock.Click += refreshBtnRestock_Click;
            // 
            // productDetailsGroupbox
            // 
            productDetailsGroupbox.BackColor = Color.OrangeRed;
            productDetailsGroupbox.Controls.Add(productOutOfStockLabel);
            productDetailsGroupbox.Controls.Add(senderLabel);
            productDetailsGroupbox.Controls.Add(label3);
            productDetailsGroupbox.Controls.Add(label1);
            productDetailsGroupbox.Controls.Add(requestOperationsBox);
            productDetailsGroupbox.Controls.Add(productPictureBox);
            productDetailsGroupbox.Controls.Add(productDetailsLabel);
            productDetailsGroupbox.Controls.Add(productImage);
            productDetailsGroupbox.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            productDetailsGroupbox.Location = new Point(1126, 208);
            productDetailsGroupbox.Margin = new Padding(3, 2, 3, 2);
            productDetailsGroupbox.Name = "productDetailsGroupbox";
            productDetailsGroupbox.Padding = new Padding(3, 2, 3, 2);
            productDetailsGroupbox.Size = new Size(370, 335);
            productDetailsGroupbox.TabIndex = 36;
            productDetailsGroupbox.TabStop = false;
            // 
            // productOutOfStockLabel
            // 
            productOutOfStockLabel.BackColor = Color.Transparent;
            productOutOfStockLabel.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            productOutOfStockLabel.ForeColor = Color.Black;
            productOutOfStockLabel.Location = new Point(164, 103);
            productOutOfStockLabel.Name = "productOutOfStockLabel";
            productOutOfStockLabel.Size = new Size(196, 48);
            productOutOfStockLabel.TabIndex = 48;
            productOutOfStockLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // senderLabel
            // 
            senderLabel.BackColor = Color.Transparent;
            senderLabel.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            senderLabel.ForeColor = Color.Black;
            senderLabel.Location = new Point(164, 55);
            senderLabel.Name = "senderLabel";
            senderLabel.Size = new Size(196, 32);
            senderLabel.TabIndex = 47;
            senderLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(18, 92);
            label3.Name = "label3";
            label3.Size = new Size(140, 59);
            label3.TabIndex = 46;
            label3.Text = "Out of stock product:";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(74, 59);
            label1.Name = "label1";
            label1.Size = new Size(82, 28);
            label1.TabIndex = 45;
            label1.Text = "Sender:";
            // 
            // requestOperationsBox
            // 
            requestOperationsBox.Controls.Add(deleteRequestBtn);
            requestOperationsBox.Controls.Add(approveRequestBtn);
            requestOperationsBox.Controls.Add(denyRequestBtn);
            requestOperationsBox.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            requestOperationsBox.Location = new Point(18, 172);
            requestOperationsBox.Margin = new Padding(2);
            requestOperationsBox.Name = "requestOperationsBox";
            requestOperationsBox.Padding = new Padding(2);
            requestOperationsBox.Size = new Size(330, 159);
            requestOperationsBox.TabIndex = 44;
            requestOperationsBox.TabStop = false;
            requestOperationsBox.Text = "Request Operations";
            // 
            // deleteRequestBtn
            // 
            deleteRequestBtn.BackColor = Color.DarkSlateGray;
            deleteRequestBtn.BackgroundColor = Color.DarkSlateGray;
            deleteRequestBtn.BorderColor = Color.White;
            deleteRequestBtn.BorderRadius = 15;
            deleteRequestBtn.BorderSize = 2;
            deleteRequestBtn.Cursor = Cursors.Hand;
            deleteRequestBtn.FlatStyle = FlatStyle.Flat;
            deleteRequestBtn.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            deleteRequestBtn.ForeColor = Color.White;
            deleteRequestBtn.Location = new Point(241, 36);
            deleteRequestBtn.Margin = new Padding(3, 2, 3, 2);
            deleteRequestBtn.Name = "deleteRequestBtn";
            deleteRequestBtn.Size = new Size(84, 101);
            deleteRequestBtn.TabIndex = 35;
            deleteRequestBtn.Text = "🗑";
            deleteRequestBtn.TextColor = Color.White;
            deleteRequestBtn.UseVisualStyleBackColor = false;
            deleteRequestBtn.Click += deleteRequestBtn_Click;
            // 
            // productPictureBox
            // 
            productPictureBox.BackColor = Color.DimGray;
            productPictureBox.Location = new Point(18, 51);
            productPictureBox.Margin = new Padding(3, 2, 3, 2);
            productPictureBox.Name = "productPictureBox";
            productPictureBox.Size = new Size(253, 2);
            productPictureBox.TabIndex = 25;
            productPictureBox.TabStop = false;
            // 
            // productDetailsLabel
            // 
            productDetailsLabel.AutoSize = true;
            productDetailsLabel.BackColor = Color.Transparent;
            productDetailsLabel.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            productDetailsLabel.ForeColor = Color.Black;
            productDetailsLabel.Location = new Point(65, 12);
            productDetailsLabel.Name = "productDetailsLabel";
            productDetailsLabel.Size = new Size(182, 32);
            productDetailsLabel.TabIndex = 26;
            productDetailsLabel.Text = "Request Details";
            // 
            // productImage
            // 
            productImage.BackColor = Color.OrangeRed;
            productImage.Image = (Image)resources.GetObject("productImage.Image");
            productImage.Location = new Point(6, 12);
            productImage.Margin = new Padding(3, 2, 3, 2);
            productImage.Name = "productImage";
            productImage.Size = new Size(53, 37);
            productImage.SizeMode = PictureBoxSizeMode.Zoom;
            productImage.TabIndex = 25;
            productImage.TabStop = false;
            // 
            // restockStatusLabel
            // 
            restockStatusLabel.BackColor = Color.Transparent;
            restockStatusLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            restockStatusLabel.ForeColor = Color.Black;
            restockStatusLabel.Location = new Point(41, 81);
            restockStatusLabel.Name = "restockStatusLabel";
            restockStatusLabel.Size = new Size(845, 44);
            restockStatusLabel.TabIndex = 49;
            restockStatusLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UserControlRestock
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(restockStatusLabel);
            Controls.Add(productDetailsGroupbox);
            Controls.Add(refreshBtnRestock);
            Controls.Add(restockGrid);
            Cursor = Cursors.Hand;
            Font = new Font("Segoe UI", 9.75F);
            Name = "UserControlRestock";
            Size = new Size(1499, 730);
            ((System.ComponentModel.ISupportInitialize)restockGrid).EndInit();
            productDetailsGroupbox.ResumeLayout(false);
            productDetailsGroupbox.PerformLayout();
            requestOperationsBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)productPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)productImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView restockGrid;
        private CustomButton approveRequestBtn;
        private CustomButton denyRequestBtn;
        private CustomButton refreshBtnRestock;
        private GroupBox productDetailsGroupbox;
        private GroupBox requestOperationsBox;
        private PictureBox productPictureBox;
        private Label productDetailsLabel;
        private PictureBox productImage;
        private Label productOutOfStockLabel;
        private Label senderLabel;
        private Label label3;
        private Label label1;
        private Label restockStatusLabel;
        private CustomButton deleteRequestBtn;
    }
}
