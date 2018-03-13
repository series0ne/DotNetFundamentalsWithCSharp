namespace BitwiseEnumerationSample
{
    using System;

    [Flags]
    public enum PizzaToppings
    {
        Cheese = 1 << 0,
        Pepperoni = 1 << 1,
        Tomato = 1 << 2,
        Sausage = 1 << 3,
        Onion = 1 << 4,
        Mushroom = 1 << 5,
        Anchovy = 1 << 6,
        Ham = 1 << 7,
        Bacon = 1 << 8,
        TheWorks = Cheese | Pepperoni | Tomato | Sausage | Onion | Mushroom | Anchovy | Ham | Bacon
    }
}
