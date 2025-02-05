using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LoopWithStars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Alt Alta 10 Tane Yıldız Oluşturma
            //for (int i = 0; i < 10; i++) { 
            //    Console.WriteLine("*");
            //}
            #endregion

            #region Yan Yana 10 Tane Yıldız Oluşturma
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.Write("* ");
            //}
            #endregion

            #region Alt Alta 10 Tane Yıldız Oluşturma ve Her Satırda 10 Tane Yıldız Olsun
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.Write("* ");
            //    for (int j = 0; j < 9; j++) {
            //        Console.Write("* ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Dik Üçgen
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.Write("* ");

            //    for (int j = 0; j < i; j++)
            //    {
            //        Console.Write("* ");
            //    }

            //    Console.WriteLine();

            //}
            #endregion

            #region Ters Dik Üçgen
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.Write("* ");
            //    for (int j = 0; j < 9 - i; j++) { 
            //        Console.Write("* ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Baklava Dilimi
            //int n = 5;
            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = n - 1; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }

            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }

            //    Console.WriteLine();
            //}

            //for (int i = n - 1; i >= 1; i--)
            //{
            //    for (int j = n - 1; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }

            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Piramit
            //int count = 0;
            //for (int i = 1; i < 11; i += 2) {

            //    for (int left = 4 - count; 0 < left; left--)
            //    {
            //        Console.Write(" ");
            //    }

            //    for (int k = 0; k < i; k++) {
            //        Console.Write("*");
            //    }

            //    count+=1;

            //    Console.WriteLine();

            //}

            #endregion

            #region Ters Piramit
            //int n = 5;
            //for(int i = n; i >= 1; i--)
            //{
            //    for(int j = n - i; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }

            //    for(int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion
        }
    }
}


