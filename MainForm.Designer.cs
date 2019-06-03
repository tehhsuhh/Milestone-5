namespace Milestone_1_Hi_Fi
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemPropertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addItemButton = new System.Windows.Forms.Button();
            this.restockButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.nameListBox = new System.Windows.Forms.ListBox();
            this.categoryListBox = new System.Windows.Forms.ListBox();
            this.quantityListBox = new System.Windows.Forms.ListBox();
            this.priceListBox = new System.Windows.Forms.ListBox();
            this.removeQTYButton = new System.Windows.Forms.Button();
            this.searchForTextBox = new System.Windows.Forms.TextBox();
            this.searchCriteriaComboBox = new System.Windows.Forms.ComboBox();
            this.searchCriteriaLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.editToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(471, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.SystemColors.MenuBar;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.QuitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemPropertiesToolStripMenuItem});
            this.viewToolStripMenuItem.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewToolStripMenuItem.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // itemPropertiesToolStripMenuItem
            // 
            this.itemPropertiesToolStripMenuItem.Name = "itemPropertiesToolStripMenuItem";
            this.itemPropertiesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.itemPropertiesToolStripMenuItem.Text = "Item Properties";
            this.itemPropertiesToolStripMenuItem.Click += new System.EventHandler(this.ItemPropertiesToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteSelectedToolStripMenuItem});
            this.editToolStripMenuItem.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editToolStripMenuItem.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // deleteSelectedToolStripMenuItem
            // 
            this.deleteSelectedToolStripMenuItem.Name = "deleteSelectedToolStripMenuItem";
            this.deleteSelectedToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteSelectedToolStripMenuItem.Text = "Delete";
            this.deleteSelectedToolStripMenuItem.Click += new System.EventHandler(this.DeleteSelectedToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutToolStripMenuItem.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // addItemButton
            // 
            this.addItemButton.BackColor = System.Drawing.Color.LimeGreen;
            this.addItemButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addItemButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addItemButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addItemButton.Location = new System.Drawing.Point(365, 73);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(93, 23);
            this.addItemButton.TabIndex = 2;
            this.addItemButton.Text = "Add";
            this.addItemButton.UseVisualStyleBackColor = false;
            this.addItemButton.Click += new System.EventHandler(this.AddItemButton_Click);
            // 
            // restockButton
            // 
            this.restockButton.BackColor = System.Drawing.Color.DarkTurquoise;
            this.restockButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.restockButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restockButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.restockButton.Location = new System.Drawing.Point(365, 102);
            this.restockButton.Name = "restockButton";
            this.restockButton.Size = new System.Drawing.Size(93, 23);
            this.restockButton.TabIndex = 3;
            this.restockButton.Text = "Order";
            this.restockButton.UseVisualStyleBackColor = false;
            this.restockButton.Click += new System.EventHandler(this.RestockButton_Click_1);
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(192, 27);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click_1);
            // 
            // nameListBox
            // 
            this.nameListBox.FormattingEnabled = true;
            this.nameListBox.Location = new System.Drawing.Point(18, 73);
            this.nameListBox.Name = "nameListBox";
            this.nameListBox.Size = new System.Drawing.Size(106, 264);
            this.nameListBox.TabIndex = 5;
            this.nameListBox.SelectedIndexChanged += new System.EventHandler(this.NameListBox_SelectedIndexChanged);
            // 
            // categoryListBox
            // 
            this.categoryListBox.FormattingEnabled = true;
            this.categoryListBox.Location = new System.Drawing.Point(123, 73);
            this.categoryListBox.Name = "categoryListBox";
            this.categoryListBox.Size = new System.Drawing.Size(114, 264);
            this.categoryListBox.TabIndex = 6;
            this.categoryListBox.SelectedIndexChanged += new System.EventHandler(this.CategoryListBox_SelectedIndexChanged);
            // 
            // quantityListBox
            // 
            this.quantityListBox.FormattingEnabled = true;
            this.quantityListBox.Location = new System.Drawing.Point(236, 73);
            this.quantityListBox.Name = "quantityListBox";
            this.quantityListBox.Size = new System.Drawing.Size(46, 264);
            this.quantityListBox.TabIndex = 7;
            this.quantityListBox.SelectedIndexChanged += new System.EventHandler(this.QuantityListBox_SelectedIndexChanged);
            // 
            // priceListBox
            // 
            this.priceListBox.FormattingEnabled = true;
            this.priceListBox.Location = new System.Drawing.Point(281, 73);
            this.priceListBox.Name = "priceListBox";
            this.priceListBox.Size = new System.Drawing.Size(78, 264);
            this.priceListBox.TabIndex = 8;
            this.priceListBox.SelectedIndexChanged += new System.EventHandler(this.PriceListBox_SelectedIndexChanged);
            // 
            // removeQTYButton
            // 
            this.removeQTYButton.BackColor = System.Drawing.Color.Firebrick;
            this.removeQTYButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.removeQTYButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeQTYButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.removeQTYButton.Location = new System.Drawing.Point(365, 131);
            this.removeQTYButton.Name = "removeQTYButton";
            this.removeQTYButton.Size = new System.Drawing.Size(93, 23);
            this.removeQTYButton.TabIndex = 9;
            this.removeQTYButton.Text = "Remove";
            this.removeQTYButton.UseVisualStyleBackColor = false;
            this.removeQTYButton.Click += new System.EventHandler(this.RemoveQTYButton_Click_1);
            // 
            // searchForTextBox
            // 
            this.searchForTextBox.Location = new System.Drawing.Point(57, 29);
            this.searchForTextBox.Name = "searchForTextBox";
            this.searchForTextBox.Size = new System.Drawing.Size(131, 22);
            this.searchForTextBox.TabIndex = 10;
            // 
            // searchCriteriaComboBox
            // 
            this.searchCriteriaComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.searchCriteriaComboBox.FormattingEnabled = true;
            this.searchCriteriaComboBox.Items.AddRange(new object[] {
            "Name",
            "Quantity",
            "Category",
            "SKU"});
            this.searchCriteriaComboBox.Location = new System.Drawing.Point(270, 28);
            this.searchCriteriaComboBox.Name = "searchCriteriaComboBox";
            this.searchCriteriaComboBox.Size = new System.Drawing.Size(78, 21);
            this.searchCriteriaComboBox.TabIndex = 11;
            // 
            // searchCriteriaLabel
            // 
            this.searchCriteriaLabel.AutoSize = true;
            this.searchCriteriaLabel.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchCriteriaLabel.Location = new System.Drawing.Point(349, 32);
            this.searchCriteriaLabel.Name = "searchCriteriaLabel";
            this.searchCriteriaLabel.Size = new System.Drawing.Size(80, 13);
            this.searchCriteriaLabel.TabIndex = 12;
            this.searchCriteriaLabel.Text = "Search Criteria";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Search:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(18, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 19);
            this.label2.TabIndex = 14;
            this.label2.Text = "Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(120, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 19);
            this.label3.TabIndex = 15;
            this.label3.Text = "Category";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(234, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 19);
            this.label4.TabIndex = 16;
            this.label4.Text = "QTY";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(279, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 19);
            this.label5.TabIndex = 17;
            this.label5.Text = "Price/Unit";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 352);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchCriteriaLabel);
            this.Controls.Add(this.searchCriteriaComboBox);
            this.Controls.Add(this.searchForTextBox);
            this.Controls.Add(this.removeQTYButton);
            this.Controls.Add(this.priceListBox);
            this.Controls.Add(this.quantityListBox);
            this.Controls.Add(this.categoryListBox);
            this.Controls.Add(this.nameListBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.restockButton);
            this.Controls.Add(this.addItemButton);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button addItemButton;
        private System.Windows.Forms.Button restockButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemPropertiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteSelectedToolStripMenuItem;
        private System.Windows.Forms.ListBox nameListBox;
        private System.Windows.Forms.ListBox categoryListBox;
        private System.Windows.Forms.ListBox quantityListBox;
        private System.Windows.Forms.ListBox priceListBox;
        private System.Windows.Forms.Button removeQTYButton;
        private System.Windows.Forms.TextBox searchForTextBox;
        private System.Windows.Forms.ComboBox searchCriteriaComboBox;
        private System.Windows.Forms.Label searchCriteriaLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

