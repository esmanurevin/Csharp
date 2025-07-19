using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region for döngüsü
            //brekpoint için f11 basıp kontrol edebiliriz
            //for (int j = 0; j < 5; j++)
            //{
            //    Console.WriteLine("esma");
            //}

            //for (int i = 1; i <= 20; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //for (int i = 3; i <= 50; i = i + 3)
            //{

            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("lütfen kac adet girilmesini istediğinizi yazınız:");
            //int finishvalue=int.Parse(Console.ReadLine());
            //for (int i = 1; i <= finishvalue; i++)
            //{
            //    Console.WriteLine("yaşasın cumhuriyet");
            //}

            #endregion
            #region for döngüsü ile karar yapıları
            //for (int i = 1; i < 100; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            // int toplam = 0;
            //for (int i = 1; i <= 10; i++)
            //{
            //    toplam += i;
            //}
            //Console.WriteLine(toplam);

            // int toplam = 0;

            //for (int i = 0; i < 20; i += 2)
            //{
            //    toplam += i;

            //}
            //Console.WriteLine(toplam);

            //int count = 0;
            //for (int i = 1; i <= 50; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        Console.WriteLine(i);
            //        count++;
            //    }
            //}
            //    Console.WriteLine(count);

            //int bakteri = 1;
            //for (int i = 1; i <= 24; i++)
            //{
            //    bakteri*=2;
            //    Console.WriteLine(i+".saat sonunda bakteri:"+bakteri);
            //}
            #endregion
            #region while
            //int i = 1;
            //while (i <= 10)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}
            //int i = 1;
            //while (i <= 10)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}

            #endregion
            #region örnek sınav sorusu
            //klavyeden girilen 3 basamaklı sayının basamaklarının tplamını hesaplayan program
           
            Console.WriteLine("klavyeden 3 basamaklı sayı giriniz");
            int sayı=int.Parse(Console.ReadLine());
            int ones, tens, hundreds;
            int sum;

            ones = sayı % 10;
            hundreds = sayı/100;
            tens = (sayı % 100) / 10;
            sum = ones + tens + hundreds;
            Console.WriteLine(sum);

            #endregion
            Console.Read();
        }
    }
}
