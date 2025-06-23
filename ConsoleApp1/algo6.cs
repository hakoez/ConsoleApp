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
    public class Algo6
    {
        public static void Coz()
        {
            //1'den 500'e kadar olan tamsayilarin toplami

            int result = 0;

            for(int i = 1; i <=500; i++)
            {
                result += i;
            }
            Console.WriteLine("1'den 500'e kadarki tam sayilarin toplami:  "+ result);
        }
    }
}
