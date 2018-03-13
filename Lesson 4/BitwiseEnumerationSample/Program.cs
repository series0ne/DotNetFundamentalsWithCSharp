namespace BitwiseEnumerationSample
{
    using System;

    internal sealed class Program
    {
        private static void Main(string[] args)
        {
            PizzaToppings margherita = PizzaToppings.Cheese | PizzaToppings.Tomato;
            Console.WriteLine($"The toppings for a margherita pizza are {margherita}");

            PizzaToppings meatFeast = 
                PizzaToppings.Cheese
                | PizzaToppings.Tomato
                | PizzaToppings.Bacon
                | PizzaToppings.Ham
                | PizzaToppings.Onion
                | PizzaToppings.Pepperoni
                | PizzaToppings.Sausage;
            Console.WriteLine($"The toppings for a meat feast pizza are {meatFeast}");

            PizzaToppings theWorks = PizzaToppings.TheWorks;
            Console.WriteLine($"The toppings for a 'the works' pizza are {theWorks}");

            Console.Read();
        }
    }
}
