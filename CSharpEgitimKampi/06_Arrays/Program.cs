using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri
            //string[] colors = new string[4];
            //colors[0] = "Kırmızı";
            //colors[1] = "Sarı";
            //colors[2] = "Beyaz";
            //colors[3] = "Mavi";

            //Console.WriteLine(colors[3]);

            //int[] numbers = new int[10];
            //numbers[0] = 50;
            //numbers[1] = 48;
            //numbers[2] = 698;
            //numbers[3] = 24;
            //numbers[7] = 748;

            //Console.WriteLine(numbers[5]);

            //string[] cities = { "Samsun", "Ankara", "İstanbul" };
            //Console.WriteLine(cities[0]);
            #endregion

            #region Dizideki Tüm Elemanları Listeleme
            //string[] colors = {"Sarı","Kırmızı","Beyaz","Mavi","Yeşil","Turuncu","Pembe"};

            //for (int i = 0; i < colors.Length; i++) { 
            //    Console.WriteLine(colors[i]);
            //}

            //int[] numbers = { 4, 85, 96, 75, 125, 635, 488, 522, 7426, 2365, 1120 };

            //for (int i = 0; i < numbers.Length; i++) {
            //    if (numbers[i] % 3 == 0) { 
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //char[] symbols = { 'a', 'b', 'c', '*', '/', '-' };
            //for (int i = 0; i < symbols.Length; i++) { 
            //    Console.WriteLine(symbols[i]);
            //}

            //int[] myArray = { 47, 85, 95, 41, 25, 635, 789, 86, 100 };

            //int maxNumber = myArray[0];
            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    if (maxNumber < myArray[i])
            //    {
            //        maxNumber = myArray[i];
            //    }
            //}

            //Console.WriteLine(maxNumber);

            //int[] numbers = { 4, 85, 96, 75, 125, 635, 488, 522, 7426, 2365, 1120 };

            //Array.Sort(numbers);

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //int[] numbers = { 4, 85, 96, 75, 125, 635, 488, 522, 7426, 2365, 1120 };

            //Array.Reverse(numbers);

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            #endregion

            #region Dizi Metotlar
            // index numarasını tespit eden metot
            //string[] customers = { "ali", "buse", "ayşegul", "merve", "çınar", "kaya" };
            //int index = Array.IndexOf(customers, "merve");
            //Console.WriteLine(index);

            //int[] numbers = { 45, 85, 96, 63, 74, 10, 25, 22, 36 };
            //Console.WriteLine("Dizini En Büyük Elemanı: "+numbers.Max() + " Dizinin En Küçük Elemanı: "+ numbers.Min());
            #endregion

            #region Kullanıcıdan Değer Alma
            //string[] cities = new string[5];

            //for (int i = 0; i < cities.Length; i++) {
            //    Console.Write($"Lütfen {i + 1}. Şehri Giriniz :");
            //    cities[i] = Console.ReadLine();
            //}

            //Console.WriteLine();
            //Console.WriteLine("--------------------");

            //for (int i = 0; i < cities.Length; i++) { 
            //Console.WriteLine(cities[i]);
            //}

            //int[] numbers = {1 , 2, 3, 4, 5, 6, 7};
            //int sum = 0;
            //for (int i = 0; i < numbers.Length; i++) { 
            //sum += numbers[i];
            //}

            //Console.WriteLine(sum);

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7 };
            //Console.WriteLine("Çift Sayılar");

            //for (int i = 0; i < numbers.Length; i++)
            //{

            //    if (numbers[i] % 2 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //Console.WriteLine();
            //Console.WriteLine("Tek Sayılar");

            //for (int i = 0; i < numbers.Length; i++)
            //{

            //    if (numbers[i] % 2 != 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}
            #endregion
        }
    }
}
