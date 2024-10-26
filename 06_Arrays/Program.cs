using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Temel Dizi Örnekleri

            //string[] colors = new string[4];
            //colors[0] = "Kırmızı";
            //colors[1] = "Sarı";
            //colors[2] = "Beyaz";
            //colors[3] = "Pembe";

            //Console.WriteLine(colors[2]);


            //string[] cities = new string[5];
            //cities[0] = "Milano";
            //cities[1] = "Budapeşte";
            //cities[2] = "Kahire";
            //cities[3] = "Üsküp";

            //Console.WriteLine(cities[3]);



            //int[] numbers = new int[10];
            //numbers[0] = 50;
            //numbers[2] = 48;
            //numbers[5] = 698;
            //numbers[7] = 24;
            //numbers[8] = 456;
            //Console.WriteLine(numbers[5]);



            //string[] cities = { "Prag", "Roma", "Atina", "Ankara", "Bursa" };
            //Console.WriteLine(cities[2]);




            #endregion


            #region Dizideki Tüm Elemanları Listeleme

            //string[] colors = { "Sarı", "Kırmızı", "Beyaz", "Mavi", "Yeşil", "Turuncu" };

            //for(int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}



            //int[] numbers = { 4, 54, 48, 123, 58, 99, 65, 66, 1142 };

            //for(int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}


            //char[] symbol = { 'a', 'b', 'c', '+', '-' };
            //for(int i = 0; i < symbol.Length; i++)
            //{
            //    Console.WriteLine(symbol[i]);
            //}



            //int[] myArray = { 47, 89, 45, 12, 1452, 465, 98 };

            //int maxNumber = myArray[0];

            //for(int i = 0; i < myArray.Length; i++)
            //{
            //    if (myArray[i] > maxNumber)
            //    {
            //        maxNumber = myArray[i];
            //    }
            //}
            //Console.WriteLine(maxNumber);



            //string[] persons = { "Ali", "Ayşe", "Esra", "Salih", "Cem" };
            //Console.WriteLine(persons.Length);


            //int[] numbers = { 15, 87, 96, 556, 487, 23, 11, 54, 66 };
            //Array.Sort(numbers);
            //for(int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}


            //int[] numbers = { 15, 87, 96, 556, 487, 23, 11, 54, 66 };
            //Array.Reverse(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            #endregion


            #region Dizi Metotları

            //string[] customers = { "Ali", "Buse", "Merve", "Çınar", "Kaya" };
            //int index = Array.IndexOf(customers, "Merve");
            //Console.WriteLine(index);



            //int[] numbers = { 165, 74, 89, 65, 4, 23, 56, 78 };
            //Console.WriteLine("Dizinin En Büyük Elemanı: " + numbers.Max() + "Dizinin En Küçük Elemanı: " + numbers.Min());


            #endregion


            #region Kullanıcıdan Değer Alma

            //string[] cities = new string[5];

            //for(int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine($"Lütfen {i + 1}. Şehri giriniz: ");
            //    cities[i] = Console.ReadLine();
            //}

            //Console.WriteLine();
            //Console.WriteLine("-----------------");

            //for(int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}



            //int[] numbers = { 10, 20, 30, 40, 50 };
            //int sum = 0;

            //for(int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}
            //Console.WriteLine(sum);



            //int[] numbers = { 51, 52, 73, 456, 875, 56, 37, 8, 579 };

            //Console.WriteLine("Çift Sayılar");
            //Console.WriteLine();

            //for(int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //Console.WriteLine("Tek Sayılar");
            //Console.WriteLine();

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 1)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}


            #endregion
        }
    }
}
