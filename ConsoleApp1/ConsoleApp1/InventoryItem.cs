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
    }
}
