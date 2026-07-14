using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment05Code
{
    // This class represents an item in the warehouse inventory.
    // It contains properties such as name, type, quantity, price, total sold, and total bought.
    //The constructor initializes these properties when a new item is created and these properties
    //can be accessed and modified as needed after created.
    internal class Item
    {
        public Product product { get; }
        public ItemType itemType { get; }
        internal int quantity;
        internal float price;
        internal int totalSold;
        internal int totalBought;

        internal Item(Product product, ItemType itemType, int quantity, float price, int totalSold, int internalBought)
        {
            this.product = product;
            this.itemType = itemType;
            this.quantity = quantity;
            this.price = price;
            this.totalSold = totalSold;
            this.totalBought = internalBought;
        }

    }
}

