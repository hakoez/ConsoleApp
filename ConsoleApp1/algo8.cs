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
    public class Algo8
    {
        public static void Coz()
        {
            //Dogum tarihi girilen kisinin yasini hesaplama
            Console.WriteLine("Dogum tarihini giriniz: ");
            int a = int.Parse(Console.ReadLine());
            int result = 0;

            result = 2025 - a;

            Console.WriteLine("Yasiniz: "+ result);


        }
    }
}
