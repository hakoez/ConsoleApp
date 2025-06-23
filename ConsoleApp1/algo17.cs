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
    public class Algo17
    {
        public static void Coz()
        {
            //X ve Y sayilarinin dost sayi olup olmadigini kontrol etmek

            int xtoplam = 0;
            int ytoplam = 0;

            Console.WriteLine("Lutfen ilk sayiyi giriniz: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Lutfen ikinci sayiyi giriniz: ");
            int y= int.Parse(Console.ReadLine());

            for (int i = 1; i < x; i++)
            {
                if (x % i == 0)
                {
                    xtoplam += i;
                }
            }
            for (int i=1; i<y; i++)
            {
                if (y % i==0)
                {
                    ytoplam += i;
                }
            }

            if(xtoplam==y && ytoplam==x)
            {
                Console.WriteLine("Sayilar dost sayidir");
            }
            else
            {
                Console.WriteLine("Sayilar dost sayi degildir");
            }

        }
    }
}
