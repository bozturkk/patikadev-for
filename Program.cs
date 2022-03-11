using System;

namespace For // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir sayı giriniz :");
            int kadar = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= kadar; i+=2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("1 den girdiğiniz sayıya (" + kadar + ") kadar olan tek sayılar yukarıdaki gibidir.");
            Console.WriteLine(" ");
           
            int tekToplam=0, ciftToplam=0;
            for (int i = 0; i < 1000; i++)
            {
                if(i%2 == 0)
                {
                    ciftToplam += i;
                }
                else
                {
                    tekToplam += i;
                }
            }
            Console.WriteLine("1 den 1000 e kadar olan tek sayıların toplamı: {0}",tekToplam);
            Console.WriteLine("1'den 1000 e kadar olan çift sayıların toplamı: {0}", ciftToplam);


            for (int i = 0; i < 10; i++)
            {
                if(i ==4) //3 e kadar gelir 4. de döngüden çıkar
                    break;
                Console.WriteLine(i);
            }

            for (int i = 0; i < 10; i++)
            {
                if(i ==4) // 4 ü atlar ama geri kalan tüm değerleri yazdırır.
                    continue;
                Console.WriteLine(i);
            }
            //for(;;) sonsuz döngüdür.
        }
    }
}