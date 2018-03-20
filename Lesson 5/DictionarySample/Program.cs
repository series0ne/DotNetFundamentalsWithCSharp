namespace DictionarySample
{
    using System;
    using System.Collections.Generic;

    internal static class Program
    {
        private static void Main(string[] args)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>
            {
                ["aardvark"] = "A nocturnal badger-sized burrowing mammal of Africa, with long ears, a tubular snout, and a long extensible tongue, feeding on ants and termites.",
                ["mammal"] = "A warm-blooded vertebrate animal of a class that is distinguished by the possession of hair or fur, females that secrete milk for the nourishment of the young, and (typically) the birth of live young.",
                ["zodiac"] = "A belt of the heavens within about 8° either side of the ecliptic, including all apparent positions of the sun, moon, and most familiar planets. It is divided into twelve equal divisions or signs (Aries, Taurus, Gemini, Cancer, Leo, Virgo, Libra, Scorpio, Sagittarius, Capricorn, Aquarius, Pisces)."
            };

            WriteWordDefinition(dictionary, "car");
            WriteWordDefinition(dictionary, "mammal");

            Console.Read();
        }

        private static void WriteWordDefinition(Dictionary<string, string> dictionary, string key)
        {
            if(!dictionary.ContainsKey(key))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{key} does not exist in the dictionary");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($"{key} ");
                Console.ResetColor();
                Console.WriteLine(dictionary[key]);
            }
        }
    }
}
