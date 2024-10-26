using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Foreach Döngüsü

            //string[] cities = { "milano", "roma", "budapeşte", "ankara", "istsnbul" };

            //foreach(string x in cities)
            //{
            //    Console.WriteLine(x);
            //}



            //int[] numbers = { 15, 48, 79, 456, 157, 236, 55, 66, 798, 1245, 12365 };

            //foreach(int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}



            //int[] numbers = { 15, 48, 79, 456, 157, 236, 55, 66, 798, 1245, 12365 };

            //foreach (int number in numbers)
            //{
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}


            //int[] numbers = { 15, 48, 79, 456, 157, 236, 55, 66, 798, 1245, 12365 };

            //int total = 0;

            //foreach(int i in numbers)
            //{
            //    total += 1;
            //}
            //Console.WriteLine(total);



            //List<int> numbers = new List<int>()
            //{
            //    1,2,3,4,5,6,7
            //};

            //foreach(int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}



            //string word= "Merhaba";

            //foreach(char c in word)
            //{
            //    Console.WriteLine(c);
            //}






            #endregion



            #region Örnek Sınav Sistemi Uygulaması

            Console.Write("***** C# Eğitim Kampı Sınav Uygulaması *****");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            //Sınıftaki öğrenci sayısını kullanıcıdan alma
            Console.WriteLine("-----------------------------------");
            Console.Write("Sınıfınızda Kaç Öğrenci Var: ");
            int studentCount = int.Parse(Console.ReadLine());
            Console.WriteLine("-----------------------------------");

            string[] studentNames = new string[studentCount];
            double[] studentExamAvg = new double[studentCount];
            
            for(int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i + 1}. öğrencinin ismini giriniz: ");
                studentNames[i] = Console.ReadLine();

                double totalExamResult = 0;

                //Her öğrenci için 3 sınav girişi 

                for(int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentNames[i]} isimli öğrencinin {j+1}. sınav notunu giriniz: ");
                    double value = double.Parse(Console.ReadLine());
                    totalExamResult += value;// notları topluyoruz
                }
                Console.WriteLine();
                studentExamAvg[i] = totalExamResult / 3;
            }

            //Sınav Ortalamaları
            for(int i = 0; i < studentCount; i++)
            {
                Console.WriteLine("------------------------------------");
                Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması : {studentExamAvg[i]}");

                //Öğrencilerin ortalaması ve geçip kalma durumları
                if (studentExamAvg[i] >= 50)
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersi geçti");
                }
                else
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten kaldı");
                }

                Console.WriteLine("------------------------------------");
            }




            #endregion
        }
    }
}
