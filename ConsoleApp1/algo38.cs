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
    public class Algo38
    {
        public static void Coz()
        {
            //Rastgele girilen 50 sayidan negatif ve pozitif olanlarin sayilarini göstermek

            int negatif = 0;
            int pozitif = 0;
            int x = 0;


            while (x<50)
            {
                Console.WriteLine("Bir sayi giriniz: ");
                int a = int.Parse(Console.ReadLine());

                if(a<0)
                {
                    negatif++;
                }
                else
                {
                    pozitif++;
                }

                x++;
            }
            Console.WriteLine("Pozitif sayilar: " + pozitif + " Negatif sayilar:" + negatif);

        }
    }
}
