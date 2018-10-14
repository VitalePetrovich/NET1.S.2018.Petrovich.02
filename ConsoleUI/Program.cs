using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using static TasksDay02.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task1
            int num = InsertNumber(-4106, 22095, 4, 9);
            Console.WriteLine(num);

            //Task2
            //Random rnd = new Random();
            //List<int> list = new List<int>();
            //for (int i = 0; i < 10; i++)
            //{
            //    list.Add(rnd.Next(-100, 100));
            //}

            //var arr = list.ToArray();

            //foreach (var i in arr)
            //{
            //    Console.Write(i + " ");
            //}
            //Console.WriteLine("\nMax element is: " + MaxElement(arr));

            //Task3
            //double[] arr = new[] {1.0, 2, 3, 4, -213453, 10};
            //Console.WriteLine("Index is: " + MiddleSum(arr));

            //Task4
            //string str1 = "Garbage Collector";
            //string str2 = "Hello";

            //Console.Write(UniqConcat(str1, str2));

            Console.ReadKey();
        }
    }
}
