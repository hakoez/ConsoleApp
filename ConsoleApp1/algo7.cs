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
    public class Algo7
    {
        public static void Coz()
        {
            //1 ile 25 arasindaki tam sayilarin karelerinin carpimi

            double result = 1;

            for(int i = 1; i<=25; i++)
            {
                result*=(i*i);
            }
            Console.WriteLine("Sonuc: " + result);

        }
    }
}
