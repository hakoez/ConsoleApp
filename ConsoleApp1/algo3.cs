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
    public class Algo3
    {
        public static void Coz()
        {
            //Girilen sayinin faktoriyeli
            Console.WriteLine("Bir sayi girin: ");
            int a =int.Parse(Console.ReadLine());
            int result = 1;

            for(int i=1; i<=a; i++)
            {
                result *= i;
            }
            Console.WriteLine(a+"! = " + result);


        }
    }
}