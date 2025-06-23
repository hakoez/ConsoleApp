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
    public class Algo20
    {
        public static void Coz()
        {
            //Girilen sayinin mükemmel sayi olup olmadigini bulma
            Console.WriteLine("Bir sayi giriniz: ");
            int a = int.Parse(Console.ReadLine());
            int atoplam = 0;

            for(int i = 1; i<a; i++)
            {
                if(a%i == 0)
                {
                    atoplam += i;
                }
            }
            if(atoplam == a)
            {
                Console.WriteLine(a + " mükemmel sayidir.");
            }
            else
            {
                Console.WriteLine(a + " mükemmel sayi degildir.");
            }
        }
    }
}
