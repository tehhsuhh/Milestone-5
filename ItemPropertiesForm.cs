using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milestone_1_Hi_Fi
{
    public partial class ItemPropertiesForm : Form
    {
        public ItemPropertiesForm()
        {
            InitializeComponent();
        }

        public void SetLabels(InventoryItem item)
        {
            itemIDLabel.Text += item.ItemID.ToString();
            itemNameLabel.Text += item.ItemName;
            categoryLabel.Text += item.ItemCategory;
            QOHLabel.Text += item.QuantityOnHand.ToString();
            QOOLabel.Text += item.QuantityOnOrder.ToString();
            priceLabel.Text += item.ItemPrice.ToString();
        }

        private void ItemPropertiesForm_Load(object sender, EventArgs e)
        {

        }
    }
}