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
    public class Algo35
    {
        public static void Coz()
        {
            //1 ile 500 tam sayilari arasinda tek sayilarin toplamiyla cift
            //sayilarin toplami arasindaki farkin pozitifmi negatifmi oldugunu bulma
            int cift = 0;
            int tek = 0;

            for(int i =1; i<=500; i++)
            {
                if(i%2==0)
                {
                    cift += i;
                }
                else
                {
                    tek += i;
                }
            }

            if((tek-cift)>0)
            {
                Console.WriteLine("Fark pozitiftir.");
            }
            else
            {
                Console.WriteLine("Fark negatiftir.");
            }
        }
    }
}
