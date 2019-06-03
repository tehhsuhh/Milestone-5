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
    public partial class RemoveQTYForm : Form
    {
        InventoryItem workingItem;

        public RemoveQTYForm(InventoryItem item)
        {
            InitializeComponent();
            workingItem = item;
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {

            {
                if (int.TryParse(removeTextBox.Text, out int quantity))
                {
                    workingItem.QuantityOnHand -= quantity;
                    Close();
                }
                else
                {
                    MessageBox.Show("Enter a valid quantity to continue.");
                }
            }
    }
    }
}
