namespace Milestone_1_Hi_Fi
{
    partial class ItemPropertiesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemPropertiesForm));
            this.itemNameLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.QOHLabel = new System.Windows.Forms.Label();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.itemIDLabel = new System.Windows.Forms.Label();
            this.QOOLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // itemNameLabel
            // 
            this.itemNameLabel.AutoSize = true;
            this.itemNameLabel.Location = new System.Drawing.Point(44, 20);
            this.itemNameLabel.Name = "itemNameLabel";
            this.itemNameLabel.Size = new System.Drawing.Size(70, 13);
            this.itemNameLabel.TabIndex = 0;
            this.itemNameLabel.Text = "Item Name:   ";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(44, 40);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(43, 13);
            this.priceLabel.TabIndex = 1;
            this.priceLabel.Text = "Price:   ";
            // 
            // QOHLabel
            // 
            this.QOHLabel.AutoSize = true;
            this.QOHLabel.Location = new System.Drawing.Point(44, 101);
            this.QOHLabel.Name = "QOHLabel";
            this.QOHLabel.Size = new System.Drawing.Size(104, 13);
            this.QOHLabel.TabIndex = 2;
            this.QOHLabel.Text = "Quantity Available:   ";
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(44, 60);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(61, 13);
            this.categoryLabel.TabIndex = 3;
            this.categoryLabel.Text = "Category:   ";
            // 
            // itemIDLabel
            // 
            this.itemIDLabel.AutoSize = true;
            this.itemIDLabel.Location = new System.Drawing.Point(44, 81);
            this.itemIDLabel.Name = "itemIDLabel";
            this.itemIDLabel.Size = new System.Drawing.Size(41, 13);
            this.itemIDLabel.TabIndex = 4;
            this.itemIDLabel.Text = "SKU:   ";
            // 
            // QOOLabel
            // 
            this.QOOLabel.AutoSize = true;
            this.QOOLabel.Location = new System.Drawing.Point(44, 121);
            this.QOOLabel.Name = "QOOLabel";
            this.QOOLabel.Size = new System.Drawing.Size(102, 13);
            this.QOOLabel.TabIndex = 5;
            this.QOOLabel.Text = "Quantity Ordered:    ";
            // 
            // ItemPropertiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 149);
            this.Controls.Add(this.QOOLabel);
            this.Controls.Add(this.itemIDLabel);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.QOHLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.itemNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ItemPropertiesForm";
            this.Text = "Item Details";
            this.Load += new System.EventHandler(this.ItemPropertiesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label itemNameLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label QOHLabel;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Label itemIDLabel;
        private System.Windows.Forms.Label QOOLabel;
    }
}