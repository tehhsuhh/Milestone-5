﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milestone_1_Hi_Fi
{
    public class InventoryItem
    {
        public int ItemID { get; }
        public string ItemName { get; set; }
        public int QuantityOnHand { get; set; }
        public int QuantityOnOrder { get; set; } = 0;
        public decimal ItemPrice { get; set; }
        public string ItemCategory { get; set; }
        private static int ItemIDSeed = 1; //used to determine ITEM_ID

        //constructor
        public InventoryItem(string itemName, string itemCategory, int quantityOnHand, decimal itemPrice)
        {
            ItemName = itemName;
            QuantityOnHand = quantityOnHand;
            ItemPrice = itemPrice;
            ItemCategory = itemCategory;
            ItemID = ItemIDSeed;
            ItemIDSeed++;
        }

        //methods
        public void OrderItems(int howMany)
        {
            QuantityOnOrder += howMany;
        }

        public void RemoveItem(int howMany)
        {
            QuantityOnHand -= howMany;
        }

        public void AddItem(int howMany)
        {
            QuantityOnHand += howMany;
        }

        public new string ToString()
        {
            return ItemName + " " + QuantityOnHand + " " + ItemCategory;
        }
    }
}