using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ConsoleApp1
{
    public class Algo10
    {
        public static void Coz()
        {
            //Bölme islemini cikartma yaparak bulma
            Console.WriteLine("Bölüneni giriniz: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Böleni giriniz: ");
            int a = int.Parse(Console.ReadLine());

            int k = n;
            int b = 0;

            while (k>=a)
            {
                k = k - a;
                b++;
            }
            Console.WriteLine("Bölüm: " + b + " Kalan: " + k);

        }
    }
}
