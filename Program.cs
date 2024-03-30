using System;

namespace PizzaOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create an object
            Pizza peperoni = new Pizza("Peperoni", "30,00$");
            Pizza capriciosa = new Pizza("Capriciosa", "22,00$");
            Pizza hawaii = new Pizza("Hawaii", "28,00$");
            Pizza goralska = new Pizza("Goralska", "24.00$");
            Pizza neapolitana = new Pizza("Neapolitana", "23,00$");

            Console.WriteLine("Welcome to Jeff's Pizza");
            Console.WriteLine("Choose your pizza");

            Console.WriteLine("------- MENU -------");
            Console.WriteLine("1. Peperoni");
            Console.WriteLine("2. Capriciosa");
            Console.WriteLine("3. Hawaii");
            Console.WriteLine("4. Goralska");
            Console.WriteLine("5. Neapolitana");

            int choose;
            choose = int.Parse(Console.ReadLine());

            Console.Clear();

            // Loop until user enters a number out of range
            while (choose >= 1 && choose <= 5)
            {
                switch (choose)
                {
                    case 1:
                        Console.WriteLine("You chose " + peperoni.name);
                        Console.WriteLine("Price: " + peperoni.price);
                        break;

                    case 2:
                        Console.WriteLine("You chose " + capriciosa.name);
                        Console.WriteLine("Price: " + capriciosa.price);
                        break;

                    case 3:
                        Console.WriteLine("You chose " + hawaii.name);
                        Console.WriteLine("Price: " + hawaii.price);
                        break;

                    case 4:
                        Console.WriteLine("You chose " + goralska.name);
                        Console.WriteLine("Price: " + goralska.price);
                        break;

                    case 5:
                        Console.WriteLine("You chose " + neapolitana.name);
                        Console.WriteLine("Price: " + neapolitana.price);
                        break;
                }

                Console.WriteLine("Enter your address:");
                string address = Console.ReadLine();

                // After processing the order, break out of the loop
                break;
            }

            // Inform the user about invalid input if choose is out of range
            if (choose < 1 || choose > 5)
            {
                Console.WriteLine("You chose a number out of range. Please try again.");
            }

            Console.ReadKey();
        }
    }

    class Pizza
    {
        public string name;
        public string price;

        // Constructor
        public Pizza(string name, string price)
        {
            this.name = name;
            this.price = price;
        }
    }
}

