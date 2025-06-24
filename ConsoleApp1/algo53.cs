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
    public class Algo53
    {
        public static void Coz()
        {
            //girilen sayi 5-10 arasindaysa sayinin karesi,5ten kücükse faktöryelini,10dan büyükse ikiye bölüp 1 eksigini alan algo
            Console.WriteLine("Lutfen bir sayi girin: ");
            int number = int.Parse(Console.ReadLine());

            if (number >=5 &&  number <=10)
            {
                number = number * number;
            }
            else if(number <5)
            {
                for(int i = 1;i<number;i++)
                {
                    number *= i;
                }
            }
            else
            {
                number = number / 2 - 1;
            }
            Console.WriteLine(number);

        }
    }
}
