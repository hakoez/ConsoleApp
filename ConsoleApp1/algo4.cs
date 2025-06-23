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
    public class Algo4
    {
        public static void Coz()
        {
            //Girilen sayinin 5'in kuvveti olup olmadigini bulma

            Console.WriteLine("Bir sayi girin: ");
            int a = int.Parse(Console.ReadLine());

            if (a % 5 == 0)
            {
                Console.WriteLine(a + " 5in kuvvetidir.");
            }
            else
            {
                Console.WriteLine(a + " 5in kuvveti degildir.");
            }


        }
    }
}