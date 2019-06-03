using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milestone_1_Hi_Fi
{
    public class InventoryManager
    {
        //array of inventory items
        private List<InventoryItem> _yourInventory = new List<InventoryItem>();

        //fill the array with dummy values
        public InventoryManager()
        {
            _yourInventory.Add(new InventoryItem("Bleach", "Cleaning Supplies", 15, 19.99m));
            _yourInventory.Add(new InventoryItem("Pens", "Office Supplies", 150, .24m));
            _yourInventory.Add(new InventoryItem("Copy Paper", "Office Supplies", 10000, 7.99m));
            _yourInventory.Add(new InventoryItem("Desk Chairs", "Office Furniture", 15, 99.95m));
            _yourInventory.Add(new InventoryItem("Coffee", "Food", 28, 3.17m));
        }

        public void AddItem(string itemName, string itemCategory, int quantity, decimal itemPrice)
        {
            _yourInventory.Add(new InventoryItem(itemName, itemCategory, quantity, itemPrice));
        }

        public void removeItem(int index)
        {
            _yourInventory.RemoveAt(index);
        }

        //restock a single item in the inverntory
        public void restockItem(int index, int quantity)
        {
            _yourInventory[index].AddItem(quantity);
        }

        //returns a single item from the inventory
        public InventoryItem GetSingleItem(int index)
        {
            return _yourInventory[index];
        }

        //search the inventory for an item. Returns the index of the item.
        //-1 is returned if there is an error or the item was not found.
        public int searchInventory(string searchCriteria, string lookingFor)
        {
            int foundIndex = -1;

            switch (searchCriteria)
            {
                case "Name":

                    for (int index = 0; index < _yourInventory.Count; index++)
                    {
                        if (_yourInventory[index].ItemName == lookingFor)
                        {
                            foundIndex = index;
                        }
                    }
                    break;

                case "Quantity":

                    for (int index = 0; index < _yourInventory.Count; index++)
                    {
                        if (_yourInventory[index].QuantityOnHand == int.Parse(lookingFor))
                        {
                            foundIndex = index;
                            return foundIndex;
                        }
                    }

                    break;

                case "Category":

                    for (int index = 0; index < _yourInventory.Count; index++)
                    {
                        if (_yourInventory[index].ItemCategory == lookingFor)
                        {
                            foundIndex = index;
                            return foundIndex;
                        }
                    }
                    break;

                case "Item ID":

                    for (int index = 0; index < _yourInventory.Count; index++)
                    {
                        if (_yourInventory[index].ItemID == int.Parse(lookingFor))
                        {
                            foundIndex = index;
                            return foundIndex;
                        }
                    }
                    break;
            }
            return foundIndex;
        }

        public int NumberOfElements
        {
            get { return _yourInventory.Count; }
        }
    }
}
