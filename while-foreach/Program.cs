using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //while 
            //1 den başlayarak console dan girilen sayıya kadar (sayı  dahil) ort. hesaplayıp console'a yazdıran program
            Console.WriteLine("Lütfen bir sayı giriniz.");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;
            while (sayac<=sayi)
            {
                toplam += sayac;
                sayac++;
                

            }
            Console.WriteLine("Toplam:"+toplam);
            Console.WriteLine("Ortalama:"+toplam/sayi);
            //'a' dan 'z' ye kadar tüm harfleri console'a yazdıralım.
            char character = 'a';
                while (character <= 'z') 
            {
                Console.WriteLine(character);
                character++;
            }
                //foreach
                Console.WriteLine("***foreach***");
            string[] arabalar = { "BWM", "Ford", "Toyota", "Nissan" };
            foreach(var item in arabalar)
            {
                Console.WriteLine(item);
            }
        }
    }
}
