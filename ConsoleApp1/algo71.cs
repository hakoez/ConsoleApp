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
    public class Algo71
    {
        public static void Coz()
        {
            //Bir siniftaki 50 ögrencinin aldiklari yil sonu notlari veriliyor basari notu 50 olan sinifta kac kisi gecmistir
            int gecenler = 0;

            int[] notlar = new int[50];
            Random rnd = new Random();

            for (int i = 0; i < 50; i++)
            {
                notlar[i] = rnd.Next(1, 101);
            }
           
            for(int i = 0;i<50;i++)
            {
                if (notlar[i] >=50)
                {
                    gecenler++;
                }
            }
            foreach (int i in notlar)
            {
                Console.WriteLine(i );
            }
            Console.WriteLine(gecenler + " kisi gecti.");



        }
    }
}
