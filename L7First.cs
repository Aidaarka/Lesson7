using System;
using System.Collections.Generic;

namespace ConsoleApp1.Second
{
    struct CoffeeMachine
    {
        public string Drink;
        public int Price;
    }

    class DrinkBuying
    {
        static void Main()
        {
            Dictionary<CoffeeMachine, CoffeeMachine> coffeeMachine = new Dictionary<CoffeeMachine, CoffeeMachine>
            {
                { new CoffeeMachine() { Drink = "HerbalTea" }, new CoffeeMachine() { Price = 34 } },
                { new CoffeeMachine() { Drink = "Tea" }, new CoffeeMachine() { Price = 55 } },
                { new CoffeeMachine() { Drink = "Water" }, new CoffeeMachine() { Price = 12 } },
                { new CoffeeMachine() { Drink = "DecafCoffee" }, new CoffeeMachine() { Price = 137 } },
                { new CoffeeMachine() { Drink = "HotChocolate" }, new CoffeeMachine() { Price = 250 } }
            };

            Console.Write("Введите сумму: ");
            int price = Convert.ToInt32(Console.ReadLine());

            foreach (KeyValuePair<CoffeeMachine, CoffeeMachine> keyValue in coffeeMachine)
            {
                if (price >= keyValue.Value.Price)
                {
                    Console.WriteLine($"Для покупки доступен: {keyValue.Key.Drink} по цене {keyValue.Value.Price} руб.");
                }
            }
        }
    }
}