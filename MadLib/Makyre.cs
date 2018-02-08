using System;
using System.IO;

namespace MadLib
{
    class Makyre
    {
        public static void MakyreLibs()
        {
            string makyre = new StreamReader(@"C:\Users\Grand Circus Student\source\repos\MadLib\Makyre.txt").ReadToEnd();


            Console.WriteLine(makyre, Constructor.GetAdjective(), Constructor.GetAdjective(), Constructor.GetAdjective(), Constructor.GetNoun(), Constructor.GetAdjective(), Constructor.GetVerb(), Constructor.GetVerb(), Constructor.GetAdjective(), Constructor.GetNumber(), Constructor.GetAdjective(), Constructor.GetPlace(), Constructor.GetPlace(), Constructor.GetVerb(), Constructor.GetVerb(), Constructor.GetVerb(), Constructor.GetVerb(), Constructor.GetAnimal(), Constructor.GetVerb());
        }
    }
}
