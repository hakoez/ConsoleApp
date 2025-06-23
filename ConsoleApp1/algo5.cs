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
    public class Algo5
    {
        public static void Coz()
        {
            //Girilen sayinin negatif,pozitif veya 0 oldugunu bulmak

            Console.WriteLine("Bir sayi girin: ");
            int a = int.Parse(Console.ReadLine());

            if (a == 0)
            {
                Console.WriteLine("Sayi 0");
            }
            else if(a>0)
            {
                Console.WriteLine("Sayi pozitif");
            }
            else
            {
                Console.WriteLine("Sayi negatif");
            }
        }
    }
}
