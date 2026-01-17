using System;

class Program
{
    static void Main()
    {
        string[] products = { "Laptop", "Mouse", "Keyboard" };
        double[] prices = { 15000, 300, 800 };

        int option;
        double total = 0;

        do
        {
            ShowMenu(products, prices);
            Console.Write("Select a product (0 to exit): ");
            option = int.Parse(Console.ReadLine());

            if (option > 0 && option <= products.Length)
            {
                total += prices[option - 1];
                Console.WriteLine("Product added!");
            }

        } while (option != 0);

        Console.WriteLine("\nTotal to pay: $" + total);
    }

    static void ShowMenu(string[] products, double[] prices)
    {
        Console.WriteLine("\n--- PRODUCT MENU ---");
        for (int i = 0; i < products.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {products[i]} - ${prices[i]}");
        }
        Console.WriteLine("0. Exit");
    }
}
