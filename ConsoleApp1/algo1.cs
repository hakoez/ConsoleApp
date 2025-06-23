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
    public class Algo1
    {
        public static void Coz()
        {
            //Girilen iki sayinin karelerinin toplami

            Console.WriteLine("Ilk sayiyi girin: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ikinci sayiyi girin: ");
            int b = int.Parse(Console.ReadLine());

            int result = a * a + b * b;
            Console.WriteLine("Sonuc: " + result);
        }
    }
}
