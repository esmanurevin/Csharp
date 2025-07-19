using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region if else
            //Console.WriteLine("lütfen şifrenizi giriniz:");
            //string password;
            //password = Console.ReadLine();
            //if (password == "abcd")
            //{
            //    Console.WriteLine("şifre doğru");
            //}
            //else
            //{
            //    Console.WriteLine("şifre yanlış");
            //}

            //string capital,country;
            //Console.Write("başkenti girirniz:");
            //capital = Console.ReadLine();
            //Console.Write("ülkeyi giriniz:");
            //country = Console.ReadLine();
            //if (capital == "ankara" & country == "türkiye")
            //{
            //    Console.WriteLine("veriler doğru");

            //}
            //else
            //{
            //    Console.WriteLine("veriler yanlış");
            //}

            //int sayı;
            //Console.WriteLine("sayıyı giriniz:");
            //sayı=int.Parse(Console.ReadLine());
            //if (sayı == 5)
            //{
            //    Console.WriteLine("sayı doğru");
            //}
            //else
            //{
            //    Console.WriteLine("sayı yanlış");
            //}



            //double exam1, exam2, exam3,avarage;
            //string result=" ";
            //Console.Write("sınav1:");
            //exam1=int.Parse(Console.ReadLine());
            //Console.Write("sınav2:");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.Write("sınav3:");
            //exam3 = int.Parse(Console.ReadLine());

            //avarage = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("sınavların ortalaması:" + avarage);
            //if(avarage>0 & avarage < 50)
            //{
            //    result = "sonuç vasat";

            //}
            //if (avarage > 50 & avarage <= 70)
            //{
            //    result = "orta";

            //}
            //if (avarage > 70 & avarage <= 84)
            //{
            //    result = "iyi";

            //}
            //if (avarage > 84)
            //{
            //    result = "çok iyi";

            //}
            //Console.WriteLine(result);


            //int not = 85;

            //if (not >= 90)
            //{
            //    Console.WriteLine("Notunuz: A");
            //}
            //else if (not >= 80)
            //{
            //    Console.WriteLine("Notunuz: B");
            //}
            //else if (not >= 70)
            //{
            //    Console.WriteLine("Notunuz: C");
            //}
            //else
            //{
            //    Console.WriteLine("Notunuz: D veya F");
            //}
            #endregion
            #region mod işlemleri
            //int number;
            //number = 26;
            //int sonuç=number%5;
            //Console.WriteLine(sonuç);

            //Console.WriteLine("1.sayıyı giriniz:");
            //int sayı1=int.Parse(Console.ReadLine());
            //Console.WriteLine("2.sayıyı giriniz:");
            //int sayı2=int.Parse(Console.ReadLine());
            //int result = sayı1 % sayı2;
            //Console.WriteLine("sayı1'in sayı2 ye bölümünden kalan:" + result);
            //Console.WriteLine("sayıyı giriniz:");
            //int sayı=int.Parse(Console.ReadLine());
            //if (sayı % 2 == 0)
            //{

            //    Console.WriteLine("bu sayı çifttir");
            //}
            //else
            //{
            //    Console.WriteLine("bu sayı tektir");
            //}
            #endregion
            #region char ile karar yapıları
            //Console.WriteLine("karakter giriniz:");
            //char karakter=char.Parse(Console.ReadLine());
            //if (karakter == 'g' | karakter == 'G')
            //{
            //    Console.WriteLine("galatasaray");
            //}
            //else if (karakter == 'f' | karakter =='F')
            //{
            //    Console.WriteLine("fenerbahce");

            //}
            //else if (karakter == 'b' | karakter == 'B')
            //{
            //    Console.WriteLine("beşiktaş");
            //}
            //else
            //{
            //    Console.WriteLine("karakter doğru giriniz");
            //}
            #endregion
            #region örnek proje uygulaması
            //Console.WriteLine("c# eğitim kampı  restoran");
            //Console.WriteLine();
            //Console.WriteLine("1-ana yemekler");
            //Console.WriteLine("2-pizzalar");
            //Console.WriteLine("3-tatlılar");
            //Console.WriteLine("4-çorbalar");

            //Console.WriteLine();
            //string menuItems;
            //Console.WriteLine("detayını gormek istediğin menuyu sec:");
            //menuItems = Console.ReadLine();
            //if(menuItems=="1")
            //{
            //    Console.WriteLine("1-Köri soslu tavuk");
            //    Console.WriteLine("2-mantarlı tavuk");
            //    Console.WriteLine("3-makarna");
            //    Console.WriteLine("4-pizza");
            //}
            //if (menuItems == "2")
            //{
            //    Console.WriteLine("1-karışık pizza ");
            //    Console.WriteLine("2-margarita");
            //    Console.WriteLine("3-kavurmalı pizza");

            //}
            //if (menuItems == "3")
            //{
            //    Console.WriteLine("1-halka tatlısı");
            //    Console.WriteLine("2-tulumba");
            //    Console.WriteLine("3-kadayıf");
            //    Console.WriteLine("4-baklava");
            //}
            //if (menuItems == "4")
            //{
            //    Console.WriteLine("1-mercimek");
            //    Console.WriteLine("2-ezogelin");

            //}

            #endregion
            #region switch case
            //Console.WriteLine("ay giriş yapınız:");
            //int monthnumber=int.Parse(Console.ReadLine());
            //switch (monthnumber)
            //{
            //    case 1:Console.WriteLine("ocak");break;
            //    case 2:Console.WriteLine("şubat");break;
            //    case 3:Console.WriteLine("mart");break;
            //    case 4:Console.WriteLine("nisan");break;
            //    case 5:Console.WriteLine("mayıs");break;
            //    case 6:Console.WriteLine("haziran");break;
            //    case 7:Console.WriteLine("temmuz");break;
            //    case 8:Console.WriteLine("ağustos");break;
            //    case 9:Console.WriteLine("eylül");break;
            //    case 10:Console.WriteLine("ekim");break;
            //    case 11:Console.WriteLine("kasım");break;
            //    case 12:Console.WriteLine("aralık");break;

            //    default:Console.WriteLine("doğru sayıyı giriniz.");
            //        break;
            //}
            #endregion
            #region  switch case hesap makinesi
            //Console.WriteLine("birnci sayıyı giriniz:");
            //int sayi1=int.Parse(Console.ReadLine());
            //Console.WriteLine("ikinci sayıyı giriniz:");
            //int sayi2=int.Parse(Console.ReadLine());
            //Console.WriteLine("seçim yapınız(1-toplama,2-Çıkarma,3-çarpma,4-bölme)");
            //int seçim=int.Parse(Console.ReadLine());
            //int sonuç;
            //switch (seçim)
            //{
            //    case 1:sonuç = sayi1 + sayi2;Console.WriteLine(sonuç); break;
            //    case 2: sonuç = sayi1 - sayi2; Console.WriteLine(sonuç); break;
            //    case 3: sonuç = sayi1 *sayi2; Console.WriteLine(sonuç); break;
            //    case 4: sonuç = sayi1 / sayi2; Console.WriteLine(sonuç); break;

            //    default:Console.WriteLine("yanlış seçim yaptınız.");
            //        break;
            //}


            #endregion

            Console.Read();

        }
    }
}
