using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ExamplesUpToArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ÖRNEK1:Bilgisayar 1 - 100 arasında rastgele bir sayı tutsun.Kullanıcı tahmin ettikçe yönlendirme yapılsın.5 tanede hakkı olsun.
            #region ÖRNEK1
            //Random rnd = new Random();
            //int hedef = rnd.Next(1, 101); // 1-100 arası sayı
            //int deneme = 0;
            //int maxHak = 5;

            //Console.WriteLine("1 ile 100 arasında bir sayı tuttum.");
            //Console.WriteLine("Tahmin etmeye çalış. Toplam 5 hakkın var.");

            //while (deneme < maxHak)
            //{
            //    Console.Write($"[{deneme + 1}. tahmininiz] → ");
            //    int tahmin = int.Parse(Console.ReadLine());
            //    deneme++;

            //    if (tahmin == hedef)
            //    {
            //        Console.WriteLine($"🎉 Tebrikler! {deneme}. denemede doğru bildiniz!");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("❌ Yanlış tahmin.");

            //        if (tahmin < hedef)
            //            Console.WriteLine("🔺 Daha büyük bir sayı girin.");
            //        else
            //            Console.WriteLine("🔻 Daha küçük bir sayı girin.");

            //        if (deneme == maxHak)
            //        {
            //            Console.WriteLine($"\n😔 Maalesef hakkınız doldu. Doğru sayı: {hedef}");
            //        }
            //    }
            //}
            #endregion
            // ÖRNEk2:bir sayının asal olup olmadığını bulma
            #region ÖRNEK2
            //Console.WriteLine("Bir sayı giriniz asal mı bulalım:");
            //int sayı=int.Parse(Console.ReadLine());
            //int count = 0;
            //for (int i=2;i<=sayı/2;i++)
            //{
            //    if (sayı % i == 0)
            //    {  count++; }
            //}

            //if (count == 0)
            //{
            //    Console.WriteLine("bu sayı asaldır");
            //}
            //else
            //{
            //    Console.WriteLine("asal değildir");
            //}
            #endregion
            //armstrong Sayısı mı ?
            #region ÖRNEK3

            //Console.Write("Bir sayı giriniz: ");
            //int sayi = int.Parse(Console.ReadLine());

            //int temp = sayi;
            //int toplam = 0;
            //int basamakSayisi = sayi.ToString().Length;

            //while (temp > 0)
            //{
            //    int basamak = temp % 10;
            //    toplam += (int)Math.Pow(basamak, basamakSayisi);
            //    temp /= 10;
            //}

            //if (toplam == sayi)
            //{
            //    Console.WriteLine($"{sayi} bir Armstrong sayısıdır.");
            //}
            //else
            //{
            //    Console.WriteLine($"{sayi} bir Armstrong sayısı değildir.");
            //}

            #endregion
            //Rakamlar Aynı mı ?
            #region ÖRNEK4
            String sayı;
            bool hepsiaynı = true;
            Console.WriteLine("sayıyı giriniz:");
            sayı = Console.ReadLine();
            char ilkRakam = sayı[0];
            for (int i = 1; i < sayı.Length; i++)
            {
                if (sayı[i] != ilkRakam) {
                    hepsiaynı = false;
                }
            }
            if (hepsiaynı)
                {

                    Console.WriteLine("aynıdır sayılar");
                }
            else{


                Console.WriteLine("farklıdır");
            }
            #endregion


            Console.ReadKey();

            }
        }
    }
