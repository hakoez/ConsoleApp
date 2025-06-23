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
    public class Algo39
    {
        public static void Coz()
        {
            //Sayi bulmaca oyunuß
            int deneme = 0;
            Random rnd = new Random();
            int sayi = rnd.Next(1, 11);
            int tahmin = 0;

            while (tahmin!=sayi)
            {
                Console.WriteLine("Lutfen bir sayi tahmin edin: ");
                tahmin=int.Parse(Console.ReadLine());

                if (tahmin>sayi)
                {
                    Console.WriteLine("High");
                }
                else
                {
                    Console.WriteLine("Low");
                }
                deneme++;
            }
            Console.WriteLine(tahmin + " dogru tahmin."+" Deneme sayisi: "+deneme);


        }
    }
}
