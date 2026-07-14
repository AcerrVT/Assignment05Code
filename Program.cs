namespace Assignment05Code
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WareHouse warehouse = new WareHouse();
            int menuSelection;
            string decision = null;
            do
            {
                Console.WriteLine("----------Lasalle Supermarket!----------");
                Console.WriteLine($"Current Time: {DateTime.Now.ToString()}\n");
                Console.WriteLine("Welcome Manager! What would you like to do?");
                Console.WriteLine("1. Buy Inventory\n2. Sell Inventory\n3. View Inventory\n4. View Store Info\n5. Exit");
                Console.WriteLine("Please enter the number of your choice.");
                menuSelection = Convert.ToInt32(Console.ReadLine());

                switch (menuSelection)
                {
                    case 1:
                        do
                        {
                            warehouse.BuyInventory();
                            Console.WriteLine("Would you like to purchase more items?\n Please type yes or no in all lowercase.");
                            decision = Console.ReadLine();
                        } while (decision == "yes");

                        break;
                    case 2:
                        do
                        {
                            warehouse.SellInventory();
                            Console.WriteLine("Would you like to sell more items?\n Please type yes or no.");
                            decision = Console.ReadLine();
                        } while (decision == "yes");
                        break;
                    case 3:
                        warehouse.DisplayInventory();
                        break;
                    case 4:
                        warehouse.DisplayStoreInfo();
                        break;
                    case 5:
                        break;
                }

            } while (menuSelection != 5);


        }
    }
}

