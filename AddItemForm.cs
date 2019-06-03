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
    public partial class AddItemForm : Form
    {
        public AddItemForm()
        {
            InitializeComponent();
        }

        

        private void AddItemForm_Load(object sender, EventArgs e)
        {

        }

        private void AddButton_Click_1(object sender, EventArgs e)
        {
            //check if filled
            if (nameTextBox.Text != "" &&
                categoryTextBox.Text != "" &&
                quantityTextBox.Text != "" &&
                priceTextBox.Text != "")
            {
                int quantity;
                decimal price;

                //attempt to parse the values
                if (!int.TryParse(quantityTextBox.Text, out quantity))
                {
                    MessageBox.Show("Please enter a valid quantity for how many you currently have.");
                }

                if (!decimal.TryParse(priceTextBox.Text, out price))
                {
                    MessageBox.Show("Please enter a valid amount for how much the item costs in dollars.");
                }

                //add the item according to the text fields
                MainForm.WorkingManager.AddItem(nameTextBox.Text, categoryTextBox.Text, quantity, price);

                Close();
            }
            else
            {
                MessageBox.Show("All fields are required!");
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        }
    }
