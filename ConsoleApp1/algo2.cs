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
    public class Algo2
    {
        public static void Coz()
        {
            //1'den 100 e kadar olan sayilarin küplerinin toplami

            int result = 0;

            for(int i = 1; i<=100; i++)
            {
                result=result+(i*i*i);
            }
            Console.WriteLine("1'den 100e kadar ki sayilarin küplerinin toplami:" + result); 


        }
    }
}