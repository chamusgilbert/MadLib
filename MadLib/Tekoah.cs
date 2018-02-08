using System;
using System.IO;

namespace MadLib
{
    class Tekoah
    {
        public static void TekoahLibs()
        {
            string tekoah = new StreamReader(@"C:\Users\Grand Circus Student\source\repos\MadLib\Tekoah.txt").ReadToEnd();


            Console.WriteLine(tekoah, Constructor.GetAdjective(), Constructor.GetAdjective(), Constructor.GetVerbIng(), Constructor.GetName(), Constructor.GetName(), Constructor.GetNoun(), Constructor.GetNoun(), Constructor.GetVerbIng(), Constructor.GetNoun(), Constructor.GetPNoun(), Constructor.GetPNoun(), Constructor.GetVerbIng(), Constructor.GetAdjective(), Constructor.GetNoun());
        }
    }
}
