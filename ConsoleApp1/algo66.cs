using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Algo66
    {
        public static void Coz()
        {
            //Girilen kelimeyi tersten yazdiran
            Console.WriteLine("Bir kelime girin: ");
            string word = Console.ReadLine();
            string word2 = "";

            for(int i = word.Length-1;i>=0; i--)
            {
                word2 += word[i];
            }

            Console.WriteLine(word2);
        }
    }
}
