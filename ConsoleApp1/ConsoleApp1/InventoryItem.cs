using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class InventoryItem
    {
        public Item Details { get; set; }
        public string Quantity { get; set; }
        public InventoryItem(Item details, string quantity)
        {
            Details = details;
            Quantity = quantity;
        }
        public void AddItemToInventory(Item itemToAdd)
        {
            foreach (InventoryItem ii in Inventory)
            {
                if (ii.Details.ID == itemToAdd.ID)
                {
                    // They have the item in their inventory, so increase the quantity by one
                ii.Quantity++;
                    return; // We added the item, and are done, so get out of this function
                }
            }
            // They didn't have the item, so add it to their inventory, with a quantity of 1
            Inventory.Add(new InventoryItem(itemToAdd, 1));

            // Display message
            /*
            rtbMessages.Text += "You hit the " + _currentMonster.Name + " for " +
             damageToMonster.ToString() + " points." + Environment.NewLine;
             */

            // Add the looted items to the player's inventory
            foreach (InventoryItem inventoryItem in lootedItems)
            {
                _player.AddItemToInventory(inventoryItem.Details);
                if (inventoryItem.Quantity == 1)
                {
                    rtbMessages.Text += "You loot " +
                     inventoryItem.Quantity.ToString() + " " +
                     inventoryItem.Details.Name + Environment.NewLine;
                }
                else
                {
                    rtbMessages.Text += "You loot " +
                     inventoryItem.Quantity.ToString() + " " +
                     inventoryItem.Details.NamePlural + Environment.NewLine;
                }
            }
        }
