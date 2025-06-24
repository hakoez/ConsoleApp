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
    public class Algo45
    {
        public static void Coz()
        {
            
            //10-100 arasi asal sayi bulma
            for(int j = 10;j<=100;j++)
            {
                int counter = 0;
                for (int i = 2; i < j; i++)
                {
                    if (j%i==0)
                    {
                        counter++;
                        break;
                    }
                }
                if(counter==0)
                {
                    Console.WriteLine(j);
                }
            }

        }
    }
}