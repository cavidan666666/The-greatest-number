using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learnArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] sayilar = {10 , 45 , 21 , 75 , 26 , 84 , 35 , 90 };
            //Console.Write(sayilar[5]);
            //Console.Read();

            //string[] isimler = { "Cavidan", "Fexriyye", "Uzeyir", "Iqbal", "Isi" };
            //Console.WriteLine(isimler[3]);
            //Console.Read();

            //string[] sehirler = new string[3];
            //for (int i = 0; i <3 ; i++)
            //{
            //    Console.Write("Sehir: ");
            //    sehirler[i] = Console.ReadLine();

            //}
            //Console.WriteLine("***** Sehirler Listesi*****");

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine(sehirler[i]);
            //}
            //Console.Read();

            int[] mirtlasir = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Ededler: ");
                mirtlasir[i] =Convert.ToInt32( Console.ReadLine());
     
            }

            int enBoyuk;
            enBoyuk = mirtlasir[0];
             
            for (int i = 1; i < 5; i++)
            {
                if(enBoyuk < mirtlasir[i])
                {
                    enBoyuk = mirtlasir[i];
                }
            }
            Console.WriteLine(enBoyuk);

            Console.ReadLine();
        }
    }
}  
