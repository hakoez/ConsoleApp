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
    public class Algo9
    {
        public static void Coz()
        {
            //Carpma islemini toplama kullanarak bulma
            Console.WriteLine("Birinci sayiyi giriniz: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ikinci sayiyi giriniz: ");
            int b = int.Parse(Console.ReadLine());
            int result = 0;
            for(int i=1; i<=a; i++)
            {
                result += b;
            }

            Console.WriteLine("Sonuc: " + result);

        }
    }
}
