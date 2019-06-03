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
    public partial class RestockForm : Form
 
    {
        InventoryItem restockItem;

        private InventoryItem inventoryItem;


        public RestockForm(InventoryItem Item)
        {
            InitializeComponent();
            restockItem = Item;
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(howManyTextBox.Text, out int quantity))
            {
                restockItem.QuantityOnHand += quantity;
                Close();
            }
            else
            {
                MessageBox.Show("Enter a valid quantity to continue.");
            }

        }

        private void RestockForm_Load(object sender, EventArgs e)
        {

        }
    }
}
