using System;

namespace MadLib
{
    class Constructor
    {
        public static string GetNoun()
        {
            Console.WriteLine("Give me a Noun");
            Console.WriteLine("That is a Person, Place or thing");
            string noun = Console.ReadLine();
            return noun;
        }
        public static string GetPNoun()
        {
            Console.WriteLine("Give me a Plural Noun");
            Console.WriteLine("That is many Persons, Places or things");
            string noun = Console.ReadLine();
            return noun;
        }
        public static string GetVerb()
        {
            Console.WriteLine("Give me a Verb");
            Console.WriteLine("That is an Action, preferably future tense");
            string verb = Console.ReadLine();
            return verb;
        }
        public static string GetAdjective()
        {
            Console.WriteLine("Give me a Adjective");
            Console.WriteLine("That is a Discribing Word");
            string adjective = Console.ReadLine();
            return adjective;
        }
        public static string GetNumber()
        {
            Console.WriteLine("Give me a Number");
            string number = Console.ReadLine();
            return number;
        }
        public static string GetName()
        {
            Console.WriteLine("Give me a Name");
            string name = Console.ReadLine();
            return name;
        }
        public static string GetLiquid()
        {
            Console.WriteLine("Give me a name of a Liquid");
            string liquid = Console.ReadLine();
            return liquid;
        }
        public static string GetFood()
        {
            Console.WriteLine("Give me a name of a Food");
            string food = Console.ReadLine();
            return food;
        }
        public static string GetAnimal()
        {
            Console.WriteLine("Give me a name of an Animal");
            string animal = Console.ReadLine();
            return animal;
        }
        public static string GetVerbIng()
        {
            Console.WriteLine("Give me a Verb ending in 'ing'");
            Console.WriteLine("That is an present tense action");
            string verb = Console.ReadLine();
            return verb;
        }
        public static string GetPlace()
        {
            Console.WriteLine("Give me a Place");
            string verb = Console.ReadLine();
            return verb;
        }
        public static string GetVerbED()
        {
            Console.WriteLine("Give me a Verb");
            Console.WriteLine("That is an Past Tense action");
            string verb = Console.ReadLine();
            return verb;
        }
    }
}
