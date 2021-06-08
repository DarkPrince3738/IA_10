using System;
using System.Diagnostics;

namespace Task2
{
    /*Використовуючи Visual Studio, створіть проект за шаблоном Console Application, назвіть його Lesson015_Task2.
    Створіть клас PointClass і структуру PointStruct з автореалізованими властивостями int X, int У. 
    Створіть статисний клас PerformanceTest із методами MeasureTestPointClass і MeasureTestPointStruct 
    які прймають (int length), які створюють масив із довжиною length, і відповідно заповнюють його елементами.
    Перевірте ефективність виконання цих методів, передаючи у параметр 1 000 000​*/
    
    class Program
    {
        static void Main(string[] args)
        {
            var stopWatch = new Stopwatch();

            stopWatch.Start();
            PermormanceTest.MeasureTestPointClass(100_000_000);
            stopWatch.Stop();

            Console.WriteLine($"PointClass {stopWatch.ElapsedMilliseconds}");
            stopWatch.Reset();


            stopWatch.Start();
            PermormanceTest.MeasureTestPointStruct(100_000_000);
            stopWatch.Stop();

            Console.WriteLine($"PointStruct {stopWatch.ElapsedMilliseconds}");
            stopWatch.Reset();
        }
    }
    static class PermormanceTest
    {
        public static void MeasureTestPointClass(int length)
        {
            var random = new Random();

            PointClass[] array = new PointClass[length];
            for(int i = 0; i < length; i++)
            {
                array[i] = new PointClass(random.Next(-100,100), random.Next(-100, 100));
            }
        }
        public static void MeasureTestPointStruct(int length)
        {
            var random = new Random();
            PointStruct[] array = new PointStruct[length];
            for (int i = 0; i < length; i++)
            {
                array[i] = new PointStruct(random.Next(-100, 100), random.Next(-100, 100));
            }
        }
    }

    class PointClass
    {
        public int X;
        public int Y;

        public PointClass(int x, int y)
        {
            X = x;
            Y = y;
        }
    }

    struct PointStruct
    {
        public int X;
        public int Y;

        public PointStruct(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
