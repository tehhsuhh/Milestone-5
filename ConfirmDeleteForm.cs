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
    public partial class ConfirmDeleteForm : Form
    {
        int itemIndex;

        public ConfirmDeleteForm(int selectedIndex)
        {
            InitializeComponent();
            itemIndex = selectedIndex;
        }

        private void ConfirmDeleteForm_Load(object sender, EventArgs e)
        {

        }

        public void SetLabels(InventoryItem item)
        {
            messageLabel.Text = ("Are you sure you want to delete: "+ item.ItemName +"?");
        }

        

        

        private void ConfirmButton_Click(object sender, EventArgs e)
        { 
                MainForm.WorkingManager.removeItem(itemIndex);
                Close();
            }

        private void CancelButton_Click(object sender, EventArgs e)
        {
                Close();
            }
        }
    }
   
