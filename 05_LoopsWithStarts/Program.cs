using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LoopsWithStarts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region alt alta 10 tane yıldız oluşturma
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("*");
            //}

            #endregion
            #region yan yana 10 tane yıldız oluşturma
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.Write(" * ");
            //}

            #endregion
            #region alt  10 tane yıldız oluşturma her satırda 10 tane yıldız olusturma
            //for (int i = 0; i < 10; i++)
            //{
            //    for (int j = 0; j < 10; j++)
            //    {
            //        Console.Write("*");

            //    }
            //    Console.WriteLine();
            //}

            #endregion
            #region dik üçgen yapma yıldızlardan
            //for (int i = 1;i < 10; i++) 
            //    {
            //        for(int j = 1;j <=i; j++)
            //        {
            //            Console.Write("*");
            //        }
            //        Console.WriteLine();
            //    }
            #endregion
            #region ters dik üçgen yapma yıldızlardan
            //for (int i = 1; i<=10; i++)
            //{
            //    for (int j = 10; j >= i; j--)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion
            #region dik ve ters dik üçgen beraber
            //for (int i = 1; i < 10; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //for (int k = 1; k <= 10; k++)
            //{
            //    for (int m = 10; m >= k; m--)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion
            #region baklava
            int n = 5; // Yüksekliği belirler (satır sayısı)

            // Üst üçgen (normal üçgen)
            for (int i = 1; i <= n; i++)
            {
                // Boşluklar
                for (int j = 1; j <= n - i; j++)
                    Console.Write(" ");

                // Yıldızlar
                for (int k = 1; k <= i; k++)
                    Console.Write("* ");

                Console.WriteLine();
            }

            // Alt üçgen (ters üçgen)
            for (int i = n - 1; i >= 1; i--)
            {
                // Boşluklar
                for (int j = 1; j <= n - i; j++)
                    Console.Write(" ");

                // Yıldızlar
                for (int k = 1; k <= i; k++)
                    Console.Write("* ");

                Console.WriteLine();
            }
        
        #endregion

        Console.ReadLine();

        }
    }
}
