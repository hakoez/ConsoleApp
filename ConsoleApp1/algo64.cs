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
    public class Algo64
    {
        public static void Coz()
        {
            //Girilen kelimenin uzunlugunu bulma
            Console.WriteLine("Lutfen bir kelime girin: ");
            string word = Console.ReadLine();

            int uzunluk = 0;
            
            foreach (char c in word)
            {
                uzunluk++;
            }
            Console.WriteLine(uzunluk);

        }
    }
}
