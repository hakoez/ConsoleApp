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
    public class Algo40
    {
        public static void Coz()
        {
            //10-200 arasindaki tam sayilardan 3katinin 2 fazlasi 5 ile tam bölünebilen sayilar

            int counter = 10;

            while (counter<=200)
            {
                int number = counter * 3 + 2;
                if (number % 5 == 0)
                {
                    Console.WriteLine(counter);
                }
                counter++;
               
            }


        }
    }
}