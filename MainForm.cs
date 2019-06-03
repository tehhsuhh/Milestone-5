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
    public partial class MainForm : Form
    {
        private static InventoryManager workingManager = new InventoryManager();
        public static InventoryManager WorkingManager
        {
            get
            {
                return workingManager;
            }
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //populate the fields to display the inventory
            ResetFields();
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            AddItemForm addItemForm = new AddItemForm();
            addItemForm.ShowDialog();

            //Refresh the list.
            ResetFields();
        }

        //clears the fields and adds them back into the plains. Previously used to correct possible errors in display.
        public void ResetFields()
        {
            nameListBox.Items.Clear();
            categoryListBox.Items.Clear();
            quantityListBox.Items.Clear();
            priceListBox.Items.Clear();

            for (int i = 0; i < WorkingManager.NumberOfElements; i++)
            {
                InventoryItem singleItem = WorkingManager.GetSingleItem(i);
                nameListBox.Items.Add(singleItem.ItemName);
                categoryListBox.Items.Add(singleItem.ItemCategory);
                quantityListBox.Items.Add(singleItem.QuantityOnHand);
                priceListBox.Items.Add("$" + singleItem.ItemPrice);
            }
        }

       


        // About Menu Window
        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Title: Inventory Manager App\n\n" +
                "Author: Tessa Biava\n\n" +
                "Date Published: May 27th, 2019\n\n" +
                "This program was created for CST-117, Enterprise Applications Programming I");
        }

        // Search Button
        private void SearchButton_Click_1(object sender, EventArgs e)
        {
            string criteria = searchCriteriaComboBox.Text;
            nameListBox.SetSelected(WorkingManager.searchInventory(criteria, searchForTextBox.Text), true);
        }

        // Remove Button
        private void RemoveQTYButton_Click_1(object sender, EventArgs e)
        {
            RemoveQTYForm form = new RemoveQTYForm(WorkingManager.GetSingleItem(nameListBox.SelectedIndex));
            form.ShowDialog();
            ResetFields();
        }


        // Order Button
        private void RestockButton_Click_1(object sender, EventArgs e)
        {
            RestockForm form = new RestockForm(WorkingManager.GetSingleItem(nameListBox.SelectedIndex));
            form.ShowDialog();
            ResetFields();
        }

        // Menu Strip Quit
        private void QuitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DeleteSelectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfirmDeleteForm form = new ConfirmDeleteForm(nameListBox.SelectedIndex);
            form.SetLabels(WorkingManager.GetSingleItem(nameListBox.SelectedIndex));
            form.ShowDialog();
            ResetFields();
        }


        //view all properties of the selected item
        private void ItemPropertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ItemPropertiesForm propertiesForm = new ItemPropertiesForm();
            propertiesForm.SetLabels(WorkingManager.GetSingleItem(nameListBox.SelectedIndex));
            propertiesForm.ShowDialog();
        }


        //The following are to ensure that when one item is selected, all properties are selected.
        private void PriceListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (priceListBox.SelectedIndex != nameListBox.SelectedIndex)
            {
                nameListBox.SetSelected(priceListBox.SelectedIndex, true);
            }

            if (priceListBox.SelectedIndex != categoryListBox.SelectedIndex)
            {
                categoryListBox.SetSelected(priceListBox.SelectedIndex, true);
            }

            if (priceListBox.SelectedIndex != quantityListBox.SelectedIndex)
            {
                quantityListBox.SetSelected(priceListBox.SelectedIndex, true);
            }
        }

        private void QuantityListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
                if (nameListBox.SelectedIndex != quantityListBox.SelectedIndex)
                {
                    nameListBox.SetSelected(quantityListBox.SelectedIndex, true);
                }

                if (categoryListBox.SelectedIndex != quantityListBox.SelectedIndex)
                {
                    categoryListBox.SetSelected(quantityListBox.SelectedIndex, true);
                }
                if (priceListBox.SelectedIndex != quantityListBox.SelectedIndex)
                {
                    priceListBox.SetSelected(quantityListBox.SelectedIndex, true);
                }
            }

        private void CategoryListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
                if (categoryListBox.SelectedIndex != nameListBox.SelectedIndex)
                {
                    nameListBox.SetSelected(categoryListBox.SelectedIndex, true);
                }

                if (categoryListBox.SelectedIndex != quantityListBox.SelectedIndex)
                {
                    quantityListBox.SetSelected(categoryListBox.SelectedIndex, true);
                }
                if (categoryListBox.SelectedIndex != priceListBox.SelectedIndex)
                {
                    priceListBox.SetSelected(categoryListBox.SelectedIndex, true);
                }
            }

        private void NameListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (nameListBox.SelectedIndex != categoryListBox.SelectedIndex)
            {
                categoryListBox.SetSelected(nameListBox.SelectedIndex, true);
            }

            if (nameListBox.SelectedIndex != quantityListBox.SelectedIndex)
            {
                quantityListBox.SetSelected(nameListBox.SelectedIndex, true);
            }

            if (nameListBox.SelectedIndex != priceListBox.SelectedIndex)
            {
                priceListBox.SetSelected(nameListBox.SelectedIndex, true);
            }
        }

        }
    }

    
