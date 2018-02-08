using System;
using System.IO;


namespace MadLib
{
    class Raston
    {
        public static void RastonLibs()
        {
            string raston = new StreamReader(@"C:\Users\Grand Circus Student\source\repos\MadLib\Raston.txt").ReadToEnd();


            Console.WriteLine(raston, Constructor.GetAdjective(), Constructor.GetNoun(), Constructor.GetAdjective(), Constructor.GetVerbIng(), Constructor.GetNumber(), Constructor.GetPlace(), Constructor.GetName(), Constructor.GetAdjective(), Constructor.GetVerb(), Constructor.GetVerbIng(), Constructor.GetAdjective(), Constructor.GetAdjective(), Constructor.GetVerb(), Constructor.GetNoun(), Constructor.GetAdjective(), Constructor.GetVerb(), Constructor.GetVerb(), Constructor.GetAdjective(), Constructor.GetAdjective(), Constructor.GetPlace());

        }
    }
}
