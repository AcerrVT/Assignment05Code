using Assignment05Code;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment05Code
{
    //The warehouse stores everything in the inventory and keeps track of the store's statistics.
    //It also has methods to buy and sell inventory, display inventory, and display store information.
    internal class WareHouse
    {
        //The inventory is a list of items that the store has in stock.
        //All the attributes of the store are stored in this class as well, each 
        //attribute value is updated when the store buys or sells inventory.

        internal List<Item> InventoryItems = new List<Item>();
        int selection, quantity;
        int totalBought, totalSold, searchSelection = 0;
        float totalExpenses, totalCost, totalSales, employeePayout = 0;
        Item item = null;
        Item newItem = null;
        Product searchItem;

        //This method finds an item in the inventory by its name and returns it.
        internal Item FindItem(Product product)
        {

            foreach (Item item in InventoryItems)
            {
                if (item.product == product)
                {
                    return item;
                }
            }

            return null;
        }

        //This method allows the user to buy inventory from the market.
        //It prompts the user to select an item and quantity, then updates the inventory and store statistics accordingly.
        internal void BuyInventory()
        {
            Console.WriteLine("--------Market--------");
            Console.WriteLine("1. Apple\n2. Banana\n3. Chocolate\n4. Milk\n5. Carrots\n6. Celery");
            do
            {
                Console.WriteLine("Please enter the items you want by typing its assigned number below.");
                selection = Convert.ToInt32(Console.ReadLine());
            } while (selection != 1 && selection != 2 && selection != 3 && selection != 4 && selection != 5 && selection != 6);

            do
            {
                Console.WriteLine("Please enter the quantity of the item you want to buy.");
                quantity = Convert.ToInt32(Console.ReadLine());
            } while (quantity < 0);

            switch (selection)
            {
                case 1:
                    item = FindItem(Product.APPLE);

                    if (item == null)
                    {
                        newItem = new Item(Product.APPLE, ItemType.FRUIT, quantity, 1.50f, 0, 0);
                        InventoryItems.Add(newItem);
                        item = newItem;
                    }
                    else { item.quantity += quantity; }

                    item.totalBought += quantity;
                    totalCost += quantity * 1.50f;
                    totalBought += quantity;
                    totalExpenses += totalCost;

                    Console.WriteLine($"You have bought {quantity} {Product.APPLE} for {quantity * item.price}");
                    break;

                case 2:
                    item = FindItem(Product.BANANA);

                    if (item == null)
                    {
                        newItem = new Item(Product.BANANA, ItemType.FRUIT, quantity, 2.00f, 0, 0);
                        InventoryItems.Add(newItem);
                        item = newItem;
                    }
                    else { item.quantity += quantity; }

                    item.totalBought += quantity;
                    totalCost += quantity * 2.00f;
                    totalBought += quantity;
                    totalExpenses += totalCost;

                    Console.WriteLine($"You have bought {quantity} {Product.BANANA} for {quantity * item.price}");
                    break;

                case 3:
                    item = FindItem(Product.CHOCOLATE);

                    if (item == null)
                    {
                        newItem = new Item(Product.CHOCOLATE, ItemType.SWEETS, quantity, 4.50f, 0, 0);
                        InventoryItems.Add(newItem);
                        item = newItem;
                    }
                    else { item.quantity += quantity; }

                    item.totalBought += quantity;
                    totalCost += quantity * 4.50f;
                    totalBought += quantity;
                    totalExpenses += totalCost;

                    Console.WriteLine($"You have bought {quantity} {Product.CHOCOLATE} for {quantity * item.price}");
                    break;

                case 4:
                    item = FindItem(Product.MILK);

                    if (item == null)
                    {
                        newItem = new Item(Product.MILK, ItemType.DAIRY, quantity, 3.50f, 0, 0);
                        InventoryItems.Add(newItem);
                        item = newItem;
                    }
                    else { item.quantity += quantity; }

                    item.totalBought += quantity;
                    totalCost += quantity * 3.50f;
                    totalBought += quantity;
                    totalExpenses += totalCost;

                    Console.WriteLine($"You have bought {quantity} {Product.MILK} for {quantity * item.price}");
                    break;

                case 5:
                    item = FindItem(Product.CARROTS);

                    if (item == null)
                    {
                        newItem = new Item(Product.CARROTS, ItemType.VEGETABLE, quantity, 2.75f, 0, 0);
                        InventoryItems.Add(newItem);
                        item = newItem;
                    }
                    else { item.quantity += quantity; }

                    item.totalBought += quantity;
                    totalCost += quantity * 2.75f;
                    totalBought += quantity;
                    totalExpenses += totalCost;

                    Console.WriteLine($"You have bought {quantity} {Product.CARROTS} for {quantity * item.price}");
                    break;

                case 6:
                    item = FindItem(Product.CELERY);

                    if (item == null)
                    {
                        newItem = new Item(Product.CELERY, ItemType.VEGETABLE, quantity, 3.75f, 0, 0);
                        InventoryItems.Add(newItem);
                        item = newItem;
                    }
                    else { item.quantity += quantity; }

                    item.totalBought += quantity;
                    totalCost += quantity * 3.75f;
                    totalBought += quantity;
                    totalExpenses += totalCost;

                    Console.WriteLine($"You have bought {quantity} {Product.CELERY} for {quantity * item.price}");
                    break;

                default:
                    Console.WriteLine("Invalid selection. Please try again.");
                    break;
            }

        }

        //This method allows the user to sell inventory to the market at a higher price than the purchase price.
        internal void SellInventory()
        {
            DisplayInventory();
            Console.WriteLine("--------Market--------");
            Console.WriteLine("1. Apple\n2. Banana\n3. Chocolate\n4. Milk\n5. Carrots\n6. Celery");
            do
            {
                Console.WriteLine("Please enter the items you want to sell by typing its assigned number below.");
                selection = Convert.ToInt32(Console.ReadLine());
            } while (selection != 1 && selection != 2 && selection != 3 && selection != 4 && selection != 5 && selection != 6);
            do
            {
                Console.WriteLine("Please enter the quantity of the item you want to sell.");
                quantity = Convert.ToInt32(Console.ReadLine());
            } while (quantity < 0);

            switch (selection)
            {
                case 1:
                    item = FindItem(Product.APPLE);
                    break;
                case 2:
                    item = FindItem(Product.BANANA);
                    break;
                case 3:
                    item = FindItem(Product.CHOCOLATE);
                    break;
                case 4:
                    item = FindItem(Product.MILK);
                    break;
                case 5:
                    item = FindItem(Product.CARROTS);
                    break;
                case 6:
                    item = FindItem(Product.CELERY);
                    break;
                default:
                    Console.WriteLine("Invalid selection. Please try again.");
                    break;
            }

            if (item == null)
            {
                Console.WriteLine($"You don't have this in your inventory.");
            }
            else if (item.quantity < quantity)
            {
                Console.WriteLine($"You don't have enough of this in your inventory to sell.");
            }
            else
            {
                item.totalSold += quantity;
                item.quantity -= quantity;
                totalSales += quantity * (item.price + 5);
                employeePayout += totalSales * 0.15f;
                totalSold += quantity;
                totalExpenses += employeePayout;
                Console.WriteLine($"You sold {quantity} {item.product}(s) for ${quantity * (item.price + 5)}");
            }

        }

        //This method displays the current inventory of the store, including the name, type, quantity, price, total bought, and total sold for each item.
        internal void DisplayInventory()
        {

            Console.WriteLine("--------Inventory--------");
            foreach (var item in InventoryItems)
            {
                Console.WriteLine($"Item: {item.product}\nType: {item.itemType}\nQuantity: {item.quantity}\nPrice: ${item.price}\nTotal Bought: {item.totalBought}\nTotal Sold: {item.totalSold}");
                Console.WriteLine("--------------------");
            }
        }

        //This method displays the store's statistics, including the total items bought and sold, total cost of purchased items, employee payout, total expenses, total sales, and total profit.
        //The total profit is calculated by subtracting the total expenses from the total sales, it isn't a variable that is stored in the class, but rather calculated when the method is called.
        internal void DisplayStoreInfo()
        {
            do
            {
                Console.WriteLine($"Current Time: {DateTime.Now.ToString()}");
                Console.WriteLine($"Total Items Bought: {totalBought}\nTotal Items Sold: {totalSold}\nTotal Cost of Purchased Items: ${totalCost:F2}\nEmployee Payout: ${employeePayout:F2}\nTotal Expenses: ${totalExpenses:F2}\nTotal Sales: ${totalSales:F2}\nTotal Profit: ${(totalSales - totalExpenses):F2}");
                Console.WriteLine("Would you like to search for an item's statistics?\nPlease enter 1 for yes or 2 for no.");
                searchSelection = Convert.ToInt32(Console.ReadLine());
            } while (searchSelection != 1 && searchSelection != 2);

            if (searchSelection == 1)
            {
                do
                {
                    Console.WriteLine("Please enter the name of the item you want to search for.");
                    string input = Console.ReadLine();

                    switch (input)
                    {
                        case "Apple":
                            searchItem = Product.APPLE;
                            break;
                        case "Banana":
                            searchItem = Product.BANANA;
                            break;
                        case "Chocolate":
                            searchItem = Product.CHOCOLATE;
                            break;
                        case "Milk":
                            searchItem = Product.MILK;
                            break;
                        case "Carrots":
                            searchItem = Product.CARROTS;
                            break;
                        case "Celery":
                            searchItem = Product.CELERY;
                            break;
                        default:
                            Console.WriteLine("Invalid Product. Try again with beginning capital letter.");
                            break;
                    }

                    item = FindItem(searchItem);

                    if (item == null)
                    {
                        Console.WriteLine($"You don't have any {searchItem} in your inventory.");
                    }
                    else
                    {
                        Console.WriteLine($"Item: {item.product}\nTotal Bought: {item.totalBought}\nTotal Sold: {item.totalSold}");
                    }

                    Console.WriteLine("Would you like to search for another item?\nPlease enter 1 for yes or 2 for no.");
                    searchSelection = Convert.ToInt32(Console.ReadLine());

                } while (searchSelection == 1);
            }

        }
    }
}
