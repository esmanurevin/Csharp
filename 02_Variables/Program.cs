using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double değişkenler
            //double number;
            //number = 4.85;
            //Console.WriteLine(number);
            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();
            //double applePrice, orangePrice,strawberryPrice,potatoPrice,TomatoPrice;
            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 35.6;
            //TomatoPrice = 12.45;
            //Console.WriteLine("------elma birim fiyatı:" + applePrice+"TL");
            //Console.WriteLine("------portakal birim fiyatı:" + orangePrice + "TL");
            //Console.WriteLine("------çilek birim fiyatı:" +strawberryPrice + "TL");
            //Console.WriteLine("------patates birim fiyatı:" + potatoPrice + "TL");
            //Console.WriteLine("------domates birim fiyatı:" + TomatoPrice + "TL");
            //Console.WriteLine();
            //double appleGram, orangeGram, strawberryGram, potatoGram, TomatoGram;
            //appleGram = 1.260;
            //orangeGram = 2.344;
            //strawberryGram = 0.750;
            //potatoGram = 3.356;
            //TomatoGram = 2.341;
            //double appletotalPrice = appleGram * applePrice;
            //Console.WriteLine("elmanın toplam fiyatı:" + appletotalPrice);
            #endregion

            #region Char Değişkenler
            //char symbol= 'a';
            //Console.WriteLine(symbol);
            #endregion

            #region Klavyeden veri girişleri STRİNG
            //Console.WriteLine("****CSharp hava yolları yolcu bilgisi****");
            //Console.WriteLine();
            //string custemorName, custemorSurname, custemorDistrict, customerCity,customerAge;
            //Console.Write("Yolcu Adı:");
            //custemorName = Console.ReadLine();
            //Console.Write("yolcu soyadı:");
            //custemorSurname = Console.ReadLine();
            //Console.Write("İlçe bilgisi:");
            //    custemorDistrict = Console.ReadLine();
            //Console.Write("Şehir bilgisi:");
            //customerCity = Console.ReadLine();
            //Console.Write("yaş bilgisi:");
            //customerAge = Console.ReadLine();

            //Console.WriteLine();
            //Console.WriteLine("adı:"+custemorName+" "+custemorSurname+" " +custemorDistrict+" "+customerCity+" "+customerAge);

            #endregion

            #region klavyeden tam sayı girişleri ve dönüşümler
            // int shoePrice, computerPrice, chairPrice, tvPrice;
            // shoePrice = 1000;
            // computerPrice = 20000;
            // chairPrice = 100;
            // tvPrice = 4500;
            // int shoeCount, computerCount, chairCount, tvCount;
            // Console.Write("lütfen kaç tane ayakkaı aldığınızı yazınız:");
            // shoeCount = int.Parse(Console.ReadLine());
            // Console.Write("lütfen aldığınız bilgisayar sayısını giriniz:");
            // computerCount = int.Parse(Console.ReadLine());
            // Console.Write("lütfen aldığınız sandalye sayısını giriniz:");
            // chairCount = int.Parse(Console.ReadLine());
            // Console.Write("lütfen aldığınız televizyon sayısını giriniz:");
            //tvCount = int.Parse(Console.ReadLine());
            // int totalPrice = shoeCount * shoePrice + computerCount * computerPrice + chairCount * chairPrice + tvCount * tvPrice;
            // Console.WriteLine(totalPrice);
            #endregion

            #region klavyeden ondalıklı sayı işlemleri
            //double exam1,exam2,exam3,result;
            //Console.Write("lütfen 1. sınav notunu giriniz:");
            //exam1 =double.Parse(Console.ReadLine());
            //Console.Write("lütfen 2. sınav notunu giriniz:");
            //exam2 = double.Parse(Console.ReadLine());
            //Console.Write("lütfen 3. sınav notunu giriniz:");
            //exam3 = double.Parse(Console.ReadLine());
            //result=(exam1+exam2 +exam3)/3;
            //Console.Write("SINAV ORTALAMANIZ:"+result);
            #endregion

            #region klavyeden karakter girişleri
            char gender;
            Console.Write("lütfen cinsiyet giriniz:");
            gender=char.Parse(Console.ReadLine());
            Console.Write("seçtiğiniz cinsiyet:" + gender);
            #endregion
            Console.Read();

        }
    }
}
